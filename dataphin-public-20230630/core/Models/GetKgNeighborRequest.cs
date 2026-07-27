// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataphin_public20230630.Models
{
    public class GetKgNeighborRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123</para>
        /// </summary>
        [NameInMap("EntityDataId")]
        [Validation(Required=false)]
        public string EntityDataId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Student</para>
        /// </summary>
        [NameInMap("EntityType")]
        [Validation(Required=false)]
        public string EntityType { get; set; }

        [NameInMap("NeighborsQuery")]
        [Validation(Required=false)]
        public GetKgNeighborRequestNeighborsQuery NeighborsQuery { get; set; }
        public class GetKgNeighborRequestNeighborsQuery : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("Depth")]
            [Validation(Required=false)]
            public int? Depth { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>both</para>
            /// </summary>
            [NameInMap("DirectionType")]
            [Validation(Required=false)]
            public string DirectionType { get; set; }

            [NameInMap("RelationTypes")]
            [Validation(Required=false)]
            public List<string> RelationTypes { get; set; }

        }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>30001011</para>
        /// </summary>
        [NameInMap("OpTenantId")]
        [Validation(Required=false)]
        public long? OpTenantId { get; set; }

        /// <summary>
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
