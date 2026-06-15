// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PaiFeatureStore20230621.Models
{
    public class CreateFeatureViewRequest : TeaModel {
        /// <summary>
        /// <para>The configurations of the feature view.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;save_original_field&quot;:true}</para>
        /// </summary>
        [NameInMap("Config")]
        [Validation(Required=false)]
        public string Config { get; set; }

        /// <summary>
        /// <para>The ID of the feature entity.</para>
        /// 
        /// <b>Example:</b>
        /// <para>4</para>
        /// </summary>
        [NameInMap("FeatureEntityId")]
        [Validation(Required=false)]
        public string FeatureEntityId { get; set; }

        /// <summary>
        /// <para>The fields.</para>
        /// </summary>
        [NameInMap("Fields")]
        [Validation(Required=false)]
        public List<CreateFeatureViewRequestFields> Fields { get; set; }
        public class CreateFeatureViewRequestFields : TeaModel {
            /// <summary>
            /// <para>The attributes of the field. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><c>Partition</c>: partition field.</para>
            /// </description></item>
            /// <item><description><para><c>PrimaryKey</c>: primary key.</para>
            /// </description></item>
            /// <item><description><para><c>EventTime</c>: event time.</para>
            /// </description></item>
            /// </list>
            /// </summary>
            [NameInMap("Attributes")]
            [Validation(Required=false)]
            public List<string> Attributes { get; set; }

            /// <summary>
            /// <para>The name of the field.</para>
            /// 
            /// <b>Example:</b>
            /// <para>age</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The feature generation configurations.</para>
            /// </summary>
            [NameInMap("Transform")]
            [Validation(Required=false)]
            public List<CreateFeatureViewRequestFieldsTransform> Transform { get; set; }
            public class CreateFeatureViewRequestFieldsTransform : TeaModel {
                /// <summary>
                /// <para>The input for feature generation.</para>
                /// </summary>
                [NameInMap("Input")]
                [Validation(Required=false)]
                public List<CreateFeatureViewRequestFieldsTransformInput> Input { get; set; }
                public class CreateFeatureViewRequestFieldsTransformInput : TeaModel {
                    /// <summary>
                    /// <para>The modality of the input, such as text or image.</para>
                    /// </summary>
                    [NameInMap("Modality")]
                    [Validation(Required=false)]
                    public string Modality { get; set; }

                    /// <summary>
                    /// <para>The name of the input field.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>f1</para>
                    /// </summary>
                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    /// <summary>
                    /// <para>The data type of the input field.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>STRING</para>
                    /// </summary>
                    [NameInMap("Type")]
                    [Validation(Required=false)]
                    public string Type { get; set; }

                }

                /// <summary>
                /// <para>The ID of the large language model (LLM) configuration.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("LLMConfigId")]
                [Validation(Required=false)]
                public int? LLMConfigId { get; set; }

                /// <summary>
                /// <para>The type of the feature generation.</para>
                /// 
                /// <b>Example:</b>
                /// <para>LLMEmbedding</para>
                /// </summary>
                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

            /// <summary>
            /// <para>The data type of the field. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>INT32</para>
            /// </description></item>
            /// <item><description><para>INT64</para>
            /// </description></item>
            /// <item><description><para>FLOAT</para>
            /// </description></item>
            /// <item><description><para>DOUBLE</para>
            /// </description></item>
            /// <item><description><para>STRING</para>
            /// </description></item>
            /// <item><description><para>BOOLEAN</para>
            /// </description></item>
            /// <item><description><para>TIMESTAMP</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>INT32</para>
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        /// <summary>
        /// <para>The name of the feature view.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>FeatureView1</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The ID of the project.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3</para>
        /// </summary>
        [NameInMap("ProjectId")]
        [Validation(Required=false)]
        public string ProjectId { get; set; }

        /// <summary>
        /// <para>The ID of the data source to which the table to be registered belongs. You can call the ListDatasources operation to obtain the data source ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5</para>
        /// </summary>
        [NameInMap("RegisterDatasourceId")]
        [Validation(Required=false)]
        public string RegisterDatasourceId { get; set; }

        /// <summary>
        /// <para>The name of the table to register.</para>
        /// 
        /// <b>Example:</b>
        /// <para>table1</para>
        /// </summary>
        [NameInMap("RegisterTable")]
        [Validation(Required=false)]
        public string RegisterTable { get; set; }

        /// <summary>
        /// <para>Specifies whether to synchronize the online feature table. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><c>true</c>: Synchronizes the online feature table.</para>
        /// </description></item>
        /// <item><description><para><c>false</c>: Does not synchronize the online feature table.</para>
        /// </description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("SyncOnlineTable")]
        [Validation(Required=false)]
        public bool? SyncOnlineTable { get; set; }

        /// <summary>
        /// <para>The time-to-live (TTL) of the feature view, in days.</para>
        /// 
        /// <b>Example:</b>
        /// <para>90</para>
        /// </summary>
        [NameInMap("TTL")]
        [Validation(Required=false)]
        public int? TTL { get; set; }

        /// <summary>
        /// <para>The tags of the feature view.</para>
        /// </summary>
        [NameInMap("Tags")]
        [Validation(Required=false)]
        public List<string> Tags { get; set; }

        /// <summary>
        /// <para>The type of the feature view. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><c>Batch</c>: Offline feature.</para>
        /// </description></item>
        /// <item><description><para><c>Stream</c>: Real-time feature.</para>
        /// </description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Batch</para>
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

        /// <summary>
        /// <para>The write method. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><c>ByReadyMadeTable</c>: Registers the feature view by using an existing table.</para>
        /// </description></item>
        /// <item><description><para><c>Custom</c>: Defines a custom table structure.</para>
        /// </description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Custom</para>
        /// </summary>
        [NameInMap("WriteMethod")]
        [Validation(Required=false)]
        public string WriteMethod { get; set; }

        /// <summary>
        /// <para>Specifies whether to write data to the online feature store. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><c>true</c>: Writes data to the online feature store.</para>
        /// </description></item>
        /// <item><description><para><c>false</c>: Does not write data to the online feature store.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("WriteToFeatureDB")]
        [Validation(Required=false)]
        public bool? WriteToFeatureDB { get; set; }

    }

}
