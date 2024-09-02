// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OpenSearch20171225.Models
{
    public class CreateFunctionResourceRequest : TeaModel {
        /// <summary>
        /// The resource data. The data structure varies with the resource type.
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public CreateFunctionResourceRequestData Data { get; set; }
        public class CreateFunctionResourceRequestData : TeaModel {
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
            public List<CreateFunctionResourceRequestDataGenerators> Generators { get; set; }
            public class CreateFunctionResourceRequestDataGenerators : TeaModel {
                /// <summary>
                /// The type of the feature generator.
                /// 
                /// Valid values:
                /// 
                /// *   lookup
                /// 
                ///     <!-- -->
                /// 
                ///     <!-- -->
                /// 
                ///     <!-- -->
                /// 
                /// *   sequence
                /// 
                ///     <!-- -->
                /// 
                ///     <!-- -->
                /// 
                ///     <!-- -->
                /// 
                /// *   overlap
                /// 
                ///     <!-- -->
                /// 
                ///     <!-- -->
                /// 
                ///     <!-- -->
                /// 
                /// *   raw
                /// 
                ///     <!-- -->
                /// 
                ///     <!-- -->
                /// 
                ///     <!-- -->
                /// 
                /// *   combo
                /// 
                ///     <!-- -->
                /// 
                ///     <!-- -->
                /// 
                ///     <!-- -->
                /// 
                /// *   id
                /// 
                ///     <!-- -->
                /// 
                ///     <!-- -->
                /// 
                ///     <!-- -->
                /// </summary>
                [NameInMap("Generator")]
                [Validation(Required=false)]
                public string Generator { get; set; }

                /// <summary>
                /// The input.
                /// </summary>
                [NameInMap("Input")]
                [Validation(Required=false)]
                public CreateFunctionResourceRequestDataGeneratorsInput Input { get; set; }
                public class CreateFunctionResourceRequestDataGeneratorsInput : TeaModel {
                    /// <summary>
                    /// The input features.
                    /// </summary>
                    [NameInMap("Features")]
                    [Validation(Required=false)]
                    public List<CreateFunctionResourceRequestDataGeneratorsInputFeatures> Features { get; set; }
                    public class CreateFunctionResourceRequestDataGeneratorsInputFeatures : TeaModel {
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
        /// The name of the resource.
        /// </summary>
        [NameInMap("ResourceName")]
        [Validation(Required=false)]
        public string ResourceName { get; set; }

        /// <summary>
        /// The resource type.
        /// 
        /// Valid values:
        /// 
        /// *   feature_generator
        /// 
        ///     <!-- -->
        /// 
        ///     <!-- -->
        /// 
        ///     <!-- -->
        /// 
        /// *   raw_file
        /// 
        ///     <!-- -->
        /// 
        ///     <!-- -->
        /// 
        ///     <!-- -->
        /// </summary>
        [NameInMap("ResourceType")]
        [Validation(Required=false)]
        public string ResourceType { get; set; }

    }

}
