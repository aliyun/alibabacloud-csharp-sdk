// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PaiFeatureStore20230621.Models
{
    public class ListProjectFeatureViewsResponseBody : TeaModel {
        /// <summary>
        /// <para>The list of feature views.</para>
        /// </summary>
        [NameInMap("FeatureViews")]
        [Validation(Required=false)]
        public List<ListProjectFeatureViewsResponseBodyFeatureViews> FeatureViews { get; set; }
        public class ListProjectFeatureViewsResponseBodyFeatureViews : TeaModel {
            /// <summary>
            /// <para>The feature view ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>3</para>
            /// </summary>
            [NameInMap("FeatureViewId")]
            [Validation(Required=false)]
            public string FeatureViewId { get; set; }

            /// <summary>
            /// <para>A list of features.</para>
            /// </summary>
            [NameInMap("Features")]
            [Validation(Required=false)]
            public List<ListProjectFeatureViewsResponseBodyFeatureViewsFeatures> Features { get; set; }
            public class ListProjectFeatureViewsResponseBodyFeatureViewsFeatures : TeaModel {
                /// <summary>
                /// <para>A list of field attributes. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para>Partition: Indicates that the feature is a partition field.</para>
                /// </description></item>
                /// <item><description><para>PrimaryKey: Indicates that the feature is a primary key.</para>
                /// </description></item>
                /// <item><description><para>EventTime: Indicates that the feature represents the event time.</para>
                /// </description></item>
                /// </list>
                /// </summary>
                [NameInMap("Attributes")]
                [Validation(Required=false)]
                public List<string> Attributes { get; set; }

                /// <summary>
                /// <para>The feature name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>f1</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>The feature type. Valid values include:</para>
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
            /// <para>The join ID of the feature entity.</para>
            /// 
            /// <b>Example:</b>
            /// <para>item_id</para>
            /// </summary>
            [NameInMap("JoinId")]
            [Validation(Required=false)]
            public string JoinId { get; set; }

            /// <summary>
            /// <para>The feature view name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>feature_view1</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The join ID of the parent feature entity.</para>
            /// 
            /// <b>Example:</b>
            /// <para>item_id</para>
            /// </summary>
            [NameInMap("ParentJoinId")]
            [Validation(Required=false)]
            public string ParentJoinId { get; set; }

            /// <summary>
            /// <para>The type of the feature view.</para>
            /// <list type="bullet">
            /// <item><description><para>Batch: A feature view that processes data in batches.</para>
            /// </description></item>
            /// <item><description><para>Stream: A feature view that processes data as a stream.</para>
            /// </description></item>
            /// <item><description><para>Sequence: A feature view that represents a sequence of features.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Batch</para>
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>AE2AF33E-0C0D-51A8-B89B-C5F1DF261D92</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total count of feature views.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
