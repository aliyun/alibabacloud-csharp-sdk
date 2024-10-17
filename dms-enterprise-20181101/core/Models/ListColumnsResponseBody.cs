// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms_enterprise20181101.Models
{
    public class ListColumnsResponseBody : TeaModel {
        /// <summary>
        /// <para>The details about columns.</para>
        /// </summary>
        [NameInMap("ColumnList")]
        [Validation(Required=false)]
        public ListColumnsResponseBodyColumnList ColumnList { get; set; }
        public class ListColumnsResponseBodyColumnList : TeaModel {
            [NameInMap("Column")]
            [Validation(Required=false)]
            public List<ListColumnsResponseBodyColumnListColumn> Column { get; set; }
            public class ListColumnsResponseBodyColumnListColumn : TeaModel {
                /// <summary>
                /// <para>Indicates whether the column is an auto-increment column. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>true: The column is an auto-increment column.</description></item>
                /// <item><description>false: The column is not an auto-increment column.</description></item>
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
                /// <para>62589****</para>
                /// </summary>
                [NameInMap("ColumnId")]
                [Validation(Required=false)]
                public string ColumnId { get; set; }

                /// <summary>
                /// <para>The name of the column.</para>
                /// 
                /// <b>Example:</b>
                /// <para>name</para>
                /// </summary>
                [NameInMap("ColumnName")]
                [Validation(Required=false)]
                public string ColumnName { get; set; }

                /// <summary>
                /// <para>The data type of the column.</para>
                /// 
                /// <b>Example:</b>
                /// <para>varchar</para>
                /// </summary>
                [NameInMap("ColumnType")]
                [Validation(Required=false)]
                public string ColumnType { get; set; }

                /// <summary>
                /// <para>The length of the field.</para>
                /// 
                /// <b>Example:</b>
                /// <para>4</para>
                /// </summary>
                [NameInMap("DataLength")]
                [Validation(Required=false)]
                public long? DataLength { get; set; }

                /// <summary>
                /// <para>The number of valid digits for the field.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
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
                /// <para>The default value of the column.</para>
                /// 
                /// <b>Example:</b>
                /// <para>def_value</para>
                /// </summary>
                [NameInMap("DefaultValue")]
                [Validation(Required=false)]
                public string DefaultValue { get; set; }

                /// <summary>
                /// <para>The description of the column.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test</para>
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// <para>The type of the masking algorithm that is used for the field. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>null: No masking algorithm is used.</description></item>
                /// <item><description>DEFAULT: A full masking algorithm is used.</description></item>
                /// <item><description>FIX_POS: The fixed position is masked.</description></item>
                /// <item><description>FIX_CHAR: The fixed characters are replaced.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>DEFAULT</para>
                /// </summary>
                [NameInMap("FunctionType")]
                [Validation(Required=false)]
                public string FunctionType { get; set; }

                /// <summary>
                /// <para>Indicates whether the column can be empty. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>true</b>: The column can be empty.</description></item>
                /// <item><description><b>false</b>: The column cannot be empty.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("Nullable")]
                [Validation(Required=false)]
                public bool? Nullable { get; set; }

                /// <summary>
                /// <para>The security level of the column. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>INNER: The column is an internal column but not sensitive.</description></item>
                /// <item><description>SENSITIVE: The column is a sensitive column.</description></item>
                /// <item><description>CONFIDENTIAL: The column is a confidential column.</description></item>
                /// </list>
                /// <remarks>
                /// <para>For more information, see <a href="https://help.aliyun.com/document_detail/66091.html">Sensitivity levels of fields</a>.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>INNER</para>
                /// </summary>
                [NameInMap("SecurityLevel")]
                [Validation(Required=false)]
                public string SecurityLevel { get; set; }

                /// <summary>
                /// <para>Indicates whether the column is a sensitive column. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>true</b>: The column is a sensitive column.</description></item>
                /// <item><description><b>false</b>: The column is not a sensitive column.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("Sensitive")]
                [Validation(Required=false)]
                public bool? Sensitive { get; set; }

            }

        }

        /// <summary>
        /// <para>The error code returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>UnknownError</para>
        /// </summary>
        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// <para>The error message returned.</para>
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
        /// <para>0AD9AC55-5873-474A-9F33-4285806A3619</para>
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
