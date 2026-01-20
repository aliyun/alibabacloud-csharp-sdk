// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PaiFeatureStore20230621.Models
{
    public class CreateFeatureViewRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>{&quot;save_original_field&quot;:true}</para>
        /// </summary>
        [NameInMap("Config")]
        [Validation(Required=false)]
        public string Config { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>4</para>
        /// </summary>
        [NameInMap("FeatureEntityId")]
        [Validation(Required=false)]
        public string FeatureEntityId { get; set; }

        [NameInMap("Fields")]
        [Validation(Required=false)]
        public List<CreateFeatureViewRequestFields> Fields { get; set; }
        public class CreateFeatureViewRequestFields : TeaModel {
            [NameInMap("Attributes")]
            [Validation(Required=false)]
            public List<string> Attributes { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>age</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("Transform")]
            [Validation(Required=false)]
            public List<CreateFeatureViewRequestFieldsTransform> Transform { get; set; }
            public class CreateFeatureViewRequestFieldsTransform : TeaModel {
                [NameInMap("Input")]
                [Validation(Required=false)]
                public List<CreateFeatureViewRequestFieldsTransformInput> Input { get; set; }
                public class CreateFeatureViewRequestFieldsTransformInput : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>f1</para>
                    /// </summary>
                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>STRING</para>
                    /// </summary>
                    [NameInMap("Type")]
                    [Validation(Required=false)]
                    public string Type { get; set; }

                }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("LLMConfigId")]
                [Validation(Required=false)]
                public int? LLMConfigId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>LLMEmbedding</para>
                /// </summary>
                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>INT32</para>
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>FeatureView1</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3</para>
        /// </summary>
        [NameInMap("ProjectId")]
        [Validation(Required=false)]
        public string ProjectId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>5</para>
        /// </summary>
        [NameInMap("RegisterDatasourceId")]
        [Validation(Required=false)]
        public string RegisterDatasourceId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>table1</para>
        /// </summary>
        [NameInMap("RegisterTable")]
        [Validation(Required=false)]
        public string RegisterTable { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("SyncOnlineTable")]
        [Validation(Required=false)]
        public bool? SyncOnlineTable { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>90</para>
        /// </summary>
        [NameInMap("TTL")]
        [Validation(Required=false)]
        public int? TTL { get; set; }

        [NameInMap("Tags")]
        [Validation(Required=false)]
        public List<string> Tags { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Batch</para>
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Custom</para>
        /// </summary>
        [NameInMap("WriteMethod")]
        [Validation(Required=false)]
        public string WriteMethod { get; set; }

        [NameInMap("WriteToFeatureDB")]
        [Validation(Required=false)]
        public bool? WriteToFeatureDB { get; set; }

    }

}
