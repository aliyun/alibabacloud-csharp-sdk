// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Iot20180120.Models
{
    public class QueryImportedDeviceByApplyIdResponseBody : TeaModel {
        /// <summary>
        /// The error code returned if the request fails. For more information, see [Error codes](~~87387~~).
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// The queried devices.
        /// </summary>
        [NameInMap("DeviceList")]
        [Validation(Required=false)]
        public QueryImportedDeviceByApplyIdResponseBodyDeviceList DeviceList { get; set; }
        public class QueryImportedDeviceByApplyIdResponseBodyDeviceList : TeaModel {
            [NameInMap("device")]
            [Validation(Required=false)]
            public List<QueryImportedDeviceByApplyIdResponseBodyDeviceListDevice> Device { get; set; }
            public class QueryImportedDeviceByApplyIdResponseBodyDeviceListDevice : TeaModel {
                /// <summary>
                /// The DeviceName of the device.
                /// 
                /// >  Keep the information confidential.
                /// </summary>
                [NameInMap("DeviceName")]
                [Validation(Required=false)]
                public string DeviceName { get; set; }

                /// <summary>
                /// The DeviceSecret of the device.
                /// 
                /// >  Keep the information confidential.
                /// </summary>
                [NameInMap("DeviceSecret")]
                [Validation(Required=false)]
                public string DeviceSecret { get; set; }

                /// <summary>
                /// The **ProductKey** of the product to which the device belongs.
                /// </summary>
                [NameInMap("ProductKey")]
                [Validation(Required=false)]
                public string ProductKey { get; set; }

                /// <summary>
                /// The serial number (SN) of the device.
                /// 
                /// > If you did not specify an SN for the device, this parameter is empty.
                /// </summary>
                [NameInMap("Sn")]
                [Validation(Required=false)]
                public string Sn { get; set; }

            }

        }

        /// <summary>
        /// The error message returned if the request fails.
        /// </summary>
        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        /// <summary>
        /// The page number.
        /// </summary>
        [NameInMap("PageNo")]
        [Validation(Required=false)]
        public int? PageNo { get; set; }

        /// <summary>
        /// The number of entries per page.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// The **ProductKey** of the product to which the devices belong.
        /// </summary>
        [NameInMap("ProductKey")]
        [Validation(Required=false)]
        public string ProductKey { get; set; }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// Indicates whether the request was successful. Valid values:
        /// 
        /// *   **true**
        /// *   **false**
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// The total number of pages returned.
        /// </summary>
        [NameInMap("TotalPage")]
        [Validation(Required=false)]
        public int? TotalPage { get; set; }

    }

}
