// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20240518.Models
{
    public class UpdateKnowledgeSourceResponseBody : TeaModel {
        /// <summary>
        /// <para>The business error code. You can use this code to determine the error type when the request fails.</para>
        /// 
        /// <b>Example:</b>
        /// <para>InvalidParameter</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The business data returned when the request is successful.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public UpdateKnowledgeSourceResponseBodyData Data { get; set; }
        public class UpdateKnowledgeSourceResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The creation time. The value is a timestamp in milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1790200400000</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public long? CreateTime { get; set; }

            /// <summary>
            /// <para>The creator. This field is written by the server.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1000000000000000</para>
            /// </summary>
            [NameInMap("CreateUser")]
            [Validation(Required=false)]
            public string CreateUser { get; set; }

            /// <summary>
            /// <para>The data source information. This field is available only when Type is set to DATA_SOURCE.</para>
            /// </summary>
            [NameInMap("DataSource")]
            [Validation(Required=false)]
            public UpdateKnowledgeSourceResponseBodyDataDataSource DataSource { get; set; }
            public class UpdateKnowledgeSourceResponseBodyDataDataSource : TeaModel {
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
            /// <para>The optional description of the purpose.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Sales metrics and policy documents</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The document information. This field is available only when Type is set to DOCUMENT.</para>
            /// </summary>
            [NameInMap("Document")]
            [Validation(Required=false)]
            public UpdateKnowledgeSourceResponseBodyDataDocument Document { get; set; }
            public class UpdateKnowledgeSourceResponseBodyDataDocument : TeaModel {
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
                /// <para>Indicates whether the credentials required for the connector are configured. This field is read-only and does not return the credential content or ciphertext.</para>
                /// </summary>
                [NameInMap("CredentialConfigured")]
                [Validation(Required=false)]
                public bool? CredentialConfigured { get; set; }

                /// <summary>
                /// <para>The DingTalk configuration. This parameter is present only when the connector type is DINGTALK.</para>
                /// </summary>
                [NameInMap("DingTalk")]
                [Validation(Required=false)]
                public UpdateKnowledgeSourceResponseBodyDataDocumentDingTalk DingTalk { get; set; }
                public class UpdateKnowledgeSourceResponseBodyDataDocumentDingTalk : TeaModel {
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
                public UpdateKnowledgeSourceResponseBodyDataDocumentFeishu Feishu { get; set; }
                public class UpdateKnowledgeSourceResponseBodyDataDocumentFeishu : TeaModel {
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
                public UpdateKnowledgeSourceResponseBodyDataDocumentLark Lark { get; set; }
                public class UpdateKnowledgeSourceResponseBodyDataDocumentLark : TeaModel {
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
                public UpdateKnowledgeSourceResponseBodyDataDocumentWeCom WeCom { get; set; }
                public class UpdateKnowledgeSourceResponseBodyDataDocumentWeCom : TeaModel {
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
                    /// <para>The selected shared spaces, including their identities and display names.</para>
                    /// </summary>
                    [NameInMap("Spaces")]
                    [Validation(Required=false)]
                    public List<UpdateKnowledgeSourceResponseBodyDataDocumentWeComSpaces> Spaces { get; set; }
                    public class UpdateKnowledgeSourceResponseBodyDataDocumentWeComSpaces : TeaModel {
                        /// <summary>
                        /// <para>The identity of the shared space.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>space-001</para>
                        /// </summary>
                        [NameInMap("SpaceId")]
                        [Validation(Required=false)]
                        public string SpaceId { get; set; }

                        /// <summary>
                        /// <para>The display name verified by the server. This field is not used for identity verification.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>R&amp;D knowledge</para>
                        /// </summary>
                        [NameInMap("SpaceName")]
                        [Validation(Required=false)]
                        public string SpaceName { get; set; }

                    }

                }

                /// <summary>
                /// <para>The Yuque configuration. This parameter is present only when the connector type is YUQUE.</para>
                /// </summary>
                [NameInMap("Yuque")]
                [Validation(Required=false)]
                public UpdateKnowledgeSourceResponseBodyDataDocumentYuque Yuque { get; set; }
                public class UpdateKnowledgeSourceResponseBodyDataDocumentYuque : TeaModel {
                    /// <summary>
                    /// <para>The Yuque team configuration. Each team independently selects the synchronization scope.</para>
                    /// </summary>
                    [NameInMap("Teams")]
                    [Validation(Required=false)]
                    public List<UpdateKnowledgeSourceResponseBodyDataDocumentYuqueTeams> Teams { get; set; }
                    public class UpdateKnowledgeSourceResponseBodyDataDocumentYuqueTeams : TeaModel {
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
                        /// <para>The team ID verified by the server.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>team-001</para>
                        /// </summary>
                        [NameInMap("TeamId")]
                        [Validation(Required=false)]
                        public string TeamId { get; set; }

                        /// <summary>
                        /// <para>The logon name of the team. This is read-only display information.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>example-team</para>
                        /// </summary>
                        [NameInMap("TeamLogin")]
                        [Validation(Required=false)]
                        public string TeamLogin { get; set; }

                        /// <summary>
                        /// <para>The name of the team. This is read-only display information.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>Sample team</para>
                        /// </summary>
                        [NameInMap("TeamName")]
                        [Validation(Required=false)]
                        public string TeamName { get; set; }

                    }

                }

            }

            /// <summary>
            /// <para>The ID of the knowledge base to which the source belongs. The source cannot be migrated to another knowledge base after creation.</para>
            /// 
            /// <b>Example:</b>
            /// <para>12345678-1234-4234-8234-123456789abc</para>
            /// </summary>
            [NameInMap("KnowledgeBaseId")]
            [Validation(Required=false)]
            public string KnowledgeBaseId { get; set; }

            /// <summary>
            /// <para>The last modification time. The value is a timestamp in milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1790200300000</para>
            /// </summary>
            [NameInMap("ModifyTime")]
            [Validation(Required=false)]
            public long? ModifyTime { get; set; }

            /// <summary>
            /// <para>The name users use to identify the source.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Sales Project</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The project information. This field is available only when Type is set to PROJECT.</para>
            /// </summary>
            [NameInMap("Project")]
            [Validation(Required=false)]
            public UpdateKnowledgeSourceResponseBodyDataProject Project { get; set; }
            public class UpdateKnowledgeSourceResponseBodyDataProject : TeaModel {
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
            /// <para>The stable source ID generated by the service.</para>
            /// 
            /// <b>Example:</b>
            /// <para>src-001</para>
            /// </summary>
            [NameInMap("SourceId")]
            [Validation(Required=false)]
            public string SourceId { get; set; }

            /// <summary>
            /// <para>The source type. Valid values: PROJECT (workspace), DATA_SOURCE (DataWorks data source), and DOCUMENT (external document source).</para>
            /// 
            /// <b>Example:</b>
            /// <para>PROJECT</para>
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        /// <summary>
        /// <para>The error message returned when the request fails.</para>
        /// 
        /// <b>Example:</b>
        /// <para>The request parameters are invalid</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The unique identifier of the request. Use it to troubleshoot issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>00000000-0000-4000-8000-000000000001</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request is successful.</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
