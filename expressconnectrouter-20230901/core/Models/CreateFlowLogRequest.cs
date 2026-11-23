// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ExpressConnectRouter20230901.Models
{
    public class CreateFlowLogRequest : TeaModel {
        /// <summary>
        /// <para>The client token that is used to ensure the idempotence of the request.</para>
        /// <para>You can generate a parameter value on your client to ensure that the value is unique across different requests. The client token can contain only ASCII characters.</para>
        /// <remarks>
        /// <para>If you do not specify this parameter, the system automatically uses the <b>RequestId</b> of the API request as the <b>ClientToken</b>. The <b>RequestId</b> of each API request is different.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>02fb3da4-130e-11e9-8e44-00****</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>The description of the flow log.</para>
        /// <remarks>
        /// <para>The description can be empty or 0 to 256 characters in length. It cannot start with http:// or https://.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>myFlowlog</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>Specifies whether the request is only a dry run. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>true</b>: Performs a dry run without modifying EPS resources.</para>
        /// </description></item>
        /// <item><description><para><b>false</b> (default): Sends a normal request.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("DryRun")]
        [Validation(Required=false)]
        public bool? DryRun { get; set; }

        /// <summary>
        /// <para>The instance ID of the Express Connect Router (ECR).</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ecr-mezk2idmsd0vx2****</para>
        /// </summary>
        [NameInMap("EcrId")]
        [Validation(Required=false)]
        public string EcrId { get; set; }

        /// <summary>
        /// <para>The name of the flow log.</para>
        /// <remarks>
        /// <para>The name can be empty or 0 to 128 characters in length. It cannot start with http:// or https://.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>myFlowlog</para>
        /// </summary>
        [NameInMap("FlowLogName")]
        [Validation(Required=false)]
        public string FlowLogName { get; set; }

        /// <summary>
        /// <para>The instance ID of the VBR.</para>
        /// <remarks>
        /// <para>The VBR instance must be created by calling the CreateVirtualBorderRouter operation of the Vpc/2016-04-28 API version. The prerequisite is that a physical connection exists.
        /// The VBR instance must be mounted as a child instance to the Express Connect Router (ECR) corresponding to EcrId by calling AttachExpressConnectRouterChildInstance, and the mount status must be ACTIVE before you can create a flow log. You can call DescribeExpressConnectRouterChildInstance to query the mount status of the child instance.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vbr-xxx</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The type of the network instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>VBR</b>: virtual border router (VBR) instance.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>VBR</para>
        /// </summary>
        [NameInMap("InstanceType")]
        [Validation(Required=false)]
        public string InstanceType { get; set; }

        /// <summary>
        /// <para>The duration of the capture window for traffic captured by the flow log. Unit: seconds. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>60</b> </description></item>
        /// <item><description><b>600</b></description></item>
        /// </list>
        /// <para>Default value: <b>600</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>60</para>
        /// </summary>
        [NameInMap("Interval")]
        [Validation(Required=false)]
        public int? Interval { get; set; }

        /// <summary>
        /// <para>The name of the Logstore used to store catch traffic.</para>
        /// <list type="bullet">
        /// <item><description><para>If you have already created a Logstore in the current region, you can enter the name of the existing Logstore.</para>
        /// </description></item>
        /// <item><description><para>If you have not created a Logstore in the current region, you can specify a custom name for the Logstore, and the system will automatically create the Logstore. The naming rules for the Logstore name are as follows:</para>
        /// </description></item>
        /// <item><description><para>The Logstore name must be unique within the same project.</para>
        /// </description></item>
        /// <item><description><para>It can contain only lowercase letters, digits, hyphens (-), and underscores (_).</para>
        /// </description></item>
        /// <item><description><para>It must start and end with a lowercase letter or a digit.</para>
        /// </description></item>
        /// <item><description><para>It must be 3 to 63 characters in length.</para>
        /// </description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>flowlog-logstore</para>
        /// </summary>
        [NameInMap("LogStoreName")]
        [Validation(Required=false)]
        public string LogStoreName { get; set; }

        /// <summary>
        /// <para>The name of the Simple Log Service project used to store catch traffic.</para>
        /// <list type="bullet">
        /// <item><description>If you have already created a project in the current region, you can enter the name of the existing project.</description></item>
        /// <item><description>If you have not created a project in the current region, you can specify a custom name for the project, and the system will automatically create the project.</description></item>
        /// </list>
        /// <para>The project name must be globally unique within an Alibaba Cloud region and cannot be modified after creation. The naming rules are as follows:</para>
        /// <list type="bullet">
        /// <item><description>The project name must be globally unique.</description></item>
        /// <item><description>It can contain only lowercase</description></item>
        /// <item><description>letters, digits, and hyphens (-).</description></item>
        /// <item><description>It must start and end with a lowercase letter or a digit.</description></item>
        /// <item><description>It must be 3 to 63 characters in length.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>flowlog-project</para>
        /// </summary>
        [NameInMap("ProjectName")]
        [Validation(Required=false)]
        public string ProjectName { get; set; }

        /// <summary>
        /// <para>The ID of the resource group to which the flow log instance belongs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg-aek2aq7f4va****</para>
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// <para>The sampling ratio. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>1:4096</b></description></item>
        /// <item><description><b>1:2048</b></description></item>
        /// <item><description><b>1:1024</b></description></item>
        /// </list>
        /// <para>Default value: <b>1:4096</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1:4096</para>
        /// </summary>
        [NameInMap("SamplingRate")]
        [Validation(Required=false)]
        public string SamplingRate { get; set; }

        /// <summary>
        /// <para>The tags.</para>
        /// <para>You can add up to 20 tags.</para>
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<CreateFlowLogRequestTag> Tag { get; set; }
        public class CreateFlowLogRequestTag : TeaModel {
            /// <summary>
            /// <para>The tag key of the resource. If you specify this parameter, it cannot be an empty string. It can be up to 128 characters in length, and cannot start with aliyun or acs:. It cannot contain http:// or https://.</para>
            /// 
            /// <b>Example:</b>
            /// <para>TestKey</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The tag value. Valid values of N: 1 to 20. If you specify this parameter, it can be an empty string. It can be up to 128 characters in length, and cannot start with acs:. It cannot contain http:// or https://.</para>
            /// 
            /// <b>Example:</b>
            /// <para>TestValue</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// <para>The region where the project to which logs are delivered resides. You only need to specify this parameter for cross-region log delivery. You do not need to specify this parameter for same-region log delivery.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("TargetSlsRegionId")]
        [Validation(Required=false)]
        public string TargetSlsRegionId { get; set; }

        [NameInMap("Version")]
        [Validation(Required=false)]
        public string Version { get; set; }

    }

}
