// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Iot20180120.Models
{
    public class BatchGetDeviceStateRequest : TeaModel {
        [NameInMap("DeviceName")]
        [Validation(Required=false)]
        public List<string> DeviceName { get; set; }

        [NameInMap("IotId")]
        [Validation(Required=false)]
        public List<string> IotId { get; set; }

        /// <summary>
        /// The ID of the instance. You can view the ID of the instance on the **Overview** page in the IoT Platform console.
        /// 
        /// 
        /// >*   If your instance has an ID, you must specify the ID for this parameter. Otherwise, the call fails.
        /// >*   If no **Overview** page or **ID** is generated for your instance, you do not need to configure this parameter.
        /// 
        /// For more information, see [Overview](~~356505~~).
        /// </summary>
        [NameInMap("IotInstanceId")]
        [Validation(Required=false)]
        public string IotInstanceId { get; set; }

        /// <summary>
        /// The ProductKey of the product to which the device belongs.
        /// 
        /// 
        /// > If you configure this parameter, you must also specify a value for the **DeviceName** parameter.
        /// </summary>
        [NameInMap("ProductKey")]
        [Validation(Required=false)]
        public string ProductKey { get; set; }

    }

}
