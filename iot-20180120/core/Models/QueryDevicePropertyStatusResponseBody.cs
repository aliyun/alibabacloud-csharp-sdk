// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Iot20180120.Models
{
    public class QueryDevicePropertyStatusResponseBody : TeaModel {
        /// <summary>
        /// The error code returned if the call fails. For more information, see [Error codes](~~87387~~).
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// The data returned if the call succeeds. For more information, see **List**.
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public QueryDevicePropertyStatusResponseBodyData Data { get; set; }
        public class QueryDevicePropertyStatusResponseBodyData : TeaModel {
            /// <summary>
            /// The array of property information. The information about each property is indicated by the **PropertyStatusInfo** parameter.
            /// </summary>
            [NameInMap("List")]
            [Validation(Required=false)]
            public QueryDevicePropertyStatusResponseBodyDataList List { get; set; }
            public class QueryDevicePropertyStatusResponseBodyDataList : TeaModel {
                [NameInMap("PropertyStatusInfo")]
                [Validation(Required=false)]
                public List<QueryDevicePropertyStatusResponseBodyDataListPropertyStatusInfo> PropertyStatusInfo { get; set; }
                public class QueryDevicePropertyStatusResponseBodyDataListPropertyStatusInfo : TeaModel {
                    /// <summary>
                    /// The data type of the property. Valid values:
                    /// 
                    /// *   **int**: integer
                    /// *   **float**: single-precision floating-point number
                    /// *   **double**: double-precision floating-point number
                    /// *   **enum**: enumeration
                    /// *   **bool**: Boolean
                    /// *   **text**: character
                    /// *   **date**: time (string-type UTC timestamp in milliseconds)
                    /// *   **array**: array
                    /// *   **struct**: structure
                    /// </summary>
                    [NameInMap("DataType")]
                    [Validation(Required=false)]
                    public string DataType { get; set; }

                    /// <summary>
                    /// The identifier of the property.
                    /// </summary>
                    [NameInMap("Identifier")]
                    [Validation(Required=false)]
                    public string Identifier { get; set; }

                    /// <summary>
                    /// The name of the property.
                    /// </summary>
                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    /// <summary>
                    /// The time when the property was modified, in milliseconds.
                    /// </summary>
                    [NameInMap("Time")]
                    [Validation(Required=false)]
                    public string Time { get; set; }

                    /// <summary>
                    /// The unit of the property value.
                    /// </summary>
                    [NameInMap("Unit")]
                    [Validation(Required=false)]
                    public string Unit { get; set; }

                    /// <summary>
                    /// The value of the property.
                    /// </summary>
                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public string Value { get; set; }

                }

            }

        }

        /// <summary>
        /// The error message returned if the request fails.
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
