// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms20250414.Models
{
    public class AgenticTableIndex : TeaModel {
        /// <summary>
        /// <para>An array of column names included in the index.</para>
        /// </summary>
        [NameInMap("ColumnNames")]
        [Validation(Required=false)]
        public List<string> ColumnNames { get; set; }

        /// <summary>
        /// <para>An optional, user-defined description for the index.</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The unique name of the index within the table.</para>
        /// </summary>
        [NameInMap("IndexName")]
        [Validation(Required=false)]
        public string IndexName { get; set; }

        /// <summary>
        /// <para>The type of the index, such as PRIMARY, UNIQUE, or NORMAL.</para>
        /// </summary>
        [NameInMap("IndexType")]
        [Validation(Required=false)]
        public string IndexType { get; set; }

        /// <summary>
        /// <para>Specifies if the index is the primary key. A table can have only one primary key.</para>
        /// </summary>
        [NameInMap("Primary")]
        [Validation(Required=false)]
        public bool? Primary { get; set; }

        /// <summary>
        /// <para>An array of physical column names from the database. Use this parameter when the names in ColumnNames are aliases or logical names.</para>
        /// </summary>
        [NameInMap("RealColumnNames")]
        [Validation(Required=false)]
        public List<string> RealColumnNames { get; set; }

        /// <summary>
        /// <para>Specifies if the index enforces a unique constraint, requiring all its values to be unique across rows.</para>
        /// </summary>
        [NameInMap("Unique")]
        [Validation(Required=false)]
        public bool? Unique { get; set; }

    }

}
