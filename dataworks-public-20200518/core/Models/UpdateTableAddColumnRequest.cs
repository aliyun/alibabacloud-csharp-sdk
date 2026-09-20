// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class UpdateTableAddColumnRequest : TeaModel {
        /// <summary>
        /// <para>The list of columns.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("Column")]
        [Validation(Required=false)]
        public List<UpdateTableAddColumnRequestColumn> Column { get; set; }
        public class UpdateTableAddColumnRequestColumn : TeaModel {
            /// <summary>
            /// <para>The name of the column.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>abc</para>
            /// </summary>
            [NameInMap("ColumnName")]
            [Validation(Required=false)]
            public string ColumnName { get; set; }

            /// <summary>
            /// <para>The Chinese name of the column.</para>
            /// 
            /// <b>Example:</b>
            /// <para>中文</para>
            /// </summary>
            [NameInMap("ColumnNameCn")]
            [Validation(Required=false)]
            public string ColumnNameCn { get; set; }

            /// <summary>
            /// <para>The type of the column. For more information, see the column types supported by MaxCompute.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>string</para>
            /// </summary>
            [NameInMap("ColumnType")]
            [Validation(Required=false)]
            public string ColumnType { get; set; }

            /// <summary>
            /// <para>The comment of the column.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Remarks</para>
            /// </summary>
            [NameInMap("Comment")]
            [Validation(Required=false)]
            public string Comment { get; set; }

        }

        /// <summary>
        /// <para>The unique identifier of the MaxCompute table. Format: odps.projectName.tableName.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>odps.engine_name.table_name</para>
        /// </summary>
        [NameInMap("TableGuid")]
        [Validation(Required=false)]
        public string TableGuid { get; set; }

    }

}
