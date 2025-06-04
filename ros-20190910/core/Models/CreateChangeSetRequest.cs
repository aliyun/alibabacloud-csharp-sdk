// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ROS20190910.Models
{
    public class CreateChangeSetRequest : TeaModel {
        /// <summary>
        /// <para>The name of the change set.\
        /// The name can be up to 255 characters in length and can contain digits, letters, hyphens (-), and underscores (_). The name must start with a digit or a letter.</para>
        /// <remarks>
        /// <para>Make sure that the name is unique among all names of change sets that are associated with the specified stack.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>MyChangeSet</para>
        /// </summary>
        [NameInMap("ChangeSetName")]
        [Validation(Required=false)]
        public string ChangeSetName { get; set; }

        /// <summary>
        /// <para>The type of the change set. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>CREATE: creates a change set for a new stack.</description></item>
        /// <item><description>UPDATE (default): creates a change set for an existing stack.</description></item>
        /// <item><description>IMPORT: creates a change set for a new stack or an existing stack to import resources that are not managed by ROS.</description></item>
        /// </list>
        /// <para>If you set ChangeSetType to CREATE, ROS creates a stack. The stack remains in the <c>REVIEW_IN_PROGRESS</c> state until you execute the change set.</para>
        /// <remarks>
        /// </remarks>
        /// <list type="bullet">
        /// <item><description><para>You cannot set ChangeSetType to UPDATE when you create a change set for a new stack. You cannot set ChangeSetType to CREATE when you create a change set for an existing stack.</para>
        /// </description></item>
        /// <item><description><para>If you set ChangeSetType to Import, you cannot configure a stack policy. You can specify ChangeSetType only when you create or update a stack.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>UPDATE</para>
        /// </summary>
        [NameInMap("ChangeSetType")]
        [Validation(Required=false)]
        public string ChangeSetType { get; set; }

        /// <summary>
        /// <para>The client token that is used to ensure the idempotence of the request. You can use the client to generate the value, but you must make sure that the value is unique among different requests.\
        /// The token can contain letters, digits, hyphens (-), and underscores (_) and cannot exceed 64 characters in length.\
        /// For more information, see <a href="https://help.aliyun.com/document_detail/134212.html">How to ensure idempotence</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123e4567-e89b-12d3-a456-42665544****</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>The description of the change set. The description can be up to 1,024 bytes in length.</para>
        /// 
        /// <b>Example:</b>
        /// <para>It is a demo.</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>Specifies whether to disable rollback when the stack fails to be created.\
        /// Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: disables rollback for the stack when the stack fails to be created.</description></item>
        /// <item><description>false (default): enables rollback for the stack when the stack fails to be created.</description></item>
        /// </list>
        /// <remarks>
        /// <para>This parameter takes effect only if you set ChangeSetType to CREATE or IMPORT.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("DisableRollback")]
        [Validation(Required=false)]
        public bool? DisableRollback { get; set; }

        /// <summary>
        /// <para>The callback URLs that are used to receive stack events.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="http://my-site.com/ros-notify">http://my-site.com/ros-notify</a></para>
        /// </summary>
        [NameInMap("NotificationURLs")]
        [Validation(Required=false)]
        public List<string> NotificationURLs { get; set; }

        /// <summary>
        /// <para>The maximum number of concurrent operations that can be performed on resources. By default, this parameter is empty. You can set this parameter to an integer that is greater than or equal to 0. If you set this parameter to a specific value, ROS associates the value with the stack. The value can affect subsequent operations on the stack.</para>
        /// <para>This parameter takes effect only if you set ChangeSetType to CREATE or UPDATE.</para>
        /// <list type="bullet">
        /// <item><description><para>Valid values for change sets of the CREATE type:</para>
        /// <list type="bullet">
        /// <item><description>If you set this parameter to an integer that is greater than 0, the integer is used.</description></item>
        /// <item><description>If you set this parameter to 0 or leave this parameter empty, no limit is imposed on ROS stacks. However, the default value in Terraform is used for Terraform stacks. In most cases, the default value in Terraform is 10.</description></item>
        /// </list>
        /// </description></item>
        /// <item><description><para>Valid values for change sets of the UPDATE type:</para>
        /// <list type="bullet">
        /// <item><description>If you set this parameter to an integer that is greater than 0, the integer is used.</description></item>
        /// <item><description>If you set this parameter to 0, no limit is imposed on ROS stacks. However, the default value in Terraform is used for Terraform stacks. In most cases, the default value in Terraform is 10.</description></item>
        /// <item><description>If you leave this parameter empty, the value that you specified for this parameter in the previous request is used. If you left this parameter empty in the previous request, no limit is imposed on ROS stacks. However, the default value in Terraform is used for Terraform stacks. In most cases, the default value in Terraform is 10.</description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Parallelism")]
        [Validation(Required=false)]
        public long? Parallelism { get; set; }

        /// <summary>
        /// <para>The parameters that are defined in the template.</para>
        /// </summary>
        [NameInMap("Parameters")]
        [Validation(Required=false)]
        public List<CreateChangeSetRequestParameters> Parameters { get; set; }
        public class CreateChangeSetRequestParameters : TeaModel {
            /// <summary>
            /// <para>The key of parameter N that is defined in the template. If you do not specify the key and value of a parameter, ROS uses the default name and value that are defined in the template. Maximum value of N: 200.</para>
            /// <remarks>
            /// <para> Parameters is optional. If you specify Parameters, you must also specify Parameters.N.ParameterKey.</para>
            /// </remarks>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Amount</para>
            /// </summary>
            [NameInMap("ParameterKey")]
            [Validation(Required=false)]
            public string ParameterKey { get; set; }

            /// <summary>
            /// <para>The value of parameter N that is defined in the template. Maximum value of N: 200.</para>
            /// <remarks>
            /// <para> Parameters is optional. If you specify Parameters, you must also specify Parameters.N.ParameterValue.</para>
            /// </remarks>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>12</para>
            /// </summary>
            [NameInMap("ParameterValue")]
            [Validation(Required=false)]
            public string ParameterValue { get; set; }

        }

        /// <summary>
        /// <para>The name of the Resource Access Management (RAM) role. ROS assumes the RAM role to create the stack and uses the credentials of the role to call the APIs of Alibaba Cloud services.\
        /// ROS assumes the RAM role to perform operations on the stack. If you have permissions to perform operations on the stack, ROS assumes the RAM role even if you do not have permissions to use the RAM role. You must make sure that permissions are granted to the RAM role based on the principle of least privilege.\
        /// If you do not specify this parameter, ROS assumes the existing role of the stack. If no roles are available, ROS uses a temporary credential that is generated from the credentials of your account.\
        /// The RAM role name can be up to 64 characters in length.</para>
        /// <para>For more information about RAM roles, see <a href="https://help.aliyun.com/document_detail/2568025.html">Use a stack role</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test-role</para>
        /// </summary>
        [NameInMap("RamRoleName")]
        [Validation(Required=false)]
        public string RamRoleName { get; set; }

        /// <summary>
        /// <para>The region ID of the change set.</para>
        /// <para>You can call the <a href="https://help.aliyun.com/document_detail/131035.html">DescribeRegions</a> operation to query the most recent region list.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable replacement update if a resource property is changed and you cannot modify the new resource property. For a change, the physical ID of the resource remains unchanged. For a replacement update, the existing resource is deleted, a new resource is created, and the physical ID of the resource is changed. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Enabled</description></item>
        /// <item><description>Disabled (default)</description></item>
        /// </list>
        /// <remarks>
        /// <para>Operations that you perform to modify the resource properties for an update take precedence over operations you perform to replace the resource properties for an update. This parameter takes effect only if you set ChangeSetType to UPDATE.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>Disabled</para>
        /// </summary>
        [NameInMap("ReplacementOption")]
        [Validation(Required=false)]
        public string ReplacementOption { get; set; }

        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// <para>The resources that you want to import to the stack.</para>
        /// </summary>
        [NameInMap("ResourcesToImport")]
        [Validation(Required=false)]
        public List<CreateChangeSetRequestResourcesToImport> ResourcesToImport { get; set; }
        public class CreateChangeSetRequestResourcesToImport : TeaModel {
            /// <summary>
            /// <para>The logical ID of resource N. The logical ID is the name of the resource defined in the template.</para>
            /// <remarks>
            /// <para> This parameter takes effect only when ChangeSetType is set to IMPORT. ResourcesToImport is optional. If you specify ResourcesToImport, you must specify ResourcesToImport.N.LogicalResourceId.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>Vpc</para>
            /// </summary>
            [NameInMap("LogicalResourceId")]
            [Validation(Required=false)]
            public string LogicalResourceId { get; set; }

            /// <summary>
            /// <para>The key-value mapping between strings. The key-value mapping is used to identify resource N that you want to import. The key-value mapping must be a JSON string.\
            /// A key is an identifier property of a resource and a value is the property value. For example, the key of the ALIYUN::ECS::VPC resource is VpcId and the value is <c>vpc-2zevx9ios****</c>.</para>
            /// <para>You can call the <a href="https://help.aliyun.com/document_detail/172485.html">GetTemplateSummary</a> operation to query the identifier property of the resource.</para>
            /// <remarks>
            /// <para> This parameter takes effect only when ChangeSetType is set to IMPORT. ResourcesToImport is optional. If you specify ResourcesToImport, you must specify ResourcesToImport.N.ResourceIdentifier.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>{&quot;VpcId&quot;: &quot;vpc-2zevx9ios******&quot;}</para>
            /// </summary>
            [NameInMap("ResourceIdentifier")]
            [Validation(Required=false)]
            public string ResourceIdentifier { get; set; }

            /// <summary>
            /// <para>The type of resource N. The resource type must be the same as the resource type that is defined in the template.</para>
            /// <remarks>
            /// <para> This parameter takes effect only when ChangeSetType is set to IMPORT. ResourcesToImport is optional. If you specify ResourcesToImport, you must specify ResourcesToImport.N.ResourceType.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>ALIYUN::ECS::VPC</para>
            /// </summary>
            [NameInMap("ResourceType")]
            [Validation(Required=false)]
            public string ResourceType { get; set; }

        }

        /// <summary>
        /// <para>The ID of the stack for which you want to create the change set. ROS compares the stack information with the information that you submit, such as an updated template or parameter value, to generate the change set.\
        /// You can call the <a href="https://help.aliyun.com/document_detail/610818.html">ListStacks</a> operation to query the stack ID.</para>
        /// <remarks>
        /// <para> This parameter takes effect only when ChangeSetType is set to UPDATE or IMPORT.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>4a6c9851-3b0f-4f5f-b4ca-a14bf691****</para>
        /// </summary>
        [NameInMap("StackId")]
        [Validation(Required=false)]
        public string StackId { get; set; }

        /// <summary>
        /// <para>The name of the stack for which you want to create the change set.\
        /// The name can be up to 255 characters in length and can contain digits, letters, hyphens (-), and underscores (_). The name must start with a digit or a letter.</para>
        /// <remarks>
        /// <para>This parameter takes effect only if you set ChangeSetType to CREATE or IMPORT.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>MyStack</para>
        /// </summary>
        [NameInMap("StackName")]
        [Validation(Required=false)]
        public string StackName { get; set; }

        /// <summary>
        /// <para>The structure that contains the stack policy body. The policy body must be 1 to 16,384 bytes in length.</para>
        /// <para>If you set ChangeSetType to <b>CREATE</b>, you can specify StackPolicyBody or StackPolicyURL.</para>
        /// <para>If you set ChangeSetType to <b>UPDATE</b>, you can specify only one of the following parameters:</para>
        /// <list type="bullet">
        /// <item><description>StackPolicyBody</description></item>
        /// <item><description>StackPolicyURL</description></item>
        /// <item><description>StackPolicyDuringUpdateBody</description></item>
        /// <item><description>StackPolicyDuringUpdateURL</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;Statement&quot;:[{&quot;Effect&quot;:&quot;Allow&quot;,&quot;Action&quot;:&quot;Update:<em>&quot;,&quot;Principal&quot;:&quot;</em>&quot;,&quot;Resource&quot;:&quot;*&quot;}]}</para>
        /// </summary>
        [NameInMap("StackPolicyBody")]
        [Validation(Required=false)]
        public string StackPolicyBody { get; set; }

        /// <summary>
        /// <para>The structure of the temporary overriding stack policy. The policy body must be 1 to 16,384 bytes in length.\
        /// If you need to update protected resources, specify a temporary overriding stack policy for the resources during the update. If you do not specify a temporary overriding stack policy, the existing stack policy that is associated with the stack is used.\
        /// This parameter takes effect only if you set ChangeSetType to UPDATE. You can specify only one of the following parameters:</para>
        /// <list type="bullet">
        /// <item><description>StackPolicyBody</description></item>
        /// <item><description>StackPolicyURL</description></item>
        /// <item><description>StackPolicyDuringUpdateBody</description></item>
        /// <item><description>StackPolicyDuringUpdateURL</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;Statement&quot;:[{&quot;Effect&quot;:&quot;Allow&quot;,&quot;Action&quot;:&quot;Update:<em>&quot;,&quot;Principal&quot;:&quot;</em>&quot;,&quot;Resource&quot;:&quot;*&quot;}]}</para>
        /// </summary>
        [NameInMap("StackPolicyDuringUpdateBody")]
        [Validation(Required=false)]
        public string StackPolicyDuringUpdateBody { get; set; }

        /// <summary>
        /// <para>The URL of the stack policy based on which the stack is updated. The URL must point to a policy that is located on an HTTP or HTTPS web server or in an OSS bucket, such as oss://ros/stack-policy/demo and oss://ros/stack-policy/demo?RegionId=cn-hangzhou. The policy file can be up to 16,384 bytes in length.</para>
        /// <remarks>
        /// <para>If you do not specify the region of the OSS bucket, the value of RegionId is used.</para>
        /// </remarks>
        /// <para>The URL can be up to 1,350 bytes in length.\
        /// If you need to update protected resources, specify a temporary overriding stack policy for the resources during the update. If you do not specify a stack policy, the existing policy that is associated with the stack is used. This parameter takes effect only if you set ChangeSetType to UPDATE. You can specify only one of the following parameters:</para>
        /// <list type="bullet">
        /// <item><description>StackPolicyBody</description></item>
        /// <item><description>StackPolicyURL</description></item>
        /// <item><description>StackPolicyDuringUpdateBody</description></item>
        /// <item><description>StackPolicyDuringUpdateURL</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>oss://ros/stack-policy/demo</para>
        /// </summary>
        [NameInMap("StackPolicyDuringUpdateURL")]
        [Validation(Required=false)]
        public string StackPolicyDuringUpdateURL { get; set; }

        /// <summary>
        /// <para>The URL of the file that contains the stack policy. The URL must point to a policy that is located on an HTTP or HTTPS web server or in an Object Storage Service (OSS) bucket, such as oss://ros/stack-policy/demo or oss://ros/stack-policy/demo?RegionId=cn-hangzhou. The policy file can be up to 16,384 bytes in length.</para>
        /// <para>The URL can be up to 1,350 bytes in length.</para>
        /// <remarks>
        /// <para> If you do not specify the region ID of the OSS bucket, the value of RegionId is used.</para>
        /// </remarks>
        /// <para>If you set ChangeSetType to <b>CREATE</b>, you can specify StackPolicyBody or StackPolicyURL.</para>
        /// <para>If you set ChangeSetType to <b>UPDATE</b>, you can specify only one of the following parameters:</para>
        /// <list type="bullet">
        /// <item><description>StackPolicyBody</description></item>
        /// <item><description>StackPolicyURL</description></item>
        /// <item><description>StackPolicyDuringUpdateBody</description></item>
        /// <item><description>StackPolicyDuringUpdateURL</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>oss://ros/stack-policy/demo</para>
        /// </summary>
        [NameInMap("StackPolicyURL")]
        [Validation(Required=false)]
        public string StackPolicyURL { get; set; }

        [NameInMap("Tags")]
        [Validation(Required=false)]
        public List<CreateChangeSetRequestTags> Tags { get; set; }
        public class CreateChangeSetRequestTags : TeaModel {
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        [NameInMap("TaintResources")]
        [Validation(Required=false)]
        public List<string> TaintResources { get; set; }

        [NameInMap("TemplateBody")]
        [Validation(Required=false)]
        public string TemplateBody { get; set; }

        /// <summary>
        /// <para>The template ID. This parameter applies to shared templates and private templates.</para>
        /// <para>You can call the <a href="https://help.aliyun.com/document_detail/610842.html">ListTemplates</a> operation to query the template ID.</para>
        /// <remarks>
        /// <para> You can specify only one of the following parameters: TemplateBody, TemplateURL, and TemplateId.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>5ecd1e10-b0e9-4389-a565-e4c15efc****</para>
        /// </summary>
        [NameInMap("TemplateId")]
        [Validation(Required=false)]
        public string TemplateId { get; set; }

        /// <summary>
        /// <para>The ID of the resource scenario. In this example, this parameter specifies the ID of a resource management scenario.</para>
        /// <para>This parameter takes effect only when ChangeSetType is set to IMPORT. TemplateScratchId is supported only when you import resources to create a new stack.</para>
        /// <para>If you want to use a resource management scenario to import resources, you can specify only TemplateScratchId rather than configuring parameters related to templates.</para>
        /// <para>You can call the <a href="https://help.aliyun.com/document_detail/610832.html">ListTemplateScratches</a> operation to query the ID of the resource management scenario.</para>
        /// 
        /// <b>Example:</b>
        /// <para>4a6c9851-3b0f-4f5f-b4ca-a14bf691****</para>
        /// </summary>
        [NameInMap("TemplateScratchId")]
        [Validation(Required=false)]
        public string TemplateScratchId { get; set; }

        /// <summary>
        /// <para>The URL of the file that contains the template body. The URL must point to a template that is located on an HTTP or HTTPS web server or in an OSS bucket, such as oss://ros/template/demo and oss://ros/template/demo?RegionId=cn-hangzhou. The template body can be up to 524,288 bytes in length.</para>
        /// <remarks>
        /// <para>If you do not specify the region of the OSS bucket, the value of RegionId is used.</para>
        /// </remarks>
        /// <para>You can specify only one of the following parameters: TemplateBody, TemplateURL, and TemplateId.</para>
        /// <para>The URL can be up to 1,024 bytes in length.</para>
        /// 
        /// <b>Example:</b>
        /// <para>oss://ros/template/demo</para>
        /// </summary>
        [NameInMap("TemplateURL")]
        [Validation(Required=false)]
        public string TemplateURL { get; set; }

        /// <summary>
        /// <para>The version of the template.</para>
        /// <remarks>
        /// <para>This parameter takes effect only if you specify TemplateId.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>v1</para>
        /// </summary>
        [NameInMap("TemplateVersion")]
        [Validation(Required=false)]
        public string TemplateVersion { get; set; }

        /// <summary>
        /// <para>The amount of time that can elapse before the stack enters the CREATE_FAILED or UPDATE_FAILED state.\
        /// If you set ChangeSetType to CREATE, this parameter is required. If you set ChangeSetType to UPDATE, this parameter is optional.</para>
        /// <list type="bullet">
        /// <item><description>Unit: minutes.</description></item>
        /// <item><description>Valid values: 10 to 1440.</description></item>
        /// <item><description>Default value: 60.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>12</para>
        /// </summary>
        [NameInMap("TimeoutInMinutes")]
        [Validation(Required=false)]
        public long? TimeoutInMinutes { get; set; }

        /// <summary>
        /// <para>Specifies whether to use the values that were passed last time for the parameters that you do not specify in the current request. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true</description></item>
        /// <item><description>false (default)</description></item>
        /// </list>
        /// <remarks>
        /// <para>This parameter takes effect only if you set ChangeSetType to UPDATE or IMPORT.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("UsePreviousParameters")]
        [Validation(Required=false)]
        public bool? UsePreviousParameters { get; set; }

    }

}
