// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20240518.Models
{
    public class LineageRelationship : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>1743040581000</para>
        /// </summary>
        [NameInMap("CreateTime")]
        [Validation(Required=false)]
        public long? CreateTime { get; set; }

        [NameInMap("DstEntity")]
        [Validation(Required=false)]
        public LineageEntity DstEntity { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>maxcompute-table.p.table:custom-table.xxx:custom-sql.123</para>
        /// </summary>
        [NameInMap("Id")]
        [Validation(Required=false)]
        public string Id { get; set; }

        [NameInMap("SrcEntity")]
        [Validation(Required=false)]
        public LineageEntity SrcEntity { get; set; }

        [NameInMap("Task")]
        [Validation(Required=false)]
        public LineageTask Task { get; set; }

    }

}
