// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Iot20180120.Models
{
    public class ListOTAModuleVersionsByDeviceResponseBody : TeaModel {
        /// <summary>
        /// The error code returned if the call fails. For more information, see [Error codes](~~87387~~).
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// The current page number.
        /// </summary>
        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public int? CurrentPage { get; set; }

        /// <summary>
        /// The module version information returned if the call is successful. The information was submitted by the device. For more information, see the **SimpleOTAModuleInfo** parameter in this table.
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public ListOTAModuleVersionsByDeviceResponseBodyData Data { get; set; }
        public class ListOTAModuleVersionsByDeviceResponseBodyData : TeaModel {
            [NameInMap("SimpleOTAModuleInfo")]
            [Validation(Required=false)]
            public List<ListOTAModuleVersionsByDeviceResponseBodyDataSimpleOTAModuleInfo> SimpleOTAModuleInfo { get; set; }
            public class ListOTAModuleVersionsByDeviceResponseBodyDataSimpleOTAModuleInfo : TeaModel {
                /// <summary>
                /// The DeviceName of the device.
                /// </summary>
                [NameInMap("DeviceName")]
                [Validation(Required=false)]
                public string DeviceName { get; set; }

                /// <summary>
                /// The ID of the device.
                /// </summary>
                [NameInMap("IotId")]
                [Validation(Required=false)]
                public string IotId { get; set; }

                /// <summary>
                /// The name of the OTA module.
                /// </summary>
                [NameInMap("ModuleName")]
                [Validation(Required=false)]
                public string ModuleName { get; set; }

                /// <summary>
                /// The module version that was submitted by the device.
                /// </summary>
                [NameInMap("ModuleVersion")]
                [Validation(Required=false)]
                public string ModuleVersion { get; set; }

                /// <summary>
                /// The **ProductKey** of the product to which the device belongs.
                /// </summary>
                [NameInMap("ProductKey")]
                [Validation(Required=false)]
                public string ProductKey { get; set; }

            }

        }

        /// <summary>
        /// The error message returned if the call fails.
        /// </summary>
        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        /// <summary>
        /// The total number of pages returned.
        /// </summary>
        [NameInMap("PageCount")]
        [Validation(Required=false)]
        public int? PageCount { get; set; }

        /// <summary>
        /// The number of module versions returned on each page.
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
        /// The total number of module versions that was submitted by the device.
        /// </summary>
        [NameInMap("Total")]
        [Validation(Required=false)]
        public int? Total { get; set; }

    }

}
