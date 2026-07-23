// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eventbridge20200401.Models
{
    public class Table : TeaModel {
        /// <summary>
        /// <para>The name of the data catalog to which the table belongs</para>
        /// 
        /// <b>Example:</b>
        /// <para>my_catalog</para>
        /// </summary>
        [NameInMap("Catalog")]
        [Validation(Required=false)]
        public string Catalog { get; set; }

        /// <summary>
        /// <para>The column definition list of the table. Each column contains Name (column name), Type (data type), and Comment (remarks)</para>
        /// 
        /// <b>Example:</b>
        /// <para>[{&quot;Name&quot;:&quot;id&quot;,&quot;Type&quot;:&quot;bigint&quot;,&quot;Comment&quot;:&quot;主键&quot;}]</para>
        /// </summary>
        [NameInMap("Columns")]
        [Validation(Required=false)]
        public List<TableColumns> Columns { get; set; }
        public class TableColumns : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>主键ID</para>
            /// </summary>
            [NameInMap("Comment")]
            [Validation(Required=false)]
            public string Comment { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>id</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>bigint</para>
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        /// <summary>
        /// <para>Comment description of the table</para>
        /// 
        /// <b>Example:</b>
        /// <para>测试事件表</para>
        /// </summary>
        [NameInMap("Comment")]
        [Validation(Required=false)]
        public string Comment { get; set; }

        /// <summary>
        /// <para>The creation time of the table (Unix timestamp, in milliseconds)</para>
        /// 
        /// <b>Example:</b>
        /// <para>1717948800000</para>
        /// </summary>
        [NameInMap("CreateTime")]
        [Validation(Required=false)]
        public long? CreateTime { get; set; }

        /// <summary>
        /// <para>The unique identifier name of the event table</para>
        /// 
        /// <b>Example:</b>
        /// <para>my_table</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The name of the namespace to which the table belongs</para>
        /// 
        /// <b>Example:</b>
        /// <para>my_namespace</para>
        /// </summary>
        [NameInMap("Namespace")]
        [Validation(Required=false)]
        public string Namespace { get; set; }

        /// <summary>
        /// <para>Data retention policy. Includes the retention days for hot data and cold data</para>
        /// </summary>
        [NameInMap("RetentionPolicy")]
        [Validation(Required=false)]
        public TableRetentionPolicy RetentionPolicy { get; set; }
        public class TableRetentionPolicy : TeaModel {
            /// <summary>
            /// <para>Retention days for cold data, used for low-cost archival storage</para>
            /// 
            /// <b>Example:</b>
            /// <para>30</para>
            /// </summary>
            [NameInMap("ColdTTL")]
            [Validation(Required=false)]
            public int? ColdTTL { get; set; }

            /// <summary>
            /// <para>Retention days for hot data, used for high-performance query storage</para>
            /// 
            /// <b>Example:</b>
            /// <para>7</para>
            /// </summary>
            [NameInMap("HotTTL")]
            [Validation(Required=false)]
            public int? HotTTL { get; set; }

        }

        /// <summary>
        /// <para>The last update time of the table (Unix timestamp, in milliseconds)</para>
        /// 
        /// <b>Example:</b>
        /// <para>1717948800000</para>
        /// </summary>
        [NameInMap("UpdateTime")]
        [Validation(Required=false)]
        public long? UpdateTime { get; set; }

    }

}
