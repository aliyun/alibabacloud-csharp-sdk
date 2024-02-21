// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.DAS20200116.Models
{
    public class GetQueryOptimizeDataStatsResponseBody : TeaModel {
        /// <summary>
        /// The HTTP status code returned.
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// The data returned.
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetQueryOptimizeDataStatsResponseBodyData Data { get; set; }
        public class GetQueryOptimizeDataStatsResponseBodyData : TeaModel {
            /// <summary>
            /// The reserved parameter.
            /// </summary>
            [NameInMap("Extra")]
            [Validation(Required=false)]
            public string Extra { get; set; }

            /// <summary>
            /// The information about the SQL templates.
            /// </summary>
            [NameInMap("List")]
            [Validation(Required=false)]
            public List<GetQueryOptimizeDataStatsResponseBodyDataList> List { get; set; }
            public class GetQueryOptimizeDataStatsResponseBodyDataList : TeaModel {
                /// <summary>
                /// The average lock wait time. Unit: seconds.
                /// </summary>
                [NameInMap("AvgLockTime")]
                [Validation(Required=false)]
                public double? AvgLockTime { get; set; }

                /// <summary>
                /// The average query execution time. Unit: seconds.
                /// </summary>
                [NameInMap("AvgQueryTime")]
                [Validation(Required=false)]
                public double? AvgQueryTime { get; set; }

                /// <summary>
                /// The average number of rows affected by the SQL statement.
                /// 
                /// > A value of -1 indicates that this parameter is not collected.
                /// </summary>
                [NameInMap("AvgRowsAffected")]
                [Validation(Required=false)]
                public double? AvgRowsAffected { get; set; }

                /// <summary>
                /// The average number of scanned rows.
                /// </summary>
                [NameInMap("AvgRowsExamined")]
                [Validation(Required=false)]
                public double? AvgRowsExamined { get; set; }

                /// <summary>
                /// The average number of returned rows.
                /// </summary>
                [NameInMap("AvgRowsSent")]
                [Validation(Required=false)]
                public double? AvgRowsSent { get; set; }

                /// <summary>
                /// The number of times that the SQL template is executed.
                /// </summary>
                [NameInMap("Count")]
                [Validation(Required=false)]
                public int? Count { get; set; }

                /// <summary>
                /// The name of the database to which the SQL template belongs.
                /// </summary>
                [NameInMap("Dbname")]
                [Validation(Required=false)]
                public string Dbname { get; set; }

                /// <summary>
                /// The instance ID.
                /// </summary>
                [NameInMap("InstanceId")]
                [Validation(Required=false)]
                public string InstanceId { get; set; }

                /// <summary>
                /// The longest lock wait time. Unit: seconds.
                /// </summary>
                [NameInMap("MaxLockTime")]
                [Validation(Required=false)]
                public double? MaxLockTime { get; set; }

                /// <summary>
                /// The longest query execution time. Unit: seconds.
                /// </summary>
                [NameInMap("MaxQueryTime")]
                [Validation(Required=false)]
                public double? MaxQueryTime { get; set; }

                /// <summary>
                /// The largest number of rows affected by the SQL template.
                /// 
                /// > A value of -1 indicates that this parameter is not collected.
                /// </summary>
                [NameInMap("MaxRowsAffected")]
                [Validation(Required=false)]
                public long? MaxRowsAffected { get; set; }

                /// <summary>
                /// The largest number of scanned rows.
                /// </summary>
                [NameInMap("MaxRowsExamined")]
                [Validation(Required=false)]
                public long? MaxRowsExamined { get; set; }

                /// <summary>
                /// The largest number of returned rows.
                /// </summary>
                [NameInMap("MaxRowsSent")]
                [Validation(Required=false)]
                public long? MaxRowsSent { get; set; }

                /// <summary>
                /// The SQL template.
                /// </summary>
                [NameInMap("Psql")]
                [Validation(Required=false)]
                public string Psql { get; set; }

                /// <summary>
                /// The information about the rules.
                /// </summary>
                [NameInMap("RuleList")]
                [Validation(Required=false)]
                public List<GetQueryOptimizeDataStatsResponseBodyDataListRuleList> RuleList { get; set; }
                public class GetQueryOptimizeDataStatsResponseBodyDataListRuleList : TeaModel {
                    /// <summary>
                    /// The rule name.
                    /// </summary>
                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    /// <summary>
                    /// The type of the rule. Valid values:
                    /// 
                    /// * **Predefined**
                    /// * **UserDefined**
                    /// </summary>
                    [NameInMap("Type")]
                    [Validation(Required=false)]
                    public string Type { get; set; }

                }

                /// <summary>
                /// The SQL template ID.
                /// </summary>
                [NameInMap("SqlId")]
                [Validation(Required=false)]
                public string SqlId { get; set; }

                /// <summary>
                /// The sample query that took the longest time to execute.
                /// </summary>
                [NameInMap("SqlSample")]
                [Validation(Required=false)]
                public string SqlSample { get; set; }

                /// <summary>
                /// The type of the SQL statement.
                /// </summary>
                [NameInMap("SqlType")]
                [Validation(Required=false)]
                public string SqlType { get; set; }

                /// <summary>
                /// The account of the database.
                /// </summary>
                [NameInMap("User")]
                [Validation(Required=false)]
                public string User { get; set; }

            }

            /// <summary>
            /// The reserved parameter.
            /// </summary>
            [NameInMap("PageNo")]
            [Validation(Required=false)]
            public int? PageNo { get; set; }

            /// <summary>
            /// The reserved parameter.
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            /// <summary>
            /// The total number of entries returned.
            /// </summary>
            [NameInMap("Total")]
            [Validation(Required=false)]
            public long? Total { get; set; }

        }

        /// <summary>
        /// The returned message.
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// Indicates whether the request was successful. Valid values:
        /// 
        /// *   **true**: The request was successful.
        /// *   **false**: The request failed.
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public string Success { get; set; }

    }

}
