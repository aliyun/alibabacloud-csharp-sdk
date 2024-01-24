// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Drds20190123.Models
{
    public class DescribeTableResponseBody : TeaModel {
        /// <summary>
        /// Indicates the returned data.
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public DescribeTableResponseBodyData Data { get; set; }
        public class DescribeTableResponseBodyData : TeaModel {
            /// <summary>
            /// Indicates the details about the table schema.
            /// </summary>
            [NameInMap("List")]
            [Validation(Required=false)]
            public List<DescribeTableResponseBodyDataList> List { get; set; }
            public class DescribeTableResponseBodyDataList : TeaModel {
                /// <summary>
                /// Indicates the name of a column.
                /// </summary>
                [NameInMap("ColumnName")]
                [Validation(Required=false)]
                public string ColumnName { get; set; }

                /// <summary>
                /// Indicates the type of the column.
                /// </summary>
                [NameInMap("ColumnType")]
                [Validation(Required=false)]
                public string ColumnType { get; set; }

                /// <summary>
                /// Extra
                /// </summary>
                [NameInMap("Extra")]
                [Validation(Required=false)]
                public string Extra { get; set; }

                /// <summary>
                /// Indicates the primary key of the table.
                /// </summary>
                [NameInMap("Index")]
                [Validation(Required=false)]
                public string Index { get; set; }

                /// <summary>
                /// Indicates whether the column can be empty.
                /// </summary>
                [NameInMap("IsAllowNull")]
                [Validation(Required=false)]
                public string IsAllowNull { get; set; }

                /// <summary>
                /// Indicates whether the column is the primary key column of the table.
                /// </summary>
                [NameInMap("IsPk")]
                [Validation(Required=false)]
                public string IsPk { get; set; }

            }

        }

        /// <summary>
        /// Indicates the unique ID of the request. If the request fails, provide this ID for technical support to troubleshoot the failure.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// Indicates whether the request is successful.
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
