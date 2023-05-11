// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Iot20180120.Models
{
    public class QueryDeviceOriginalPropertyDataResponseBody : TeaModel {
        /// <summary>
        /// The error code returned if the call fails. For more information, see [Error codes](~~87387~~).
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// The property records returned if the call is successful.
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public QueryDeviceOriginalPropertyDataResponseBodyData Data { get; set; }
        public class QueryDeviceOriginalPropertyDataResponseBodyData : TeaModel {
            /// <summary>
            /// The properties. Each element indicates a property.
            /// </summary>
            [NameInMap("List")]
            [Validation(Required=false)]
            public QueryDeviceOriginalPropertyDataResponseBodyDataList List { get; set; }
            public class QueryDeviceOriginalPropertyDataResponseBodyDataList : TeaModel {
                [NameInMap("PropertyInfo")]
                [Validation(Required=false)]
                public List<QueryDeviceOriginalPropertyDataResponseBodyDataListPropertyInfo> PropertyInfo { get; set; }
                public class QueryDeviceOriginalPropertyDataResponseBodyDataListPropertyInfo : TeaModel {
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
            /// Indicates whether the next page exists. 
            /// 
            /// - **true**: The next page exists.
            /// - **false**: The next page does not exist.
            /// 
            /// If **true** is returned for the **NextValid** parameter, you can add the value of the **NextPageToken** parameter to the next request. This way, you can query the data that is not included in the current query.
            /// </summary>
            [NameInMap("NextValid")]
            [Validation(Required=false)]
            public bool? NextValid { get; set; }

            /// <summary>
            /// The token that is used to retrieve the next page of the query results.
            /// </summary>
            [NameInMap("nextPageToken")]
            [Validation(Required=false)]
            public string NextPageToken { get; set; }

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
        /// Indicates whether the call was successful. Valid values:
        /// 
        /// *   **true**: The call was successful.
        /// *   **false**: The call failed.
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
