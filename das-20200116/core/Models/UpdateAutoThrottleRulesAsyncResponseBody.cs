// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.DAS20200116.Models
{
    public class UpdateAutoThrottleRulesAsyncResponseBody : TeaModel {
        /// <summary>
        /// The HTTP status code returned.
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public long? Code { get; set; }

        /// <summary>
        /// The data returned.
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public UpdateAutoThrottleRulesAsyncResponseBodyData Data { get; set; }
        public class UpdateAutoThrottleRulesAsyncResponseBodyData : TeaModel {
            /// <summary>
            /// Indicates whether the asynchronous request was complete. Valid values:
            /// 
            /// *   **true**
            /// *   **false**
            /// </summary>
            [NameInMap("Complete")]
            [Validation(Required=false)]
            public bool? Complete { get; set; }

            /// <summary>
            /// The returned data of the configuration.
            /// 
            /// >  The data is returned only if the value of isFinish is **true**. This value indicates that the asynchronous request is complete.
            /// </summary>
            [NameInMap("ConfigResponse")]
            [Validation(Required=false)]
            public UpdateAutoThrottleRulesAsyncResponseBodyDataConfigResponse ConfigResponse { get; set; }
            public class UpdateAutoThrottleRulesAsyncResponseBodyDataConfigResponse : TeaModel {
                /// <summary>
                /// The number of database instances for which the parameters failed to be configured.
                /// </summary>
                [NameInMap("ConfigFailInstanceCount")]
                [Validation(Required=false)]
                public long? ConfigFailInstanceCount { get; set; }

                /// <summary>
                /// The database instances for which the parameters failed to be configured.
                /// </summary>
                [NameInMap("ConfigFailInstanceList")]
                [Validation(Required=false)]
                public List<UpdateAutoThrottleRulesAsyncResponseBodyDataConfigResponseConfigFailInstanceList> ConfigFailInstanceList { get; set; }
                public class UpdateAutoThrottleRulesAsyncResponseBodyDataConfigResponseConfigFailInstanceList : TeaModel {
                    /// <summary>
                    /// Indicates whether the parameters are configured. Valid values:
                    /// 
                    /// * **true**
                    /// 
                    /// * **false**
                    /// </summary>
                    [NameInMap("ConfigSuccess")]
                    [Validation(Required=false)]
                    public bool? ConfigSuccess { get; set; }

                    /// <summary>
                    /// The error message returned.
                    /// </summary>
                    [NameInMap("ErrorMessage")]
                    [Validation(Required=false)]
                    public string ErrorMessage { get; set; }

                    /// <summary>
                    /// The database instance ID.
                    /// </summary>
                    [NameInMap("InstanceId")]
                    [Validation(Required=false)]
                    public string InstanceId { get; set; }

                }

                /// <summary>
                /// The number of database instances for which the parameters are configured.
                /// </summary>
                [NameInMap("ConfigSuccessInstanceCount")]
                [Validation(Required=false)]
                public long? ConfigSuccessInstanceCount { get; set; }

                /// <summary>
                /// The database instances for which the parameters are configured.
                /// </summary>
                [NameInMap("ConfigSuccessInstanceList")]
                [Validation(Required=false)]
                public List<UpdateAutoThrottleRulesAsyncResponseBodyDataConfigResponseConfigSuccessInstanceList> ConfigSuccessInstanceList { get; set; }
                public class UpdateAutoThrottleRulesAsyncResponseBodyDataConfigResponseConfigSuccessInstanceList : TeaModel {
                    /// <summary>
                    /// Indicates whether the parameters are configured. Valid values:
                    /// 
                    /// * **true**
                    /// 
                    /// * **false**
                    /// </summary>
                    [NameInMap("ConfigSuccess")]
                    [Validation(Required=false)]
                    public bool? ConfigSuccess { get; set; }

                    /// <summary>
                    /// The database instance ID.
                    /// </summary>
                    [NameInMap("InstanceId")]
                    [Validation(Required=false)]
                    public string InstanceId { get; set; }

                }

                /// <summary>
                /// The total number of database instances.
                /// </summary>
                [NameInMap("TotalInstanceCount")]
                [Validation(Required=false)]
                public long? TotalInstanceCount { get; set; }

            }

            /// <summary>
            /// Indicates whether the asynchronous request failed. Valid values:
            /// 
            /// *   **true**
            /// *   **false**
            /// </summary>
            [NameInMap("Fail")]
            [Validation(Required=false)]
            public bool? Fail { get; set; }

            /// <summary>
            /// Indicates whether the asynchronous request was complete. Valid values:
            /// 
            /// *   **true**
            /// *   **false**
            /// </summary>
            [NameInMap("IsFinish")]
            [Validation(Required=false)]
            public bool? IsFinish { get; set; }

            /// <summary>
            /// The ID of the asynchronous request.
            /// </summary>
            [NameInMap("ResultId")]
            [Validation(Required=false)]
            public string ResultId { get; set; }

            /// <summary>
            /// The state of the asynchronous request. Valid values:
            /// 
            /// *   **RUNNING**
            /// *   **SUCCESS**
            /// *   **FAIL**
            /// </summary>
            [NameInMap("State")]
            [Validation(Required=false)]
            public string State { get; set; }

            /// <summary>
            /// The time when the asynchronous request was made. This value is a UNIX timestamp representing the number of milliseconds that have elapsed since January 1, 1970, 00:00:00 UTC.
            /// </summary>
            [NameInMap("Timestamp")]
            [Validation(Required=false)]
            public long? Timestamp { get; set; }

        }

        /// <summary>
        /// The returned message.
        /// 
        /// >  If the request was successful, **Successful** is returned. If the request failed, an error message such as an error code is returned.
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
        public bool? Success { get; set; }

    }

}
