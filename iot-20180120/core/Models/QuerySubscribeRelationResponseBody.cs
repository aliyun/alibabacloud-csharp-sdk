// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Iot20180120.Models
{
    public class QuerySubscribeRelationResponseBody : TeaModel {
        /// <summary>
        /// The error code returned if the call fails. For more information, see [Error codes](~~87387~~).
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// The IDs of the consumer groups that are created in the AMQP subscription. This parameter is returned if the **Type** parameter is set to **AMQP**.
        /// </summary>
        [NameInMap("ConsumerGroupIds")]
        [Validation(Required=false)]
        public List<string> ConsumerGroupIds { get; set; }

        /// <summary>
        /// Indicates whether upstream device messages were pushed.
        /// 
        /// *   **true**: yes.
        /// *   **false**: no.
        /// </summary>
        [NameInMap("DeviceDataFlag")]
        [Validation(Required=false)]
        public bool? DeviceDataFlag { get; set; }

        /// <summary>
        /// Indicates whether messages about device lifecycle changes were pushed.
        /// 
        /// *   **true**: yes.
        /// *   **false**: no.
        /// </summary>
        [NameInMap("DeviceLifeCycleFlag")]
        [Validation(Required=false)]
        public bool? DeviceLifeCycleFlag { get; set; }

        /// <summary>
        /// Indicates whether messages about device status changes were pushed.
        /// 
        /// *   **true**: yes.
        /// *   **false**: no.
        /// </summary>
        [NameInMap("DeviceStatusChangeFlag")]
        [Validation(Required=false)]
        public bool? DeviceStatusChangeFlag { get; set; }

        /// <summary>
        /// Indicates whether messages about device tag changes were pushed. Valid values:
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
        /// Indicates whether messages about topological relationship changes of devices were pushed.
        /// 
        /// *   **true**: yes. The value **true** is returned only when you query a gateway product.
        /// *   **false**: no.
        /// </summary>
        [NameInMap("DeviceTopoLifeCycleFlag")]
        [Validation(Required=false)]
        public bool? DeviceTopoLifeCycleFlag { get; set; }

        /// <summary>
        /// The error message returned if the call fails.
        /// </summary>
        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        /// <summary>
        /// Indicates whether messages were pushed if a gateway detected new sub-devices.
        /// 
        /// *   **true**: yes. The value **true** is returned only when you query a gateway product.
        /// *   **false**: no.
        /// </summary>
        [NameInMap("FoundDeviceListFlag")]
        [Validation(Required=false)]
        public bool? FoundDeviceListFlag { get; set; }

        /// <summary>
        /// The configurations of the MNS queue. This parameter is returned if the **Type** parameter is set to **MNS**.
        /// 
        /// For more information, see the "Definition of the MnsConfiguration parameter" section.
        /// </summary>
        [NameInMap("MnsConfiguration")]
        [Validation(Required=false)]
        public string MnsConfiguration { get; set; }

        /// <summary>
        /// Indicates whether notifications about the status of OTA update batches were pushed.
        /// 
        /// *   **true**: yes.
        /// *   **false**: no.
        /// </summary>
        [NameInMap("OtaEventFlag")]
        [Validation(Required=false)]
        public bool? OtaEventFlag { get; set; }

        /// <summary>
        /// Indicates whether notifications about OTA batch updates were pushed. Valid values:
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
        /// Indicates whether messages about the version numbers of OTA modules were pushed. Valid values:
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
        /// The ProductKey of the product that is specified for the subscription.
        /// </summary>
        [NameInMap("ProductKey")]
        [Validation(Required=false)]
        public string ProductKey { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("SubscribeFlags")]
        [Validation(Required=false)]
        public string SubscribeFlags { get; set; }

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
        /// Indicates whether upstream historical Thing Specification Language (TSL) data was pushed.
        /// 
        /// *   **true**: yes.
        /// *   **false**: no.
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
