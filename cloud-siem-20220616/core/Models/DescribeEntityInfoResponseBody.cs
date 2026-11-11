// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloud_siem20220616.Models
{
    public class DescribeEntityInfoResponseBody : TeaModel {
        /// <summary>
        /// <para>The status code of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        /// <summary>
        /// <para>The response data.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123456</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public DescribeEntityInfoResponseBodyData Data { get; set; }
        public class DescribeEntityInfoResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The logical ID of the entity.</para>
            /// 
            /// <b>Example:</b>
            /// <para>12345</para>
            /// </summary>
            [NameInMap("EntityId")]
            [Validation(Required=false)]
            public long? EntityId { get; set; }

            /// <summary>
            /// <para>The entity information.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{&quot;location&quot;: &quot;xian&quot;, &quot;net_connect_dir&quot;: &quot;in&quot;, &quot;malware_type&quot;: &quot;${aliyun.siem.sas.alert_tag.login_unusual_account}&quot;}</para>
            /// </summary>
            [NameInMap("EntityInfo")]
            [Validation(Required=false)]
            public Dictionary<string, object> EntityInfo { get; set; }

            /// <summary>
            /// <para>The entity type. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>ip: IP address</description></item>
            /// <item><description>domain: Domain name</description></item>
            /// <item><description>url: URL</description></item>
            /// <item><description>process: Process</description></item>
            /// <item><description>file: File</description></item>
            /// <item><description>host: Host</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>ip</para>
            /// </summary>
            [NameInMap("EntityType")]
            [Validation(Required=false)]
            public string EntityType { get; set; }

            /// <summary>
            /// <para>The threat intelligence information.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{
            ///       &quot;Ip&quot;: {
            ///             &quot;queryHot&quot;: &quot;0&quot;,
            ///             &quot;country&quot;: &quot;China&quot;,
            ///             &quot;province&quot;: &quot;shanxi&quot;,
            ///             &quot;ip&quot;: &quot;221.11.XX.XXX&quot;,
            ///             &quot;asn&quot;: &quot;4837&quot;,
            ///             &quot;asn_label&quot;: &quot;CHINAXXX-Backbone - CHINA UNICOM ChinaXXX Backbone, CN&quot;
            ///       }
            /// }</para>
            /// </summary>
            [NameInMap("TipInfo")]
            [Validation(Required=false)]
            public Dictionary<string, object> TipInfo { get; set; }

        }

        /// <summary>
        /// <para>The response message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>9AAA9ED9-78F4-5021-86DC-D51C7511****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request is successful. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: successful</description></item>
        /// <item><description>false: failed</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
