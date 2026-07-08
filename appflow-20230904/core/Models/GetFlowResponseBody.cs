// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Appflow20230904.Models
{
    public class GetFlowResponseBody : TeaModel {
        /// <summary>
        /// <para>The flow object.</para>
        /// </summary>
        [NameInMap("Flow")]
        [Validation(Required=false)]
        public GetFlowResponseBodyFlow Flow { get; set; }
        public class GetFlowResponseBodyFlow : TeaModel {
            /// <summary>
            /// <para>Indicates whether the flow is enabled.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("Enabled")]
            [Validation(Required=false)]
            public string Enabled { get; set; }

            /// <summary>
            /// <para>The flow description.</para>
            /// 
            /// <b>Example:</b>
            /// <para>以AI卡片形式发送至钉钉群聊，如果想要支持私聊，请使用同时支持群聊&amp;私聊的模版</para>
            /// </summary>
            [NameInMap("FlowDesc")]
            [Validation(Required=false)]
            public string FlowDesc { get; set; }

            /// <summary>
            /// <para>The flow ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>flow-xxxxxxxx</para>
            /// </summary>
            [NameInMap("FlowId")]
            [Validation(Required=false)]
            public string FlowId { get; set; }

            /// <summary>
            /// <para>The flow name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>微信连接流1</para>
            /// </summary>
            [NameInMap("FlowName")]
            [Validation(Required=false)]
            public string FlowName { get; set; }

            /// <summary>
            /// <para>The list of nodes.</para>
            /// 
            /// <b>Example:</b>
            /// <para>连接流节点信息</para>
            /// </summary>
            [NameInMap("FlowNodes")]
            [Validation(Required=false)]
            public List<GetFlowResponseBodyFlowFlowNodes> FlowNodes { get; set; }
            public class GetFlowResponseBodyFlowFlowNodes : TeaModel {
                /// <summary>
                /// <para>The authentication credentials of the node.</para>
                /// 
                /// <b>Example:</b>
                /// <para>{\&quot;authconfigId\&quot;:\&quot;uac-xxxxxxxxx\&quot;}</para>
                /// </summary>
                [NameInMap("AuthMetadata")]
                [Validation(Required=false)]
                public string AuthMetadata { get; set; }

                /// <summary>
                /// <para>The connector ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>connector-xxx24b139c62</para>
                /// </summary>
                [NameInMap("ConnectorId")]
                [Validation(Required=false)]
                public string ConnectorId { get; set; }

                /// <summary>
                /// <para>The connector version.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2</para>
                /// </summary>
                [NameInMap("ConnectorVersion")]
                [Validation(Required=false)]
                public string ConnectorVersion { get; set; }

                /// <summary>
                /// <para>The flow ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>flow-856cb84b309747e48b43</para>
                /// </summary>
                [NameInMap("FlowId")]
                [Validation(Required=false)]
                public string FlowId { get; set; }

                /// <summary>
                /// <para>The flow version.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("FlowVersion")]
                [Validation(Required=false)]
                public string FlowVersion { get; set; }

                /// <summary>
                /// <para>The metadata of the node.</para>
                /// 
                /// <b>Example:</b>
                /// <para>{}</para>
                /// </summary>
                [NameInMap("InputSchema")]
                [Validation(Required=false)]
                public string InputSchema { get; set; }

                /// <summary>
                /// <para>The node ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>fn-xxxxxxxx</para>
                /// </summary>
                [NameInMap("NodeId")]
                [Validation(Required=false)]
                public string NodeId { get; set; }

                /// <summary>
                /// <para>The node key.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Node1</para>
                /// </summary>
                [NameInMap("NodeKey")]
                [Validation(Required=false)]
                public string NodeKey { get; set; }

                /// <summary>
                /// <para>The node name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>NotifyMessage_1</para>
                /// </summary>
                [NameInMap("NodeName")]
                [Validation(Required=false)]
                public string NodeName { get; set; }

                /// <summary>
                /// <para>The node type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Trigger</para>
                /// </summary>
                [NameInMap("NodeType")]
                [Validation(Required=false)]
                public string NodeType { get; set; }

                /// <summary>
                /// <para>The ID of the previous node.</para>
                /// 
                /// <b>Example:</b>
                /// <para>fn-xxxxx,fn-yyyyyy</para>
                /// </summary>
                [NameInMap("PrevNodeId")]
                [Validation(Required=false)]
                public string PrevNodeId { get; set; }

                /// <summary>
                /// <para>The ID of the trigger or action.</para>
                /// 
                /// <b>Example:</b>
                /// <para>trigger-xxxxxxxxxx</para>
                /// </summary>
                [NameInMap("RefId")]
                [Validation(Required=false)]
                public string RefId { get; set; }

                /// <summary>
                /// <para>The trigger or action version.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("RefVersion")]
                [Validation(Required=false)]
                public string RefVersion { get; set; }

                /// <summary>
                /// <para>The webhook URL.</para>
                /// 
                /// <b>Example:</b>
                /// <para>https://{uid}.computenest.aliyun.com/webhook/xxxxxxxx</para>
                /// </summary>
                [NameInMap("WebhookUrl")]
                [Validation(Required=false)]
                public string WebhookUrl { get; set; }

            }

            /// <summary>
            /// <para>The flow template content.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{
            ///   &quot;FormatVersion&quot;: &quot;appflow-2025-07-01&quot;,
            ///   &quot;Nodes&quot;: [
            ///         {}
            ///    ]
            /// }</para>
            /// </summary>
            [NameInMap("FlowTemplate")]
            [Validation(Required=false)]
            public string FlowTemplate { get; set; }

            /// <summary>
            /// <para>The flow version.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("FlowVersion")]
            [Validation(Required=false)]
            public string FlowVersion { get; set; }

            /// <summary>
            /// <para>The flow version status.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("FlowVersionStatus")]
            [Validation(Required=false)]
            public string FlowVersionStatus { get; set; }

            /// <summary>
            /// <para>The creation time.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2025-07-30T02:13:22Z</para>
            /// </summary>
            [NameInMap("GmtCreate")]
            [Validation(Required=false)]
            public string GmtCreate { get; set; }

            /// <summary>
            /// <para>The last modification time.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2025-11-13T02:11:56Z</para>
            /// </summary>
            [NameInMap("GmtModified")]
            [Validation(Required=false)]
            public string GmtModified { get; set; }

            /// <summary>
            /// <para>A list of tags.</para>
            /// </summary>
            [NameInMap("Tags")]
            [Validation(Required=false)]
            public List<GetFlowResponseBodyFlowTags> Tags { get; set; }
            public class GetFlowResponseBodyFlowTags : TeaModel {
                /// <summary>
                /// <para>The tag key. The value can be up to 64 characters in length.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Environment</para>
                /// </summary>
                [NameInMap("Key")]
                [Validation(Required=false)]
                public string Key { get; set; }

                /// <summary>
                /// <para>The tag value.</para>
                /// 
                /// <b>Example:</b>
                /// <para>pre</para>
                /// </summary>
                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>B6E1E38D-011F-5368-ADD8-4DC278254AA3</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
