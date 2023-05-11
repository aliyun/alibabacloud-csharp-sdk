// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Iot20180120.Models
{
    public class BatchRegisterDeviceWithApplyIdRequest : TeaModel {
        /// <summary>
        /// The ID of the application. The application ID is returned by the [BatchCheckDeviceNames](~~69482~~) operation.
        /// </summary>
        [NameInMap("ApplyId")]
        [Validation(Required=false)]
        public long? ApplyId { get; set; }

        /// <summary>
        /// The ID of the instance. You can view the **ID** of the instance on the **Overview** page in the IoT Platform console.
        /// 
        /// >*   If your instance has an ID, you must specify the ID for this parameter. Otherwise, the call fails.
        /// >*   If no **Overview** page or ID is generated for your instance, you do not need to configure this parameter.
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

    }

}
