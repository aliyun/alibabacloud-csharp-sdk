// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PaiFeatureStore20230621.Models
{
    public class ListFeatureViewFieldRelationshipsResponseBody : TeaModel {
        /// <summary>
        /// <para>A list of relationships.</para>
        /// </summary>
        [NameInMap("Relationships")]
        [Validation(Required=false)]
        public List<ListFeatureViewFieldRelationshipsResponseBodyRelationships> Relationships { get; set; }
        public class ListFeatureViewFieldRelationshipsResponseBodyRelationships : TeaModel {
            /// <summary>
            /// <para>The feature view name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>featureView1</para>
            /// </summary>
            [NameInMap("FeatureName")]
            [Validation(Required=false)]
            public string FeatureName { get; set; }

            /// <summary>
            /// <para>A list of models.</para>
            /// </summary>
            [NameInMap("Models")]
            [Validation(Required=false)]
            public List<ListFeatureViewFieldRelationshipsResponseBodyRelationshipsModels> Models { get; set; }
            public class ListFeatureViewFieldRelationshipsResponseBodyRelationshipsModels : TeaModel {
                /// <summary>
                /// <para>The feature alias.</para>
                /// 
                /// <b>Example:</b>
                /// <para>f1</para>
                /// </summary>
                [NameInMap("FeatureAliasName")]
                [Validation(Required=false)]
                public string FeatureAliasName { get; set; }

                /// <summary>
                /// <para>The ID of the model.</para>
                /// 
                /// <b>Example:</b>
                /// <para>3</para>
                /// </summary>
                [NameInMap("ModelId")]
                [Validation(Required=false)]
                public string ModelId { get; set; }

                /// <summary>
                /// <para>The name of the model.</para>
                /// 
                /// <b>Example:</b>
                /// <para>dbmtl</para>
                /// </summary>
                [NameInMap("ModelName")]
                [Validation(Required=false)]
                public string ModelName { get; set; }

            }

            /// <summary>
            /// <para>The name of the offline table.</para>
            /// 
            /// <b>Example:</b>
            /// <para>table2</para>
            /// </summary>
            [NameInMap("OfflineTableName")]
            [Validation(Required=false)]
            public string OfflineTableName { get; set; }

            /// <summary>
            /// <para>The name of the online table.</para>
            /// 
            /// <b>Example:</b>
            /// <para>table1</para>
            /// </summary>
            [NameInMap("OnlineTableName")]
            [Validation(Required=false)]
            public string OnlineTableName { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>BF349686-C932-55B5-9B31-DAFA395C0E06</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
