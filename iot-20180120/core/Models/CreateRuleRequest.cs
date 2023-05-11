// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Iot20180120.Models
{
    public class CreateRuleRequest : TeaModel {
        /// <summary>
        /// The format of the data that is processed based on the rule. The value of this parameter must be consistent with the format of device data that you want to process. Valid values:
        /// 
        /// *   **JSON**: JSON data. This is the default value.
        /// *   **BINARY**: binary data.
        /// 
        /// >  If this parameter is set to **BINARY**, you cannot set the **TopicType** parameter to 0 and cannot forward data to Tablestore and ApsaraDB RDS.
        /// </summary>
        [NameInMap("DataType")]
        [Validation(Required=false)]
        public string DataType { get; set; }

        /// <summary>
        /// The ID of the instance. On the **Overview** page in the IoT Platform console, you can view the **ID** of the instance.
        /// 
        /// >*   If your instance has an ID, you must specify the ID for this parameter. Otherwise, the call fails.
        /// >*   If the **Overview** page or instance ID is not displayed in the IoT Platform console, you do not need to configure this parameter.
        /// 
        /// For more information about the instance, see [Overview](~~356505~~).
        /// </summary>
        [NameInMap("IotInstanceId")]
        [Validation(Required=false)]
        public string IotInstanceId { get; set; }

        /// <summary>
        /// The name of the data forwarding rule. The rule name must be 1 to 30 characters in length, and can contain letters, digits, underscores (\_), and hyphens (-).
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// The ProductKey of the product to which the rule applies.
        /// </summary>
        [NameInMap("ProductKey")]
        [Validation(Required=false)]
        public string ProductKey { get; set; }

        /// <summary>
        /// The ID of the resource group to which the rule is assigned. You can view the resource group information in the [Resource Management console](https://resourcemanager.console.aliyun.com/resource-groups).
        /// 
        /// >You can specify a value for this parameter only if you have activated Resource Management.
        /// 
        /// If you do not specify this parameter, the rule is assigned to the default resource group.
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// The description of the rule. The description can be up to 100 characters in length.
        /// </summary>
        [NameInMap("RuleDesc")]
        [Validation(Required=false)]
        public string RuleDesc { get; set; }

        /// <summary>
        /// The SQL SELECT statement that you want to execute. For more information about the syntax, see [SQL statements](~~30554~~).
        /// 
        /// >  This parameter specifies the fields in SELECT statements. For example, if the SELECT statement is `SELECT a,b,c`, specify `a,b,c` for this parameter.
        /// </summary>
        [NameInMap("Select")]
        [Validation(Required=false)]
        public string Select { get; set; }

        /// <summary>
        /// The topic to which this rule is applied. Format: `${deviceName}/topicShortName`. `${deviceName}` specifies the name of the device, and `topicShortName` specifies the custom name of the topic.
        /// 
        /// *   Basic communication topics or Thing Specification Language (TSL)-based communication topics. Format: `${deviceName}/topicShortName`. You can replace `${deviceName}` with the `+` wildcard character. The wildcard character indicates that the topic applies to all devices under the product. Valid values of `topicShortName`:
        /// 
        ///     *   `/thing/event/property/post`: submits the property data of a device.
        /// 
        ///     *   `/thing/event/${tsl.event.identifier}/post`: submits the event data of a device. `${tsl.event.identifier}` specifies the identifier of an event in the TSL model.
        /// 
        ///     *   `/thing/lifecycle`: submits device lifecycle changes.
        /// 
        ///     *   `/thing/downlink/reply/message`: sends a response to a request from IoT Platform.
        /// 
        ///     *   `/thing/list/found`: submits the data when a gateway detects a new sub-device.
        /// 
        ///     *   `/thing/topo/lifecycle`: submits device topology changes.
        /// 
        ///     *   `/thing/event/property/history/post`: submits the historical property data of a device.
        /// 
        ///     *   `/thing/event/${tsl.event.identifier}/post`: submits the historical event data of a device. `${tsl.event.identifier}` specifies the identifier of an event in the TSL model.
        /// 
        ///     *   `/ota/upgrade`: submits the OTA update status.
        /// 
        ///     *   `/ota/version/post`: submits OTA module versions.
        /// 
        ///     *   `/thing/deviceinfo/update`: submits device tag changes.
        /// 
        ///     *   `/edge/driver/${driver_id}/point_post`: submits pass-through data from Link IoT Edge. `${driver_id}` specifies the ID of the driver that a device uses to access Link IoT Edge.
        /// 
        ///         The `${packageId}/${jobId}/ota/job/status` topic submits the status of OTA update batches. This topic is a basic communication topic. `${packageId}` specifies the ID of the update package. `${jobId}` specifies the ID of the update batch.
        /// 
        /// *   Custom topics. Example: `${deviceName}/user/get`.
        /// 
        ///     You can call the [QueryProductTopic](~~69647~~) operation to view all custom topics of the product.
        /// 
        ///     When you specify a custom topic, you can use the `+` and `#` wildcard characters.
        /// 
        ///     *   You can replace `${deviceName}` with the `+` wildcard character. The wildcard character specifies that the topic applies to all devices in the product.
        /// 
        ///     *   You can add `/user/#` after ${deviceName}. The `#` wildcard character can match all field values at the levels that follow `/user`.
        /// 
        ///         For more information about how to use wildcard characters, see [Custom topics with one or more wildcard characters](~~85539~~).
        /// 
        /// *   Topics that are used to submit device status changes. The topic name is in the `${deviceName}` format.
        /// 
        ///     You can use the `+` wildcard character. In this case, the status changes of all devices under the product are submitted.
        /// </summary>
        [NameInMap("ShortTopic")]
        [Validation(Required=false)]
        public string ShortTopic { get; set; }

        /// <summary>
        /// The complete topic to which the rule applies.
        /// 
        /// If you specify this parameter, you do not need to specify the **ShortTopic** and **TopicType** parameters.
        /// </summary>
        [NameInMap("Topic")]
        [Validation(Required=false)]
        public string Topic { get; set; }

        /// <summary>
        /// *   **0**: The topic is a basic communication topic or TSL-based communication topic. The topic that is used to submit the status of OTA update batches belongs to the basic communication topics.****
        /// *   **1**: a custom topic.
        /// *   **2**: The topic is used to submit device status changes. Format: `/as/mqtt/status/${productKey}/${deviceName}`.
        /// </summary>
        [NameInMap("TopicType")]
        [Validation(Required=false)]
        public int? TopicType { get; set; }

        /// <summary>
        /// The condition that is used to trigger the rule. For more information about the rule, see [SQL statements](~~30554~~).
        /// 
        /// >  This parameter specifies the fields in the **WHERE** clause. For example, if the **WHERE** clause is `WHERE a > 10`, you must specify `a > 10` for this parameter.
        /// </summary>
        [NameInMap("Where")]
        [Validation(Required=false)]
        public string Where { get; set; }

    }

}
