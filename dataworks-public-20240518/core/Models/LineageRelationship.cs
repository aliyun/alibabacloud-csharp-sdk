// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20240518.Models
{
    public class LineageRelationship : TeaModel {
        /// <summary>
        /// <para>The creation time.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1743040581000</para>
        /// </summary>
        [NameInMap("CreateTime")]
        [Validation(Required=false)]
        public long? CreateTime { get; set; }

        /// <summary>
        /// <para>The destination entity.</para>
        /// </summary>
        [NameInMap("DstEntity")]
        [Validation(Required=false)]
        public LineageEntity DstEntity { get; set; }

        /// <summary>
        /// <para>The ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>maxcompute-table.p.table:custom-table.xxx:custom-sql.123</para>
        /// </summary>
        [NameInMap("Id")]
        [Validation(Required=false)]
        public string Id { get; set; }

        /// <summary>
        /// <para>The source entity.</para>
        /// </summary>
        [NameInMap("SrcEntity")]
        [Validation(Required=false)]
        public LineageEntity SrcEntity { get; set; }

        /// <summary>
        /// <para>The task.</para>
        /// </summary>
        [NameInMap("Task")]
        [Validation(Required=false)]
        public LineageTask Task { get; set; }

    }

}
