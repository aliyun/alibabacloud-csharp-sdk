// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PaiFeatureStore20230621.Models
{
    public class ListFeatureViewFieldRelationshipsResponseBody : TeaModel {
        [NameInMap("Relationships")]
        [Validation(Required=false)]
        public List<ListFeatureViewFieldRelationshipsResponseBodyRelationships> Relationships { get; set; }
        public class ListFeatureViewFieldRelationshipsResponseBodyRelationships : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>featureView1</para>
            /// </summary>
            [NameInMap("FeatureName")]
            [Validation(Required=false)]
            public string FeatureName { get; set; }

            [NameInMap("Models")]
            [Validation(Required=false)]
            public List<ListFeatureViewFieldRelationshipsResponseBodyRelationshipsModels> Models { get; set; }
            public class ListFeatureViewFieldRelationshipsResponseBodyRelationshipsModels : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>3</para>
                /// </summary>
                [NameInMap("ModelId")]
                [Validation(Required=false)]
                public string ModelId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>dbmtl</para>
                /// </summary>
                [NameInMap("ModelName")]
                [Validation(Required=false)]
                public string ModelName { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>table2</para>
            /// </summary>
            [NameInMap("OfflineTableName")]
            [Validation(Required=false)]
            public string OfflineTableName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>table1</para>
            /// </summary>
            [NameInMap("OnlineTableName")]
            [Validation(Required=false)]
            public string OnlineTableName { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>BF349686-C932-55B5-9B31-DAFA395C0E06</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
