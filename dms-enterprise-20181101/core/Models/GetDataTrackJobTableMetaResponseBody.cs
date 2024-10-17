// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms_enterprise20181101.Models
{
    public class GetDataTrackJobTableMetaResponseBody : TeaModel {
        /// <summary>
        /// <para>The error code returned if the request failed.</para>
        /// 
        /// <b>Example:</b>
        /// <para>UnknownError</para>
        /// </summary>
        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// <para>The error message returned if the request failed.</para>
        /// 
        /// <b>Example:</b>
        /// <para>UnknownError</para>
        /// </summary>
        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0C1CB646-1DE4-4AD0-B4A4-7D47DD52E931</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request was successful. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: The request was successful.</description></item>
        /// <item><description><b>false</b>: The request failed.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// <para>The metadata of tables.</para>
        /// </summary>
        [NameInMap("TableMetaList")]
        [Validation(Required=false)]
        public List<GetDataTrackJobTableMetaResponseBodyTableMetaList> TableMetaList { get; set; }
        public class GetDataTrackJobTableMetaResponseBodyTableMetaList : TeaModel {
            /// <summary>
            /// <para>The information about columns.</para>
            /// </summary>
            [NameInMap("Columns")]
            [Validation(Required=false)]
            public List<GetDataTrackJobTableMetaResponseBodyTableMetaListColumns> Columns { get; set; }
            public class GetDataTrackJobTableMetaResponseBodyTableMetaListColumns : TeaModel {
                /// <summary>
                /// <para>The name of the character set.</para>
                /// 
                /// <b>Example:</b>
                /// <para>utf8mb4</para>
                /// </summary>
                [NameInMap("Charset")]
                [Validation(Required=false)]
                public string Charset { get; set; }

                /// <summary>
                /// <para>The name of the column.</para>
                /// 
                /// <b>Example:</b>
                /// <para>claimantno</para>
                /// </summary>
                [NameInMap("ColumnName")]
                [Validation(Required=false)]
                public string ColumnName { get; set; }

                /// <summary>
                /// <para>The position of the column.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("ColumnPosition")]
                [Validation(Required=false)]
                public int? ColumnPosition { get; set; }

                /// <summary>
                /// <para>The data type of the column. Examples: BIGINT, INT, and VARCHAR.</para>
                /// 
                /// <b>Example:</b>
                /// <para>BIGINT</para>
                /// </summary>
                [NameInMap("ColumnType")]
                [Validation(Required=false)]
                public string ColumnType { get; set; }

                /// <summary>
                /// <para>Indicates whether the column is a virtual column. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>true</b></description></item>
                /// <item><description><b>false</b></description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("Fictive")]
                [Validation(Required=false)]
                public bool? Fictive { get; set; }

            }

            /// <summary>
            /// <para>The name of the database.</para>
            /// 
            /// <b>Example:</b>
            /// <para>DB165</para>
            /// </summary>
            [NameInMap("SchemaName")]
            [Validation(Required=false)]
            public string SchemaName { get; set; }

            /// <summary>
            /// <para>The name of the table.</para>
            /// 
            /// <b>Example:</b>
            /// <para>live_stat</para>
            /// </summary>
            [NameInMap("TableName")]
            [Validation(Required=false)]
            public string TableName { get; set; }

        }

    }

}
