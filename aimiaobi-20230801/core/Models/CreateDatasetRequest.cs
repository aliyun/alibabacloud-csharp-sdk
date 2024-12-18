// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AiMiaoBi20230801.Models
{
    public class CreateDatasetRequest : TeaModel {
        [NameInMap("DatasetConfig")]
        [Validation(Required=false)]
        public CreateDatasetRequestDatasetConfig DatasetConfig { get; set; }
        public class CreateDatasetRequestDatasetConfig : TeaModel {
            [NameInMap("SearchSourceConfigs")]
            [Validation(Required=false)]
            public List<CreateDatasetRequestDatasetConfigSearchSourceConfigs> SearchSourceConfigs { get; set; }
            public class CreateDatasetRequestDatasetConfigSearchSourceConfigs : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>可以搜索到的关键词，用来验证是否可用</para>
                /// </summary>
                [NameInMap("DemoQuery")]
                [Validation(Required=false)]
                public string DemoQuery { get; set; }

                [NameInMap("SearchSourceRequestConfig")]
                [Validation(Required=false)]
                public CreateDatasetRequestDatasetConfigSearchSourceConfigsSearchSourceRequestConfig SearchSourceRequestConfig { get; set; }
                public class CreateDatasetRequestDatasetConfigSearchSourceConfigsSearchSourceRequestConfig : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>{}</para>
                    /// </summary>
                    [NameInMap("Body")]
                    [Validation(Required=false)]
                    public string Body { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>3000</para>
                    /// </summary>
                    [NameInMap("ConnectTimeout")]
                    [Validation(Required=false)]
                    public int? ConnectTimeout { get; set; }

                    [NameInMap("Headers")]
                    [Validation(Required=false)]
                    public List<CreateDatasetRequestDatasetConfigSearchSourceConfigsSearchSourceRequestConfigHeaders> Headers { get; set; }
                    public class CreateDatasetRequestDatasetConfigSearchSourceConfigsSearchSourceRequestConfigHeaders : TeaModel {
                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>参数名称</para>
                        /// </summary>
                        [NameInMap("Name")]
                        [Validation(Required=false)]
                        public string Name { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>参数值</para>
                        /// </summary>
                        [NameInMap("Value")]
                        [Validation(Required=false)]
                        public string Value { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>valueType = time 时有效</para>
                        /// </summary>
                        [NameInMap("ValueFormat")]
                        [Validation(Required=false)]
                        public string ValueFormat { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>参数值数据类型: 默认string</para>
                        /// </summary>
                        [NameInMap("ValueType")]
                        [Validation(Required=false)]
                        public string ValueType { get; set; }

                    }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>请求方式</para>
                    /// </summary>
                    [NameInMap("Method")]
                    [Validation(Required=false)]
                    public string Method { get; set; }

                    [NameInMap("Params")]
                    [Validation(Required=false)]
                    public List<CreateDatasetRequestDatasetConfigSearchSourceConfigsSearchSourceRequestConfigParams> Params { get; set; }
                    public class CreateDatasetRequestDatasetConfigSearchSourceConfigsSearchSourceRequestConfigParams : TeaModel {
                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>参数名称</para>
                        /// </summary>
                        [NameInMap("Name")]
                        [Validation(Required=false)]
                        public string Name { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>参数值</para>
                        /// </summary>
                        [NameInMap("Value")]
                        [Validation(Required=false)]
                        public string Value { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>valueType = time 时有效</para>
                        /// </summary>
                        [NameInMap("ValueFormat")]
                        [Validation(Required=false)]
                        public string ValueFormat { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>参数值数据类型: 默认string</para>
                        /// </summary>
                        [NameInMap("ValueType")]
                        [Validation(Required=false)]
                        public string ValueType { get; set; }

                    }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>true</para>
                    /// </summary>
                    [NameInMap("PathParamsEnable")]
                    [Validation(Required=false)]
                    public bool? PathParamsEnable { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>3000</para>
                    /// </summary>
                    [NameInMap("SocketTimeout")]
                    [Validation(Required=false)]
                    public int? SocketTimeout { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>api地址</para>
                    /// </summary>
                    [NameInMap("Url")]
                    [Validation(Required=false)]
                    public string Url { get; set; }

                }

                [NameInMap("SearchSourceResponseConfig")]
                [Validation(Required=false)]
                public CreateDatasetRequestDatasetConfigSearchSourceConfigsSearchSourceResponseConfig SearchSourceResponseConfig { get; set; }
                public class CreateDatasetRequestDatasetConfigSearchSourceConfigsSearchSourceResponseConfig : TeaModel {
                    [NameInMap("JqNodes")]
                    [Validation(Required=false)]
                    public List<CreateDatasetRequestDatasetConfigSearchSourceConfigsSearchSourceResponseConfigJqNodes> JqNodes { get; set; }
                    public class CreateDatasetRequestDatasetConfigSearchSourceConfigsSearchSourceResponseConfigJqNodes : TeaModel {
                        [NameInMap("JqNodes")]
                        [Validation(Required=false)]
                        public List<CreateDatasetRequestDatasetConfigSearchSourceConfigsSearchSourceResponseConfigJqNodesJqNodes> JqNodes { get; set; }
                        public class CreateDatasetRequestDatasetConfigSearchSourceConfigsSearchSourceResponseConfigJqNodesJqNodes : TeaModel {
                            [NameInMap("JqNodes")]
                            [Validation(Required=false)]
                            public List<CreateDatasetRequestDatasetConfigSearchSourceConfigsSearchSourceResponseConfigJqNodesJqNodesJqNodes> JqNodes { get; set; }
                            public class CreateDatasetRequestDatasetConfigSearchSourceConfigsSearchSourceResponseConfigJqNodesJqNodesJqNodes : TeaModel {
                                /// <summary>
                                /// <b>Example:</b>
                                /// <para>title</para>
                                /// </summary>
                                [NameInMap("Key")]
                                [Validation(Required=false)]
                                public string Key { get; set; }

                                [NameInMap("Path")]
                                [Validation(Required=false)]
                                public string Path { get; set; }

                                /// <summary>
                                /// <b>Example:</b>
                                /// <para>string</para>
                                /// </summary>
                                [NameInMap("Type")]
                                [Validation(Required=false)]
                                public string Type { get; set; }

                            }

                            /// <summary>
                            /// <b>Example:</b>
                            /// <para>title</para>
                            /// </summary>
                            [NameInMap("Key")]
                            [Validation(Required=false)]
                            public string Key { get; set; }

                            [NameInMap("Path")]
                            [Validation(Required=false)]
                            public string Path { get; set; }

                            /// <summary>
                            /// <b>Example:</b>
                            /// <para>string</para>
                            /// </summary>
                            [NameInMap("Type")]
                            [Validation(Required=false)]
                            public string Type { get; set; }

                        }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>节点key</para>
                        /// </summary>
                        [NameInMap("Key")]
                        [Validation(Required=false)]
                        public string Key { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>节点路径</para>
                        /// </summary>
                        [NameInMap("Path")]
                        [Validation(Required=false)]
                        public string Path { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>节点数据类型：string number list object base</para>
                        /// </summary>
                        [NameInMap("Type")]
                        [Validation(Required=false)]
                        public string Type { get; set; }

                    }

                }

                /// <summary>
                /// <b>Example:</b>
                /// <para>10</para>
                /// </summary>
                [NameInMap("Size")]
                [Validation(Required=false)]
                public int? Size { get; set; }

            }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>企业自定义数据集</para>
        /// </summary>
        [NameInMap("DatasetDescription")]
        [Validation(Required=false)]
        public string DatasetDescription { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>businessDataset</para>
        /// </summary>
        [NameInMap("DatasetName")]
        [Validation(Required=false)]
        public string DatasetName { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>CustomSemanticSearch</para>
        /// </summary>
        [NameInMap("DatasetType")]
        [Validation(Required=false)]
        public string DatasetType { get; set; }

        [NameInMap("DocumentHandleConfig")]
        [Validation(Required=false)]
        public CreateDatasetRequestDocumentHandleConfig DocumentHandleConfig { get; set; }
        public class CreateDatasetRequestDocumentHandleConfig : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("DisableHandleMultimodalMedia")]
            [Validation(Required=false)]
            public bool? DisableHandleMultimodalMedia { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>3</para>
        /// </summary>
        [NameInMap("SearchDatasetEnable")]
        [Validation(Required=false)]
        public int? SearchDatasetEnable { get; set; }

        /// <summary>
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
