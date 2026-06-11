// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms20250414.Models
{
    public class AgenticTableColumn : TeaModel {
        /// <summary>
        /// <para>The name of the column.</para>
        /// </summary>
        [NameInMap("ColumnName")]
        [Validation(Required=false)]
        public string ColumnName { get; set; }

        /// <summary>
        /// <para>The data type of the column.</para>
        /// </summary>
        [NameInMap("ColumnType")]
        [Validation(Required=false)]
        public string ColumnType { get; set; }

        /// <summary>
        /// <para>The description of the column.</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>Engine-specific metadata for the column.</para>
        /// </summary>
        [NameInMap("EngineMeta")]
        [Validation(Required=false)]
        public AgenticTableColumnEngineMeta EngineMeta { get; set; }

        /// <summary>
        /// <para>The 1-based ordinal position of the column within the table.</para>
        /// </summary>
        [NameInMap("Position")]
        [Validation(Required=false)]
        public int? Position { get; set; }

    }

}
