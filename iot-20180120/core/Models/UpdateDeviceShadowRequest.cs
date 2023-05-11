// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Iot20180120.Models
{
    public class UpdateDeviceShadowRequest : TeaModel {
        /// <summary>
        /// Specifies whether to perform an incremental update on the **desired** parameter. Valid values:
        /// 
        /// *   **true**: performs an incremental update.
        /// *   **false**: performs a full update. This is the default value.
        /// </summary>
        [NameInMap("DeltaUpdate")]
        [Validation(Required=false)]
        public bool? DeltaUpdate { get; set; }

        /// <summary>
        /// The name of the device whose shadow information you want to modify.
        /// </summary>
        [NameInMap("DeviceName")]
        [Validation(Required=false)]
        public string DeviceName { get; set; }

        /// <summary>
        /// The ID of the elastic container instance. You can view the ID of the instance on the **Overview** page in the IoT Platform console.****
        /// 
        /// >*   If your instance has an ID, you must specify the ID for this parameter. Otherwise, the call fails.****
        /// >*   If no **Overview** page or **ID** is generated for your instance, you do not need to configure this parameter.
        /// 
        /// For more information, see [Overview](~~356505~~).
        /// </summary>
        [NameInMap("IotInstanceId")]
        [Validation(Required=false)]
        public string IotInstanceId { get; set; }

        /// <summary>
        /// The ProductKey of the product to which the device belongs.
        /// </summary>
        [NameInMap("ProductKey")]
        [Validation(Required=false)]
        public string ProductKey { get; set; }

        /// <summary>
        /// The information that you want to specify for the device shadow.
        /// 
        /// The information includes the following parameters:
        /// 
        /// *   **method**: the type of the operation. Data type: string. Set the value to **update**.
        /// 
        /// *   **state**: the status of the device shadow. Data type: string. The **desired** parameter specifies the expected shadow status.
        /// 
        /// *   **version**: the version of the device shadow. Data type: long.
        /// 
        ///     *   If versioning is not required, set this parameter to 0.
        ///     *   If versioning is required, specify a version that is later than the current version.
        /// 
        /// **
        /// 
        /// **Important** If versioning is required, do not query the version of a device shadow in the IoT Platform console. If a large number of update and query operations are concurrently performed, multiple update operations may return the same version. In this case, the most recent update operation may first be completed. As a result, the current shadow information is not the latest shadow information. We recommend that you maintain the versions of device shadows on the on-premises device. When you call this operation, use an on-premises application to obtain the latest version of the device shadow.
        /// </summary>
        [NameInMap("ShadowMessage")]
        [Validation(Required=false)]
        public string ShadowMessage { get; set; }

    }

}
