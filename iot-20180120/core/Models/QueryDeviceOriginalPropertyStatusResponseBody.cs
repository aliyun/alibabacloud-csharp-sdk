// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Iot20180120.Models
{
    public class QueryDeviceOriginalPropertyStatusResponseBody : TeaModel {
        /// <summary>
        /// The error code returned if the call fails. For more information, see [Error codes](~~87387~~).
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// The data returned if the call succeeds. For more information, see the parameters of the List parameter.
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public QueryDeviceOriginalPropertyStatusResponseBodyData Data { get; set; }
        public class QueryDeviceOriginalPropertyStatusResponseBodyData : TeaModel {
            /// <summary>
            /// The array of property information. The information about each property is indicated by the **PropertyStatusInfo** parameter.
            /// </summary>
            [NameInMap("List")]
            [Validation(Required=false)]
            public QueryDeviceOriginalPropertyStatusResponseBodyDataList List { get; set; }
            public class QueryDeviceOriginalPropertyStatusResponseBodyDataList : TeaModel {
                [NameInMap("PropertyStatusDataInfo")]
                [Validation(Required=false)]
                public List<QueryDeviceOriginalPropertyStatusResponseBodyDataListPropertyStatusDataInfo> PropertyStatusDataInfo { get; set; }
                public class QueryDeviceOriginalPropertyStatusResponseBodyDataListPropertyStatusDataInfo : TeaModel {
                    /// <summary>
                    /// The identifier of the property.
                    /// </summary>
                    [NameInMap("Identifier")]
                    [Validation(Required=false)]
                    public string Identifier { get; set; }

                    /// <summary>
                    /// The time when the property was modified, in milliseconds.
                    /// </summary>
                    [NameInMap("Time")]
                    [Validation(Required=false)]
                    public long? Time { get; set; }

                    /// <summary>
                    /// The value of the property.
                    /// </summary>
                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public string Value { get; set; }

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
            /// If the value ******true** is returned, you can add the value of the **NextPageToken** parameter**** to the next query. This allows you to query the data that is not returned by the current query.
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
