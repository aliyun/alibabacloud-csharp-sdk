// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataphin_public20230630.Models
{
    public class GetKgNeighborRequest : TeaModel {
        /// <summary>
        /// <para>The data ID of the entity record.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123</para>
        /// </summary>
        [NameInMap("EntityDataId")]
        [Validation(Required=false)]
        public string EntityDataId { get; set; }

        /// <summary>
        /// <para>The entity type.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Student</para>
        /// </summary>
        [NameInMap("EntityType")]
        [Validation(Required=false)]
        public string EntityType { get; set; }

        /// <summary>
        /// <para>The neighbor node query instruction for entity records.</para>
        /// </summary>
        [NameInMap("NeighborsQuery")]
        [Validation(Required=false)]
        public GetKgNeighborRequestNeighborsQuery NeighborsQuery { get; set; }
        public class GetKgNeighborRequestNeighborsQuery : TeaModel {
            /// <summary>
            /// <para>The maximum depth of neighbor nodes. Default value: 1.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("Depth")]
            [Validation(Required=false)]
            public int? Depth { get; set; }

            /// <summary>
            /// <para>The direction type. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>in: Uses the current entity as the target node.</description></item>
            /// <item><description>out: Uses the current entity as the source node.</description></item>
            /// <item><description>both: Uses the current entity as both the source and target nodes.
            /// Default value: both.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>both</para>
            /// </summary>
            [NameInMap("DirectionType")]
            [Validation(Required=false)]
            public string DirectionType { get; set; }

            /// <summary>
            /// <para>The list of relation types.</para>
            /// </summary>
            [NameInMap("RelationTypes")]
            [Validation(Required=false)]
            public List<string> RelationTypes { get; set; }

        }

        /// <summary>
        /// <para>The tenant ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>30001011</para>
        /// </summary>
        [NameInMap("OpTenantId")]
        [Validation(Required=false)]
        public long? OpTenantId { get; set; }

        /// <summary>
        /// <para>The ID of the operator.</para>
        /// 
        /// <b>Example:</b>
        /// <para>30001011</para>
        /// </summary>
        [NameInMap("OpUserId")]
        [Validation(Required=false)]
        public string OpUserId { get; set; }

        /// <summary>
        /// <para>The model ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>f1d4559a4db044158305e2d89bccf81f</para>
        /// </summary>
        [NameInMap("WorkspaceId")]
        [Validation(Required=false)]
        public string WorkspaceId { get; set; }

    }

}
