// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Iot20180120.Models
{
    public class UpdateRuleRequest : TeaModel {
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
        /// The name of the rule. The rule name must be 1 to 30 characters in length, and can contain letters, digits, underscores (\_), and hyphens (-).
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// The **ProductKey** of the product to which the rule applies.
        /// </summary>
        [NameInMap("ProductKey")]
        [Validation(Required=false)]
        public string ProductKey { get; set; }

        /// <summary>
        /// The description of the rule. The description can be up to 100 characters in length.
        /// </summary>
        [NameInMap("RuleDesc")]
        [Validation(Required=false)]
        public string RuleDesc { get; set; }

        /// <summary>
        /// The ID of the rule that you want to modify. You can log on to the IoT Platform console and choose **Rules** > **Data Forwarding** to view the rule ID. You can also call the [ListRule](~~69486~~) operation and view the rule ID in the response.
        /// </summary>
        [NameInMap("RuleId")]
        [Validation(Required=false)]
        public long? RuleId { get; set; }

        /// <summary>
        /// The SQL SELECT statement to be executed. For more information, see [SQL expressions](~~30554~~).
        /// 
        /// >  Specify the content that follows the SELECT keyword for this parameter. For example, if the SELECT statement is `SELECT a,b,c`, specify `a,b,c` for this parameter.
        /// </summary>
        [NameInMap("Select")]
        [Validation(Required=false)]
        public string Select { get; set; }

        /// <summary>
        /// The topic to which this rule is applied. Syntax: `${deviceName}/topicShortName`. `${deviceName}` specifies the name of the device, and `topicShortName` specifies the custom name of the topic.
        /// 
        /// *   Basic communication topics or Thing Specification Language (TSL)-based communication topics. Syntax: `${deviceName}/topicShortName`. You can replace `${deviceName}` with the `+` wildcard. The wildcard indicates that the topic applies to all devices under the product. Valid values of `topicShortName`:
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
        ///     *   `/thing/event/property/history/post`: submits historical property data of a device.
        /// 
        ///     *   `/thing/event/${tsl.event.identifier}/post`: submits the historical event data of a device. `${tsl.event.identifier}` specifies the identifier of an event in the TSL.
        /// 
        ///     *   `/ota/upgrade`: submits OTA update statuses.
        /// 
        ///     *   `/ota/version/post`: submits OTA module versions.
        /// 
        ///     *   `/thing/deviceinfo/update`: submits device tag changes.
        /// 
        ///     *   `/edge/driver/${driver_id}/point_post`: submits pass-through data from Link IoT Edge. `${driver_id}` specifies the ID of the driver that a device uses to access Link IoT Edge.
        /// 
        ///         `${packageId}/${jobId}/ota/job/status`: submits the statuses of OTA update batches. This topic is a basic communication topic. `${packageId}` specifies the ID of the update package. `${jobId}` specifies the ID of the update batch.
        /// 
        /// *   Custom topics. Example: `${deviceName}/user/get`.
        /// 
        ///     You can call the [QueryProductTopic](~~69647~~) operation to view all custom topics of the product.
        /// 
        ///     When you specify a custom topic, you can use the `+` and `#` wildcards.
        /// 
        ///     *   You can replace `${deviceName}` with the `+` wildcard. The wildcard indicates that the topic applies to all devices under the product.
        /// 
        ///     *   You can replace the fields that follow ${deviceName} with `/user/#`. The `#` wildcard indicates that the topic applies whatever values are specified for the fields that follow`/user`.
        /// 
        ///         For more information about how to use wildcards, see [Wildcards in topics](~~85539~~).
        /// 
        /// *   Topic that is used to submit device status changes: `${deviceName}`.
        /// 
        ///     You can use the `+` wildcard. In this case, the status changes of all devices under the product are submitted.
        /// </summary>
        [NameInMap("ShortTopic")]
        [Validation(Required=false)]
        public string ShortTopic { get; set; }

        /// <summary>
        /// The complete topic to which the rule applies.
        /// 
        /// If you specify this parameter, you do not need to specify the **ProductKey**, **ShortTopic**, and **TopicType** parameters.
        /// </summary>
        [NameInMap("Topic")]
        [Validation(Required=false)]
        public string Topic { get; set; }

        /// <summary>
        /// *   **0**: The topic is a basic communication topic or TSL-based communication topic.****
        /// *   **1**: The topic is a custom topic.
        /// *   **2**: The topic is used to submit device status changes. Syntax: `/as/mqtt/status/${productKey}/${deviceName}`.
        /// </summary>
        [NameInMap("TopicType")]
        [Validation(Required=false)]
        public int? TopicType { get; set; }

        /// <summary>
        /// The condition that is used to trigger the rule. For more information, see [SQL expressions](~~30554~~).
        /// 
        /// >  Specify the content that follows the WHERE keyword for this parameter. For example, if the WHERE statement is `WHERE a>10`, specify `a>10` for this parameter.
        /// </summary>
        [NameInMap("Where")]
        [Validation(Required=false)]
        public string Where { get; set; }

    }

}
