// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Iot20180120.Models
{
    public class QueryDeviceOriginalEventDataResponseBody : TeaModel {
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
        public QueryDeviceOriginalEventDataResponseBodyData Data { get; set; }
        public class QueryDeviceOriginalEventDataResponseBodyData : TeaModel {
            /// <summary>
            /// The array of events. Each element represents an event. For more information about the details of the event, see the parameters of the **EventInfo** parameter.
            /// </summary>
            [NameInMap("List")]
            [Validation(Required=false)]
            public QueryDeviceOriginalEventDataResponseBodyDataList List { get; set; }
            public class QueryDeviceOriginalEventDataResponseBodyDataList : TeaModel {
                [NameInMap("EventInfo")]
                [Validation(Required=false)]
                public List<QueryDeviceOriginalEventDataResponseBodyDataListEventInfo> EventInfo { get; set; }
                public class QueryDeviceOriginalEventDataResponseBodyDataListEventInfo : TeaModel {
                    /// <summary>
                    /// The type of the event. Valid values:
                    /// 
                    /// *   info: information.
                    /// *   alert: alert.
                    /// *   error: error.
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
                    /// The time when the event occurred. The value is a 13-digit timestamp in milliseconds.
                    /// </summary>
                    [NameInMap("Time")]
                    [Validation(Required=false)]
                    public string Time { get; set; }

                }

            }

            /// <summary>
            /// The identifier of the next page.
            /// </summary>
            [NameInMap("NextPageToken")]
            [Validation(Required=false)]
            public string NextPageToken { get; set; }

            /// <summary>
            /// Indicates whether the next page exists.
            /// 
            /// *   **true**: The next page exists.
            /// *   **false**: The next page does not exist.
            /// 
            /// If the value ******true** is returned, you can add the value of the **NextPageToken** parameter**** to the next request. This allows you to query the data that is not included in the current query.
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
        /// Indicates whether the call succeeds.
        /// 
        /// *   true: The call succeeded.
        /// *   false: The call failed.
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
