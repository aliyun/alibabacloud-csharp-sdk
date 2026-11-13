// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class LineageRelationRegisterBulkVO : TeaModel {
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
        /// <para>All destination entities</para>
        /// </summary>
        [NameInMap("DestEntities")]
        [Validation(Required=false)]
        public List<LineageEntityVO> DestEntities { get; set; }

        /// <summary>
        /// <para>relationship between entities</para>
        /// </summary>
        [NameInMap("Relationship")]
        [Validation(Required=false)]
        public RelationshipVO Relationship { get; set; }

        /// <summary>
        /// <para>All source entities</para>
        /// </summary>
        [NameInMap("SrcEntities")]
        [Validation(Required=false)]
        public List<LineageEntityVO> SrcEntities { get; set; }

    }

}
