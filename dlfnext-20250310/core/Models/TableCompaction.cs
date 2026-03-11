// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.DlfNext20250310.Models
{
    public class TableCompaction : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>clg-paimon-xxx</para>
        /// </summary>
        [NameInMap("catalogId")]
        [Validation(Required=false)]
        public string CatalogId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("cuUsage")]
        [Validation(Required=false)]
        public double? CuUsage { get; set; }

        /// <term><b>Obsolete</b></term>
        /// 
        /// <summary>
        /// 
        /// <b>Example:</b>
        /// <para>1759111660075</para>
        /// 
        /// <b>if can be null:</b>
        /// <c>true</c>
        /// </summary>
        [NameInMap("lastCompactedFileTime")]
        [Validation(Required=false)]
        [Obsolete]
        public long? LastCompactedFileTime { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1760321763633</para>
        /// </summary>
        [NameInMap("latencyFileEarliestTime")]
        [Validation(Required=false)]
        public long? LatencyFileEarliestTime { get; set; }

        /// <term><b>Obsolete</b></term>
        /// 
        /// <summary>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// 
        /// <b>if can be null:</b>
        /// <c>true</c>
        /// </summary>
        [NameInMap("maxLevel0FileCount")]
        [Validation(Required=false)]
        [Obsolete]
        public string MaxLevel0FileCount { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>tbl-xxx</para>
        /// </summary>
        [NameInMap("tableId")]
        [Validation(Required=false)]
        public string TableId { get; set; }

    }

}
