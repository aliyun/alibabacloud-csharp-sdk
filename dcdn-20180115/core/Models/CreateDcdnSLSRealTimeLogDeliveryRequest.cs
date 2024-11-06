// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dcdn20180115.Models
{
    public class CreateDcdnSLSRealTimeLogDeliveryRequest : TeaModel {
        /// <summary>
        /// <para>The type of the collected logs. Default value: cdn_log_access_l1. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>cdn_log_access_l1</b>: access logs of Dynamic Content Delivery Network (DCDN) points of presence (POPs)</description></item>
        /// <item><description><b>cdn_log_origin</b>: back-to-origin logs</description></item>
        /// <item><description><b>cdn_log_er</b>: EdgeRoutine logs</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>cdn_log_access_l1</para>
        /// </summary>
        [NameInMap("BusinessType")]
        [Validation(Required=false)]
        public string BusinessType { get; set; }

        /// <summary>
        /// <para>The data center. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>cn: China</description></item>
        /// <item><description>sg: Singapore</description></item>
        /// <item><description>eu: Europe</description></item>
        /// <item><description>us: United States</description></item>
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
        /// <para>The name of a real-time log delivery project.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>example</para>
        /// </summary>
        [NameInMap("ProjectName")]
        [Validation(Required=false)]
        public string ProjectName { get; set; }

        /// <summary>
        /// <para>The name of the Log Service Logstore.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>demo</para>
        /// </summary>
        [NameInMap("SLSLogStore")]
        [Validation(Required=false)]
        public string SLSLogStore { get; set; }

        /// <summary>
        /// <para>The name of the Log Service project.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>aliyundoc</para>
        /// </summary>
        [NameInMap("SLSProject")]
        [Validation(Required=false)]
        public string SLSProject { get; set; }

        /// <summary>
        /// <para>The region to which real-time logs are delivered.</para>
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
