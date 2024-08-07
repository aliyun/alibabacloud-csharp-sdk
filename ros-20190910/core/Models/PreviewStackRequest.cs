// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ROS20190910.Models
{
    public class PreviewStackRequest : TeaModel {
        /// <summary>
        /// The client token that is used to ensure the idempotence of the request. You can use the client to generate the token, but you must make sure that the token is unique among different requests.\\
        /// The token can be up to 64 characters in length, and can contain letters, digits, underscores (_), and hyphens (-).\\
        /// For more information, see [Ensure idempotence](https://help.aliyun.com/document_detail/134212.html).
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// Specifies whether to disable rollback for the resources when the stack fails to be created. Valid values:
        /// 
        /// *   true
        /// *   false (default)
        /// </summary>
        [NameInMap("DisableRollback")]
        [Validation(Required=false)]
        public bool? DisableRollback { get; set; }

        /// <summary>
        /// Specifies whether to query the parameters that you want to use in compliance precheck.
        /// 
        /// Valid values:
        /// 
        /// *   true
        /// *   false (default)
        /// </summary>
        [NameInMap("EnablePreConfig")]
        [Validation(Required=false)]
        public bool? EnablePreConfig { get; set; }

        /// <summary>
        /// The maximum number of concurrent operations that can be performed on resources. This parameter takes effect only for Terraform stacks.
        /// 
        /// By default, this parameter is empty. You can set this parameter to an integer that is greater than or equal to 0.
        /// 
        /// > If you set this parameter to an integer greater than 0, the integer is used. If you set this parameter to 0 or leave this parameter empty, the default value of Terraform is used. In most cases, the default value of Terraform is 10.
        /// </summary>
        [NameInMap("Parallelism")]
        [Validation(Required=false)]
        public long? Parallelism { get; set; }

        /// <summary>
        /// The parameters of the stack.
        /// </summary>
        [NameInMap("Parameters")]
        [Validation(Required=false)]
        public List<PreviewStackRequestParameters> Parameters { get; set; }
        public class PreviewStackRequestParameters : TeaModel {
            /// <summary>
            /// The name of the parameter N. If you do not specify the name and value of a parameter, Resource Orchestration Service (ROS) uses the default name and value that are specified in the template. Maximum value of N: 200.
            /// 
            /// > If you specify Parameters, you must specify Parameters.N.ParameterKey.
            /// 
            /// This parameter is required.
            /// </summary>
            [NameInMap("ParameterKey")]
            [Validation(Required=false)]
            public string ParameterKey { get; set; }

            /// <summary>
            /// The value of parameter N. Maximum value of N: 200.
            /// 
            /// > If you specify Parameters, you must specify Parameters.N.ParameterValue.
            /// 
            /// This parameter is required.
            /// </summary>
            [NameInMap("ParameterValue")]
            [Validation(Required=false)]
            public string ParameterValue { get; set; }

        }

        /// <summary>
        /// The region ID of the stack. You can call the [DescribeRegions](https://help.aliyun.com/document_detail/131035.html) operation to query the most recent region list.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// The stack ID. You can use this parameter to preview a stack that you want to update.
        /// 
        /// 
        /// 
        /// > -  You must and can specify only one of StackName and StackId.
        /// > - In the scenario in which you preview a stack that you want to create or update, you cannot preview the resources in its nested stacks.
        /// </summary>
        [NameInMap("StackId")]
        [Validation(Required=false)]
        public string StackId { get; set; }

        /// <summary>
        /// The stack name. You can use this parameter to preview the stack that you want to create. The name can be up to 255 characters in length, and can contain digits, letters, hyphens (-), and underscores (_). It must start with a digit or letter.
        /// 
        /// > You must and can specify only one of StackName and StackId.
        /// </summary>
        [NameInMap("StackName")]
        [Validation(Required=false)]
        public string StackName { get; set; }

        /// <summary>
        /// The structure that contains the stack policy body. The stack policy body must be 1 to 16,384 bytes in length.
        /// 
        /// > You can specify only one of StackPolicyBody and StackPolicyURL.
        /// </summary>
        [NameInMap("StackPolicyBody")]
        [Validation(Required=false)]
        public string StackPolicyBody { get; set; }

        /// <summary>
        /// The URL of the file that contains the stack policy. The URL must point to a policy that is located on an HTTP or HTTPS web server or in an Object Storage Service (OSS) bucket, such as oss://ros/stack-policy/demo or oss://ros/stack-policy/demo?RegionId=cn-hangzhou. The policy file can be up to 16,384 bytes in length. If you do not specify the region ID of the OSS bucket, the value of RegionId is used.
        /// 
        /// > You can specify only one of StackPolicyBody and StackPolicyURL.
        /// 
        /// The URL can be up to 1,350 bytes in length.
        /// </summary>
        [NameInMap("StackPolicyURL")]
        [Validation(Required=false)]
        public string StackPolicyURL { get; set; }

        [NameInMap("TemplateBody")]
        [Validation(Required=false)]
        public string TemplateBody { get; set; }

        /// <summary>
        /// The template ID. This parameter applies to shared and private templates.
        /// 
        /// > You must and can specify only one of the following parameters: TemplateBody, TemplateURL, TemplateId, and TemplateScratchId.
        /// </summary>
        [NameInMap("TemplateId")]
        [Validation(Required=false)]
        public string TemplateId { get; set; }

        /// <summary>
        /// The scenario ID.
        /// 
        /// For more information about how to query the scenario ID, see [ListTemplateScratches](https://help.aliyun.com/document_detail/363050.html).
        /// 
        /// > You must and can specify only one of the following parameters: TemplateBody, TemplateURL, TemplateId, and TemplateScratchId.
        /// </summary>
        [NameInMap("TemplateScratchId")]
        [Validation(Required=false)]
        public string TemplateScratchId { get; set; }

        /// <summary>
        /// The region ID of the scenario. The default value is the same as the value of RegionId.
        /// 
        /// You can call the [DescribeRegions](https://help.aliyun.com/document_detail/131035.html) operation to query the most recent region list.
        /// </summary>
        [NameInMap("TemplateScratchRegionId")]
        [Validation(Required=false)]
        public string TemplateScratchRegionId { get; set; }

        /// <summary>
        /// The URL of the file that contains the template body. The URL must point to a template that is located on an HTTP or HTTPS web server or in an OSS bucket, such as oss://ros/template/demo or oss://ros/template/demo?RegionId=cn-hangzhou. The template body can be up to 524,288 bytes in length. If you do not specify the region ID of the OSS bucket, the value of RegionId is used.
        /// 
        /// > You must and can specify only one of the following parameters: TemplateBody, TemplateURL, TemplateId, and TemplateScratchId.
        /// </summary>
        [NameInMap("TemplateURL")]
        [Validation(Required=false)]
        public string TemplateURL { get; set; }

        /// <summary>
        /// The version of the template. This parameter takes effect only when TemplateId is specified.
        /// </summary>
        [NameInMap("TemplateVersion")]
        [Validation(Required=false)]
        public string TemplateVersion { get; set; }

        /// <summary>
        /// The timeout period for creating the stack.
        /// 
        /// Unit: minutes.
        /// 
        /// Default value: 60.
        /// </summary>
        [NameInMap("TimeoutInMinutes")]
        [Validation(Required=false)]
        public long? TimeoutInMinutes { get; set; }

    }

}
