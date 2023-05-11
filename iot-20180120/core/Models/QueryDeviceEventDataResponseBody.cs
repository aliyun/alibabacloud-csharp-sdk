// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Iot20180120.Models
{
    public class QueryDeviceEventDataResponseBody : TeaModel {
        /// <summary>
        /// The error code returned if the call fails. For more information, see [Error codes](~~87387~~).
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// The event records returned if the call succeeds.
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public QueryDeviceEventDataResponseBodyData Data { get; set; }
        public class QueryDeviceEventDataResponseBodyData : TeaModel {
            /// <summary>
            /// The array of events. Each element represents an event.
            /// </summary>
            [NameInMap("List")]
            [Validation(Required=false)]
            public QueryDeviceEventDataResponseBodyDataList List { get; set; }
            public class QueryDeviceEventDataResponseBodyDataList : TeaModel {
                [NameInMap("EventInfo")]
                [Validation(Required=false)]
                public List<QueryDeviceEventDataResponseBodyDataListEventInfo> EventInfo { get; set; }
                public class QueryDeviceEventDataResponseBodyDataListEventInfo : TeaModel {
                    /// <summary>
                    /// The type of the event. Valid values:
                    /// 
                    /// *   **info**: information.
                    /// *   **alert**: alert.
                    /// *   **error**: error.
                    /// </summary>
                    [NameInMap("EventType")]
                    [Validation(Required=false)]
                    public string EventType { get; set; }

                    /// <summary>
                    /// The identifier of the event.
                    /// </summary>
                    [NameInMap("Identifier")]
                    [Validation(Required=false)]
                    public string Identifier { get; set; }

                    /// <summary>
                    /// The name of the event.
                    /// </summary>
                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    /// <summary>
                    /// The output parameter of the event. The value is a string in the MAP format.
                    /// </summary>
                    [NameInMap("OutputData")]
                    [Validation(Required=false)]
                    public string OutputData { get; set; }

                    /// <summary>
                    /// The time when the event occurred. The value is a timestamp in milliseconds.
                    /// </summary>
                    [NameInMap("Time")]
                    [Validation(Required=false)]
                    public string Time { get; set; }

                }

            }

            /// <summary>
            /// The start time of the event records on the next page. The value is a timestamp in milliseconds.  
            /// 
            /// - If the **Asc** parameter is set to 0, you can specify this value for the **EndTime** parameter when you call this operation again to query the next page of event records.
            /// - If the **Asc** parameter is set to 1, you can specify this value for the **StartTime** parameter when you call this operation again to query the next page of event records.
            /// </summary>
            [NameInMap("NextTime")]
            [Validation(Required=false)]
            public long? NextTime { get; set; }

            /// <summary>
            /// Indicates whether the next page exists.
            /// 
            /// *   **true**: The next page exists. The value of the **NextTime** parameter is returned. For more information, see the description of the **NextTime** parameter in this topic.
            /// *   **false**: The next page does not exist.
            /// </summary>
            [NameInMap("NextValid")]
            [Validation(Required=false)]
            public bool? NextValid { get; set; }

        }

        /// <summary>
        /// The error message returned if the call fails.
        /// </summary>
        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// Indicates whether the call was successful.
        /// 
        /// *   **true**: The call was successful.
        /// *   **false**: The call failed.
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
