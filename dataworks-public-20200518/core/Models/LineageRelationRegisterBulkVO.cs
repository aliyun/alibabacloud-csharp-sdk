// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class LineageRelationRegisterBulkVO : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>1684327487964</para>
        /// </summary>
        [NameInMap("CreateTimestamp")]
        [Validation(Required=false)]
        public long? CreateTimestamp { get; set; }

        [NameInMap("DestEntities")]
        [Validation(Required=false)]
        public List<LineageEntityVO> DestEntities { get; set; }

        [NameInMap("Relationship")]
        [Validation(Required=false)]
        public RelationshipVO Relationship { get; set; }

        [NameInMap("SrcEntities")]
        [Validation(Required=false)]
        public List<LineageEntityVO> SrcEntities { get; set; }

    }

}
