// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PaiFeatureStore20230621.Models
{
    public class UpdateFeatureViewRequest : TeaModel {
        /// <summary>
        /// <para>A list of fields.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("Fields")]
        [Validation(Required=false)]
        public List<UpdateFeatureViewRequestFields> Fields { get; set; }
        public class UpdateFeatureViewRequestFields : TeaModel {
            /// <summary>
            /// <para>A list of field attributes. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><c>Partition</c>: Indicates that the field is a partition field.</para>
            /// </description></item>
            /// <item><description><para><c>PrimaryKey</c>: Indicates that the field is a primary key.</para>
            /// </description></item>
            /// <item><description><para><c>EventTime</c>: Indicates that the field is the event time.</para>
            /// </description></item>
            /// </list>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("Attributes")]
            [Validation(Required=false)]
            public List<string> Attributes { get; set; }

            /// <summary>
            /// <para>The name of the field.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>user_id</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The feature generation configuration.</para>
            /// </summary>
            [NameInMap("Transform")]
            [Validation(Required=false)]
            public List<UpdateFeatureViewRequestFieldsTransform> Transform { get; set; }
            public class UpdateFeatureViewRequestFieldsTransform : TeaModel {
                /// <summary>
                /// <para>The input fields.</para>
                /// <para>This parameter is required.</para>
                /// </summary>
                [NameInMap("Input")]
                [Validation(Required=false)]
                public List<UpdateFeatureViewRequestFieldsTransformInput> Input { get; set; }
                public class UpdateFeatureViewRequestFieldsTransformInput : TeaModel {
                    /// <summary>
                    /// <para>The modality of the input, such as text or image.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>NONE</para>
                    /// </summary>
                    [NameInMap("Modality")]
                    [Validation(Required=false)]
                    public string Modality { get; set; }

                    /// <summary>
                    /// <para>The name of the input field.</para>
                    /// <para>This parameter is required.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>f1</para>
                    /// </summary>
                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    /// <summary>
                    /// <para>The data type of the input field.</para>
                    /// <para>This parameter is required.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>STRING</para>
                    /// </summary>
                    [NameInMap("Type")]
                    [Validation(Required=false)]
                    public string Type { get; set; }

                }

                /// <summary>
                /// <para>The ID of the LLM configuration.</para>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("LLMConfigId")]
                [Validation(Required=false)]
                public int? LLMConfigId { get; set; }

                /// <summary>
                /// <para>The type of feature generation.</para>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>LLMEmbedding</para>
                /// </summary>
                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

            /// <summary>
            /// <para>The data type of the field.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>INT32</para>
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

    }

}
