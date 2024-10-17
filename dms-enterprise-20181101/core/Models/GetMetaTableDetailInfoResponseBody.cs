// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms_enterprise20181101.Models
{
    public class GetMetaTableDetailInfoResponseBody : TeaModel {
        /// <summary>
        /// <para>The details of the table.</para>
        /// </summary>
        [NameInMap("DetailInfo")]
        [Validation(Required=false)]
        public GetMetaTableDetailInfoResponseBodyDetailInfo DetailInfo { get; set; }
        public class GetMetaTableDetailInfoResponseBodyDetailInfo : TeaModel {
            /// <summary>
            /// <para>The columns in the table.</para>
            /// </summary>
            [NameInMap("ColumnList")]
            [Validation(Required=false)]
            public List<GetMetaTableDetailInfoResponseBodyDetailInfoColumnList> ColumnList { get; set; }
            public class GetMetaTableDetailInfoResponseBodyDetailInfoColumnList : TeaModel {
                /// <summary>
                /// <para>Indicates whether the column is an auto-increment column. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>true: The column is an auto-increment column.</description></item>
                /// <item><description>false: The column is not an auto-increment column.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("AutoIncrement")]
                [Validation(Required=false)]
                public bool? AutoIncrement { get; set; }

                /// <summary>
                /// <para>The ID of the column.</para>
                /// 
                /// <b>Example:</b>
                /// <para>191234849</para>
                /// </summary>
                [NameInMap("ColumnId")]
                [Validation(Required=false)]
                public string ColumnId { get; set; }

                /// <summary>
                /// <para>The name of the column.</para>
                /// 
                /// <b>Example:</b>
                /// <para>id</para>
                /// </summary>
                [NameInMap("ColumnName")]
                [Validation(Required=false)]
                public string ColumnName { get; set; }

                /// <summary>
                /// <para>The data type of the column. Examples: Bigint, Int, and Varchar.</para>
                /// 
                /// <b>Example:</b>
                /// <para>bigint(20) unsigned</para>
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
                /// <para>0</para>
                /// </summary>
                [NameInMap("DataPrecision")]
                [Validation(Required=false)]
                public int? DataPrecision { get; set; }

                /// <summary>
                /// <para>The scale of the column.</para>
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
                /// <para>test</para>
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// <para>Indicates whether the column is nullable. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>true: The column is nullable.</description></item>
                /// <item><description>false: The column is not nullable.</description></item>
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
                public string Position { get; set; }

            }

            /// <summary>
            /// <para>The list of indexes.</para>
            /// </summary>
            [NameInMap("IndexList")]
            [Validation(Required=false)]
            public List<GetMetaTableDetailInfoResponseBodyDetailInfoIndexList> IndexList { get; set; }
            public class GetMetaTableDetailInfoResponseBodyDetailInfoIndexList : TeaModel {
                /// <summary>
                /// <para>The index column.</para>
                /// </summary>
                [NameInMap("IndexColumns")]
                [Validation(Required=false)]
                public List<string> IndexColumns { get; set; }

                /// <summary>
                /// <para>The ID of the index.</para>
                /// 
                /// <b>Example:</b>
                /// <para>123</para>
                /// </summary>
                [NameInMap("IndexId")]
                [Validation(Required=false)]
                public string IndexId { get; set; }

                /// <summary>
                /// <para>The name of the index.</para>
                /// 
                /// <b>Example:</b>
                /// <para>PRIMARY</para>
                /// </summary>
                [NameInMap("IndexName")]
                [Validation(Required=false)]
                public string IndexName { get; set; }

                /// <summary>
                /// <para>The type of the index. Examples: Primary, Unique, and Normal.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Primary</para>
                /// </summary>
                [NameInMap("IndexType")]
                [Validation(Required=false)]
                public string IndexType { get; set; }

                /// <summary>
                /// <para>Indicates whether the index is unique. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>true: The index is unique.</description></item>
                /// <item><description>false: The index is not unique.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("Unique")]
                [Validation(Required=false)]
                public bool? Unique { get; set; }

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
        /// <para>E881CB2F-DE42-42E5-90EB-8B3173DCB9B9</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request was successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
