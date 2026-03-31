// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Oos20190601.Models
{
    public class GetChatConfigurationResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>{
        ///   &quot;Name&quot;: &quot;chatops&quot;,
        ///   &quot;Type&quot;: &quot;DingTalk&quot;,
        ///   &quot;RamRole&quot;: &quot;OOSServiceRole&quot;,
        ///   &quot;Configuration&quot;: &quot;{\&quot;DingTalkClientId\&quot;: \&quot;dingpxlbxp0rgs7uxmtb\&quot;, \&quot;DingTalkClientSecret\&quot;: \&quot;******\&quot;, \&quot;DingTalkTemplateId\&quot;: \&quot;381c5aee-f8af-48a4-94be-cce587e42ea4.schema\&quot;}&quot;,
        ///   &quot;ResourceGroupId&quot;: &quot;s&quot;,
        ///   &quot;CreatedDate&quot;: &quot;2025-12-26T09:53:02+00:00&quot;,
        ///   &quot;UpdatedDate&quot;: &quot;2026-01-07T02:14:55+00:00&quot;,
        ///   &quot;Outputs&quot;: &quot;{\&quot;URL\&quot;: \&quot;<a href="https://1407907063606569.appflow.aliyunnest.com/webhook/%5C%5C%22%7D">https://1407907063606569.appflow.aliyunnest.com/webhook/\\&quot;}</a>&quot;,
        ///   &quot;RequestId&quot;: &quot;4DB0****1234&quot;
        /// }</para>
        /// </summary>
        [NameInMap("ChatConfiguration")]
        [Validation(Required=false)]
        public GetChatConfigurationResponseBodyChatConfiguration ChatConfiguration { get; set; }
        public class GetChatConfigurationResponseBodyChatConfiguration : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>{&quot;DingTalkClientId&quot;: &quot;dingpxlbxp0rgs7uxmtb&quot;, &quot;DingTalkClientSecret&quot;: &quot;******&quot;, &quot;DingTalkTemplateId&quot;: &quot;381c5aee-f8af-48a4-94be-cce587e42ea4.schema&quot;}</para>
            /// </summary>
            [NameInMap("Configuration")]
            [Validation(Required=false)]
            public string Configuration { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2025-12-26T09:53:02+00:00</para>
            /// </summary>
            [NameInMap("CreatedDate")]
            [Validation(Required=false)]
            public string CreatedDate { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>chatops</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>{&quot;URL&quot;: &quot;<a href="https://1407907063606569.appflow.aliyunnest.com/webhook/%22%7D">https://1407907063606569.appflow.aliyunnest.com/webhook/&quot;}</a></para>
            /// </summary>
            [NameInMap("Outputs")]
            [Validation(Required=false)]
            public string Outputs { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>OOSServiceRole</para>
            /// </summary>
            [NameInMap("RamRole")]
            [Validation(Required=false)]
            public string RamRole { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>s</para>
            /// </summary>
            [NameInMap("ResourceGroupId")]
            [Validation(Required=false)]
            public string ResourceGroupId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>DingTalk</para>
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2026-01-07T02:14:55+00:00</para>
            /// </summary>
            [NameInMap("UpdatedDate")]
            [Validation(Required=false)]
            public string UpdatedDate { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>4DB0****1234</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
