// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Drds20190123.Models
{
    public class DescribeBroadcastTablesResponseBody : TeaModel {
        /// <summary>
        /// <para>Indicates whether the database is sharded.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("IsShard")]
        [Validation(Required=false)]
        public bool? IsShard { get; set; }

        /// <summary>
        /// <para>Indicates information about broadcast tables.</para>
        /// </summary>
        [NameInMap("List")]
        [Validation(Required=false)]
        public List<DescribeBroadcastTablesResponseBodyList> List { get; set; }
        public class DescribeBroadcastTablesResponseBodyList : TeaModel {
            /// <summary>
            /// <para>Indicates whether a table is a broadcast table.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("Broadcast")]
            [Validation(Required=false)]
            public bool? Broadcast { get; set; }

            /// <summary>
            /// <para>Indicates the type of the broadcast table. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>1</b>: multi-write mode</description></item>
            /// <item><description><b>2</b>: synchronous mode</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("BroadcastType")]
            [Validation(Required=false)]
            public string BroadcastType { get; set; }

            /// <summary>
            /// <para>Indicates the storage type of the database. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>0</b>: RDS</description></item>
            /// <item><description><b>4</b>: PolarDB</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("DbInstType")]
            [Validation(Required=false)]
            public int? DbInstType { get; set; }

            /// <summary>
            /// <para>Indicates whether the broadcast table was sharded.</para>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("IsShard")]
            [Validation(Required=false)]
            public bool? IsShard { get; set; }

            /// <summary>
            /// <para>Indicates the activation state of the broadcast table. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>1</b>: The broadcast table is activated.</description></item>
            /// <item><description><b>2</b>: The broadcast table is being activated.</description></item>
            /// <item><description><b>3</b>: An exception occurs when the broadcast table is being activated.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public int? Status { get; set; }

            /// <summary>
            /// <para>Indicates the name of the table.</para>
            /// 
            /// <b>Example:</b>
            /// <para>nation</para>
            /// </summary>
            [NameInMap("Table")]
            [Validation(Required=false)]
            public string Table { get; set; }

        }

        /// <summary>
        /// <para>Indicates the page number of the returned page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>Indicates the number of entries returned per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>40</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>Indicates the ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>86E420ED-43F2-4788-A58C-921849******</para>
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
        /// <para>Indicates the total number of entries returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("Total")]
        [Validation(Required=false)]
        public int? Total { get; set; }

    }

}
