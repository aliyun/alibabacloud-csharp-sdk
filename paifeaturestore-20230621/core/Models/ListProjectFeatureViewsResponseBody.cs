// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PaiFeatureStore20230621.Models
{
    public class ListProjectFeatureViewsResponseBody : TeaModel {
        [NameInMap("FeatureViews")]
        [Validation(Required=false)]
        public List<ListProjectFeatureViewsResponseBodyFeatureViews> FeatureViews { get; set; }
        public class ListProjectFeatureViewsResponseBodyFeatureViews : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>3</para>
            /// </summary>
            [NameInMap("FeatureViewId")]
            [Validation(Required=false)]
            public string FeatureViewId { get; set; }

            [NameInMap("Features")]
            [Validation(Required=false)]
            public List<ListProjectFeatureViewsResponseBodyFeatureViewsFeatures> Features { get; set; }
            public class ListProjectFeatureViewsResponseBodyFeatureViewsFeatures : TeaModel {
                [NameInMap("Attributes")]
                [Validation(Required=false)]
                public List<string> Attributes { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>f1</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>INT32</para>
                /// </summary>
                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>item_id</para>
            /// </summary>
            [NameInMap("JoinId")]
            [Validation(Required=false)]
            public string JoinId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>feature_view1</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>item_id</para>
            /// </summary>
            [NameInMap("ParentJoinId")]
            [Validation(Required=false)]
            public string ParentJoinId { get; set; }

            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>AE2AF33E-0C0D-51A8-B89B-C5F1DF261D92</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
