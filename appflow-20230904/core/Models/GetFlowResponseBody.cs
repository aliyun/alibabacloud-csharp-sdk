// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Appflow20230904.Models
{
    public class GetFlowResponseBody : TeaModel {
        [NameInMap("Flow")]
        [Validation(Required=false)]
        public GetFlowResponseBodyFlow Flow { get; set; }
        public class GetFlowResponseBodyFlow : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("Enabled")]
            [Validation(Required=false)]
            public string Enabled { get; set; }

            [NameInMap("FlowDesc")]
            [Validation(Required=false)]
            public string FlowDesc { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>flow-xxxxxxxx</para>
            /// </summary>
            [NameInMap("FlowId")]
            [Validation(Required=false)]
            public string FlowId { get; set; }

            [NameInMap("FlowName")]
            [Validation(Required=false)]
            public string FlowName { get; set; }

            [NameInMap("FlowNodes")]
            [Validation(Required=false)]
            public List<GetFlowResponseBodyFlowFlowNodes> FlowNodes { get; set; }
            public class GetFlowResponseBodyFlowFlowNodes : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>{\&quot;authconfigId\&quot;:\&quot;uac-xxxxxxxxx\&quot;}</para>
                /// </summary>
                [NameInMap("AuthMetadata")]
                [Validation(Required=false)]
                public string AuthMetadata { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>connector-xxx24b139c62</para>
                /// </summary>
                [NameInMap("ConnectorId")]
                [Validation(Required=false)]
                public string ConnectorId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2</para>
                /// </summary>
                [NameInMap("ConnectorVersion")]
                [Validation(Required=false)]
                public string ConnectorVersion { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>flow-856cb84b309747e48b43</para>
                /// </summary>
                [NameInMap("FlowId")]
                [Validation(Required=false)]
                public string FlowId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("FlowVersion")]
                [Validation(Required=false)]
                public string FlowVersion { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>{}</para>
                /// </summary>
                [NameInMap("InputSchema")]
                [Validation(Required=false)]
                public string InputSchema { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>fn-xxxxxxxx</para>
                /// </summary>
                [NameInMap("NodeId")]
                [Validation(Required=false)]
                public string NodeId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>Node1</para>
                /// </summary>
                [NameInMap("NodeKey")]
                [Validation(Required=false)]
                public string NodeKey { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>NotifyMessage_1</para>
                /// </summary>
                [NameInMap("NodeName")]
                [Validation(Required=false)]
                public string NodeName { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>Trigger</para>
                /// </summary>
                [NameInMap("NodeType")]
                [Validation(Required=false)]
                public string NodeType { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>fn-xxxxx,fn-yyyyyy</para>
                /// </summary>
                [NameInMap("PrevNodeId")]
                [Validation(Required=false)]
                public string PrevNodeId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>trigger-xxxxxxxxxx</para>
                /// </summary>
                [NameInMap("RefId")]
                [Validation(Required=false)]
                public string RefId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("RefVersion")]
                [Validation(Required=false)]
                public string RefVersion { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>https://{uid}.computenest.aliyun.com/webhook/xxxxxxxx</para>
                /// </summary>
                [NameInMap("WebhookUrl")]
                [Validation(Required=false)]
                public string WebhookUrl { get; set; }

            }

            /// <summary>
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
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("FlowVersion")]
            [Validation(Required=false)]
            public string FlowVersion { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("FlowVersionStatus")]
            [Validation(Required=false)]
            public string FlowVersionStatus { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2025-07-30T02:13:22Z</para>
            /// </summary>
            [NameInMap("GmtCreate")]
            [Validation(Required=false)]
            public string GmtCreate { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2025-11-13T02:11:56Z</para>
            /// </summary>
            [NameInMap("GmtModified")]
            [Validation(Required=false)]
            public string GmtModified { get; set; }

            [NameInMap("Tags")]
            [Validation(Required=false)]
            public List<GetFlowResponseBodyFlowTags> Tags { get; set; }
            public class GetFlowResponseBodyFlowTags : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>Environment</para>
                /// </summary>
                [NameInMap("Key")]
                [Validation(Required=false)]
                public string Key { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>pre</para>
                /// </summary>
                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

        }

        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>B6E1E38D-011F-5368-ADD8-4DC278254AA3</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
