// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ROS20190910.Models
{
    public class ListStackOperationRisksRequest : TeaModel {
        /// <summary>
        /// The resource N that you want to retain in the stack.
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// Specifies whether to retain all resources in the stack.
        /// 
        /// Default value: false. Valid values:
        /// 
        /// *   true
        /// *   false
        /// 
        /// >  This parameter takes effect when the OperationType parameter is set to DeleteStack.
        /// </summary>
        [NameInMap("OperationType")]
        [Validation(Required=false)]
        public string OperationType { get; set; }

        /// <summary>
        /// The resource N that you want to retain in the stack.
        /// </summary>
        [NameInMap("RamRoleName")]
        [Validation(Required=false)]
        public string RamRoleName { get; set; }

        /// <summary>
        /// The client token that is used to ensure the idempotence of the request. You can use the client to generate the value, but you must make sure that the value is unique among different requests.
        /// 
        /// The token can be up to 64 characters in length, and can contain letters, digits, hyphens (-), and underscores (\_).
        /// 
        /// For more information, see [Ensure idempotence](~~134212~~).
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// The structure that contains the template body. The template body must be 1 to 524,288 bytes in length. If the length of the template body exceeds the upper limit, we recommend that you add parameters to the HTTP POST request body to prevent request failures caused by excessively long URLs.
        /// 
        /// >  You must specify only one of the following parameters: TemplateBody, TemplateURL, TemplateId, and TemplateScratchId.
        /// </summary>
        [NameInMap("RetainAllResources")]
        [Validation(Required=false)]
        public bool? RetainAllResources { get; set; }

        /// <summary>
        /// The URL of the file that contains the template body. The URL must point to a template that is located on an HTTP or HTTPS web server or in an Object Storage Service (OSS) bucket, such as oss://ros/stack-policy/demo or oss://ros/stack-policy/demo?RegionId=cn-hangzhou. The template body can be up to 524,288 bytes in length. If you do not specify the region ID of the OSS bucket, the value of the RegionId parameter is used.
        /// 
        /// >  You must specify only one of the following parameters: TemplateBody, TemplateURL, TemplateId, and TemplateScratchId.
        /// </summary>
        [NameInMap("RetainResources")]
        [Validation(Required=false)]
        public List<string> RetainResources { get; set; }

        /// <summary>
        /// The name of the RAM role.
        /// 
        /// *   If you specify a RAM role, ROS creates stacks based on the permissions that are granted to the RAM role and uses the credentials of the RAM role to call the API operations of Alibaba Cloud services.
        /// *   If you do not specify a RAM role, ROS creates stacks based on the permissions of your Alibaba Cloud account.
        /// 
        /// The name of the RAM role can be up to 64 bytes in length.
        /// </summary>
        [NameInMap("StackId")]
        [Validation(Required=false)]
        public string StackId { get; set; }

        /// <summary>
        /// The version of the template.
        /// 
        /// >  This parameter takes effect only when the TemplateId parameter is specified.
        /// </summary>
        [NameInMap("TemplateBody")]
        [Validation(Required=false)]
        public string TemplateBody { get; set; }

        /// <summary>
        /// The resources that are at risk.
        /// </summary>
        [NameInMap("TemplateId")]
        [Validation(Required=false)]
        public string TemplateId { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("TemplateURL")]
        [Validation(Required=false)]
        public string TemplateURL { get; set; }

        /// <summary>
        /// The logical ID of the resource. The logical ID is the resource name that is defined in the template.
        /// </summary>
        [NameInMap("TemplateVersion")]
        [Validation(Required=false)]
        public string TemplateVersion { get; set; }

    }

}
