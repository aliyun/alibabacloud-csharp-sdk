// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sae20190506.Models
{
    public class DataInstancesValue : TeaModel {
        /// <summary>
        /// <para>The DNS name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>nlb-wb7r6dlwetvt5j****.cn-hangzhou.nlb.aliyuncs.com</para>
        /// </summary>
        [NameInMap("DnsName")]
        [Validation(Required=false)]
        public string DnsName { get; set; }

        /// <summary>
        /// <para>A collection of listener details.</para>
        /// </summary>
        [NameInMap("Listeners")]
        [Validation(Required=false)]
        public Dictionary<string, DataInstancesValueListenersValue> Listeners { get; set; }

        /// <summary>
        /// <para>Indicates whether SAE created the instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>true</b>: SAE created the instance.</para>
        /// </description></item>
        /// <item><description><para><b>false</b>: SAE reused an existing instance.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("CreatedBySae")]
        [Validation(Required=false)]
        public bool? CreatedBySae { get; set; }

    }

}
