// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20240518.Models
{
    public class ListKnowledgeSourcesResponseBody : TeaModel {
        /// <summary>
        /// <para>The business error code. This code is used to determine the error type when the request fails.</para>
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
        public ListKnowledgeSourcesResponseBodyData Data { get; set; }
        public class ListKnowledgeSourcesResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The pagination token for the next page. If no next page exists, the value is null.</para>
            /// 
            /// <b>Example:</b>
            /// <para>eyJvZmZzZXQiOjIwfQ</para>
            /// </summary>
            [NameInMap("NextToken")]
            [Validation(Required=false)]
            public string NextToken { get; set; }

            /// <summary>
            /// <para>The knowledge sources that you have permission to read on the current page.</para>
            /// </summary>
            [NameInMap("Sources")]
            [Validation(Required=false)]
            public List<ListKnowledgeSourcesResponseBodyDataSources> Sources { get; set; }
            public class ListKnowledgeSourcesResponseBodyDataSources : TeaModel {
                /// <summary>
                /// <para>The creation time. The value is a UNIX timestamp in milliseconds.</para>
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
                public ListKnowledgeSourcesResponseBodyDataSourcesDataSource DataSource { get; set; }
                public class ListKnowledgeSourcesResponseBodyDataSourcesDataSource : TeaModel {
                    /// <summary>
                    /// <para>The ID of the DataWorks data source. The server uses this ID to resolve the workspace, environment, and data source type.</para>
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
                public ListKnowledgeSourcesResponseBodyDataSourcesDocument Document { get; set; }
                public class ListKnowledgeSourcesResponseBodyDataSourcesDocument : TeaModel {
                    /// <summary>
                    /// <para>The connector type. Valid values: DINGTALK, FEISHU, LARK, WECOM, or YUQUE. The connector type cannot be changed after the source is created.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>WECOM</para>
                    /// </summary>
                    [NameInMap("ConnectorType")]
                    [Validation(Required=false)]
                    public string ConnectorType { get; set; }

                    /// <summary>
                    /// <para>Indicates whether the credentials required by the connector are configured. This field is read-only, and the credential content or ciphertext is not returned.</para>
                    /// </summary>
                    [NameInMap("CredentialConfigured")]
                    [Validation(Required=false)]
                    public bool? CredentialConfigured { get; set; }

                    /// <summary>
                    /// <para>The DingTalk configuration. This field is available only when the connector type is DingTalk.</para>
                    /// </summary>
                    [NameInMap("DingTalk")]
                    [Validation(Required=false)]
                    public ListKnowledgeSourcesResponseBodyDataSourcesDocumentDingTalk DingTalk { get; set; }
                    public class ListKnowledgeSourcesResponseBodyDataSourcesDocumentDingTalk : TeaModel {
                        /// <summary>
                        /// <para>The Feishu or Lark application ID. This is not the AppSecret.</para>
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
                    /// <para>The Feishu configuration. This field is available only when the connector type is Feishu.</para>
                    /// </summary>
                    [NameInMap("Feishu")]
                    [Validation(Required=false)]
                    public ListKnowledgeSourcesResponseBodyDataSourcesDocumentFeishu Feishu { get; set; }
                    public class ListKnowledgeSourcesResponseBodyDataSourcesDocumentFeishu : TeaModel {
                        /// <summary>
                        /// <para>The Feishu or Lark application ID. This is not the AppSecret.</para>
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
                    /// <para>The Lark configuration. This field is available only when the connector type is Lark.</para>
                    /// </summary>
                    [NameInMap("Lark")]
                    [Validation(Required=false)]
                    public ListKnowledgeSourcesResponseBodyDataSourcesDocumentLark Lark { get; set; }
                    public class ListKnowledgeSourcesResponseBodyDataSourcesDocumentLark : TeaModel {
                        /// <summary>
                        /// <para>The Feishu or Lark application ID. This is not the AppSecret.</para>
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
                    /// <para>The WeCom configuration. This field is available only when the connector type is WeCom.</para>
                    /// </summary>
                    [NameInMap("WeCom")]
                    [Validation(Required=false)]
                    public ListKnowledgeSourcesResponseBodyDataSourcesDocumentWeCom WeCom { get; set; }
                    public class ListKnowledgeSourcesResponseBodyDataSourcesDocumentWeCom : TeaModel {
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
                        /// <para>The selected shared spaces, including their identities and display names.</para>
                        /// </summary>
                        [NameInMap("Spaces")]
                        [Validation(Required=false)]
                        public List<ListKnowledgeSourcesResponseBodyDataSourcesDocumentWeComSpaces> Spaces { get; set; }
                        public class ListKnowledgeSourcesResponseBodyDataSourcesDocumentWeComSpaces : TeaModel {
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
                            /// <para>R&amp;D Knowledge</para>
                            /// </summary>
                            [NameInMap("SpaceName")]
                            [Validation(Required=false)]
                            public string SpaceName { get; set; }

                        }

                    }

                    /// <summary>
                    /// <para>The Yuque configuration. This field is available only when the connector type is Yuque.</para>
                    /// </summary>
                    [NameInMap("Yuque")]
                    [Validation(Required=false)]
                    public ListKnowledgeSourcesResponseBodyDataSourcesDocumentYuque Yuque { get; set; }
                    public class ListKnowledgeSourcesResponseBodyDataSourcesDocumentYuque : TeaModel {
                        /// <summary>
                        /// <para>The Yuque team configurations. Each team independently selects the synchronization scope.</para>
                        /// </summary>
                        [NameInMap("Teams")]
                        [Validation(Required=false)]
                        public List<ListKnowledgeSourcesResponseBodyDataSourcesDocumentYuqueTeams> Teams { get; set; }
                        public class ListKnowledgeSourcesResponseBodyDataSourcesDocumentYuqueTeams : TeaModel {
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
                            /// <para>The team logon name. This is read-only display information.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>example-team</para>
                            /// </summary>
                            [NameInMap("TeamLogin")]
                            [Validation(Required=false)]
                            public string TeamLogin { get; set; }

                            /// <summary>
                            /// <para>The team name. This is read-only display information.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>Sample Team</para>
                            /// </summary>
                            [NameInMap("TeamName")]
                            [Validation(Required=false)]
                            public string TeamName { get; set; }

                        }

                    }

                }

                /// <summary>
                /// <para>The ID of the knowledge base to which the source belongs. The source cannot be migrated to another knowledge base after it is created.</para>
                /// 
                /// <b>Example:</b>
                /// <para>12345678-1234-4234-8234-123456789abc</para>
                /// </summary>
                [NameInMap("KnowledgeBaseId")]
                [Validation(Required=false)]
                public string KnowledgeBaseId { get; set; }

                /// <summary>
                /// <para>The last modification time. The value is a UNIX timestamp in milliseconds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1790200300000</para>
                /// </summary>
                [NameInMap("ModifyTime")]
                [Validation(Required=false)]
                public long? ModifyTime { get; set; }

                /// <summary>
                /// <para>The name used to identify the source.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Sales Topic Project</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>The project information. This field is available only when Type is set to PROJECT.</para>
                /// </summary>
                [NameInMap("Project")]
                [Validation(Required=false)]
                public ListKnowledgeSourcesResponseBodyDataSourcesProject Project { get; set; }
                public class ListKnowledgeSourcesResponseBodyDataSourcesProject : TeaModel {
                    /// <summary>
                    /// <para>The environment type. This optional field restricts the read environment to Dev or Prod. If this field is not specified, it does not mean that you have the permissions to read both environments.</para>
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
                /// <para>The stable source ID generated by the service.</para>
                /// 
                /// <b>Example:</b>
                /// <para>src-001</para>
                /// </summary>
                [NameInMap("SourceId")]
                [Validation(Required=false)]
                public string SourceId { get; set; }

                /// <summary>
                /// <para>The source type. Valid values: PROJECT (workspace), DATA_SOURCE (DataWorks data source), or DOCUMENT (external document source).</para>
                /// 
                /// <b>Example:</b>
                /// <para>PROJECT</para>
                /// </summary>
                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

        }

        /// <summary>
        /// <para>The maximum number of entries per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

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
        /// <para>The unique identifier of the request, which can be used to troubleshoot issues.</para>
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
