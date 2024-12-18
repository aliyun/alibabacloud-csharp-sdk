// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Config20200907.Models
{
    public class ListAggregateResourceRelationsResponseBody : TeaModel {
        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>7A25F9DE-4C8B-5AD3-A241-FFF5A259E5A1</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The result of the relationship.</para>
        /// </summary>
        [NameInMap("ResourceRelations")]
        [Validation(Required=false)]
        public ListAggregateResourceRelationsResponseBodyResourceRelations ResourceRelations { get; set; }
        public class ListAggregateResourceRelationsResponseBodyResourceRelations : TeaModel {
            /// <summary>
            /// <para>The maximum number of entries returned on each page.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("MaxResults")]
            [Validation(Required=false)]
            public int? MaxResults { get; set; }

            /// <summary>
            /// <para>The token that was used to initiate the next request.</para>
            /// 
            /// <b>Example:</b>
            /// <para>AcBjqMYSy0is7zSMGu16****</para>
            /// </summary>
            [NameInMap("NextToken")]
            [Validation(Required=false)]
            public string NextToken { get; set; }

            /// <summary>
            /// <para>An array that contains the relationships.</para>
            /// </summary>
            [NameInMap("ResourceRelationList")]
            [Validation(Required=false)]
            public List<ListAggregateResourceRelationsResponseBodyResourceRelationsResourceRelationList> ResourceRelationList { get; set; }
            public class ListAggregateResourceRelationsResponseBodyResourceRelationsResourceRelationList : TeaModel {
                /// <summary>
                /// <para>The Alibaba Cloud account ID of the resource owner.</para>
                /// 
                /// <b>Example:</b>
                /// <para>100931896542****</para>
                /// </summary>
                [NameInMap("AccountId")]
                [Validation(Required=false)]
                public long? AccountId { get; set; }

                /// <summary>
                /// <para>The type of the relationship between the resource and the object.</para>
                /// <para>Valid values:</para>
                /// <list type="bullet">
                /// <item><description>IsContained: The object is included as part of the resource.</description></item>
                /// <item><description>IsAttachedTo: The object is added to the resource.</description></item>
                /// <item><description>IsAssociatedIn: The object is associated with the resource.</description></item>
                /// <item><description>Contains: The object contains the resource.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>IsAttachedTo</para>
                /// </summary>
                [NameInMap("RelationType")]
                [Validation(Required=false)]
                public string RelationType { get; set; }

                /// <summary>
                /// <para>The resource ID of the current resource.</para>
                /// 
                /// <b>Example:</b>
                /// <para>i-j6cajg9yrfoh4sas****</para>
                /// </summary>
                [NameInMap("SourceResourceId")]
                [Validation(Required=false)]
                public string SourceResourceId { get; set; }

                /// <summary>
                /// <para>The region ID of the current resource.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cn-shanghai</para>
                /// </summary>
                [NameInMap("SourceResourceRegionId")]
                [Validation(Required=false)]
                public string SourceResourceRegionId { get; set; }

                /// <summary>
                /// <para>The type of the resource.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ACS::ECS::Instance</para>
                /// </summary>
                [NameInMap("SourceResourceType")]
                [Validation(Required=false)]
                public string SourceResourceType { get; set; }

                /// <summary>
                /// <para>The resource ID of the resource that is associated with the object.</para>
                /// 
                /// <b>Example:</b>
                /// <para>d-j6c8k731qbrc7fxi****</para>
                /// </summary>
                [NameInMap("TargetResourceId")]
                [Validation(Required=false)]
                public string TargetResourceId { get; set; }

                /// <summary>
                /// <para>The type of the resource that is associated with the object.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ACS::ECS::Disk</para>
                /// </summary>
                [NameInMap("TargetResourceType")]
                [Validation(Required=false)]
                public string TargetResourceType { get; set; }

            }

        }

    }

}
