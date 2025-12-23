// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OpenSearch20171225.Models
{
    public class CreateFunctionResourceRequest : TeaModel {
        /// <summary>
        /// <para>The resource data. The data structure varies with the resource type.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public CreateFunctionResourceRequestData Data { get; set; }
        public class CreateFunctionResourceRequestData : TeaModel {
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
            public List<CreateFunctionResourceRequestDataGenerators> Generators { get; set; }
            public class CreateFunctionResourceRequestDataGenerators : TeaModel {
                /// <summary>
                /// <para>The type of the feature generator.</para>
                /// <para>Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para>lookup</para>
                /// <!-- -->
                /// 
                /// <!-- -->
                /// 
                /// <!-- -->
                /// </description></item>
                /// <item><description><para>sequence</para>
                /// <!-- -->
                /// 
                /// <!-- -->
                /// 
                /// <!-- -->
                /// </description></item>
                /// <item><description><para>overlap</para>
                /// <!-- -->
                /// 
                /// <!-- -->
                /// 
                /// <!-- -->
                /// </description></item>
                /// <item><description><para>raw</para>
                /// <!-- -->
                /// 
                /// <!-- -->
                /// 
                /// <!-- -->
                /// </description></item>
                /// <item><description><para>combo</para>
                /// <!-- -->
                /// 
                /// <!-- -->
                /// 
                /// <!-- -->
                /// </description></item>
                /// <item><description><para>id</para>
                /// <!-- -->
                /// 
                /// <!-- -->
                /// 
                /// <!-- --></description></item>
                /// </list>
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
                public CreateFunctionResourceRequestDataGeneratorsInput Input { get; set; }
                public class CreateFunctionResourceRequestDataGeneratorsInput : TeaModel {
                    /// <summary>
                    /// <para>The input features.</para>
                    /// </summary>
                    [NameInMap("Features")]
                    [Validation(Required=false)]
                    public List<CreateFunctionResourceRequestDataGeneratorsInputFeatures> Features { get; set; }
                    public class CreateFunctionResourceRequestDataGeneratorsInputFeatures : TeaModel {
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
                /// <para>item_id_feature</para>
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
        /// <para>The name of the resource.</para>
        /// 
        /// <b>Example:</b>
        /// <para>fg_jsoon</para>
        /// </summary>
        [NameInMap("ResourceName")]
        [Validation(Required=false)]
        public string ResourceName { get; set; }

        /// <summary>
        /// <para>The resource type.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>feature_generator</para>
        /// <!-- -->
        /// 
        /// <!-- -->
        /// 
        /// <!-- -->
        /// </description></item>
        /// <item><description><para>raw_file</para>
        /// <!-- -->
        /// 
        /// <!-- -->
        /// 
        /// <!-- --></description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>feature_generator</para>
        /// </summary>
        [NameInMap("ResourceType")]
        [Validation(Required=false)]
        public string ResourceType { get; set; }

    }

}
