// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.DAS20200116.Models
{
    public class GetQueryOptimizeDataStatsResponseBody : TeaModel {
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
        /// <para>The data returned.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetQueryOptimizeDataStatsResponseBodyData Data { get; set; }
        public class GetQueryOptimizeDataStatsResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The reserved parameter.</para>
            /// 
            /// <b>Example:</b>
            /// <para>None</para>
            /// </summary>
            [NameInMap("Extra")]
            [Validation(Required=false)]
            public string Extra { get; set; }

            /// <summary>
            /// <para>The information about the SQL templates.</para>
            /// </summary>
            [NameInMap("List")]
            [Validation(Required=false)]
            public List<GetQueryOptimizeDataStatsResponseBodyDataList> List { get; set; }
            public class GetQueryOptimizeDataStatsResponseBodyDataList : TeaModel {
                /// <summary>
                /// <para>The average lock wait time. Unit: seconds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0.1</para>
                /// </summary>
                [NameInMap("AvgLockTime")]
                [Validation(Required=false)]
                public double? AvgLockTime { get; set; }

                /// <summary>
                /// <para>The average query execution time. Unit: seconds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1.1</para>
                /// </summary>
                [NameInMap("AvgQueryTime")]
                [Validation(Required=false)]
                public double? AvgQueryTime { get; set; }

                /// <summary>
                /// <para>The average number of rows affected by the SQL statement.</para>
                /// <remarks>
                /// <para>A value of -1 indicates that this parameter is not collected.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>100.1</para>
                /// </summary>
                [NameInMap("AvgRowsAffected")]
                [Validation(Required=false)]
                public double? AvgRowsAffected { get; set; }

                /// <summary>
                /// <para>The average number of scanned rows.</para>
                /// 
                /// <b>Example:</b>
                /// <para>100.1</para>
                /// </summary>
                [NameInMap("AvgRowsExamined")]
                [Validation(Required=false)]
                public double? AvgRowsExamined { get; set; }

                /// <summary>
                /// <para>The average number of returned rows.</para>
                /// 
                /// <b>Example:</b>
                /// <para>100.1</para>
                /// </summary>
                [NameInMap("AvgRowsSent")]
                [Validation(Required=false)]
                public double? AvgRowsSent { get; set; }

                /// <summary>
                /// <para>The number of times that the SQL template is executed.</para>
                /// 
                /// <b>Example:</b>
                /// <para>100</para>
                /// </summary>
                [NameInMap("Count")]
                [Validation(Required=false)]
                public int? Count { get; set; }

                /// <summary>
                /// <para>The name of the database to which the SQL template belongs.</para>
                /// 
                /// <b>Example:</b>
                /// <para>testdb01</para>
                /// </summary>
                [NameInMap("Dbname")]
                [Validation(Required=false)]
                public string Dbname { get; set; }

                /// <summary>
                /// <para>The instance ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>rm-2ze8g2am97624****</para>
                /// </summary>
                [NameInMap("InstanceId")]
                [Validation(Required=false)]
                public string InstanceId { get; set; }

                /// <summary>
                /// <para>The longest lock wait time. Unit: seconds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0.1</para>
                /// </summary>
                [NameInMap("MaxLockTime")]
                [Validation(Required=false)]
                public double? MaxLockTime { get; set; }

                /// <summary>
                /// <para>The longest query execution time. Unit: seconds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1.1</para>
                /// </summary>
                [NameInMap("MaxQueryTime")]
                [Validation(Required=false)]
                public double? MaxQueryTime { get; set; }

                /// <summary>
                /// <para>The largest number of rows affected by the SQL template.</para>
                /// <remarks>
                /// <para>A value of -1 indicates that this parameter is not collected.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>10000</para>
                /// </summary>
                [NameInMap("MaxRowsAffected")]
                [Validation(Required=false)]
                public long? MaxRowsAffected { get; set; }

                /// <summary>
                /// <para>The largest number of scanned rows.</para>
                /// 
                /// <b>Example:</b>
                /// <para>100000</para>
                /// </summary>
                [NameInMap("MaxRowsExamined")]
                [Validation(Required=false)]
                public long? MaxRowsExamined { get; set; }

                /// <summary>
                /// <para>The largest number of returned rows.</para>
                /// 
                /// <b>Example:</b>
                /// <para>10000</para>
                /// </summary>
                [NameInMap("MaxRowsSent")]
                [Validation(Required=false)]
                public long? MaxRowsSent { get; set; }

                /// <summary>
                /// <para>The SQL template.</para>
                /// 
                /// <b>Example:</b>
                /// <para>select 1</para>
                /// </summary>
                [NameInMap("Psql")]
                [Validation(Required=false)]
                public string Psql { get; set; }

                /// <summary>
                /// <para>The information about the rules.</para>
                /// </summary>
                [NameInMap("RuleList")]
                [Validation(Required=false)]
                public List<GetQueryOptimizeDataStatsResponseBodyDataListRuleList> RuleList { get; set; }
                public class GetQueryOptimizeDataStatsResponseBodyDataListRuleList : TeaModel {
                    /// <summary>
                    /// <para>The rule name.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>DAS_NOT_IMPORTANT</para>
                    /// </summary>
                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    /// <summary>
                    /// <para>The type of the rule. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description><b>Predefined</b></description></item>
                    /// <item><description><b>UserDefined</b></description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Predefined</para>
                    /// </summary>
                    [NameInMap("Type")]
                    [Validation(Required=false)]
                    public string Type { get; set; }

                }

                /// <summary>
                /// <para>The SQL template ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2e8147b5ca2dfc640dfd5e43d96a****</para>
                /// </summary>
                [NameInMap("SqlId")]
                [Validation(Required=false)]
                public string SqlId { get; set; }

                /// <summary>
                /// <para>The sample query that took the longest time to execute.</para>
                /// 
                /// <b>Example:</b>
                /// <para>select 2</para>
                /// </summary>
                [NameInMap("SqlSample")]
                [Validation(Required=false)]
                public string SqlSample { get; set; }

                /// <summary>
                /// <para>The type of the SQL statement.</para>
                /// 
                /// <b>Example:</b>
                /// <para>INSERT</para>
                /// </summary>
                [NameInMap("SqlType")]
                [Validation(Required=false)]
                public string SqlType { get; set; }

                /// <summary>
                /// <para>The account of the database.</para>
                /// 
                /// <b>Example:</b>
                /// <para>testUser</para>
                /// </summary>
                [NameInMap("User")]
                [Validation(Required=false)]
                public string User { get; set; }

            }

            /// <summary>
            /// <para>The reserved parameter.</para>
            /// 
            /// <b>Example:</b>
            /// <para>None</para>
            /// </summary>
            [NameInMap("PageNo")]
            [Validation(Required=false)]
            public int? PageNo { get; set; }

            /// <summary>
            /// <para>The reserved parameter.</para>
            /// 
            /// <b>Example:</b>
            /// <para>None</para>
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            /// <summary>
            /// <para>The total number of entries returned.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("Total")]
            [Validation(Required=false)]
            public long? Total { get; set; }

        }

        /// <summary>
        /// <para>The returned message.</para>
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
        /// <item><description><b>true</b>: The request was successful.</description></item>
        /// <item><description><b>false</b>: The request failed.</description></item>
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
