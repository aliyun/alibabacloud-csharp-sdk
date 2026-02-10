// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms20250414.Models
{
    public class DLTablebaseInfo : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>hive</para>
        /// </summary>
        [NameInMap("CatalogName")]
        [Validation(Required=false)]
        public string CatalogName { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1608707407</para>
        /// </summary>
        [NameInMap("CreateTime")]
        [Validation(Required=false)]
        public int? CreateTime { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>141****</para>
        /// </summary>
        [NameInMap("CreatorId")]
        [Validation(Required=false)]
        public long? CreatorId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>19</para>
        /// </summary>
        [NameInMap("DbId")]
        [Validation(Required=false)]
        public long? DbId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>default</para>
        /// </summary>
        [NameInMap("DbName")]
        [Validation(Required=false)]
        public string DbName { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>&quot;table&quot;</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1731586286</para>
        /// </summary>
        [NameInMap("LastAccessTime")]
        [Validation(Required=false)]
        public int? LastAccessTime { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>oss://xxx</para>
        /// </summary>
        [NameInMap("Location")]
        [Validation(Required=false)]
        public string Location { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1731585286</para>
        /// </summary>
        [NameInMap("ModifierId")]
        [Validation(Required=false)]
        public long? ModifierId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>100g_customer</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("Owner")]
        [Validation(Required=false)]
        public string Owner { get; set; }

        [NameInMap("OwnerType")]
        [Validation(Required=false)]
        public string OwnerType { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>&quot;EXTERNAL&quot;: &quot;TRUE&quot;</para>
        /// </summary>
        [NameInMap("Parameters")]
        [Validation(Required=false)]
        public Dictionary<string, object> Parameters { get; set; }

        [NameInMap("PartitionKeys")]
        [Validation(Required=false)]
        public List<DLColumn> PartitionKeys { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>30000</para>
        /// </summary>
        [NameInMap("Retention")]
        [Validation(Required=false)]
        public int? Retention { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>EXTERNAL_TABLE</para>
        /// </summary>
        [NameInMap("TableType")]
        [Validation(Required=false)]
        public string TableType { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>&quot;&quot;</para>
        /// </summary>
        [NameInMap("ViewExpandedText")]
        [Validation(Required=false)]
        public string ViewExpandedText { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>&quot;&quot;</para>
        /// </summary>
        [NameInMap("ViewOriginalText")]
        [Validation(Required=false)]
        public string ViewOriginalText { get; set; }

    }

}
