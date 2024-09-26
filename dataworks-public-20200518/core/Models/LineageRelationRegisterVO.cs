// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class LineageRelationRegisterVO : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>1684327487964</para>
        /// </summary>
        [NameInMap("CreateTimestamp")]
        [Validation(Required=false)]
        public long? CreateTimestamp { get; set; }

        [NameInMap("DestEntity")]
        [Validation(Required=false)]
        public LineageEntityVO DestEntity { get; set; }

        [NameInMap("Relationship")]
        [Validation(Required=false)]
        public RelationshipVO Relationship { get; set; }

        [NameInMap("SrcEntity")]
        [Validation(Required=false)]
        public LineageEntityVO SrcEntity { get; set; }

    }

}
