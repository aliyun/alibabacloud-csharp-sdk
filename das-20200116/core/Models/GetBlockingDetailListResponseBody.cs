// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.DAS20200116.Models
{
    public class GetBlockingDetailListResponseBody : TeaModel {
        /// <summary>
        /// <para>The HTTP status code returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The returned data.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetBlockingDetailListResponseBodyData Data { get; set; }
        public class GetBlockingDetailListResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The details of the data returned.</para>
            /// </summary>
            [NameInMap("List")]
            [Validation(Required=false)]
            public List<GetBlockingDetailListResponseBodyDataList> List { get; set; }
            public class GetBlockingDetailListResponseBodyDataList : TeaModel {
                /// <summary>
                /// <para>The batch ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1683530096156</para>
                /// </summary>
                [NameInMap("BatchId")]
                [Validation(Required=false)]
                public long? BatchId { get; set; }

                /// <summary>
                /// <para>The client name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>.Net SqlClient Data Provider</para>
                /// </summary>
                [NameInMap("ClientAppName")]
                [Validation(Required=false)]
                public string ClientAppName { get; set; }

                /// <summary>
                /// <para>The time when the blocking data was collected. This value is a UNIX timestamp representing the number of milliseconds that have elapsed since January 1, 1970, 00:00:00 UTC.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1700065800000</para>
                /// </summary>
                [NameInMap("CurrentCollectionTime")]
                [Validation(Required=false)]
                public long? CurrentCollectionTime { get; set; }

                /// <summary>
                /// <para>The name of the database.</para>
                /// 
                /// <b>Example:</b>
                /// <para>school</para>
                /// </summary>
                [NameInMap("DataBase")]
                [Validation(Required=false)]
                public string DataBase { get; set; }

                /// <summary>
                /// <para>The client hostname.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ALLBNMGTAPPRD01</para>
                /// </summary>
                [NameInMap("HostName")]
                [Validation(Required=false)]
                public string HostName { get; set; }

                /// <summary>
                /// <para>The username that is used for the logon.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Cheney603</para>
                /// </summary>
                [NameInMap("LoginId")]
                [Validation(Required=false)]
                public string LoginId { get; set; }

                /// <summary>
                /// <para>The hash value of the SQL statement.</para>
                /// 
                /// <b>Example:</b>
                /// <para>6977DD06CD9CAFF2</para>
                /// </summary>
                [NameInMap("QueryHash")]
                [Validation(Required=false)]
                public string QueryHash { get; set; }

                /// <summary>
                /// <para>The session ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1717</para>
                /// </summary>
                [NameInMap("Spid")]
                [Validation(Required=false)]
                public string Spid { get; set; }

                /// <summary>
                /// <para>The SQL statement.</para>
                /// 
                /// <b>Example:</b>
                /// <para>select * from test1</para>
                /// </summary>
                [NameInMap("SqlText")]
                [Validation(Required=false)]
                public string SqlText { get; set; }

                /// <summary>
                /// <para>The time when the execution started. This value is a UNIX timestamp representing the number of milliseconds that have elapsed since January 1, 1970, 00:00:00 UTC.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1608888296000</para>
                /// </summary>
                [NameInMap("StartTime")]
                [Validation(Required=false)]
                public string StartTime { get; set; }

                /// <summary>
                /// <para>The duration of the blocking. Unit: milliseconds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>30000</para>
                /// </summary>
                [NameInMap("WaitTimeMs")]
                [Validation(Required=false)]
                public long? WaitTimeMs { get; set; }

                /// <summary>
                /// <para>The wait type. For more information about wait types, see <a href="https://learn.microsoft.com/en-us/sql/relational-databases/system-dynamic-management-views/sys-dm-os-wait-stats-transact-sql?view=sql-server-ver15">sys.dm_os_wait_stats (Transact-SQL)</a>.</para>
                /// 
                /// <b>Example:</b>
                /// <para>MISCELLANEOUS</para>
                /// </summary>
                [NameInMap("WaitType")]
                [Validation(Required=false)]
                public string WaitType { get; set; }

            }

            /// <summary>
            /// <para>The page number of the page returned.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("PageNo")]
            [Validation(Required=false)]
            public long? PageNo { get; set; }

            /// <summary>
            /// <para>The number of entries returned on each page.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public long? PageSize { get; set; }

            /// <summary>
            /// <para>The total number of entries returned.</para>
            /// 
            /// <b>Example:</b>
            /// <para>19</para>
            /// </summary>
            [NameInMap("Total")]
            [Validation(Required=false)]
            public long? Total { get; set; }

        }

        /// <summary>
        /// <para>The returned message.</para>
        /// <remarks>
        /// <para> If the request is successful, <b>Successful</b> is returned. Otherwise, an error message such as an error code is returned.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>Successful</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>B6D17591-B48B-4D31-9CD6-9B9796B2****</para>
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
        public string Success { get; set; }

    }

}
