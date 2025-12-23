// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OpenSearch20171225.Models
{
    public class GetFunctionResourceResponseBody : TeaModel {
        /// <summary>
        /// <para>The error code returned. If no error occurs, this value is empty.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Resource.NotExist</para>
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
        /// <para>The time consumed for the API request. Unit: milliseconds.</para>
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
        /// <para>Resource not exist.</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>E215C843-0795-5293-AC9A-14FE0723E890</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The returned results.</para>
        /// </summary>
        [NameInMap("Result")]
        [Validation(Required=false)]
        public GetFunctionResourceResponseBodyResult Result { get; set; }
        public class GetFunctionResourceResponseBodyResult : TeaModel {
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
            public GetFunctionResourceResponseBodyResultData Data { get; set; }
            public class GetFunctionResourceResponseBodyResultData : TeaModel {
                /// <summary>
                /// <para>The content of the file that corresponds to a resource of the raw_file type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>abc</para>
                /// </summary>
                [NameInMap("Content")]
                [Validation(Required=false)]
                public string Content { get; set; }

                /// <summary>
                /// <para>The feature generators that correspond to resources of the feature_generator type.</para>
                /// </summary>
                [NameInMap("Generators")]
                [Validation(Required=false)]
                public List<GetFunctionResourceResponseBodyResultDataGenerators> Generators { get; set; }
                public class GetFunctionResourceResponseBodyResultDataGenerators : TeaModel {
                    /// <summary>
                    /// <para>The type of the feature generator.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>id</para>
                    /// </summary>
                    [NameInMap("Generator")]
                    [Validation(Required=false)]
                    public string Generator { get; set; }

                    /// <summary>
                    /// <para>The input.</para>
                    /// </summary>
                    [NameInMap("Input")]
                    [Validation(Required=false)]
                    public GetFunctionResourceResponseBodyResultDataGeneratorsInput Input { get; set; }
                    public class GetFunctionResourceResponseBodyResultDataGeneratorsInput : TeaModel {
                        /// <summary>
                        /// <para>The input features.</para>
                        /// </summary>
                        [NameInMap("Features")]
                        [Validation(Required=false)]
                        public List<GetFunctionResourceResponseBodyResultDataGeneratorsInputFeatures> Features { get; set; }
                        public class GetFunctionResourceResponseBodyResultDataGeneratorsInputFeatures : TeaModel {
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
                    /// <para>output_feature_name</para>
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
            /// <para>&quot;&quot;</para>
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
            /// <para>raw_file</para>
            /// </summary>
            [NameInMap("ResourceType")]
            [Validation(Required=false)]
            public string ResourceType { get; set; }

        }

        /// <summary>
        /// <para>The HTTP status code. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>OK</description></item>
        /// <item><description>FAIL</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

    }

}
