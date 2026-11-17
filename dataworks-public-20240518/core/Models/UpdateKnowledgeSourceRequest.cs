// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20240518.Models
{
    public class UpdateKnowledgeSourceRequest : TeaModel {
        /// <summary>
        /// <para>The complete configuration for Type=DATA_SOURCE.</para>
        /// </summary>
        [NameInMap("DataSource")]
        [Validation(Required=false)]
        public UpdateKnowledgeSourceRequestDataSource DataSource { get; set; }
        public class UpdateKnowledgeSourceRequestDataSource : TeaModel {
            /// <summary>
            /// <para>The DataWorks data source ID. The server uses this ID to resolve the associated workspace, environment, and data source type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>12345</para>
            /// </summary>
            [NameInMap("DataSourceId")]
            [Validation(Required=false)]
            public long? DataSourceId { get; set; }

        }

        /// <summary>
        /// <para>The new description.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Sales metrics and policy documents</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The complete configuration for Type=DOCUMENT. Credentials are not returned after they are written.</para>
        /// </summary>
        [NameInMap("Document")]
        [Validation(Required=false)]
        public UpdateKnowledgeSourceRequestDocument Document { get; set; }
        public class UpdateKnowledgeSourceRequestDocument : TeaModel {
            /// <summary>
            /// <para>The connector type. Valid values: DINGTALK, FEISHU, LARK, WECOM, and YUQUE. This value cannot be changed after creation.</para>
            /// 
            /// <b>Example:</b>
            /// <para>WECOM</para>
            /// </summary>
            [NameInMap("ConnectorType")]
            [Validation(Required=false)]
            public string ConnectorType { get; set; }

            /// <summary>
            /// <para>The DingTalk configuration. This parameter is present only when the connector type is DINGTALK.</para>
            /// </summary>
            [NameInMap("DingTalk")]
            [Validation(Required=false)]
            public UpdateKnowledgeSourceRequestDocumentDingTalk DingTalk { get; set; }
            public class UpdateKnowledgeSourceRequestDocumentDingTalk : TeaModel {
                /// <summary>
                /// <para>The MCP authorization credential for the DingTalk document connector. This credential is used only for creation or updates and is not returned in the response.</para>
                /// 
                /// <b>Example:</b>
                /// <para>123456****</para>
                /// </summary>
                [NameInMap("McpKey")]
                [Validation(Required=false)]
                public string McpKey { get; set; }

                /// <summary>
                /// <para>The URLs of the knowledge bases, spaces, or documents selected for this connector. The actual allowed scope is determined by the connector and authorization.</para>
                /// </summary>
                [NameInMap("SourceUrls")]
                [Validation(Required=false)]
                public List<string> SourceUrls { get; set; }

            }

            /// <summary>
            /// <para>The Feishu configuration. This parameter is present only when the connector type is FEISHU.</para>
            /// </summary>
            [NameInMap("Feishu")]
            [Validation(Required=false)]
            public UpdateKnowledgeSourceRequestDocumentFeishu Feishu { get; set; }
            public class UpdateKnowledgeSourceRequestDocumentFeishu : TeaModel {
                /// <summary>
                /// <para>The application ID of Feishu or Lark. This is not the AppSecret.</para>
                /// 
                /// <b>Example:</b>
                /// <para>app-001</para>
                /// </summary>
                [NameInMap("AppId")]
                [Validation(Required=false)]
                public string AppId { get; set; }

                /// <summary>
                /// <para>The secret of the Feishu or Lark application. This secret is used only for creation or updates and is not returned in the response.</para>
                /// 
                /// <b>Example:</b>
                /// <para>123456****</para>
                /// </summary>
                [NameInMap("AppSecret")]
                [Validation(Required=false)]
                public string AppSecret { get; set; }

                /// <summary>
                /// <para>The URLs of the knowledge bases, spaces, or documents selected for this connector. The actual allowed scope is determined by the connector and authorization.</para>
                /// </summary>
                [NameInMap("SourceUrls")]
                [Validation(Required=false)]
                public List<string> SourceUrls { get; set; }

            }

            /// <summary>
            /// <para>The Lark configuration. This parameter is present only when the connector type is LARK.</para>
            /// </summary>
            [NameInMap("Lark")]
            [Validation(Required=false)]
            public UpdateKnowledgeSourceRequestDocumentLark Lark { get; set; }
            public class UpdateKnowledgeSourceRequestDocumentLark : TeaModel {
                /// <summary>
                /// <para>The application ID of Feishu or Lark. This is not the AppSecret.</para>
                /// 
                /// <b>Example:</b>
                /// <para>app-001</para>
                /// </summary>
                [NameInMap("AppId")]
                [Validation(Required=false)]
                public string AppId { get; set; }

                /// <summary>
                /// <para>The secret of the Feishu or Lark application. This secret is used only for creation or updates and is not returned in the response.</para>
                /// 
                /// <b>Example:</b>
                /// <para>123456****</para>
                /// </summary>
                [NameInMap("AppSecret")]
                [Validation(Required=false)]
                public string AppSecret { get; set; }

                /// <summary>
                /// <para>The URLs of the knowledge bases, spaces, or documents selected for this connector. The actual allowed scope is determined by the connector and authorization.</para>
                /// </summary>
                [NameInMap("SourceUrls")]
                [Validation(Required=false)]
                public List<string> SourceUrls { get; set; }

            }

            /// <summary>
            /// <para>The WeCom configuration. This parameter is present only when the connector type is WECOM.</para>
            /// </summary>
            [NameInMap("WeCom")]
            [Validation(Required=false)]
            public UpdateKnowledgeSourceRequestDocumentWeCom WeCom { get; set; }
            public class UpdateKnowledgeSourceRequestDocumentWeCom : TeaModel {
                /// <summary>
                /// <para>The WeCom bot ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>bot-001</para>
                /// </summary>
                [NameInMap("BotId")]
                [Validation(Required=false)]
                public string BotId { get; set; }

                /// <summary>
                /// <para>The secret of the WeCom bot. This secret is used only for creation or updates and is not returned in the response.</para>
                /// 
                /// <b>Example:</b>
                /// <para>123456****</para>
                /// </summary>
                [NameInMap("BotSecret")]
                [Validation(Required=false)]
                public string BotSecret { get; set; }

                /// <summary>
                /// <para>The IDs of the shared spaces selected for the WeCom connector.</para>
                /// </summary>
                [NameInMap("SpaceIds")]
                [Validation(Required=false)]
                public List<string> SpaceIds { get; set; }

            }

            /// <summary>
            /// <para>The Yuque configuration. This parameter is present only when the connector type is YUQUE.</para>
            /// </summary>
            [NameInMap("Yuque")]
            [Validation(Required=false)]
            public UpdateKnowledgeSourceRequestDocumentYuque Yuque { get; set; }
            public class UpdateKnowledgeSourceRequestDocumentYuque : TeaModel {
                /// <summary>
                /// <para>The Yuque team configuration. Each team independently selects the synchronization scope.</para>
                /// </summary>
                [NameInMap("Teams")]
                [Validation(Required=false)]
                public List<UpdateKnowledgeSourceRequestDocumentYuqueTeams> Teams { get; set; }
                public class UpdateKnowledgeSourceRequestDocumentYuqueTeams : TeaModel {
                    /// <summary>
                    /// <para>The URL of the team site.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para><a href="https://www.yuque.com">https://www.yuque.com</a></para>
                    /// </summary>
                    [NameInMap("Host")]
                    [Validation(Required=false)]
                    public string Host { get; set; }

                    /// <summary>
                    /// <para>The URLs of the knowledge bases, spaces, or documents selected for this connector. The actual allowed scope is determined by the connector and authorization.</para>
                    /// </summary>
                    [NameInMap("SourceUrls")]
                    [Validation(Required=false)]
                    public List<string> SourceUrls { get; set; }

                    /// <summary>
                    /// <para>The Yuque team access credential. This credential is used only for creation or updates and is not returned in the response.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>123456****</para>
                    /// </summary>
                    [NameInMap("Token")]
                    [Validation(Required=false)]
                    public string Token { get; set; }

                }

            }

        }

        /// <summary>
        /// <para>The ID of the knowledge base to which the source belongs.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>12345678-1234-4234-8234-123456789abc</para>
        /// </summary>
        [NameInMap("KnowledgeBaseId")]
        [Validation(Required=false)]
        public string KnowledgeBaseId { get; set; }

        /// <summary>
        /// <para>The new name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Sales Project</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The complete configuration for Type=PROJECT.</para>
        /// </summary>
        [NameInMap("Project")]
        [Validation(Required=false)]
        public UpdateKnowledgeSourceRequestProject Project { get; set; }
        public class UpdateKnowledgeSourceRequestProject : TeaModel {
            /// <summary>
            /// <para>Optional. Limits the read environment to Dev or Prod. If this parameter is not specified, cross-environment read access is not granted.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Prod</para>
            /// </summary>
            [NameInMap("EnvType")]
            [Validation(Required=false)]
            public string EnvType { get; set; }

            /// <summary>
            /// <para>The DataWorks workspace ID, which is used to locate the source.</para>
            /// 
            /// <b>Example:</b>
            /// <para>12345</para>
            /// </summary>
            [NameInMap("ProjectId")]
            [Validation(Required=false)]
            public long? ProjectId { get; set; }

        }

        /// <summary>
        /// <para>The source ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>src-001</para>
        /// </summary>
        [NameInMap("SourceId")]
        [Validation(Required=false)]
        public string SourceId { get; set; }

    }

}
