// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Iot20180120.Models
{
    public class QueryDevicePropertyDataResponseBody : TeaModel {
        /// <summary>
        /// The error code returned if the call fails. For more information, see [Error codes](~~87387~~).
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// The property data returned if the call is successful.
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public QueryDevicePropertyDataResponseBodyData Data { get; set; }
        public class QueryDevicePropertyDataResponseBodyData : TeaModel {
            /// <summary>
            /// The list of property records.
            /// </summary>
            [NameInMap("List")]
            [Validation(Required=false)]
            public QueryDevicePropertyDataResponseBodyDataList List { get; set; }
            public class QueryDevicePropertyDataResponseBodyDataList : TeaModel {
                [NameInMap("PropertyInfo")]
                [Validation(Required=false)]
                public List<QueryDevicePropertyDataResponseBodyDataListPropertyInfo> PropertyInfo { get; set; }
                public class QueryDevicePropertyDataResponseBodyDataListPropertyInfo : TeaModel {
                    /// <summary>
                    /// The time when the property was modified.
                    /// </summary>
                    [NameInMap("Time")]
                    [Validation(Required=false)]
                    public string Time { get; set; }

                    /// <summary>
                    /// The value of the property.
                    /// </summary>
                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public string Value { get; set; }

                }

            }

            /// <summary>
            /// The start time of the property records on the next page. 
            /// 
            /// - If the **Asc** parameter is set to **0**, you can specify this value for the **EndTime** parameter when you call this operation again to query the next page of property records.
            /// - If the **Asc** parameter is set to **1**, you can specify this value for the **StartTime** parameter when you call this operation again to query the next page of property records.
            /// </summary>
            [NameInMap("NextTime")]
            [Validation(Required=false)]
            public long? NextTime { get; set; }

            /// <summary>
            /// Indicates whether the next page exists.
            /// 
            /// *   **true**: The next page exists. If the return value of the NextValid parameter is true, the value of the **NextTime** parameter is returned. For more information, see the description of the **NextTime** parameter in this topic.
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
