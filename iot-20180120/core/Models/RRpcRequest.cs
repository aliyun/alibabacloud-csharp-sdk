// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Iot20180120.Models
{
    public class RRpcRequest : TeaModel {
        [NameInMap("ContentType")]
        [Validation(Required=false)]
        public string ContentType { get; set; }

        /// <summary>
        /// The name of the device that receives the request.
        /// </summary>
        [NameInMap("DeviceName")]
        [Validation(Required=false)]
        public string DeviceName { get; set; }

        /// <summary>
        /// The ID of the instance. You can view the instance **ID** on the **Overview** page in the IoT Platform console.
        /// 
        /// >*   If your instance has an ID, you must configure this parameter. If you do not set this parameter, the call fails.
        /// >*   If your instance has no **Overview** page or ID, you do not need to set this parameter.
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

        [NameInMap("RequestBase64Byte")]
        [Validation(Required=false)]
        public string RequestBase64Byte { get; set; }

        /// <summary>
        /// The timeout period of a response. Unit: milliseconds. Valid values: 1000 to 8000.
        /// </summary>
        [NameInMap("Timeout")]
        [Validation(Required=false)]
        public int? Timeout { get; set; }

        /// <summary>
        /// The custom revert-RPC (RRPC) topic. Before you can use a custom RRPC topic, you must configure the device. For more information, see [Use custom topics](~~90570~~).
        /// 
        /// If you do not configure this parameter, the default RRPC topic is used.
        /// </summary>
        [NameInMap("Topic")]
        [Validation(Required=false)]
        public string Topic { get; set; }

    }

}
