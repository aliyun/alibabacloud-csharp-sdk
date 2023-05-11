// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Iot20180120.Models
{
    public class QueryPageByApplyIdResponseBody : TeaModel {
        /// <summary>
        /// The registered device list information returned if the call succeeds. The **ApplyDeviceInfo** parameter includes the details of the registered devices.
        /// </summary>
        [NameInMap("ApplyDeviceList")]
        [Validation(Required=false)]
        public QueryPageByApplyIdResponseBodyApplyDeviceList ApplyDeviceList { get; set; }
        public class QueryPageByApplyIdResponseBodyApplyDeviceList : TeaModel {
            [NameInMap("ApplyDeviceInfo")]
            [Validation(Required=false)]
            public List<QueryPageByApplyIdResponseBodyApplyDeviceListApplyDeviceInfo> ApplyDeviceInfo { get; set; }
            public class QueryPageByApplyIdResponseBodyApplyDeviceListApplyDeviceInfo : TeaModel {
                /// <summary>
                /// The ID of the device (expired).
                /// 
                /// >  This parameter is no longer used. Do not use this parameter to identify a device. You can use the **IotId** parameter or a combination of the **ProductKey** and **DeviceName** parameters to identify a device.
                /// </summary>
                [NameInMap("DeviceId")]
                [Validation(Required=false)]
                public string DeviceId { get; set; }

                /// <summary>
                /// The DeviceName of the device.
                /// </summary>
                [NameInMap("DeviceName")]
                [Validation(Required=false)]
                public string DeviceName { get; set; }

                /// <summary>
                /// The DeviceSecret of the device.
                /// </summary>
                [NameInMap("DeviceSecret")]
                [Validation(Required=false)]
                public string DeviceSecret { get; set; }

                /// <summary>
                /// The ID of the device. The ID is the unique identifier that is issued by IoT Platform to the device.
                /// </summary>
                [NameInMap("IotId")]
                [Validation(Required=false)]
                public string IotId { get; set; }

            }

        }

        /// <summary>
        /// The error code returned if the call fails. For more information, see [Error codes](/help/en/iot-platform/latest/bce100).
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// The error message returned if the call fails.
        /// </summary>
        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        /// <summary>
        /// The page number of the returned page.
        /// </summary>
        [NameInMap("Page")]
        [Validation(Required=false)]
        public int? Page { get; set; }

        /// <summary>
        /// The total number of pages.
        /// </summary>
        [NameInMap("PageCount")]
        [Validation(Required=false)]
        public int? PageCount { get; set; }

        /// <summary>
        /// The number of entries returned per page.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

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

        /// <summary>
        /// The total number of devices.
        /// </summary>
        [NameInMap("Total")]
        [Validation(Required=false)]
        public int? Total { get; set; }

    }

}
