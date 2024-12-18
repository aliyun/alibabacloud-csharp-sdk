// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AiMiaoBi20230801.Models
{
    public class UpdateDatasetRequest : TeaModel {
        [NameInMap("DatasetConfig")]
        [Validation(Required=false)]
        public UpdateDatasetRequestDatasetConfig DatasetConfig { get; set; }
        public class UpdateDatasetRequestDatasetConfig : TeaModel {
            [NameInMap("SearchSourceConfigs")]
            [Validation(Required=false)]
            public List<UpdateDatasetRequestDatasetConfigSearchSourceConfigs> SearchSourceConfigs { get; set; }
            public class UpdateDatasetRequestDatasetConfigSearchSourceConfigs : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>可以搜索到的关键词，用来验证是否可用</para>
                /// </summary>
                [NameInMap("DemoQuery")]
                [Validation(Required=false)]
                public string DemoQuery { get; set; }

                [NameInMap("SearchSourceRequestConfig")]
                [Validation(Required=false)]
                public UpdateDatasetRequestDatasetConfigSearchSourceConfigsSearchSourceRequestConfig SearchSourceRequestConfig { get; set; }
                public class UpdateDatasetRequestDatasetConfigSearchSourceConfigsSearchSourceRequestConfig : TeaModel {
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
                    public List<UpdateDatasetRequestDatasetConfigSearchSourceConfigsSearchSourceRequestConfigHeaders> Headers { get; set; }
                    public class UpdateDatasetRequestDatasetConfigSearchSourceConfigsSearchSourceRequestConfigHeaders : TeaModel {
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
                    public List<UpdateDatasetRequestDatasetConfigSearchSourceConfigsSearchSourceRequestConfigParams> Params { get; set; }
                    public class UpdateDatasetRequestDatasetConfigSearchSourceConfigsSearchSourceRequestConfigParams : TeaModel {
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
                public UpdateDatasetRequestDatasetConfigSearchSourceConfigsSearchSourceResponseConfig SearchSourceResponseConfig { get; set; }
                public class UpdateDatasetRequestDatasetConfigSearchSourceConfigsSearchSourceResponseConfig : TeaModel {
                    [NameInMap("JqNodes")]
                    [Validation(Required=false)]
                    public List<UpdateDatasetRequestDatasetConfigSearchSourceConfigsSearchSourceResponseConfigJqNodes> JqNodes { get; set; }
                    public class UpdateDatasetRequestDatasetConfigSearchSourceConfigsSearchSourceResponseConfigJqNodes : TeaModel {
                        [NameInMap("JqNodes")]
                        [Validation(Required=false)]
                        public List<UpdateDatasetRequestDatasetConfigSearchSourceConfigsSearchSourceResponseConfigJqNodesJqNodes> JqNodes { get; set; }
                        public class UpdateDatasetRequestDatasetConfigSearchSourceConfigsSearchSourceResponseConfigJqNodesJqNodes : TeaModel {
                            [NameInMap("JqNodes")]
                            [Validation(Required=false)]
                            public List<UpdateDatasetRequestDatasetConfigSearchSourceConfigsSearchSourceResponseConfigJqNodesJqNodesJqNodes> JqNodes { get; set; }
                            public class UpdateDatasetRequestDatasetConfigSearchSourceConfigsSearchSourceResponseConfigJqNodesJqNodesJqNodes : TeaModel {
                                /// <summary>
                                /// <b>Example:</b>
                                /// <para>title</para>
                                /// </summary>
                                [NameInMap("Key")]
                                [Validation(Required=false)]
                                public string Key { get; set; }

                                /// <summary>
                                /// <b>Example:</b>
                                /// <para>.title</para>
                                /// </summary>
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

                            /// <summary>
                            /// <b>Example:</b>
                            /// <para>.title</para>
                            /// </summary>
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
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("DatasetId")]
        [Validation(Required=false)]
        public long? DatasetId { get; set; }

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
        /// <para>xxxx</para>
        /// </summary>
        [NameInMap("WorkspaceId")]
        [Validation(Required=false)]
        public string WorkspaceId { get; set; }

    }

}
