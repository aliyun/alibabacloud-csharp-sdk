// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adb20211201.Models
{
    public class DescribeTableAccessCountResponseBody : TeaModel {
        /// <summary>
        /// <para>The queried tables.</para>
        /// </summary>
        [NameInMap("Items")]
        [Validation(Required=false)]
        public List<DescribeTableAccessCountResponseBodyItems> Items { get; set; }
        public class DescribeTableAccessCountResponseBodyItems : TeaModel {
            /// <summary>
            /// <para>The number of accesses to the table.</para>
            /// 
            /// <b>Example:</b>
            /// <para>6</para>
            /// </summary>
            [NameInMap("AccessCount")]
            [Validation(Required=false)]
            public string AccessCount { get; set; }

            /// <summary>
            /// <para>The ID of the cluster to which the table belongs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>amv-2ze627uzpkh8a8****</para>
            /// </summary>
            [NameInMap("InstanceName")]
            [Validation(Required=false)]
            public string InstanceName { get; set; }

            /// <summary>
            /// <para>The date when the table was accessed.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2022-09-26</para>
            /// </summary>
            [NameInMap("ReportDate")]
            [Validation(Required=false)]
            public string ReportDate { get; set; }

            /// <summary>
            /// <para>The name of the table.</para>
            /// 
            /// <b>Example:</b>
            /// <para>CUSTOMER</para>
            /// </summary>
            [NameInMap("TableName")]
            [Validation(Required=false)]
            public string TableName { get; set; }

            /// <summary>
            /// <para>The database to which the table belongs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>tpch</para>
            /// </summary>
            [NameInMap("TableSchema")]
            [Validation(Required=false)]
            public string TableSchema { get; set; }

        }

        /// <summary>
        /// <para>The page number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>30</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>6B7D627B-DA23-572D-AD71-256F64698B7D</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of entries returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
