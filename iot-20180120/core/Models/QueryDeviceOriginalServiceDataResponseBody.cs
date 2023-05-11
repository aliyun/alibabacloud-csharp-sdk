// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Iot20180120.Models
{
    public class QueryDeviceOriginalServiceDataResponseBody : TeaModel {
        /// <summary>
        /// The error code returned if the call fails. For more information, see [Error codes](~~87387~~).
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// The service call records returned if the call succeeds.
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public QueryDeviceOriginalServiceDataResponseBodyData Data { get; set; }
        public class QueryDeviceOriginalServiceDataResponseBodyData : TeaModel {
            /// <summary>
            /// The array of service call records. Each element represents a service call record. For more information about the details of a service, see the parameters that belong to the **ServiceInfo** parameter.
            /// </summary>
            [NameInMap("List")]
            [Validation(Required=false)]
            public QueryDeviceOriginalServiceDataResponseBodyDataList List { get; set; }
            public class QueryDeviceOriginalServiceDataResponseBodyDataList : TeaModel {
                [NameInMap("ServiceInfo")]
                [Validation(Required=false)]
                public List<QueryDeviceOriginalServiceDataResponseBodyDataListServiceInfo> ServiceInfo { get; set; }
                public class QueryDeviceOriginalServiceDataResponseBodyDataListServiceInfo : TeaModel {
                    /// <summary>
                    /// The identifier of the service.
                    /// </summary>
                    [NameInMap("Identifier")]
                    [Validation(Required=false)]
                    public string Identifier { get; set; }

                    /// <summary>
                    /// The input parameter of the service. The value is a string in the MAP format. Syntax: key:value.
                    /// </summary>
                    [NameInMap("InputData")]
                    [Validation(Required=false)]
                    public string InputData { get; set; }

                    /// <summary>
                    /// The service name.
                    /// </summary>
                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    /// <summary>
                    /// The output parameter of the service. The value is a string in the MAP format. Syntax: key:value.
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
