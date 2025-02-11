// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adb20211201.Models
{
    public class ListApsLifecycleStrategyResponseBody : TeaModel {
        /// <summary>
        /// <para>The HTTP status code or the error code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The response code. The status code 200 indicates that the request was successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// <para>The queried lifecycle management policies.</para>
        /// </summary>
        [NameInMap("Items")]
        [Validation(Required=false)]
        public List<ListApsLifecycleStrategyResponseBodyItems> Items { get; set; }
        public class ListApsLifecycleStrategyResponseBodyItems : TeaModel {
            /// <summary>
            /// <para>The job ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>aps-******</para>
            /// </summary>
            [NameInMap("ApsJobId")]
            [Validation(Required=false)]
            public string ApsJobId { get; set; }

            /// <summary>
            /// <para>The time when the policy was created.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2021-06-30T02:44:27Z</para>
            /// </summary>
            [NameInMap("CreatedTime")]
            [Validation(Required=false)]
            public string CreatedTime { get; set; }

            /// <summary>
            /// <para>The cluster ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>amv-*******</para>
            /// </summary>
            [NameInMap("DBClusterId")]
            [Validation(Required=false)]
            public string DBClusterId { get; set; }

            /// <summary>
            /// <para>The time when the policy was modified.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2021-07-03T06:33:00Z</para>
            /// </summary>
            [NameInMap("ModifiedTime")]
            [Validation(Required=false)]
            public string ModifiedTime { get; set; }

            /// <summary>
            /// <list type="bullet">
            /// <item><description></description></item>
            /// </list>
            /// </summary>
            [NameInMap("OperationTables")]
            [Validation(Required=false)]
            public List<ListApsLifecycleStrategyResponseBodyItemsOperationTables> OperationTables { get; set; }
            public class ListApsLifecycleStrategyResponseBodyItemsOperationTables : TeaModel {
                /// <summary>
                /// <para>The name of the database.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test</para>
                /// </summary>
                [NameInMap("DatabaseName")]
                [Validation(Required=false)]
                public string DatabaseName { get; set; }

                /// <summary>
                /// <para>Indicates whether all tables in the database are selected.</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("ProcessAll")]
                [Validation(Required=false)]
                public string ProcessAll { get; set; }

                /// <summary>
                /// <para>The names of the tables.</para>
                /// </summary>
                [NameInMap("TableNames")]
                [Validation(Required=false)]
                public List<string> TableNames { get; set; }

            }

            /// <summary>
            /// <para>The status of the lifecycle management policy. Valid values:</para>
            /// <ol>
            /// <item><description>on: enables the current policy.</description></item>
            /// <item><description>off: disables the current policy.</description></item>
            /// </ol>
            /// 
            /// <b>Example:</b>
            /// <para>on</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The number of databases that are managed during the lifecycle management.</para>
            /// 
            /// <b>Example:</b>
            /// <para>5</para>
            /// </summary>
            [NameInMap("StrategyDatabases")]
            [Validation(Required=false)]
            public long? StrategyDatabases { get; set; }

            /// <summary>
            /// <para>The description of the lifecycle management policy.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("StrategyDesc")]
            [Validation(Required=false)]
            public string StrategyDesc { get; set; }

            /// <summary>
            /// <para>The name of the lifecycle management policy.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("StrategyName")]
            [Validation(Required=false)]
            public string StrategyName { get; set; }

            /// <summary>
            /// <para>The number of tables that are managed during the lifecycle management.</para>
            /// 
            /// <b>Example:</b>
            /// <para>5</para>
            /// </summary>
            [NameInMap("StrategyTables")]
            [Validation(Required=false)]
            public long? StrategyTables { get; set; }

            /// <summary>
            /// <para>The type of the lifecycle management policy.</para>
            /// 
            /// <b>Example:</b>
            /// <para>KEEP_BY_TIME</para>
            /// </summary>
            [NameInMap("StrategyType")]
            [Validation(Required=false)]
            public string StrategyType { get; set; }

            /// <summary>
            /// <para>The value of the lifecycle management policy.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("StrategyValue")]
            [Validation(Required=false)]
            public string StrategyValue { get; set; }

        }

        /// <summary>
        /// <para>The returned message. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>If the request was successful, a success message is returned.****</description></item>
        /// <item><description>If the request failed, an error message is returned.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

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
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para><b><b><b>-3EEC-</b></b></b>-9F06-******</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request was successful. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b></description></item>
        /// <item><description><b>false</b></description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// <para>The total number of entries returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
