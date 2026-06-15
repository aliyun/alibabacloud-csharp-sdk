// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PaiFeatureStore20230621.Models
{
    public class UpdateModelFeatureRequest : TeaModel {
        /// <summary>
        /// <para>The list of features.</para>
        /// </summary>
        [NameInMap("Features")]
        [Validation(Required=false)]
        public List<UpdateModelFeatureRequestFeatures> Features { get; set; }
        public class UpdateModelFeatureRequestFeatures : TeaModel {
            /// <summary>
            /// <para>The feature alias.</para>
            /// 
            /// <b>Example:</b>
            /// <para>sex</para>
            /// </summary>
            [NameInMap("AliasName")]
            [Validation(Required=false)]
            public string AliasName { get; set; }

            /// <summary>
            /// <para>The feature view ID. You can call the ListFeatureViews operation to query the feature view ID.</para>
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
            /// <para>gender</para>
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
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("LabelPriorityLevel")]
        [Validation(Required=false)]
        public long? LabelPriorityLevel { get; set; }

        /// <summary>
        /// <para>The label table ID. You can call the ListLabelTables operation to query the label table ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>4</para>
        /// </summary>
        [NameInMap("LabelTableId")]
        [Validation(Required=false)]
        public string LabelTableId { get; set; }

        [NameInMap("SequenceFeatureViewIds")]
        [Validation(Required=false)]
        public List<string> SequenceFeatureViewIds { get; set; }

    }

}
