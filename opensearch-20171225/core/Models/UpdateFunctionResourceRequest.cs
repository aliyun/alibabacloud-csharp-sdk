// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OpenSearch20171225.Models
{
    public class UpdateFunctionResourceRequest : TeaModel {
        /// <summary>
        /// <para>The resource data. The data structure varies with the resource type.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public UpdateFunctionResourceRequestData Data { get; set; }
        public class UpdateFunctionResourceRequestData : TeaModel {
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
            public List<UpdateFunctionResourceRequestDataGenerators> Generators { get; set; }
            public class UpdateFunctionResourceRequestDataGenerators : TeaModel {
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
                public UpdateFunctionResourceRequestDataGeneratorsInput Input { get; set; }
                public class UpdateFunctionResourceRequestDataGeneratorsInput : TeaModel {
                    /// <summary>
                    /// <para>The input features.</para>
                    /// </summary>
                    [NameInMap("Features")]
                    [Validation(Required=false)]
                    public List<UpdateFunctionResourceRequestDataGeneratorsInputFeatures> Features { get; set; }
                    public class UpdateFunctionResourceRequestDataGeneratorsInputFeatures : TeaModel {
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
        /// <para>updated description</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

    }

}
