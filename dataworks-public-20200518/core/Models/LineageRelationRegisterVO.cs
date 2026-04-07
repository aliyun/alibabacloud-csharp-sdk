// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class LineageRelationRegisterVO : TeaModel {
        /// <summary>
        /// <para>The time of lineage relation generation</para>
        /// 
        /// <b>Example:</b>
        /// <para>1684327487964</para>
        /// </summary>
        [NameInMap("CreateTimestamp")]
        [Validation(Required=false)]
        public long? CreateTimestamp { get; set; }

        /// <summary>
        /// <para>The destination entity in lineage relation</para>
        /// </summary>
        [NameInMap("DestEntity")]
        [Validation(Required=false)]
        public LineageEntityVO DestEntity { get; set; }

        /// <summary>
        /// <para>The relationship between entities</para>
        /// </summary>
        [NameInMap("Relationship")]
        [Validation(Required=false)]
        public RelationshipVO Relationship { get; set; }

        /// <summary>
        /// <para>The source entity in lineage relation</para>
        /// </summary>
        [NameInMap("SrcEntity")]
        [Validation(Required=false)]
        public LineageEntityVO SrcEntity { get; set; }

    }

}
