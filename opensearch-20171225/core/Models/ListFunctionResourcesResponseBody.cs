// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OpenSearch20171225.Models
{
    public class ListFunctionResourcesResponseBody : TeaModel {
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
        /// The amount of time consumed for the request. Unit: milliseconds.
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
        /// The results returned.
        /// </summary>
        [NameInMap("Result")]
        [Validation(Required=false)]
        public List<ListFunctionResourcesResponseBodyResult> Result { get; set; }
        public class ListFunctionResourcesResponseBodyResult : TeaModel {
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
            public ListFunctionResourcesResponseBodyResultData Data { get; set; }
            public class ListFunctionResourcesResponseBodyResultData : TeaModel {
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
                public List<ListFunctionResourcesResponseBodyResultDataGenerators> Generators { get; set; }
                public class ListFunctionResourcesResponseBodyResultDataGenerators : TeaModel {
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
                    public ListFunctionResourcesResponseBodyResultDataGeneratorsInput Input { get; set; }
                    public class ListFunctionResourcesResponseBodyResultDataGeneratorsInput : TeaModel {
                        /// <summary>
                        /// The input features.
                        /// </summary>
                        [NameInMap("Features")]
                        [Validation(Required=false)]
                        public List<ListFunctionResourcesResponseBodyResultDataGeneratorsInputFeatures> Features { get; set; }
                        public class ListFunctionResourcesResponseBodyResultDataGeneratorsInputFeatures : TeaModel {
                            /// <summary>
                            /// The name of the feature.
                            /// </summary>
                            [NameInMap("Name")]
                            [Validation(Required=false)]
                            public string Name { get; set; }

                            /// <summary>
                            /// The type of the feature.
                            /// 
                            /// Valid values:
                            /// 
                            /// *   item
                            /// 
                            ///     <!-- -->
                            /// 
                            ///     <!-- -->
                            /// 
                            ///     <!-- -->
                            /// 
                            /// *   user
                            /// 
                            ///     <!-- -->
                            /// 
                            ///     <!-- -->
                            /// 
                            ///     <!-- -->
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
        /// The status of the request. Valid values: OK and FAIL.
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// The total number of records that meet the requirements.
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
