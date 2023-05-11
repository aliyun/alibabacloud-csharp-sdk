// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Iot20180120.Models
{
    public class CreateSubscribeRelationRequest : TeaModel {
        [NameInMap("ConsumerGroupIds")]
        [Validation(Required=false)]
        public List<string> ConsumerGroupIds { get; set; }

        /// <summary>
        /// Specifies whether to push upstream device messages. Valid values:
        /// 
        /// *   **true**: yes.
        /// *   **false**: no. This is the default value.
        /// </summary>
        [NameInMap("DeviceDataFlag")]
        [Validation(Required=false)]
        public bool? DeviceDataFlag { get; set; }

        /// <summary>
        /// Specifies whether to push messages about device lifecycle changes. Valid values:
        /// 
        /// *   **true**: yes.
        /// *   **false**: no. This is the default value.
        /// </summary>
        [NameInMap("DeviceLifeCycleFlag")]
        [Validation(Required=false)]
        public bool? DeviceLifeCycleFlag { get; set; }

        /// <summary>
        /// Specifies whether to push messages about device status changes. Valid values:
        /// 
        /// *   **true**: yes.
        /// *   **false**: no. This is the default value.
        /// </summary>
        [NameInMap("DeviceStatusChangeFlag")]
        [Validation(Required=false)]
        public bool? DeviceStatusChangeFlag { get; set; }

        /// <summary>
        /// Specifies whether to push messages about device tag changes. Valid values:
        /// 
        /// *   **true**: yes. This parameter is valid only if you set the **Type** parameter to **AMQP**.
        /// *   **false**: no. This is the default value.
        /// </summary>
        [NameInMap("DeviceTagFlag")]
        [Validation(Required=false)]
        public bool? DeviceTagFlag { get; set; }

        /// <summary>
        /// Specifies whether to push messages about topological relationship changes of devices. Valid values:
        /// 
        /// *   **true**: yes. This parameter is valid only for gateway products.
        /// *   **false**: no. This is the default value.
        /// </summary>
        [NameInMap("DeviceTopoLifeCycleFlag")]
        [Validation(Required=false)]
        public bool? DeviceTopoLifeCycleFlag { get; set; }

        /// <summary>
        /// Specifies whether to push messages when a gateway detects new sub-devices. Valid values:
        /// 
        /// *   **true**: yes. This parameter is valid only for gateway products.
        /// *   **false**: no. This is the default value.
        /// </summary>
        [NameInMap("FoundDeviceListFlag")]
        [Validation(Required=false)]
        public bool? FoundDeviceListFlag { get; set; }

        /// <summary>
        /// The ID of the instance. You can view the ID of the instance on the **Overview** page in the IoT Platform console.
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
        /// The configurations of the MNS queue. If you set the **Type** parameter to **AMQP**, this parameter is required.
        /// 
        /// For more information, see the "Definition of the MnsConfiguration parameter" section.
        /// </summary>
        [NameInMap("MnsConfiguration")]
        [Validation(Required=false)]
        public string MnsConfiguration { get; set; }

        /// <summary>
        /// Specifies whether to push notifications about the status of over-the-air (OTA) update batches. Valid values:
        /// 
        /// *   **true**: yes.
        /// *   **false**: no. This is the default value.
        /// </summary>
        [NameInMap("OtaEventFlag")]
        [Validation(Required=false)]
        public bool? OtaEventFlag { get; set; }

        /// <summary>
        /// Specifies whether to push notifications about the status of OTA update batches. Valid values:
        /// 
        /// *   **true**: yes. This parameter is valid only if you set the **Type** parameter to **AMQP**.
        /// *   **false**: no. This is the default value.
        /// </summary>
        [NameInMap("OtaJobFlag")]
        [Validation(Required=false)]
        public bool? OtaJobFlag { get; set; }

        /// <summary>
        /// Specifies whether to push messages about the version numbers of OTA modules. Valid values:
        /// 
        /// *   **true**: yes. This parameter is valid only if you set the **Type** parameter to **AMQP**.
        /// *   **false**: no. This is the default value.
        /// </summary>
        [NameInMap("OtaVersionFlag")]
        [Validation(Required=false)]
        public bool? OtaVersionFlag { get; set; }

        /// <summary>
        /// The **ProductKey** of the product that is specified for the subscription.
        /// </summary>
        [NameInMap("ProductKey")]
        [Validation(Required=false)]
        public string ProductKey { get; set; }

        /// <summary>
        /// Specifies whether to receive the messages of a specific subscribed product.
        /// 
        /// If you subscribe to JT/T 808 gateway products, you must configure the **SubscribeFlags** parameter. Set the value to the following code.
        /// 
        /// ```
        /// 
        /// {
        ///     "jt808DeviceDataFlag": true
        /// }
        /// ```
        /// </summary>
        [NameInMap("SubscribeFlags")]
        [Validation(Required=false)]
        public string SubscribeFlags { get; set; }

        /// <summary>
        /// Specifies whether to push upstream historical Thing Specification Language (TSL) data. Valid values:
        /// 
        /// *   **true**: yes.
        /// *   **false**: no. This is the default value.
        /// </summary>
        [NameInMap("ThingHistoryFlag")]
        [Validation(Required=false)]
        public bool? ThingHistoryFlag { get; set; }

        /// <summary>
        /// The type of the subscription. Valid values:
        /// 
        /// *   **MNS**
        /// *   **AMQP**
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
