// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloud_siem20220616.Models
{
    public class DescribeEntityInfoResponseBody : TeaModel {
        /// <summary>
        /// <para>The HTTP status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        /// <summary>
        /// <para>The data returned.</para>
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
            /// <para>The information about the entry.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{ location: &quot;xian&quot;, net_connect_dir: &quot;in&quot;, malware_type: &quot;${aliyun.siem.sas.alert_tag.login_unusual_account}&quot; }</para>
            /// </summary>
            [NameInMap("EntityInfo")]
            [Validation(Required=false)]
            public Dictionary<string, object> EntityInfo { get; set; }

            /// <summary>
            /// <para>The type of the entity. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>ip</description></item>
            /// <item><description>domain</description></item>
            /// <item><description>url</description></item>
            /// <item><description>process</description></item>
            /// <item><description>file</description></item>
            /// <item><description>host</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>ip</para>
            /// </summary>
            [NameInMap("EntityType")]
            [Validation(Required=false)]
            public string EntityType { get; set; }

            /// <summary>
            /// <para>The information about the risk Intelligence.</para>
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
        /// <para>The returned message.</para>
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
        /// <para>Indicates whether the request was successful. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true</description></item>
        /// <item><description>false</description></item>
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
