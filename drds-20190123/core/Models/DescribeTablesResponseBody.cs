// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Drds20190123.Models
{
    public class DescribeTablesResponseBody : TeaModel {
        /// <summary>
        /// <para>The list of returned tables.</para>
        /// </summary>
        [NameInMap("List")]
        [Validation(Required=false)]
        public List<DescribeTablesResponseBodyList> List { get; set; }
        public class DescribeTablesResponseBodyList : TeaModel {
            /// <summary>
            /// <para>Indicates whether full table scanning is allowed.</para>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("AllowFullTableScan")]
            [Validation(Required=false)]
            public bool? AllowFullTableScan { get; set; }

            /// <summary>
            /// <para>Indicates whether the table is a replicated table.</para>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("Broadcast")]
            [Validation(Required=false)]
            public bool? Broadcast { get; set; }

            /// <summary>
            /// <para>The type of the PolarDB-X 1.0 instance. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>0: The instance is a dedicated instance.</description></item>
            /// <item><description>1: The instance is a shard instance.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("DbInstType")]
            [Validation(Required=false)]
            public int? DbInstType { get; set; }

            /// <summary>
            /// <para>Indicates whether the table is locked.</para>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("IsLocked")]
            [Validation(Required=false)]
            public bool? IsLocked { get; set; }

            /// <summary>
            /// <para>Indicates whether the table is sharded.</para>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("IsShard")]
            [Validation(Required=false)]
            public bool? IsShard { get; set; }

            /// <summary>
            /// <para>The shard key of the table.</para>
            /// 
            /// <b>Example:</b>
            /// <para>null</para>
            /// </summary>
            [NameInMap("ShardKey")]
            [Validation(Required=false)]
            public string ShardKey { get; set; }

            /// <summary>
            /// <para>Indicates whether sharding tasks are performed on the table. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>0: No sharding task is performed on the table.</description></item>
            /// <item><description>1: Sharding tasks are performed on the table.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public int? Status { get; set; }

            /// <summary>
            /// <para>The name of the table.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("Table")]
            [Validation(Required=false)]
            public string Table { get; set; }

        }

        /// <summary>
        /// <para>The number of returned pages.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of tables returned per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>83AC3D7E-461C-4D87-8ACD-6CC295******</para>
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

        /// <summary>
        /// <para>The total number of returned tables.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Total")]
        [Validation(Required=false)]
        public int? Total { get; set; }

    }

}
