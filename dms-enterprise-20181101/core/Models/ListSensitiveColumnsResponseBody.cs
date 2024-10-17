// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms_enterprise20181101.Models
{
    public class ListSensitiveColumnsResponseBody : TeaModel {
        /// <summary>
        /// <para>The error code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>UnknownError</para>
        /// </summary>
        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// <para>The error message.</para>
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
        /// <para>09D82FD7-F87F-59EF-AA82-AEF71B09E306</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The sensitive fields.</para>
        /// </summary>
        [NameInMap("SensitiveColumnList")]
        [Validation(Required=false)]
        public ListSensitiveColumnsResponseBodySensitiveColumnList SensitiveColumnList { get; set; }
        public class ListSensitiveColumnsResponseBodySensitiveColumnList : TeaModel {
            [NameInMap("SensitiveColumn")]
            [Validation(Required=false)]
            public List<ListSensitiveColumnsResponseBodySensitiveColumnListSensitiveColumn> SensitiveColumn { get; set; }
            public class ListSensitiveColumnsResponseBodySensitiveColumnListSensitiveColumn : TeaModel {
                /// <summary>
                /// <para>The number of sensitive fields.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("ColumnCount")]
                [Validation(Required=false)]
                public long? ColumnCount { get; set; }

                /// <summary>
                /// <para>The name of the field.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test_column</para>
                /// </summary>
                [NameInMap("ColumnName")]
                [Validation(Required=false)]
                public string ColumnName { get; set; }

                /// <summary>
                /// <para>The type of the de-identification algorithm. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>DEFAULT: All characters are masked. This is the default value.</description></item>
                /// <item><description>FIX_POS: The characters at specific positions are masked.</description></item>
                /// <item><description>FIX_CHAR: Specific characters are masked.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>DEFAULT</para>
                /// </summary>
                [NameInMap("FunctionType")]
                [Validation(Required=false)]
                public string FunctionType { get; set; }

                /// <summary>
                /// <para>The name of the database.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test_schema</para>
                /// </summary>
                [NameInMap("SchemaName")]
                [Validation(Required=false)]
                public string SchemaName { get; set; }

                /// <summary>
                /// <para>The sensitivity level of the field. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>SENSITIVE</description></item>
                /// <item><description>CONFIDENTIAL</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>SENSITIVE</para>
                /// </summary>
                [NameInMap("SecurityLevel")]
                [Validation(Required=false)]
                public string SecurityLevel { get; set; }

                /// <summary>
                /// <para>The name of the table.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test_table</para>
                /// </summary>
                [NameInMap("TableName")]
                [Validation(Required=false)]
                public string TableName { get; set; }

            }

        }

        /// <summary>
        /// <para>Indicates whether the request is successful. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: The request is successful.</description></item>
        /// <item><description>false: The request fails.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// <para>The total number of returned entries.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
