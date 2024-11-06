// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dcdn20180115.Models
{
    public class UpdateDcdnSLSRealtimeLogDeliveryRequest : TeaModel {
        /// <summary>
        /// <para>The region from which logs are collected.</para>
        /// <list type="bullet">
        /// <item><description><b>cn</b>: Chinese mainland</description></item>
        /// <item><description><b>sg</b>: Singapore</description></item>
        /// <item><description><b>in</b>: India</description></item>
        /// <item><description><b>eu</b>: Europe</description></item>
        /// <item><description><b>us</b>: United States</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn</para>
        /// </summary>
        [NameInMap("DataCenter")]
        [Validation(Required=false)]
        public string DataCenter { get; set; }

        /// <summary>
        /// <para>The domain names from which logs were collected. You can specify one or more domain names. Separate multiple domain names with commas (,).</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>example.com</para>
        /// </summary>
        [NameInMap("DomainName")]
        [Validation(Required=false)]
        public string DomainName { get; set; }

        /// <summary>
        /// <para>The name of the project.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>example</para>
        /// </summary>
        [NameInMap("ProjectName")]
        [Validation(Required=false)]
        public string ProjectName { get; set; }

        /// <summary>
        /// <para>The name of the Logstore.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>example-cn</para>
        /// </summary>
        [NameInMap("SLSLogStore")]
        [Validation(Required=false)]
        public string SLSLogStore { get; set; }

        /// <summary>
        /// <para>The name of the log file.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>example-cn</para>
        /// </summary>
        [NameInMap("SLSProject")]
        [Validation(Required=false)]
        public string SLSProject { get; set; }

        /// <summary>
        /// <para>The region to which logs were delivered.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("SLSRegion")]
        [Validation(Required=false)]
        public string SLSRegion { get; set; }

        /// <summary>
        /// <para>The sampling rate.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1.0</para>
        /// </summary>
        [NameInMap("SamplingRate")]
        [Validation(Required=false)]
        public string SamplingRate { get; set; }

    }

}
