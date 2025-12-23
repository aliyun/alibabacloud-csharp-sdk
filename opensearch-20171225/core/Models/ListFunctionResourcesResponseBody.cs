// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OpenSearch20171225.Models
{
    public class ListFunctionResourcesResponseBody : TeaModel {
        /// <summary>
        /// <para>The error code returned. If no error occurs, this value is empty.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Resource.InvalidResourceName</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The HTTP status code returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("HttpCode")]
        [Validation(Required=false)]
        public long? HttpCode { get; set; }

        /// <summary>
        /// <para>The amount of time consumed for the request. Unit: milliseconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123</para>
        /// </summary>
        [NameInMap("Latency")]
        [Validation(Required=false)]
        public double? Latency { get; set; }

        /// <summary>
        /// <para>The error message returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Invalid resource name.</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>&quot;3A809095-C554-5CF5-8FCE-BE19D4673790&quot;</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The results returned.</para>
        /// </summary>
        [NameInMap("Result")]
        [Validation(Required=false)]
        public List<ListFunctionResourcesResponseBodyResult> Result { get; set; }
        public class ListFunctionResourcesResponseBodyResult : TeaModel {
            /// <summary>
            /// <para>The time when the resource was created. Unit: milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1234</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public long? CreateTime { get; set; }

            /// <summary>
            /// <para>The resource data. The data structure varies with the resource type.</para>
            /// </summary>
            [NameInMap("Data")]
            [Validation(Required=false)]
            public ListFunctionResourcesResponseBodyResultData Data { get; set; }
            public class ListFunctionResourcesResponseBodyResultData : TeaModel {
                /// <summary>
                /// <para>The content of the file that corresponds to a resource of the raw_file type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>&quot;abc&quot;</para>
                /// </summary>
                [NameInMap("Content")]
                [Validation(Required=false)]
                public string Content { get; set; }

                /// <summary>
                /// <para>The feature generators that correspond to resources of the feature_generator type.</para>
                /// </summary>
                [NameInMap("Generators")]
                [Validation(Required=false)]
                public List<ListFunctionResourcesResponseBodyResultDataGenerators> Generators { get; set; }
                public class ListFunctionResourcesResponseBodyResultDataGenerators : TeaModel {
                    /// <summary>
                    /// <para>The type of the feature generator.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>combo</para>
                    /// </summary>
                    [NameInMap("Generator")]
                    [Validation(Required=false)]
                    public string Generator { get; set; }

                    /// <summary>
                    /// <para>The input.</para>
                    /// </summary>
                    [NameInMap("Input")]
                    [Validation(Required=false)]
                    public ListFunctionResourcesResponseBodyResultDataGeneratorsInput Input { get; set; }
                    public class ListFunctionResourcesResponseBodyResultDataGeneratorsInput : TeaModel {
                        /// <summary>
                        /// <para>The input features.</para>
                        /// </summary>
                        [NameInMap("Features")]
                        [Validation(Required=false)]
                        public List<ListFunctionResourcesResponseBodyResultDataGeneratorsInputFeatures> Features { get; set; }
                        public class ListFunctionResourcesResponseBodyResultDataGeneratorsInputFeatures : TeaModel {
                            /// <summary>
                            /// <para>The name of the feature.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>system_item_id</para>
                            /// </summary>
                            [NameInMap("Name")]
                            [Validation(Required=false)]
                            public string Name { get; set; }

                            /// <summary>
                            /// <para>The type of the feature.</para>
                            /// <para>Valid values:</para>
                            /// <list type="bullet">
                            /// <item><description><para>item</para>
                            /// <!-- -->
                            /// 
                            /// <!-- -->
                            /// 
                            /// <!-- -->
                            /// </description></item>
                            /// <item><description><para>user</para>
                            /// <!-- -->
                            /// 
                            /// <!-- -->
                            /// 
                            /// <!-- --></description></item>
                            /// </list>
                            /// 
                            /// <b>Example:</b>
                            /// <para>item</para>
                            /// </summary>
                            [NameInMap("Type")]
                            [Validation(Required=false)]
                            public string Type { get; set; }

                        }

                    }

                    /// <summary>
                    /// <para>The name of the output feature.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>feature1</para>
                    /// </summary>
                    [NameInMap("Output")]
                    [Validation(Required=false)]
                    public string Output { get; set; }

                }

            }

            /// <summary>
            /// <para>The description of the resource.</para>
            /// 
            /// <b>Example:</b>
            /// <para>resource description</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The name of the feature.</para>
            /// 
            /// <b>Example:</b>
            /// <para>rank</para>
            /// </summary>
            [NameInMap("FunctionName")]
            [Validation(Required=false)]
            public string FunctionName { get; set; }

            /// <summary>
            /// <para>The time when the resource was modified. Unit: milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1234</para>
            /// </summary>
            [NameInMap("ModifyTime")]
            [Validation(Required=false)]
            public long? ModifyTime { get; set; }

            /// <summary>
            /// <para>The algorithm instances that are referenced.</para>
            /// </summary>
            [NameInMap("ReferencedInstances")]
            [Validation(Required=false)]
            public List<string> ReferencedInstances { get; set; }

            /// <summary>
            /// <para>The name of the resource.</para>
            /// 
            /// <b>Example:</b>
            /// <para>fg_json</para>
            /// </summary>
            [NameInMap("ResourceName")]
            [Validation(Required=false)]
            public string ResourceName { get; set; }

            /// <summary>
            /// <para>The type of the resource.</para>
            /// 
            /// <b>Example:</b>
            /// <para>feature_generator</para>
            /// </summary>
            [NameInMap("ResourceType")]
            [Validation(Required=false)]
            public string ResourceType { get; set; }

        }

        /// <summary>
        /// <para>The status of the request. Valid values: OK and FAIL.</para>
        /// 
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <para>The total number of records that meet the requirements.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
