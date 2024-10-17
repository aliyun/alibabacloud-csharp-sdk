// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms_enterprise20181101.Models
{
    public class GetMetaTableColumnResponseBody : TeaModel {
        /// <summary>
        /// <para>The details about fields in the table.</para>
        /// </summary>
        [NameInMap("ColumnList")]
        [Validation(Required=false)]
        public List<GetMetaTableColumnResponseBodyColumnList> ColumnList { get; set; }
        public class GetMetaTableColumnResponseBodyColumnList : TeaModel {
            /// <summary>
            /// <para>Indicates whether the column is an auto-increment column. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>true</b>: The column is an auto-increment column.</description></item>
            /// <item><description><b>false</b>: The column is not an auto-increment column.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("AutoIncrement")]
            [Validation(Required=false)]
            public bool? AutoIncrement { get; set; }

            /// <summary>
            /// <para>The ID of the column.</para>
            /// 
            /// <b>Example:</b>
            /// <para>63513****</para>
            /// </summary>
            [NameInMap("ColumnId")]
            [Validation(Required=false)]
            public string ColumnId { get; set; }

            /// <summary>
            /// <para>The name of the column.</para>
            /// 
            /// <b>Example:</b>
            /// <para>has_promotion</para>
            /// </summary>
            [NameInMap("ColumnName")]
            [Validation(Required=false)]
            public string ColumnName { get; set; }

            /// <summary>
            /// <para>The data type of the column.</para>
            /// <remarks>
            /// <para>The return value of a column is not unique, such as <b>bigint</b> or <b>int</b>.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>bigint(1)</para>
            /// </summary>
            [NameInMap("ColumnType")]
            [Validation(Required=false)]
            public string ColumnType { get; set; }

            /// <summary>
            /// <para>The length of the field.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("DataLength")]
            [Validation(Required=false)]
            public long? DataLength { get; set; }

            /// <summary>
            /// <para>The precision of the field.</para>
            /// 
            /// <b>Example:</b>
            /// <para>19</para>
            /// </summary>
            [NameInMap("DataPrecision")]
            [Validation(Required=false)]
            public int? DataPrecision { get; set; }

            /// <summary>
            /// <para>The number of decimal places for the field.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("DataScale")]
            [Validation(Required=false)]
            public int? DataScale { get; set; }

            /// <summary>
            /// <para>The description of the column.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Whether discounts are provided</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>Indicates whether the field can be empty. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>true</b>: The field can be empty.</description></item>
            /// <item><description><b>false</b>: The field cannot be empty.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("Nullable")]
            [Validation(Required=false)]
            public bool? Nullable { get; set; }

            /// <summary>
            /// <para>The position of the field in the table.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Position")]
            [Validation(Required=false)]
            public int? Position { get; set; }

            /// <summary>
            /// <para>Indicates whether the field is the primary key. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>true</b>: The field is the primary key.</description></item>
            /// <item><description><b>false</b>: The field is not the primary key.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("PrimaryKey")]
            [Validation(Required=false)]
            public string PrimaryKey { get; set; }

            /// <summary>
            /// <para>The sensitivity level of the column. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>INNER</b>: The column is not sensitive.</description></item>
            /// <item><description><b>SENSITIVE</b>: The column is sensitive.</description></item>
            /// <item><description><b>CONFIDENTIAL</b>: The column is confidential.</description></item>
            /// </list>
            /// <remarks>
            /// <para>For more information, see <a href="https://help.aliyun.com/document_detail/66091.html">Sensitivity levels of columns</a>.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>INNER</para>
            /// </summary>
            [NameInMap("SecurityLevel")]
            [Validation(Required=false)]
            public string SecurityLevel { get; set; }

        }

        /// <summary>
        /// <para>The error code returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>MissingTableGuid</para>
        /// </summary>
        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// <para>The error message returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>TableGuid is mandatory for this action.</para>
        /// </summary>
        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>087DFBA1-378B-5D25-B13B-31F6409F****</para>
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

    }

}
