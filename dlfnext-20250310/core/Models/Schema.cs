// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.DlfNext20250310.Models
{
    public class Schema : TeaModel {
        /// <summary>
        /// <para>The comment for the table.</para>
        /// 
        /// <b>Example:</b>
        /// <para>description</para>
        /// </summary>
        [NameInMap("comment")]
        [Validation(Required=false)]
        public string Comment { get; set; }

        /// <summary>
        /// <para>A list of table column definitions.</para>
        /// </summary>
        [NameInMap("fields")]
        [Validation(Required=false)]
        public List<DataField> Fields { get; set; }

        /// <summary>
        /// <para>A list of table configuration options.</para>
        /// </summary>
        [NameInMap("options")]
        [Validation(Required=false)]
        public Dictionary<string, string> Options { get; set; }

        /// <summary>
        /// <para>A list of partition column names.</para>
        /// </summary>
        [NameInMap("partitionKeys")]
        [Validation(Required=false)]
        public List<string> PartitionKeys { get; set; }

        /// <summary>
        /// <para>A list of primary key column names.</para>
        /// </summary>
        [NameInMap("primaryKeys")]
        [Validation(Required=false)]
        public List<string> PrimaryKeys { get; set; }

    }

}
