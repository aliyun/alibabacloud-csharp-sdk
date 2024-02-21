// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.DAS20200116.Models
{
    public class GetRunningSqlConcurrencyControlRulesResponseBody : TeaModel {
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
        public GetRunningSqlConcurrencyControlRulesResponseBodyData Data { get; set; }
        public class GetRunningSqlConcurrencyControlRulesResponseBodyData : TeaModel {
            /// <summary>
            /// The returned data.
            /// </summary>
            [NameInMap("List")]
            [Validation(Required=false)]
            public GetRunningSqlConcurrencyControlRulesResponseBodyDataList List { get; set; }
            public class GetRunningSqlConcurrencyControlRulesResponseBodyDataList : TeaModel {
                [NameInMap("runningRules")]
                [Validation(Required=false)]
                public List<GetRunningSqlConcurrencyControlRulesResponseBodyDataListRunningRules> RunningRules { get; set; }
                public class GetRunningSqlConcurrencyControlRulesResponseBodyDataListRunningRules : TeaModel {
                    /// <summary>
                    /// The duration within which the SQL throttling rule takes effect. Unit: seconds.
                    /// 
                    /// > The throttling rule takes effect only within this duration.
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
                    /// The hash value of the SQL keywords. The hash value is calculated based on the SQL keywords that are contained in the SQL statements to which the throttling rule is applied.
                    /// </summary>
                    [NameInMap("KeywordsHash")]
                    [Validation(Required=false)]
                    public string KeywordsHash { get; set; }

                    /// <summary>
                    /// The maximum number of concurrent SQL statements. The value is a positive integer.
                    /// 
                    /// > If the number of concurrent SQL statements that contain the specified keywords reaches this upper limit, the throttling rule is triggered.
                    /// </summary>
                    [NameInMap("MaxConcurrency")]
                    [Validation(Required=false)]
                    public string MaxConcurrency { get; set; }

                    /// <summary>
                    /// The keywords contained in the SQL statements to which the throttling rule was applied.
                    /// 
                    /// > SQL keywords are separated by tildes (~). If the number of concurrent SQL statements that contain all the specified SQL keywords reaches the specified upper limit, the throttling rule is triggered.
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
                    /// The time when the throttling rule started to take effect. The value is a UNIX timestamp representing the number of milliseconds that have elapsed since January 1, 1970, 00:00:00 UTC.
                    /// </summary>
                    [NameInMap("StartTime")]
                    [Validation(Required=false)]
                    public long? StartTime { get; set; }

                    /// <summary>
                    /// The status of the throttling rule. The value of **Open** indicates that the throttling rule is in effect.
                    /// </summary>
                    [NameInMap("Status")]
                    [Validation(Required=false)]
                    public string Status { get; set; }

                    /// <summary>
                    /// The Alibaba Cloud account ID.
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
        /// *   **true**
        /// *   **false**
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public string Success { get; set; }

    }

}
