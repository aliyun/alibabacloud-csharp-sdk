// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AiMiaoBi20230801.Models
{
    public class GetDatasetResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>NoData</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetDatasetResponseBodyData Data { get; set; }
        public class GetDatasetResponseBodyData : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>2024-11-12 21:46:24</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>xxx</para>
            /// </summary>
            [NameInMap("CreateUser")]
            [Validation(Required=false)]
            public string CreateUser { get; set; }

            [NameInMap("DatasetConfig")]
            [Validation(Required=false)]
            public GetDatasetResponseBodyDataDatasetConfig DatasetConfig { get; set; }
            public class GetDatasetResponseBodyDataDatasetConfig : TeaModel {
                [NameInMap("SearchSourceConfig")]
                [Validation(Required=false)]
                public GetDatasetResponseBodyDataDatasetConfigSearchSourceConfig SearchSourceConfig { get; set; }
                public class GetDatasetResponseBodyDataDatasetConfigSearchSourceConfig : TeaModel {
                    [NameInMap("MetadataKeyValueGenerateEnable")]
                    [Validation(Required=false)]
                    public string MetadataKeyValueGenerateEnable { get; set; }

                    [NameInMap("MetadataKeyValueSearchEnable")]
                    [Validation(Required=false)]
                    public string MetadataKeyValueSearchEnable { get; set; }

                    [NameInMap("TagGenerateEnable")]
                    [Validation(Required=false)]
                    public string TagGenerateEnable { get; set; }

                    [NameInMap("TagSearchEnable")]
                    [Validation(Required=false)]
                    public string TagSearchEnable { get; set; }

                }

                [NameInMap("SearchSourceConfigs")]
                [Validation(Required=false)]
                public List<GetDatasetResponseBodyDataDatasetConfigSearchSourceConfigs> SearchSourceConfigs { get; set; }
                public class GetDatasetResponseBodyDataDatasetConfigSearchSourceConfigs : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>可以搜索到的关键词，用来验证是否可用</para>
                    /// </summary>
                    [NameInMap("DemoQuery")]
                    [Validation(Required=false)]
                    public string DemoQuery { get; set; }

                    [NameInMap("SearchSourceRequestConfig")]
                    [Validation(Required=false)]
                    public GetDatasetResponseBodyDataDatasetConfigSearchSourceConfigsSearchSourceRequestConfig SearchSourceRequestConfig { get; set; }
                    public class GetDatasetResponseBodyDataDatasetConfigSearchSourceConfigsSearchSourceRequestConfig : TeaModel {
                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>{}</para>
                        /// </summary>
                        [NameInMap("Body")]
                        [Validation(Required=false)]
                        public string Body { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>30</para>
                        /// </summary>
                        [NameInMap("ConnectTimeout")]
                        [Validation(Required=false)]
                        public int? ConnectTimeout { get; set; }

                        [NameInMap("Headers")]
                        [Validation(Required=false)]
                        public List<GetDatasetResponseBodyDataDatasetConfigSearchSourceConfigsSearchSourceRequestConfigHeaders> Headers { get; set; }
                        public class GetDatasetResponseBodyDataDatasetConfigSearchSourceConfigsSearchSourceRequestConfigHeaders : TeaModel {
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
                        public List<GetDatasetResponseBodyDataDatasetConfigSearchSourceConfigsSearchSourceRequestConfigParams> Params { get; set; }
                        public class GetDatasetResponseBodyDataDatasetConfigSearchSourceConfigsSearchSourceRequestConfigParams : TeaModel {
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
                        /// <para>78</para>
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
                    public GetDatasetResponseBodyDataDatasetConfigSearchSourceConfigsSearchSourceResponseConfig SearchSourceResponseConfig { get; set; }
                    public class GetDatasetResponseBodyDataDatasetConfigSearchSourceConfigsSearchSourceResponseConfig : TeaModel {
                        [NameInMap("JqNodes")]
                        [Validation(Required=false)]
                        public List<GetDatasetResponseBodyDataDatasetConfigSearchSourceConfigsSearchSourceResponseConfigJqNodes> JqNodes { get; set; }
                        public class GetDatasetResponseBodyDataDatasetConfigSearchSourceConfigsSearchSourceResponseConfigJqNodes : TeaModel {
                            [NameInMap("JqNodes")]
                            [Validation(Required=false)]
                            public List<GetDatasetResponseBodyDataDatasetConfigSearchSourceConfigsSearchSourceResponseConfigJqNodesJqNodes> JqNodes { get; set; }
                            public class GetDatasetResponseBodyDataDatasetConfigSearchSourceConfigsSearchSourceResponseConfigJqNodesJqNodes : TeaModel {
                                [NameInMap("JqNodes")]
                                [Validation(Required=false)]
                                public List<GetDatasetResponseBodyDataDatasetConfigSearchSourceConfigsSearchSourceResponseConfigJqNodesJqNodesJqNodes> JqNodes { get; set; }
                                public class GetDatasetResponseBodyDataDatasetConfigSearchSourceConfigsSearchSourceResponseConfigJqNodesJqNodesJqNodes : TeaModel {
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
            /// <para>xxx</para>
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
            /// <para>xxx</para>
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
            public GetDatasetResponseBodyDataDocumentHandleConfig DocumentHandleConfig { get; set; }
            public class GetDatasetResponseBodyDataDocumentHandleConfig : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("DisableHandleMultimodalMedia")]
                [Validation(Required=false)]
                public bool? DisableHandleMultimodalMedia { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("SearchDatasetEnable")]
            [Validation(Required=false)]
            public int? SearchDatasetEnable { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1813ceee-7fe5-41b4-87e5-982a4d18cca5</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
