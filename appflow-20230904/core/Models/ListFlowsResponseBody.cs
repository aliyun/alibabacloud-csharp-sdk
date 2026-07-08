// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Appflow20230904.Models
{
    public class ListFlowsResponseBody : TeaModel {
        /// <summary>
        /// <para>The list of connector flows.</para>
        /// </summary>
        [NameInMap("Flows")]
        [Validation(Required=false)]
        public List<ListFlowsResponseBodyFlows> Flows { get; set; }
        public class ListFlowsResponseBodyFlows : TeaModel {
            /// <summary>
            /// <para>Indicates whether the connector flow is enabled.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("Enabled")]
            [Validation(Required=false)]
            public bool? Enabled { get; set; }

            /// <summary>
            /// <para>The connector flow description.</para>
            /// 
            /// <b>Example:</b>
            /// <para>在未认证的公众号中更实用Qwen3开源版本自动回复</para>
            /// </summary>
            [NameInMap("FlowDesc")]
            [Validation(Required=false)]
            public string FlowDesc { get; set; }

            /// <summary>
            /// <para>The connector flow ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>flow-xxxxxxxx</para>
            /// </summary>
            [NameInMap("FlowId")]
            [Validation(Required=false)]
            public string FlowId { get; set; }

            /// <summary>
            /// <para>The connector flow name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>钉钉群聊 - 流式调用百炼应用-小助手</para>
            /// </summary>
            [NameInMap("FlowName")]
            [Validation(Required=false)]
            public string FlowName { get; set; }

            /// <summary>
            /// <para>The connector flow template content.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{}</para>
            /// </summary>
            [NameInMap("FlowTemplate")]
            [Validation(Required=false)]
            public string FlowTemplate { get; set; }

            /// <summary>
            /// <para>The connector flow version.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("FlowVersion")]
            [Validation(Required=false)]
            public string FlowVersion { get; set; }

            /// <summary>
            /// <para>The connector flow version status.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0 - 草稿
            /// 1- 发布
            /// 2- 下线</para>
            /// </summary>
            [NameInMap("FlowVersionStatus")]
            [Validation(Required=false)]
            public string FlowVersionStatus { get; set; }

            /// <summary>
            /// <para>The time when the connector flow was created.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2025-12-30T02:29:51Z</para>
            /// </summary>
            [NameInMap("GmtCreate")]
            [Validation(Required=false)]
            public string GmtCreate { get; set; }

            /// <summary>
            /// <para>The time when the connector flow was last modified.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2025-12-30T02:29:48Z</para>
            /// </summary>
            [NameInMap("GmtModified")]
            [Validation(Required=false)]
            public string GmtModified { get; set; }

            /// <summary>
            /// <para>The released version number.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("ReleasedVersion")]
            [Validation(Required=false)]
            public int? ReleasedVersion { get; set; }

            /// <summary>
            /// <para>The tag values.</para>
            /// </summary>
            [NameInMap("Tags")]
            [Validation(Required=false)]
            public List<ListFlowsResponseBodyFlowsTags> Tags { get; set; }
            public class ListFlowsResponseBodyFlowsTags : TeaModel {
                /// <summary>
                /// <para>The tag key. The tag key can be up to 64 characters in length.</para>
                /// 
                /// <b>Example:</b>
                /// <para>tuoluo</para>
                /// </summary>
                [NameInMap("Key")]
                [Validation(Required=false)]
                public string Key { get; set; }

                /// <summary>
                /// <para>The tag values.</para>
                /// 
                /// <b>Example:</b>
                /// <para>{\&quot;connectorId\&quot;: \&quot;connector-5e43ef26b53e4a158529\&quot;, \&quot;authConfig\&quot;: \&quot;{\\\&quot;apiKey\\\&quot;: \\\&quot;sk-77e7c7ed775f4fd388d505d37b2b1b33\\\&quot;}\&quot;}</para>
                /// </summary>
                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

            /// <summary>
            /// <para>The webhook URL.</para>
            /// 
            /// <b>Example:</b>
            /// <para>https://{uid}.appflow.aliyunnest.com/webhook/xxxxxx</para>
            /// </summary>
            [NameInMap("WebhookUrl")]
            [Validation(Required=false)]
            public string WebhookUrl { get; set; }

        }

        /// <summary>
        /// <para>The page size.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>The token for the next query.</para>
        /// 
        /// <b>Example:</b>
        /// <para>AAAAAVY3rYiv9VoUJQSiCitgjgRCGYBJsWLezzDdq2+aDNB4j8bgHiGAwZWnCMJPepC+WYZ4J1BLMwE7gJm++1ku/AI=</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>02FB9782-5390-5DF9-A1DA-9F2DE2FA1E3D</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of entries.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
