// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BPStudio20210931.Models
{
    public class ExecuteOperationASyncRequest : TeaModel {
        /// <summary>
        /// The ID of the Cloud Architect Design Tools (CADT) application.
        /// </summary>
        [NameInMap("ApplicationId")]
        [Validation(Required=false)]
        public string ApplicationId { get; set; }

        /// <summary>
        /// The parameters related to the action. Specify the parameters based on the value of Operation. The parameters are passed in the map format. The following examples show how to specify the parameters if you want to change the specifications of an Elastic Compute Service (ECS) instance:
        /// 
        /// *   The following common parameters are required: change_type, regionId, instanceId, appId
        /// *   Example values for changing the instance type of the ECS instance: { "ServiceType": "ecs", "Operation": "modifyInstanceType", "Attributes": "{"change_type":"modify_instance_type","instance_type":"ecs.hfr7.2xlarge","instanceId":"i-xxxxxxxxx","regionId":"cn-beijing","appId":"xxxxxxxxxxxxx"}" }
        /// *   Example values for stopping the ECS instance: { "ServiceType": "ecs", "Operation": "modifyInstanceType", "Attributes": "{"change_type":"modify_status","status":"Stopped","instanceId":"i-xxxxxxxxx","regionId":"cn-beijing","appId":"xxxxxxxxxxxxx"}" }
        /// *   Example values for starting the ECS instance: { "ServiceType": "ecs", "Operation": "modifyInstanceType", "Attributes": "{"change_type":"modify_status","status":"Running","instanceId":"i-xxxxxxxxx","regionId":"cn-beijing","appId":"xxxxxxxxxxxxx"}" }
        /// *   Example values for restarting the ECS instance: { "ServiceType": "ecs", "Operation": "modifyInstanceType", "Attributes": "{"change_type":"modify_status","status":"Restart","instanceId":"i-xxxxxxxxx","regionId":"cn-beijing","appId":"xxxxxxxxxxxxx"}" }
        /// 
        /// Example of enumerating more than one set of parameters:
        /// 
        /// *   { "ServiceType": "ecs", "Operation": "modifyInstanceType", "Attributes": "{\\\\"change_type\\\\":\\\\"modify_instance_type\\\\",\\\\"instance_type\\\\":\\\\"ecs.hfr7.2xlarge\\\\",\\\\"instanceId\\\\":\\\\"i-xxxxxxxxx\\\\",\\\\"regionId\\\\":\\\\"cn-beijing\\\\",\\\\"appId\\\\":\\\\"xxxxxxxxxxxxx\\\\"}" }
        /// 
        ///     <!-- -->
        /// 
        ///     :
        /// 
        ///     <!-- -->
        /// 
        ///     { "ServiceType": "ecs", "Operation": "modifyInstanceType", "Attributes": "{\\\\"change_type\\\\":\\\\"modify_instance_type\\\\",\\\\"instance_type\\\\":\\\\"ecs.hfr7.2xlarge\\\\",\\\\"instanceId\\\\":\\\\"i-xxxxxxxxx\\\\",\\\\"regionId\\\\":\\\\"cn-beijing\\\\",\\\\"appId\\\\":\\\\"xxxxxxxxxxxxx\\\\"}" }
        /// 
        ///     <!-- -->
        /// </summary>
        [NameInMap("Attributes")]
        [Validation(Required=false)]
        public Dictionary<string, object> Attributes { get; set; }

        /// <summary>
        /// The client token that is used to ensure the idempotence of the request.
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// This operation type is the operation type of modifying the product, some operation types are generic, and some are used alone. The following is an example of ECS deployment:
        /// - The name of the ECS: rename
        /// - Specificationof ecs: modifyInstanceType
        /// - Startup of ecs: modifyInstanceType
        /// - Stop of ecs: modifyInstanceType
        /// - Restart of ecs: modifyInstanceType
        /// - Ecs Tag: addTags
        /// - Deletion of ecs: ecsDelete
        /// - Paid type for ecs: modifyPayType
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("Operation")]
        [Validation(Required=false)]
        public string Operation { get; set; }

        /// <summary>
        /// Resource group ID, which is used to verify the permissions of the resource group
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// The type of the service. If you want to perform operations on an Elastic Compute Service (ECS) instance, set ServiceType to ecs.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("ServiceType")]
        [Validation(Required=false)]
        public string ServiceType { get; set; }

    }

}
