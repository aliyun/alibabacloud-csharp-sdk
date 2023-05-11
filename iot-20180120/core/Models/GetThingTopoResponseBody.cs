// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Iot20180120.Models
{
    public class GetThingTopoResponseBody : TeaModel {
        /// <summary>
        /// The error code returned if the call fails. For more information, see [Error codes](~~87387~~).
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// The data returned if the call succeeds. For more information, see the following parameters.
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetThingTopoResponseBodyData Data { get; set; }
        public class GetThingTopoResponseBodyData : TeaModel {
            /// <summary>
            /// The page number of the returned page.
            /// </summary>
            [NameInMap("CurrentPage")]
            [Validation(Required=false)]
            public int? CurrentPage { get; set; }

            /// <summary>
            /// The details of the sub-device. The details of the sub-device are included in the **deviceInfo** parameter.
            /// </summary>
            [NameInMap("List")]
            [Validation(Required=false)]
            public GetThingTopoResponseBodyDataList List { get; set; }
            public class GetThingTopoResponseBodyDataList : TeaModel {
                [NameInMap("deviceInfo")]
                [Validation(Required=false)]
                public List<GetThingTopoResponseBodyDataListDeviceInfo> DeviceInfo { get; set; }
                public class GetThingTopoResponseBodyDataListDeviceInfo : TeaModel {
                    /// <summary>
                    /// The DeviceName of the sub-device.
                    /// </summary>
                    [NameInMap("DeviceName")]
                    [Validation(Required=false)]
                    public string DeviceName { get; set; }

                    /// <summary>
                    /// The ID of the sub-device. The ID is the unique identifier that is issued by IoT Platform to the sub-device.
                    /// </summary>
                    [NameInMap("IotId")]
                    [Validation(Required=false)]
                    public string IotId { get; set; }

                    /// <summary>
                    /// The ProductKey of the product to which the sub-device belongs.
                    /// </summary>
                    [NameInMap("ProductKey")]
                    [Validation(Required=false)]
                    public string ProductKey { get; set; }

                }

            }

            /// <summary>
            /// The total number of pages returned.
            /// </summary>
            [NameInMap("PageCount")]
            [Validation(Required=false)]
            public long? PageCount { get; set; }

            /// <summary>
            /// The number of entries returned on each page.
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            /// <summary>
            /// The total number of entries returned.
            /// </summary>
            [NameInMap("Total")]
            [Validation(Required=false)]
            public long? Total { get; set; }

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
        /// *   **true**: The call succeeds.
        /// *   **false**: The call failed.
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
