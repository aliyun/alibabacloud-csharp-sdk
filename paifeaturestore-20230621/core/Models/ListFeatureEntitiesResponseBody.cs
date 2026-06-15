// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PaiFeatureStore20230621.Models
{
    public class ListFeatureEntitiesResponseBody : TeaModel {
        /// <summary>
        /// <para>A list of feature entities.</para>
        /// </summary>
        [NameInMap("FeatureEntities")]
        [Validation(Required=false)]
        public List<ListFeatureEntitiesResponseBodyFeatureEntities> FeatureEntities { get; set; }
        public class ListFeatureEntitiesResponseBodyFeatureEntities : TeaModel {
            /// <summary>
            /// <para>The feature entity ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>3</para>
            /// </summary>
            [NameInMap("FeatureEntityId")]
            [Validation(Required=false)]
            public string FeatureEntityId { get; set; }

            /// <summary>
            /// <para>The creation time.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2021-12-15T23:24:33.132+08:00</para>
            /// </summary>
            [NameInMap("GmtCreateTime")]
            [Validation(Required=false)]
            public string GmtCreateTime { get; set; }

            /// <summary>
            /// <para>The join ID that links the feature entity to a feature view.</para>
            /// 
            /// <b>Example:</b>
            /// <para>user_id</para>
            /// </summary>
            [NameInMap("JoinId")]
            [Validation(Required=false)]
            public string JoinId { get; set; }

            /// <summary>
            /// <para>The feature entity name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>feature_entity_1</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The owner\&quot;s Alibaba Cloud account ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>123456789****</para>
            /// </summary>
            [NameInMap("Owner")]
            [Validation(Required=false)]
            public string Owner { get; set; }

            /// <summary>
            /// <para>The parent feature entity ID. This value is empty or 0 for a root feature entity.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("ParentFeatureEntityId")]
            [Validation(Required=false)]
            public string ParentFeatureEntityId { get; set; }

            /// <summary>
            /// <para>The parent feature entity name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>user</para>
            /// </summary>
            [NameInMap("ParentFeatureEntityName")]
            [Validation(Required=false)]
            public string ParentFeatureEntityName { get; set; }

            /// <summary>
            /// <para>The join ID of the parent feature entity.</para>
            /// 
            /// <b>Example:</b>
            /// <para>user_id</para>
            /// </summary>
            [NameInMap("ParentJoinId")]
            [Validation(Required=false)]
            public string ParentJoinId { get; set; }

            /// <summary>
            /// <para>The project ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>3</para>
            /// </summary>
            [NameInMap("ProjectId")]
            [Validation(Required=false)]
            public string ProjectId { get; set; }

            /// <summary>
            /// <para>The project name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>project_1</para>
            /// </summary>
            [NameInMap("ProjectName")]
            [Validation(Required=false)]
            public string ProjectName { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>37D19490-AB69-567D-A852-407C94E510E9</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of feature entities.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
