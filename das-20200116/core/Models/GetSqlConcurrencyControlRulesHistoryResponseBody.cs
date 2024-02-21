// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.DAS20200116.Models
{
    public class GetSqlConcurrencyControlRulesHistoryResponseBody : TeaModel {
        /// <summary>
        /// The HTTP status code returned.
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// The detailed information, including the error codes and the number of entries that are returned.
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetSqlConcurrencyControlRulesHistoryResponseBodyData Data { get; set; }
        public class GetSqlConcurrencyControlRulesHistoryResponseBodyData : TeaModel {
            /// <summary>
            /// The list of the queried throttling rules.
            /// </summary>
            [NameInMap("List")]
            [Validation(Required=false)]
            public GetSqlConcurrencyControlRulesHistoryResponseBodyDataList List { get; set; }
            public class GetSqlConcurrencyControlRulesHistoryResponseBodyDataList : TeaModel {
                [NameInMap("rules")]
                [Validation(Required=false)]
                public List<GetSqlConcurrencyControlRulesHistoryResponseBodyDataListRules> Rules { get; set; }
                public class GetSqlConcurrencyControlRulesHistoryResponseBodyDataListRules : TeaModel {
                    /// <summary>
                    /// The duration within which the SQL throttling rule takes effect. Unit: seconds.
                    /// 
                    /// >  The throttling rule takes effect only within this duration.
                    /// </summary>
                    [NameInMap("ConcurrencyControlTime")]
                    [Validation(Required=false)]
                    public long? ConcurrencyControlTime { get; set; }

                    /// <summary>
                    /// The instance ID.
                    /// </summary>
                    [NameInMap("InstanceId")]
                    [Validation(Required=false)]
                    public string InstanceId { get; set; }

                    /// <summary>
                    /// The ID of the throttling rule that is applied to the instance.
                    /// </summary>
                    [NameInMap("ItemId")]
                    [Validation(Required=false)]
                    public long? ItemId { get; set; }

                    /// <summary>
                    /// The hash value of the SQL keywords. The SQL keywords are contained in the SQL statements to which the throttling rule is applied.
                    /// </summary>
                    [NameInMap("KeywordsHash")]
                    [Validation(Required=false)]
                    public string KeywordsHash { get; set; }

                    /// <summary>
                    /// The maximum number of concurrent SQL statements. Set this parameter to a positive integer.
                    /// 
                    /// >  When the number of concurrent SQL statements that contain the specified keywords reaches this upper limit, the throttling rule is triggered.
                    /// </summary>
                    [NameInMap("MaxConcurrency")]
                    [Validation(Required=false)]
                    public long? MaxConcurrency { get; set; }

                    /// <summary>
                    /// The keywords that are used to identify the SQL statements that need to be throttled.
                    /// 
                    /// > SQL keywords are separated with tildes (~). When the number of concurrent SQL statements that contain all the specified SQL keywords reaches the specified upper limit, the throttling rule is triggered.
                    /// </summary>
                    [NameInMap("SqlKeywords")]
                    [Validation(Required=false)]
                    public string SqlKeywords { get; set; }

                    /// <summary>
                    /// The type of the SQL statements. Valid values:
                    /// 
                    /// * **SELECT**
                    /// * **UPDATE**
                    /// * **DELETE**
                    /// </summary>
                    [NameInMap("SqlType")]
                    [Validation(Required=false)]
                    public string SqlType { get; set; }

                    /// <summary>
                    /// The beginning of the time range to query. This value is a UNIX timestamp representing the number of milliseconds that have elapsed since January 1, 1970, 00:00:00 UTC.
                    /// </summary>
                    [NameInMap("StartTime")]
                    [Validation(Required=false)]
                    public long? StartTime { get; set; }

                    /// <summary>
                    /// The state of the throttling rule. Valid values:
                    /// 
                    /// * **Open**: The throttling rule is in effect.
                    /// * **Closed**: The throttling rule was in effect.
                    /// </summary>
                    [NameInMap("Status")]
                    [Validation(Required=false)]
                    public string Status { get; set; }

                    /// <summary>
                    /// The user ID.
                    /// </summary>
                    [NameInMap("UserId")]
                    [Validation(Required=false)]
                    public string UserId { get; set; }

                }

            }

            /// <summary>
            /// The total number of entries returned.
            /// </summary>
            [NameInMap("Total")]
            [Validation(Required=false)]
            public long? Total { get; set; }

        }

        /// <summary>
        /// The returned message.
        /// 
        /// >  If the request was successful, Successful is returned. If the request failed, an error message such as an error code is returned.
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
