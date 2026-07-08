// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AiMiaoBi20230801.Models
{
    public class CreateDatasetRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>private</para>
        /// </summary>
        [NameInMap("AccessLevel")]
        [Validation(Required=false)]
        public string AccessLevel { get; set; }

        /// <summary>
        /// <para>The dataset search configuration.</para>
        /// </summary>
        [NameInMap("DatasetConfig")]
        [Validation(Required=false)]
        public CreateDatasetRequestDatasetConfig DatasetConfig { get; set; }
        public class CreateDatasetRequestDatasetConfig : TeaModel {
            /// <summary>
            /// <para>Dataset configuration items.</para>
            /// </summary>
            [NameInMap("SearchSourceConfig")]
            [Validation(Required=false)]
            public CreateDatasetRequestDatasetConfigSearchSourceConfig SearchSourceConfig { get; set; }
            public class CreateDatasetRequestDatasetConfigSearchSourceConfig : TeaModel {
                /// <summary>
                /// <para>Specifies whether the metadata key-value pairs are used in generation. The default value is true.</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("MetadataKeyValueGenerateEnable")]
                [Validation(Required=false)]
                public bool? MetadataKeyValueGenerateEnable { get; set; }

                /// <summary>
                /// <para>Specifies whether the metadata key-value pairs are used in searches. The default value is true.</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("MetadataKeyValueSearchEnable")]
                [Validation(Required=false)]
                public bool? MetadataKeyValueSearchEnable { get; set; }

                /// <summary>
                /// <para>Specifies whether tags are used in generation. The default value is true.</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("TagGenerateEnable")]
                [Validation(Required=false)]
                public bool? TagGenerateEnable { get; set; }

                /// <summary>
                /// <para>Specifies whether tags are used in searches. The default value is true.</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("TagSearchEnable")]
                [Validation(Required=false)]
                public bool? TagSearchEnable { get; set; }

            }

            /// <summary>
            /// <para>Third-party search: API definition.</para>
            /// </summary>
            [NameInMap("SearchSourceConfigs")]
            [Validation(Required=false)]
            public List<CreateDatasetRequestDatasetConfigSearchSourceConfigs> SearchSourceConfigs { get; set; }
            public class CreateDatasetRequestDatasetConfigSearchSourceConfigs : TeaModel {
                /// <summary>
                /// <para>A searchable keyword used to verify availability.</para>
                /// 
                /// <b>Example:</b>
                /// <para>可以搜索到的关键词，用来验证是否可用</para>
                /// </summary>
                [NameInMap("DemoQuery")]
                [Validation(Required=false)]
                public string DemoQuery { get; set; }

                /// <summary>
                /// <para>API request configuration.</para>
                /// </summary>
                [NameInMap("SearchSourceRequestConfig")]
                [Validation(Required=false)]
                public CreateDatasetRequestDatasetConfigSearchSourceConfigsSearchSourceRequestConfig SearchSourceRequestConfig { get; set; }
                public class CreateDatasetRequestDatasetConfigSearchSourceConfigsSearchSourceRequestConfig : TeaModel {
                    /// <summary>
                    /// <para>The request body.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>{}</para>
                    /// </summary>
                    [NameInMap("Body")]
                    [Validation(Required=false)]
                    public string Body { get; set; }

                    /// <summary>
                    /// <para>The connection timeout period, in milliseconds.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>3000</para>
                    /// </summary>
                    [NameInMap("ConnectTimeout")]
                    [Validation(Required=false)]
                    public int? ConnectTimeout { get; set; }

                    /// <summary>
                    /// <para>The HTTP request headers.</para>
                    /// </summary>
                    [NameInMap("Headers")]
                    [Validation(Required=false)]
                    public List<CreateDatasetRequestDatasetConfigSearchSourceConfigsSearchSourceRequestConfigHeaders> Headers { get; set; }
                    public class CreateDatasetRequestDatasetConfigSearchSourceConfigsSearchSourceRequestConfigHeaders : TeaModel {
                        /// <summary>
                        /// <para>The parameter name.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>参数名称</para>
                        /// </summary>
                        [NameInMap("Name")]
                        [Validation(Required=false)]
                        public string Name { get; set; }

                        /// <summary>
                        /// <para>The parameter value.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>参数值</para>
                        /// </summary>
                        [NameInMap("Value")]
                        [Validation(Required=false)]
                        public string Value { get; set; }

                        /// <summary>
                        /// <para>This parameter is valid only when ValueType is set to time.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>valueType = time 时有效</para>
                        /// </summary>
                        [NameInMap("ValueFormat")]
                        [Validation(Required=false)]
                        public string ValueFormat { get; set; }

                        /// <summary>
                        /// <para>The data type of the parameter value. The default value is string.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>参数值数据类型：默认string</para>
                        /// </summary>
                        [NameInMap("ValueType")]
                        [Validation(Required=false)]
                        public string ValueType { get; set; }

                    }

                    /// <summary>
                    /// <para>The request method.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>请求方式</para>
                    /// </summary>
                    [NameInMap("Method")]
                    [Validation(Required=false)]
                    public string Method { get; set; }

                    /// <summary>
                    /// <para>The request path parameters.</para>
                    /// </summary>
                    [NameInMap("Params")]
                    [Validation(Required=false)]
                    public List<CreateDatasetRequestDatasetConfigSearchSourceConfigsSearchSourceRequestConfigParams> Params { get; set; }
                    public class CreateDatasetRequestDatasetConfigSearchSourceConfigsSearchSourceRequestConfigParams : TeaModel {
                        /// <summary>
                        /// <para>The parameter name.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>参数名称</para>
                        /// </summary>
                        [NameInMap("Name")]
                        [Validation(Required=false)]
                        public string Name { get; set; }

                        /// <summary>
                        /// <para>The parameter value.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>参数值</para>
                        /// </summary>
                        [NameInMap("Value")]
                        [Validation(Required=false)]
                        public string Value { get; set; }

                        /// <summary>
                        /// <para>This parameter is valid only when ValueType is set to time.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>valueType = time 时有效</para>
                        /// </summary>
                        [NameInMap("ValueFormat")]
                        [Validation(Required=false)]
                        public string ValueFormat { get; set; }

                        /// <summary>
                        /// <para>The data type of the parameter value. The default value is string.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>参数值数据类型：默认string</para>
                        /// </summary>
                        [NameInMap("ValueType")]
                        [Validation(Required=false)]
                        public string ValueType { get; set; }

                    }

                    /// <summary>
                    /// <para>Specifies whether to enable path parameters.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>true</para>
                    /// </summary>
                    [NameInMap("PathParamsEnable")]
                    [Validation(Required=false)]
                    public bool? PathParamsEnable { get; set; }

                    /// <summary>
                    /// <para>The read timeout period, in milliseconds.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>3000</para>
                    /// </summary>
                    [NameInMap("SocketTimeout")]
                    [Validation(Required=false)]
                    public int? SocketTimeout { get; set; }

                    /// <summary>
                    /// <para>The API URL.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>api地址</para>
                    /// </summary>
                    [NameInMap("Url")]
                    [Validation(Required=false)]
                    public string Url { get; set; }

                }

                /// <summary>
                /// <para>API response configuration.</para>
                /// </summary>
                [NameInMap("SearchSourceResponseConfig")]
                [Validation(Required=false)]
                public CreateDatasetRequestDatasetConfigSearchSourceConfigsSearchSourceResponseConfig SearchSourceResponseConfig { get; set; }
                public class CreateDatasetRequestDatasetConfigSearchSourceConfigsSearchSourceResponseConfig : TeaModel {
                    /// <summary>
                    /// <para>Node configuration.</para>
                    /// </summary>
                    [NameInMap("JqNodes")]
                    [Validation(Required=false)]
                    public List<CreateDatasetRequestDatasetConfigSearchSourceConfigsSearchSourceResponseConfigJqNodes> JqNodes { get; set; }
                    public class CreateDatasetRequestDatasetConfigSearchSourceConfigsSearchSourceResponseConfigJqNodes : TeaModel {
                        /// <summary>
                        /// <para>Child node configuration.</para>
                        /// </summary>
                        [NameInMap("JqNodes")]
                        [Validation(Required=false)]
                        public List<CreateDatasetRequestDatasetConfigSearchSourceConfigsSearchSourceResponseConfigJqNodesJqNodes> JqNodes { get; set; }
                        public class CreateDatasetRequestDatasetConfigSearchSourceConfigsSearchSourceResponseConfigJqNodesJqNodes : TeaModel {
                            /// <summary>
                            /// <para>Child node configuration.</para>
                            /// </summary>
                            [NameInMap("JqNodes")]
                            [Validation(Required=false)]
                            public List<CreateDatasetRequestDatasetConfigSearchSourceConfigsSearchSourceResponseConfigJqNodesJqNodesJqNodes> JqNodes { get; set; }
                            public class CreateDatasetRequestDatasetConfigSearchSourceConfigsSearchSourceResponseConfigJqNodesJqNodesJqNodes : TeaModel {
                                /// <summary>
                                /// <para>The node key.</para>
                                /// 
                                /// <b>Example:</b>
                                /// <para>title</para>
                                /// </summary>
                                [NameInMap("Key")]
                                [Validation(Required=false)]
                                public string Key { get; set; }

                                /// <summary>
                                /// <para>The node path.</para>
                                /// 
                                /// <b>Example:</b>
                                /// <para>节点路径</para>
                                /// </summary>
                                [NameInMap("Path")]
                                [Validation(Required=false)]
                                public string Path { get; set; }

                                /// <summary>
                                /// <para>The type.</para>
                                /// 
                                /// <b>Example:</b>
                                /// <para>string</para>
                                /// </summary>
                                [NameInMap("Type")]
                                [Validation(Required=false)]
                                public string Type { get; set; }

                            }

                            /// <summary>
                            /// <para>The node key.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>title</para>
                            /// </summary>
                            [NameInMap("Key")]
                            [Validation(Required=false)]
                            public string Key { get; set; }

                            /// <summary>
                            /// <para>The path.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>节点路径</para>
                            /// </summary>
                            [NameInMap("Path")]
                            [Validation(Required=false)]
                            public string Path { get; set; }

                            /// <summary>
                            /// <para>The type.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>string</para>
                            /// </summary>
                            [NameInMap("Type")]
                            [Validation(Required=false)]
                            public string Type { get; set; }

                        }

                        /// <summary>
                        /// <para>The node key.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>节点key</para>
                        /// </summary>
                        [NameInMap("Key")]
                        [Validation(Required=false)]
                        public string Key { get; set; }

                        /// <summary>
                        /// <para>The node path.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>节点路径</para>
                        /// </summary>
                        [NameInMap("Path")]
                        [Validation(Required=false)]
                        public string Path { get; set; }

                        /// <summary>
                        /// <para>The data type of the node. Valid values: string, number, list, object, and base.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>节点数据类型：string number list object base</para>
                        /// </summary>
                        [NameInMap("Type")]
                        [Validation(Required=false)]
                        public string Type { get; set; }

                    }

                }

                /// <summary>
                /// <para>The default limit on the number of data entries for requests and responses.</para>
                /// 
                /// <b>Example:</b>
                /// <para>10</para>
                /// </summary>
                [NameInMap("Size")]
                [Validation(Required=false)]
                public int? Size { get; set; }

            }

        }

        /// <summary>
        /// <para>The description of the dataset. This is the display name in the console. Use a human-readable name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>企业知识库</para>
        /// </summary>
        [NameInMap("DatasetDescription")]
        [Validation(Required=false)]
        public string DatasetDescription { get; set; }

        /// <summary>
        /// <para>The name of the dataset. The name must be globally unique.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>businessDataset</para>
        /// </summary>
        [NameInMap("DatasetName")]
        [Validation(Required=false)]
        public string DatasetName { get; set; }

        /// <summary>
        /// <para>The type of the dataset. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>CustomSemanticSearch: A custom semantic index. This is the default value. Upload documents to build the dataset.</para>
        /// </description></item>
        /// <item><description><para>ThirdSearch: A third-party search source (API). Configure your own search API.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>CustomSemanticSearch</para>
        /// </summary>
        [NameInMap("DatasetType")]
        [Validation(Required=false)]
        public string DatasetType { get; set; }

        /// <summary>
        /// <para>Dataset index configuration.</para>
        /// </summary>
        [NameInMap("DocumentHandleConfig")]
        [Validation(Required=false)]
        public CreateDatasetRequestDocumentHandleConfig DocumentHandleConfig { get; set; }
        public class CreateDatasetRequestDocumentHandleConfig : TeaModel {
            /// <summary>
            /// <para>Disables the processing logic for multimedia files.</para>
            /// <list type="bullet">
            /// <item><description><para>true: Disables multimodal (image and video) indexing. Only text is indexed and searched.</para>
            /// </description></item>
            /// <item><description><para>false: Enables multimodal (text, image, and video) indexing. This setting takes effect only after you activate ApsaraVideo and grant authorization in system administration. If you set this to false but authorization is not granted, image and video indexing is automatically skipped. This is the default value.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("DisableHandleMultimodalMedia")]
            [Validation(Required=false)]
            public bool? DisableHandleMultimodalMedia { get; set; }

        }

        /// <summary>
        /// <para>The invocation method. Currently, only portal is supported, which indicates an invocation from the console.</para>
        /// <list type="bullet">
        /// <item><description><para>If left empty: When DatasetType is ThirdSearch, datasetConfig.SearchSourceConfigs (third-party API definition) is required.</para>
        /// </description></item>
        /// <item><description><para>If set to portal: When DatasetType is ThirdSearch, the system initializes a SearchSourceConfigs (third-party API demo) example by default for your reference.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>portal</para>
        /// </summary>
        [NameInMap("InvokeType")]
        [Validation(Required=false)]
        public string InvokeType { get; set; }

        /// <summary>
        /// <para>The dataset search switch. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>0: Disabled for all.</para>
        /// </description></item>
        /// <item><description><para>1: Visible only to Miao Search.</para>
        /// </description></item>
        /// <item><description><para>2: Visible only to Miao Bi.</para>
        /// </description></item>
        /// <item><description><para>3: Visible to both Miao Search and Miao Bi. This is the default value.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>3</para>
        /// </summary>
        [NameInMap("SearchDatasetEnable")]
        [Validation(Required=false)]
        public int? SearchDatasetEnable { get; set; }

        /// <summary>
        /// <para>The unique ID of the Alibaba Cloud Model Studio workspace. For more information, see <a href="https://help.aliyun.com/document_detail/2782167.html">Obtain a workspace ID</a>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>llm-xxx</para>
        /// </summary>
        [NameInMap("WorkspaceId")]
        [Validation(Required=false)]
        public string WorkspaceId { get; set; }

    }

}
