// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PaiFeatureStore20230621.Models
{
    public class CreateModelFeatureRequest : TeaModel {
        /// <summary>
        /// <para>The list of features.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("Features")]
        [Validation(Required=false)]
        public List<CreateModelFeatureRequestFeatures> Features { get; set; }
        public class CreateModelFeatureRequestFeatures : TeaModel {
            /// <summary>
            /// <para>The alias of the feature.</para>
            /// 
            /// <b>Example:</b>
            /// <para>userid</para>
            /// </summary>
            [NameInMap("AliasName")]
            [Validation(Required=false)]
            public string AliasName { get; set; }

            /// <summary>
            /// <para>The feature view ID. You can call the ListFeatureViews operation to obtain the feature view ID.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>5</para>
            /// </summary>
            [NameInMap("FeatureViewId")]
            [Validation(Required=false)]
            public string FeatureViewId { get; set; }

            /// <summary>
            /// <para>The feature name.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>user_id</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>cand_seq__</para>
            /// </summary>
            [NameInMap("PrefixName")]
            [Validation(Required=false)]
            public string PrefixName { get; set; }

            /// <summary>
            /// <para>The feature type. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>INT32</description></item>
            /// <item><description>INT64</description></item>
            /// <item><description>FLOAT</description></item>
            /// <item><description>DOUBLE</description></item>
            /// <item><description>STRING</description></item>
            /// <item><description>BOOLEAN</description></item>
            /// <item><description>TIMESTAMP.</description></item>
            /// </list>
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
        /// <para>The priority level of the label table. Default value: 0, which indicates that conflicts between label table features and feature view features are not allowed. A value of 1 indicates that the label table takes precedence when conflicts occur. A value of 2 indicates that the feature view takes precedence.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("LabelPriorityLevel")]
        [Validation(Required=false)]
        public long? LabelPriorityLevel { get; set; }

        /// <summary>
        /// <para>The label table ID. You can call the ListLabelTables operation to obtain the label table ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>4</para>
        /// </summary>
        [NameInMap("LabelTableId")]
        [Validation(Required=false)]
        public string LabelTableId { get; set; }

        /// <summary>
        /// <para>The name of the model feature.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>model_feature_1</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The project ID. You can call the ListProjects operation to obtain the project ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3</para>
        /// </summary>
        [NameInMap("ProjectId")]
        [Validation(Required=false)]
        public string ProjectId { get; set; }

        /// <summary>
        /// <para>The sequence feature view IDs.</para>
        /// </summary>
        [NameInMap("SequenceFeatureViewIds")]
        [Validation(Required=false)]
        public List<string> SequenceFeatureViewIds { get; set; }

    }

}
