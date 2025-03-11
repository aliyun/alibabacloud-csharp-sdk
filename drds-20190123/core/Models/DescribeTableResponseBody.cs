// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Drds20190123.Models
{
    public class DescribeTableResponseBody : TeaModel {
        /// <summary>
        /// <para>Indicates the returned data.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public DescribeTableResponseBodyData Data { get; set; }
        public class DescribeTableResponseBodyData : TeaModel {
            /// <summary>
            /// <para>Indicates the details about the table schema.</para>
            /// </summary>
            [NameInMap("List")]
            [Validation(Required=false)]
            public List<DescribeTableResponseBodyDataList> List { get; set; }
            public class DescribeTableResponseBodyDataList : TeaModel {
                /// <summary>
                /// <para>Indicates the name of a column.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Id</para>
                /// </summary>
                [NameInMap("ColumnName")]
                [Validation(Required=false)]
                public string ColumnName { get; set; }

                /// <summary>
                /// <para>Indicates the type of the column.</para>
                /// 
                /// <b>Example:</b>
                /// <para>bigint(20)</para>
                /// </summary>
                [NameInMap("ColumnType")]
                [Validation(Required=false)]
                public string ColumnType { get; set; }

                /// <summary>
                /// <para>Extra</para>
                /// 
                /// <b>Example:</b>
                /// <para>auto_increment</para>
                /// </summary>
                [NameInMap("Extra")]
                [Validation(Required=false)]
                public string Extra { get; set; }

                /// <summary>
                /// <para>Indicates the primary key of the table.</para>
                /// 
                /// <b>Example:</b>
                /// <para>PRI</para>
                /// </summary>
                [NameInMap("Index")]
                [Validation(Required=false)]
                public string Index { get; set; }

                /// <summary>
                /// <para>Indicates whether the column can be empty.</para>
                /// 
                /// <b>Example:</b>
                /// <para>NO</para>
                /// </summary>
                [NameInMap("IsAllowNull")]
                [Validation(Required=false)]
                public string IsAllowNull { get; set; }

                /// <summary>
                /// <para>Indicates whether the column is the primary key column of the table.</para>
                /// 
                /// <b>Example:</b>
                /// <para>YES</para>
                /// </summary>
                [NameInMap("IsPk")]
                [Validation(Required=false)]
                public string IsPk { get; set; }

            }

        }

        /// <summary>
        /// <para>Indicates the unique ID of the request. If the request fails, provide this ID for technical support to troubleshoot the failure.</para>
        /// 
        /// <b>Example:</b>
        /// <para>B5644ABB-559A-4A1C-83F2-9E7209******</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request is successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
