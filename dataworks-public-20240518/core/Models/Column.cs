// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20240518.Models
{
    public class Column : TeaModel {
        [NameInMap("BusinessMetadata")]
        [Validation(Required=false)]
        public ColumnBusinessMetadata BusinessMetadata { get; set; }
        public class ColumnBusinessMetadata : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>字段1的业务描述</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>字段1</para>
        /// </summary>
        [NameInMap("Comment")]
        [Validation(Required=false)]
        public string Comment { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("ForeignKey")]
        [Validation(Required=false)]
        public bool? ForeignKey { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>maxcompute-column:123456::test_project:default:test_tbl:col1</para>
        /// </summary>
        [NameInMap("Id")]
        [Validation(Required=false)]
        public string Id { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>col1</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("PartitionKey")]
        [Validation(Required=false)]
        public bool? PartitionKey { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Position")]
        [Validation(Required=false)]
        public int? Position { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("PrimaryKey")]
        [Validation(Required=false)]
        public bool? PrimaryKey { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>maxcompute-table:123456::test_project:default:test_tbl</para>
        /// </summary>
        [NameInMap("TableId")]
        [Validation(Required=false)]
        public string TableId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>bigint</para>
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
