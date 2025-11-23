// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms_enterprise20181101.Models
{
    public class ListTableColumnsResponseBody : TeaModel {
        /// <summary>
        /// <para>The details about fields in the table.</para>
        /// </summary>
        [NameInMap("ColumnList")]
        [Validation(Required=false)]
        public ListTableColumnsResponseBodyColumnList ColumnList { get; set; }
        public class ListTableColumnsResponseBodyColumnList : TeaModel {
            [NameInMap("Column")]
            [Validation(Required=false)]
            public List<ListTableColumnsResponseBodyColumnListColumn> Column { get; set; }
            public class ListTableColumnsResponseBodyColumnListColumn : TeaModel {
                /// <summary>
                /// <para>Indicates whether the field is an auto-increment field. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>true: The field is an auto-increment field.</description></item>
                /// <item><description>false: The field is not an auto-increment field.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("AutoIncrement")]
                [Validation(Required=false)]
                public bool? AutoIncrement { get; set; }

                /// <summary>
                /// <para>The ID of the field.</para>
                /// 
                /// <b>Example:</b>
                /// <para>12345</para>
                /// </summary>
                [NameInMap("ColumnId")]
                [Validation(Required=false)]
                public string ColumnId { get; set; }

                /// <summary>
                /// <para>The field name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>c1</para>
                /// </summary>
                [NameInMap("ColumnName")]
                [Validation(Required=false)]
                public string ColumnName { get; set; }

                /// <summary>
                /// <para>The data type of the field.</para>
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
                /// <para>32</para>
                /// </summary>
                [NameInMap("DataLength")]
                [Validation(Required=false)]
                public long? DataLength { get; set; }

                /// <summary>
                /// <para>The number of valid digits for the column.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("DataPrecision")]
                [Validation(Required=false)]
                public int? DataPrecision { get; set; }

                /// <summary>
                /// <para>The number of decimal places of the field data.</para>
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
                /// <para>aaa</para>
                /// </summary>
                [NameInMap("DefaultValue")]
                [Validation(Required=false)]
                public string DefaultValue { get; set; }

                /// <summary>
                /// <para>The description of the field.</para>
                /// 
                /// <b>Example:</b>
                /// <para>column desc</para>
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
                /// <para>NULL</para>
                /// </summary>
                [NameInMap("FunctionType")]
                [Validation(Required=false)]
                public string FunctionType { get; set; }

                /// <summary>
                /// <para>Indicates whether the field can be empty. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>true: The field can be empty.</description></item>
                /// <item><description>false: The field cannot be empty.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("Nullable")]
                [Validation(Required=false)]
                public bool? Nullable { get; set; }

                /// <summary>
                /// <para>The security level of the field. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>INNER: The field is an internal field but not sensitive.</description></item>
                /// <item><description>SENSITIVE: The field is sensitive.</description></item>
                /// <item><description>CONFIDENTIAL: The field is a confidential column.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>INNER</para>
                /// </summary>
                [NameInMap("SecurityLevel")]
                [Validation(Required=false)]
                public string SecurityLevel { get; set; }

                /// <summary>
                /// <para>Indicates whether the field is a sensitive column. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>true: The field is a sensitive field.</description></item>
                /// <item><description>false: The field is not a sensitive field.</description></item>
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
        /// <para>The error code returned if the request failed.</para>
        /// 
        /// <b>Example:</b>
        /// <para>UnknownError</para>
        /// </summary>
        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// <para>The error message that is returned if the request failed.</para>
        /// 
        /// <b>Example:</b>
        /// <para>UnknownError</para>
        /// </summary>
        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
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

    }

}
