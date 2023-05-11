// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Iot20180120.Models
{
    public class UpdateSubscribeRelationRequest : TeaModel {
        [NameInMap("ConsumerGroupIds")]
        [Validation(Required=false)]
        public List<string> ConsumerGroupIds { get; set; }

        /// <summary>
        /// Specifies whether to push upstream device messages. Valid values:
        /// 
        /// *   **true**: yes.
        /// *   **false**: no.
        /// 
        /// Default value: **false**.
        /// </summary>
        [NameInMap("DeviceDataFlag")]
        [Validation(Required=false)]
        public bool? DeviceDataFlag { get; set; }

        /// <summary>
        /// Specifies whether to push messages about device lifecycle changes. Valid values:
        /// 
        /// *   **true**: yes.
        /// *   **false**: no.
        /// 
        /// Default value: **false**.
        /// </summary>
        [NameInMap("DeviceLifeCycleFlag")]
        [Validation(Required=false)]
        public bool? DeviceLifeCycleFlag { get; set; }

        /// <summary>
        /// Specifies whether to push messages about device status changes. Valid values:
        /// 
        /// *   **true**: yes.
        /// *   **false**: no.
        /// 
        /// Default value: **false**.
        /// </summary>
        [NameInMap("DeviceStatusChangeFlag")]
        [Validation(Required=false)]
        public bool? DeviceStatusChangeFlag { get; set; }

        /// <summary>
        /// Specifies whether to push messages about topological relationship changes of devices. Valid values:
        /// 
        /// *   **true**: yes. This parameter takes effect only if the **Type** parameter is set to **AMQP**.
        /// *   **false**: no.
        /// 
        /// Default value: **false**.
        /// </summary>
        [NameInMap("DeviceTagFlag")]
        [Validation(Required=false)]
        public bool? DeviceTagFlag { get; set; }

        /// <summary>
        /// Specifies whether to push messages about topological relationship changes of devices. Valid values:
        /// 
        /// *   **true**: yes. This parameter is valid only for gateway products.
        /// *   **false**: no.
        /// 
        /// Default value: **false**.
        /// </summary>
        [NameInMap("DeviceTopoLifeCycleFlag")]
        [Validation(Required=false)]
        public bool? DeviceTopoLifeCycleFlag { get; set; }

        /// <summary>
        /// Specifies whether to push messages if a gateway detects new sub-devices. Valid values:
        /// 
        /// *   **true**: yes. This parameter is valid only for gateway products.
        /// *   **false**: no.
        /// 
        /// Default value: **false**.
        /// </summary>
        [NameInMap("FoundDeviceListFlag")]
        [Validation(Required=false)]
        public bool? FoundDeviceListFlag { get; set; }

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
        /// The configurations of the MNS queue. This parameter is required if the **Type** parameter is set to **AMQP**.
        /// 
        /// For more information, see the "Definition of the MnsConfiguration parameter" section.
        /// </summary>
        [NameInMap("MnsConfiguration")]
        [Validation(Required=false)]
        public string MnsConfiguration { get; set; }

        /// <summary>
        /// Specifies whether to push notifications about the status of OTA update batches. Valid values:
        /// 
        /// *   **true**: yes.
        /// *   **false**: no.
        /// 
        /// Default value: **false**.
        /// </summary>
        [NameInMap("OtaEventFlag")]
        [Validation(Required=false)]
        public bool? OtaEventFlag { get; set; }

        /// <summary>
        /// Specifies whether to push notifications about the statuses of OTA update batches. Valid values:
        /// 
        /// *   **true**: yes. This parameter takes effect only if the **Type** parameter is set to **AMQP**.
        /// *   **false**: no.
        /// 
        /// Default value: **false**.
        /// </summary>
        [NameInMap("OtaJobFlag")]
        [Validation(Required=false)]
        public bool? OtaJobFlag { get; set; }

        /// <summary>
        /// Specifies whether to push messages about OTA module version numbers. Valid values:
        /// 
        /// *   **true**: yes. This parameter takes effect only if the **Type** parameter is set to **AMQP**.
        /// *   **false**: no.
        /// 
        /// Default value: **false**.
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

        [NameInMap("SubscribeFlags")]
        [Validation(Required=false)]
        public string SubscribeFlags { get; set; }

        /// <summary>
        /// Specifies whether to push upstream historical Thing Specification Language (TSL) data. Valid values:
        /// 
        /// *   **true**: yes.
        /// *   **false**: no.
        /// 
        /// Default value: **false**.
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
