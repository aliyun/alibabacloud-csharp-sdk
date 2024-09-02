// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OpenSearch20171225.Models
{
    public class GetFunctionResourceResponseBody : TeaModel {
        /// <summary>
        /// The error code returned. If no error occurs, this value is empty.
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// The HTTP status code returned.
        /// </summary>
        [NameInMap("HttpCode")]
        [Validation(Required=false)]
        public long? HttpCode { get; set; }

        /// <summary>
        /// The time consumed for the API request. Unit: milliseconds.
        /// </summary>
        [NameInMap("Latency")]
        [Validation(Required=false)]
        public double? Latency { get; set; }

        /// <summary>
        /// The error message returned.
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The returned results.
        /// </summary>
        [NameInMap("Result")]
        [Validation(Required=false)]
        public GetFunctionResourceResponseBodyResult Result { get; set; }
        public class GetFunctionResourceResponseBodyResult : TeaModel {
            /// <summary>
            /// The time when the resource was created. Unit: milliseconds.
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public long? CreateTime { get; set; }

            /// <summary>
            /// The resource data. The data structure varies with the resource type.
            /// </summary>
            [NameInMap("Data")]
            [Validation(Required=false)]
            public GetFunctionResourceResponseBodyResultData Data { get; set; }
            public class GetFunctionResourceResponseBodyResultData : TeaModel {
                /// <summary>
                /// The content of the file that corresponds to a resource of the raw_file type.
                /// </summary>
                [NameInMap("Content")]
                [Validation(Required=false)]
                public string Content { get; set; }

                /// <summary>
                /// The feature generators that correspond to resources of the feature_generator type.
                /// </summary>
                [NameInMap("Generators")]
                [Validation(Required=false)]
                public List<GetFunctionResourceResponseBodyResultDataGenerators> Generators { get; set; }
                public class GetFunctionResourceResponseBodyResultDataGenerators : TeaModel {
                    /// <summary>
                    /// The type of the feature generator.
                    /// </summary>
                    [NameInMap("Generator")]
                    [Validation(Required=false)]
                    public string Generator { get; set; }

                    /// <summary>
                    /// The input.
                    /// </summary>
                    [NameInMap("Input")]
                    [Validation(Required=false)]
                    public GetFunctionResourceResponseBodyResultDataGeneratorsInput Input { get; set; }
                    public class GetFunctionResourceResponseBodyResultDataGeneratorsInput : TeaModel {
                        /// <summary>
                        /// The input features.
                        /// </summary>
                        [NameInMap("Features")]
                        [Validation(Required=false)]
                        public List<GetFunctionResourceResponseBodyResultDataGeneratorsInputFeatures> Features { get; set; }
                        public class GetFunctionResourceResponseBodyResultDataGeneratorsInputFeatures : TeaModel {
                            /// <summary>
                            /// The name of the feature.
                            /// </summary>
                            [NameInMap("Name")]
                            [Validation(Required=false)]
                            public string Name { get; set; }

                            /// <summary>
                            /// The type of the feature.
                            /// </summary>
                            [NameInMap("Type")]
                            [Validation(Required=false)]
                            public string Type { get; set; }

                        }

                    }

                    /// <summary>
                    /// The name of the output feature.
                    /// </summary>
                    [NameInMap("Output")]
                    [Validation(Required=false)]
                    public string Output { get; set; }

                }

            }

            /// <summary>
            /// The description of the resource.
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// The name of the feature.
            /// </summary>
            [NameInMap("FunctionName")]
            [Validation(Required=false)]
            public string FunctionName { get; set; }

            /// <summary>
            /// The time when the resource was modified. Unit: milliseconds.
            /// </summary>
            [NameInMap("ModifyTime")]
            [Validation(Required=false)]
            public long? ModifyTime { get; set; }

            /// <summary>
            /// The algorithm instances that are referenced.
            /// </summary>
            [NameInMap("ReferencedInstances")]
            [Validation(Required=false)]
            public List<string> ReferencedInstances { get; set; }

            /// <summary>
            /// The name of the resource.
            /// </summary>
            [NameInMap("ResourceName")]
            [Validation(Required=false)]
            public string ResourceName { get; set; }

            /// <summary>
            /// The type of the resource.
            /// </summary>
            [NameInMap("ResourceType")]
            [Validation(Required=false)]
            public string ResourceType { get; set; }

        }

        /// <summary>
        /// The HTTP status code. Valid values:
        /// 
        /// *   OK
        /// *   FAIL
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

    }

}
