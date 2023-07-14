// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Iot20180120.Models
{
    public class CreateDataSourceItemRequest : TeaModel {
        [NameInMap("DataSourceId")]
        [Validation(Required=false)]
        public long? DataSourceId { get; set; }

        [NameInMap("DeviceName")]
        [Validation(Required=false)]
        public string DeviceName { get; set; }

        /// <summary>
        /// The instance ID. You can view the instance **ID** on the **Overview** page in the IoT Platform console.
        /// 
        /// >  If your instance has an ID, you must specify this parameter. Otherwise, the request fails. If no Overview page exists or no instance ID is displayed, you do not need to specify this parameter.
        /// 
        /// For more information, see the [Overview](~~356505~~) topic of IoT instances.
        /// </summary>
        [NameInMap("IotInstanceId")]
        [Validation(Required=false)]
        public string IotInstanceId { get; set; }

        [NameInMap("ProductKey")]
        [Validation(Required=false)]
        public string ProductKey { get; set; }

        [NameInMap("ScopeType")]
        [Validation(Required=false)]
        public string ScopeType { get; set; }

        /// <summary>
        /// The topic that you want to add to the data source in the rules engine. Format: `/${productKey}/${deviceName}/topicShortName`. `${productKey}` specifies the **ProductKey** of the product to which a device belongs. `${deviceName}` specifies the name of the device. `topicShortName` specifies the custom name of the topic.
        /// 
        /// *   Basic communication topics or Thing Specification Language (TSL) communication topics are in the `/${productKey}/${deviceName}/topicShortName` format. You can replace `${deviceName}` with the plus sign (`+`) wildcard character. The wildcard character specifies that the topic applies to all devices in the product. Valid values of `topicShortName`:
        /// 
        ///     *   `/thing/event/property/post`: submits the property data of a device.
        ///     *   `/thing/event/${tsl.event.identifier}/post`: submits the event data of a device. `${tsl.event.identifier}` specifies the identifier of an event in the TSL model.
        ///     *   `/thing/lifecycle`: submits device lifecycle changes.
        ///     *   `/thing/downlink/reply/message`: sends a response to a request from IoT Platform.
        ///     *   `/thing/list/found`: submits data when a gateway detects a new sub-device.
        ///     *   `/thing/topo/lifecycle`: submits device topology changes.
        ///     *   `/thing/event/property/history/post`: submits the historical property data of a device.
        ///     *   `/thing/event/${tsl.event.identifier}/post`: submits the historical event data of a device. `${tsl.event.identifier}` specifies the identifier of an event in the TSL model.
        ///     *   `/ota/upgrade`: submits the over-the-air (OTA) update status.
        ///     *   `/ota/version/post`: submits OTA module versions.
        ///     *   `/thing/deviceinfo/update`: submits device tag changes.
        /// 
        ///     `/${productKey}/${packageId}/${jobId}/ota/job/status`: submits the status of each OTA update batch. This topic is a basic communication topic. `${packageId}` specifies the ID of the update package. `${jobId}` specifies the ID of the update batch.
        /// 
        /// *   Custom topics are in the `/${productKey}/${deviceName}/user/#` format. Example: `/${productKey}/${deviceName}/user/get`.
        /// 
        ///     You can call the [QueryProductTopic](~~69647~~) operation to view all custom topics of a product.
        /// 
        ///     When you specify a custom topic, you can use the plus sign (`+`) and number sign (`#`) wildcard characters.
        /// 
        ///     *   You can replace `${deviceName}` with the plus sign (`+`) wildcard character. The wildcard character specifies that the topic applies to all devices in the product.
        ///     *   You can replace the fields that follow ${deviceName} with `/user/#`. The number sign (`#`) wildcard character specifies that the topic applies to all fields that follow `/user`.
        /// 
        /// *   Topics that are used to submit device status changes are in the `/as/mqtt/status/${productKey}/${deviceName}` format.
        /// 
        /// You can use the plus sign (`+`) wildcard character to specify that the status changes of all devices in the product are submitted.
        /// 
        /// For more information about how to use wildcard characters, see the "Custom topics with wildcard characters" section in [Use custom topics](~~85539~~).
        /// 
        /// For more information about the data formats of topics, see [Data formats](~~73736~~).
        /// 
        /// > You can add only the following topics to the data source in the rules engine for MQTT gateways, devices of MQTT gateways, and products and devices that use the open source MQTT protocol: custom topics, topics that are used to submit device status changes, and topics that are used to submit device lifecycle changes. For more information about custom topics, see the "Messaging" topic. If you set this parameter to a custom topic, you must specify ScopeType and ProductKey. If you set ScopeType to DEVICE, you must specify DeviceName.
        /// </summary>
        [NameInMap("Topic")]
        [Validation(Required=false)]
        public string Topic { get; set; }

    }

}
