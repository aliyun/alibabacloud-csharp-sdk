// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AiMiaoBi20230801.Models
{
    public class UpdateDatasetRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>private</para>
        /// </summary>
        [NameInMap("AccessLevel")]
        [Validation(Required=false)]
        public string AccessLevel { get; set; }

        /// <summary>
        /// <para>The configurations for a third-party search dataset.</para>
        /// </summary>
        [NameInMap("DatasetConfig")]
        [Validation(Required=false)]
        public UpdateDatasetRequestDatasetConfig DatasetConfig { get; set; }
        public class UpdateDatasetRequestDatasetConfig : TeaModel {
            /// <summary>
            /// <para>The dataset configuration items.</para>
            /// </summary>
            [NameInMap("SearchSourceConfig")]
            [Validation(Required=false)]
            public UpdateDatasetRequestDatasetConfigSearchSourceConfig SearchSourceConfig { get; set; }
            public class UpdateDatasetRequestDatasetConfigSearchSourceConfig : TeaModel {
                /// <summary>
                /// <para>Specifies whether the key-value pairs in metadata are used for generation. Default: true.</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("MetadataKeyValueGenerateEnable")]
                [Validation(Required=false)]
                public bool? MetadataKeyValueGenerateEnable { get; set; }

                /// <summary>
                /// <para>Specifies whether the key-value pairs in metadata are included in searches. Default: true.</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("MetadataKeyValueSearchEnable")]
                [Validation(Required=false)]
                public bool? MetadataKeyValueSearchEnable { get; set; }

                /// <summary>
                /// <para>Specifies whether tags are used for generation. Default: true.</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("TagGenerateEnable")]
                [Validation(Required=false)]
                public bool? TagGenerateEnable { get; set; }

                /// <summary>
                /// <para>Specifies whether tags are included in searches. Default: true.</para>
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
            public List<UpdateDatasetRequestDatasetConfigSearchSourceConfigs> SearchSourceConfigs { get; set; }
            public class UpdateDatasetRequestDatasetConfigSearchSourceConfigs : TeaModel {
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
                /// <para>The API request configuration.</para>
                /// </summary>
                [NameInMap("SearchSourceRequestConfig")]
                [Validation(Required=false)]
                public UpdateDatasetRequestDatasetConfigSearchSourceConfigsSearchSourceRequestConfig SearchSourceRequestConfig { get; set; }
                public class UpdateDatasetRequestDatasetConfigSearchSourceConfigsSearchSourceRequestConfig : TeaModel {
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
                    public List<UpdateDatasetRequestDatasetConfigSearchSourceConfigsSearchSourceRequestConfigHeaders> Headers { get; set; }
                    public class UpdateDatasetRequestDatasetConfigSearchSourceConfigsSearchSourceRequestConfigHeaders : TeaModel {
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
                        /// <para>The data type of the parameter value. Default: string.</para>
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
                    public List<UpdateDatasetRequestDatasetConfigSearchSourceConfigsSearchSourceRequestConfigParams> Params { get; set; }
                    public class UpdateDatasetRequestDatasetConfigSearchSourceConfigsSearchSourceRequestConfigParams : TeaModel {
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
                        /// <para>The data type of the parameter value. Default: string.</para>
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
                /// <para>The API response configuration.</para>
                /// </summary>
                [NameInMap("SearchSourceResponseConfig")]
                [Validation(Required=false)]
                public UpdateDatasetRequestDatasetConfigSearchSourceConfigsSearchSourceResponseConfig SearchSourceResponseConfig { get; set; }
                public class UpdateDatasetRequestDatasetConfigSearchSourceConfigsSearchSourceResponseConfig : TeaModel {
                    /// <summary>
                    /// <para>The node configuration.</para>
                    /// </summary>
                    [NameInMap("JqNodes")]
                    [Validation(Required=false)]
                    public List<UpdateDatasetRequestDatasetConfigSearchSourceConfigsSearchSourceResponseConfigJqNodes> JqNodes { get; set; }
                    public class UpdateDatasetRequestDatasetConfigSearchSourceConfigsSearchSourceResponseConfigJqNodes : TeaModel {
                        /// <summary>
                        /// <para>The child node configuration.</para>
                        /// </summary>
                        [NameInMap("JqNodes")]
                        [Validation(Required=false)]
                        public List<UpdateDatasetRequestDatasetConfigSearchSourceConfigsSearchSourceResponseConfigJqNodesJqNodes> JqNodes { get; set; }
                        public class UpdateDatasetRequestDatasetConfigSearchSourceConfigsSearchSourceResponseConfigJqNodesJqNodes : TeaModel {
                            /// <summary>
                            /// <para>The child node configuration.</para>
                            /// </summary>
                            [NameInMap("JqNodes")]
                            [Validation(Required=false)]
                            public List<UpdateDatasetRequestDatasetConfigSearchSourceConfigsSearchSourceResponseConfigJqNodesJqNodesJqNodes> JqNodes { get; set; }
                            public class UpdateDatasetRequestDatasetConfigSearchSourceConfigsSearchSourceResponseConfigJqNodesJqNodesJqNodes : TeaModel {
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
                                /// <para>.title</para>
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
                            /// <para>The node path.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>.title</para>
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
                /// <para>The default number of data entries for requests and responses.</para>
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
        /// <para>The description of the dataset.</para>
        /// 
        /// <b>Example:</b>
        /// <para>企业自定义数据集</para>
        /// </summary>
        [NameInMap("DatasetDescription")]
        [Validation(Required=false)]
        public string DatasetDescription { get; set; }

        /// <summary>
        /// <para>The dataset ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("DatasetId")]
        [Validation(Required=false)]
        public long? DatasetId { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable search for the dataset.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3</para>
        /// </summary>
        [NameInMap("SearchDatasetEnable")]
        [Validation(Required=false)]
        public int? SearchDatasetEnable { get; set; }

        /// <summary>
        /// <para>The unique identifier of the Alibaba Cloud Model Studio workspace. For more information, see <a href="">Get a workspaceId</a>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>xxxx</para>
        /// </summary>
        [NameInMap("WorkspaceId")]
        [Validation(Required=false)]
        public string WorkspaceId { get; set; }

    }

}
