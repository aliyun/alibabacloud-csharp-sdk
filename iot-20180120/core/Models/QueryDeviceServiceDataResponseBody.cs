// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Iot20180120.Models
{
    public class QueryDeviceServiceDataResponseBody : TeaModel {
        /// <summary>
        /// The error code that is returned if the call fails. For more information, see [Error codes](~~87387~~).
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// The service call records returned if the call is successful.
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public QueryDeviceServiceDataResponseBodyData Data { get; set; }
        public class QueryDeviceServiceDataResponseBodyData : TeaModel {
            /// <summary>
            /// The array of service call records. Each element represents a service call record.
            /// </summary>
            [NameInMap("List")]
            [Validation(Required=false)]
            public QueryDeviceServiceDataResponseBodyDataList List { get; set; }
            public class QueryDeviceServiceDataResponseBodyDataList : TeaModel {
                [NameInMap("ServiceInfo")]
                [Validation(Required=false)]
                public List<QueryDeviceServiceDataResponseBodyDataListServiceInfo> ServiceInfo { get; set; }
                public class QueryDeviceServiceDataResponseBodyDataListServiceInfo : TeaModel {
                    /// <summary>
                    /// The identifier of the service.
                    /// </summary>
                    [NameInMap("Identifier")]
                    [Validation(Required=false)]
                    public string Identifier { get; set; }

                    /// <summary>
                    /// The input parameter of the service. The value is a string in the MAP format. Syntax: `key:value`.
                    /// </summary>
                    [NameInMap("InputData")]
                    [Validation(Required=false)]
                    public string InputData { get; set; }

                    /// <summary>
                    /// The name of the service.
                    /// </summary>
                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    /// <summary>
                    /// The output parameter of the service. The value is a string in the MAP format. Syntax: `key:value`.
                    /// </summary>
                    [NameInMap("OutputData")]
                    [Validation(Required=false)]
                    public string OutputData { get; set; }

                    /// <summary>
                    /// The time when the service was called.
                    /// </summary>
                    [NameInMap("Time")]
                    [Validation(Required=false)]
                    public string Time { get; set; }

                }

            }

            /// <summary>
            /// The start time of service call records on the next page. 
            /// 
            /// If you call the QueryDeviceServiceData operation to query the service call records on the next page, you must set the **StartTime** parameter to the value of this parameter.
            /// </summary>
            [NameInMap("NextTime")]
            [Validation(Required=false)]
            public long? NextTime { get; set; }

            /// <summary>
            /// Indicates whether the next page exists.
            /// 
            /// *   **true**
            /// *   **false**
            /// 
            /// If the return value of the **NextValid** parameter is **true**, you can use the value of the **NextTime** parameter as the value of the **StartTime** parameter when you query the next page of results.
            /// </summary>
            [NameInMap("NextValid")]
            [Validation(Required=false)]
            public bool? NextValid { get; set; }

        }

        /// <summary>
        /// The error message that is returned if the call fails.
        /// </summary>
        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        /// <summary>
        /// The ID of the request. The ID uniquely identifies the request.
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
