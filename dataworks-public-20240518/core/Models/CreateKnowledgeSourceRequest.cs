// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20240518.Models
{
    public class CreateKnowledgeSourceRequest : TeaModel {
        /// <summary>
        /// <para>The client token used to ensure idempotence.</para>
        /// 
        /// <b>Example:</b>
        /// <para>source-create-001</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>The data source configuration. This parameter is required when Type is set to DATA_SOURCE.</para>
        /// </summary>
        [NameInMap("DataSource")]
        [Validation(Required=false)]
        public CreateKnowledgeSourceRequestDataSource DataSource { get; set; }
        public class CreateKnowledgeSourceRequestDataSource : TeaModel {
            /// <summary>
            /// <para>The ID of the DataWorks data source. The server uses this ID to resolve the associated workspace, environment, and data source type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>12345</para>
            /// </summary>
            [NameInMap("DataSourceId")]
            [Validation(Required=false)]
            public long? DataSourceId { get; set; }

        }

        /// <summary>
        /// <para>The description.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Sales metrics and policy documents</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The document configuration. This parameter is required when Type is set to DOCUMENT.</para>
        /// </summary>
        [NameInMap("Document")]
        [Validation(Required=false)]
        public CreateKnowledgeSourceRequestDocument Document { get; set; }
        public class CreateKnowledgeSourceRequestDocument : TeaModel {
            /// <summary>
            /// <para>The type of the connector. Valid values: DINGTALK, FEISHU, LARK, WECOM, and YUQUE. The connector type cannot be changed after creation.</para>
            /// 
            /// <b>Example:</b>
            /// <para>WECOM</para>
            /// </summary>
            [NameInMap("ConnectorType")]
            [Validation(Required=false)]
            public string ConnectorType { get; set; }

            /// <summary>
            /// <para>The DingTalk configuration. This parameter is available only when ConnectorType is set to DINGTALK.</para>
            /// </summary>
            [NameInMap("DingTalk")]
            [Validation(Required=false)]
            public CreateKnowledgeSourceRequestDocumentDingTalk DingTalk { get; set; }
            public class CreateKnowledgeSourceRequestDocumentDingTalk : TeaModel {
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
                /// <para>The URLs of the knowledge bases, spaces, or documents selected for this connector. The actual allowed scope is determined by the connector and authorization settings.</para>
                /// </summary>
                [NameInMap("SourceUrls")]
                [Validation(Required=false)]
                public List<string> SourceUrls { get; set; }

            }

            /// <summary>
            /// <para>The Feishu configuration. This parameter is available only when ConnectorType is set to FEISHU.</para>
            /// </summary>
            [NameInMap("Feishu")]
            [Validation(Required=false)]
            public CreateKnowledgeSourceRequestDocumentFeishu Feishu { get; set; }
            public class CreateKnowledgeSourceRequestDocumentFeishu : TeaModel {
                /// <summary>
                /// <para>The ID of the Feishu or Lark application. This is not the AppSecret.</para>
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
                /// <para>The URLs of the knowledge bases, spaces, or documents selected for this connector. The actual allowed scope is determined by the connector and authorization settings.</para>
                /// </summary>
                [NameInMap("SourceUrls")]
                [Validation(Required=false)]
                public List<string> SourceUrls { get; set; }

            }

            /// <summary>
            /// <para>The Lark configuration. This parameter is available only when ConnectorType is set to LARK.</para>
            /// </summary>
            [NameInMap("Lark")]
            [Validation(Required=false)]
            public CreateKnowledgeSourceRequestDocumentLark Lark { get; set; }
            public class CreateKnowledgeSourceRequestDocumentLark : TeaModel {
                /// <summary>
                /// <para>The ID of the Feishu or Lark application. This is not the AppSecret.</para>
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
                /// <para>The URLs of the knowledge bases, spaces, or documents selected for this connector. The actual allowed scope is determined by the connector and authorization settings.</para>
                /// </summary>
                [NameInMap("SourceUrls")]
                [Validation(Required=false)]
                public List<string> SourceUrls { get; set; }

            }

            /// <summary>
            /// <para>The WeCom configuration. This parameter is available only when ConnectorType is set to WECOM.</para>
            /// </summary>
            [NameInMap("WeCom")]
            [Validation(Required=false)]
            public CreateKnowledgeSourceRequestDocumentWeCom WeCom { get; set; }
            public class CreateKnowledgeSourceRequestDocumentWeCom : TeaModel {
                /// <summary>
                /// <para>The ID of the WeCom bot.</para>
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
            /// <para>The Yuque configuration. This parameter is available only when ConnectorType is set to YUQUE.</para>
            /// </summary>
            [NameInMap("Yuque")]
            [Validation(Required=false)]
            public CreateKnowledgeSourceRequestDocumentYuque Yuque { get; set; }
            public class CreateKnowledgeSourceRequestDocumentYuque : TeaModel {
                /// <summary>
                /// <para>The Yuque team configurations. Each team independently selects the synchronization scope.</para>
                /// </summary>
                [NameInMap("Teams")]
                [Validation(Required=false)]
                public List<CreateKnowledgeSourceRequestDocumentYuqueTeams> Teams { get; set; }
                public class CreateKnowledgeSourceRequestDocumentYuqueTeams : TeaModel {
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
                    /// <para>The URLs of the knowledge bases, spaces, or documents selected for this connector. The actual allowed scope is determined by the connector and authorization settings.</para>
                    /// </summary>
                    [NameInMap("SourceUrls")]
                    [Validation(Required=false)]
                    public List<string> SourceUrls { get; set; }

                    /// <summary>
                    /// <para>The access token for the Yuque team. This token is used only for creation or updates and is not returned in the response.</para>
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
        /// <para>The ID of the knowledge base.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>12345678-1234-4234-8234-123456789abc</para>
        /// </summary>
        [NameInMap("KnowledgeBaseId")]
        [Validation(Required=false)]
        public string KnowledgeBaseId { get; set; }

        /// <summary>
        /// <para>The name of the source.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Sales topic project</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The project configuration. This parameter is required when Type is set to PROJECT.</para>
        /// </summary>
        [NameInMap("Project")]
        [Validation(Required=false)]
        public CreateKnowledgeSourceRequestProject Project { get; set; }
        public class CreateKnowledgeSourceRequestProject : TeaModel {
            /// <summary>
            /// <para>The environment type. This parameter is optional and restricts the read environment to Dev or Prod. If this parameter is not specified, it does not mean that you have the permissions to read data from both environments.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Prod</para>
            /// </summary>
            [NameInMap("EnvType")]
            [Validation(Required=false)]
            public string EnvType { get; set; }

            /// <summary>
            /// <para>The ID of the DataWorks workspace. This field is used to locate the source.</para>
            /// 
            /// <b>Example:</b>
            /// <para>12345</para>
            /// </summary>
            [NameInMap("ProjectId")]
            [Validation(Required=false)]
            public long? ProjectId { get; set; }

        }

        /// <summary>
        /// <para>The type of the knowledge source. Valid values: PROJECT, DATA_SOURCE, and DOCUMENT.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>PROJECT</para>
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
