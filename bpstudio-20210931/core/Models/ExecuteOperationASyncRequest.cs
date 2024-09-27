// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BPStudio20210931.Models
{
    public class ExecuteOperationASyncRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the Cloud Architect Design Tools (CADT) application.</para>
        /// 
        /// <b>Example:</b>
        /// <para>BG**********UQ</para>
        /// </summary>
        [NameInMap("ApplicationId")]
        [Validation(Required=false)]
        public string ApplicationId { get; set; }

        /// <summary>
        /// <para>The parameters related to the action. Specify the parameters based on the value of Operation. The parameters are passed in the map format. The following examples show how to specify the parameters if you want to change the specifications of an Elastic Compute Service (ECS) instance:</para>
        /// <list type="bullet">
        /// <item><description>The following common parameters are required: change_type, regionId, instanceId, appId</description></item>
        /// <item><description>Example values for changing the instance type of the ECS instance: { &quot;ServiceType&quot;: &quot;ecs&quot;, &quot;Operation&quot;: &quot;modifyInstanceType&quot;, &quot;Attributes&quot;: &quot;{&quot;change_type&quot;:&quot;modify_instance_type&quot;,&quot;instance_type&quot;:&quot;ecs.hfr7.2xlarge&quot;,&quot;instanceId&quot;:&quot;i-xxxxxxxxx&quot;,&quot;regionId&quot;:&quot;cn-beijing&quot;,&quot;appId&quot;:&quot;xxxxxxxxxxxxx&quot;}&quot; }</description></item>
        /// <item><description>Example values for stopping the ECS instance: { &quot;ServiceType&quot;: &quot;ecs&quot;, &quot;Operation&quot;: &quot;modifyInstanceType&quot;, &quot;Attributes&quot;: &quot;{&quot;change_type&quot;:&quot;modify_status&quot;,&quot;status&quot;:&quot;Stopped&quot;,&quot;instanceId&quot;:&quot;i-xxxxxxxxx&quot;,&quot;regionId&quot;:&quot;cn-beijing&quot;,&quot;appId&quot;:&quot;xxxxxxxxxxxxx&quot;}&quot; }</description></item>
        /// <item><description>Example values for starting the ECS instance: { &quot;ServiceType&quot;: &quot;ecs&quot;, &quot;Operation&quot;: &quot;modifyInstanceType&quot;, &quot;Attributes&quot;: &quot;{&quot;change_type&quot;:&quot;modify_status&quot;,&quot;status&quot;:&quot;Running&quot;,&quot;instanceId&quot;:&quot;i-xxxxxxxxx&quot;,&quot;regionId&quot;:&quot;cn-beijing&quot;,&quot;appId&quot;:&quot;xxxxxxxxxxxxx&quot;}&quot; }</description></item>
        /// <item><description>Example values for restarting the ECS instance: { &quot;ServiceType&quot;: &quot;ecs&quot;, &quot;Operation&quot;: &quot;modifyInstanceType&quot;, &quot;Attributes&quot;: &quot;{&quot;change_type&quot;:&quot;modify_status&quot;,&quot;status&quot;:&quot;Restart&quot;,&quot;instanceId&quot;:&quot;i-xxxxxxxxx&quot;,&quot;regionId&quot;:&quot;cn-beijing&quot;,&quot;appId&quot;:&quot;xxxxxxxxxxxxx&quot;}&quot; }</description></item>
        /// </list>
        /// <para>Example of enumerating more than one set of parameters:</para>
        /// <list type="bullet">
        /// <item><description><para>{ &quot;ServiceType&quot;: &quot;ecs&quot;, &quot;Operation&quot;: &quot;modifyInstanceType&quot;, &quot;Attributes&quot;: &quot;{\\&quot;change_type\\&quot;:\\&quot;modify_instance_type\\&quot;,\\&quot;instance_type\\&quot;:\\&quot;ecs.hfr7.2xlarge\\&quot;,\\&quot;instanceId\\&quot;:\\&quot;i-xxxxxxxxx\\&quot;,\\&quot;regionId\\&quot;:\\&quot;cn-beijing\\&quot;,\\&quot;appId\\&quot;:\\&quot;xxxxxxxxxxxxx\\&quot;}&quot; }</para>
        /// <!-- -->
        /// 
        /// <para>:</para>
        /// <!-- -->
        /// 
        /// <para>{ &quot;ServiceType&quot;: &quot;ecs&quot;, &quot;Operation&quot;: &quot;modifyInstanceType&quot;, &quot;Attributes&quot;: &quot;{\\&quot;change_type\\&quot;:\\&quot;modify_instance_type\\&quot;,\\&quot;instance_type\\&quot;:\\&quot;ecs.hfr7.2xlarge\\&quot;,\\&quot;instanceId\\&quot;:\\&quot;i-xxxxxxxxx\\&quot;,\\&quot;regionId\\&quot;:\\&quot;cn-beijing\\&quot;,\\&quot;appId\\&quot;:\\&quot;xxxxxxxxxxxxx\\&quot;}&quot; }</para>
        /// <!-- --></description></item>
        /// </list>
        /// </summary>
        [NameInMap("Attributes")]
        [Validation(Required=false)]
        public Dictionary<string, object> Attributes { get; set; }

        /// <summary>
        /// <para>The client token that is used to ensure the idempotence of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1600765710019</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>This operation type is the operation type of modifying the product, some operation types are generic, and some are used alone. The following is an example of ECS deployment:</para>
        /// <list type="bullet">
        /// <item><description>The name of the ECS: rename</description></item>
        /// <item><description>Specificationof ecs: modifyInstanceType</description></item>
        /// <item><description>Startup of ecs: modifyInstanceType</description></item>
        /// <item><description>Stop of ecs: modifyInstanceType</description></item>
        /// <item><description>Restart of ecs: modifyInstanceType</description></item>
        /// <item><description>Ecs Tag: addTags</description></item>
        /// <item><description>Deletion of ecs: ecsDelete</description></item>
        /// <item><description>Paid type for ecs: modifyPayType</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>queryTopo</para>
        /// </summary>
        [NameInMap("Operation")]
        [Validation(Required=false)]
        public string Operation { get; set; }

        /// <summary>
        /// <para>Resource group ID, which is used to verify the permissions of the resource group</para>
        /// 
        /// <b>Example:</b>
        /// <para>ceshi</para>
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// <para>The type of the service. If you want to perform operations on an Elastic Compute Service (ECS) instance, set ServiceType to ecs.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ACK</para>
        /// </summary>
        [NameInMap("ServiceType")]
        [Validation(Required=false)]
        public string ServiceType { get; set; }

    }

}
