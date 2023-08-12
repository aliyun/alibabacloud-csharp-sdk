// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ROS20190910.Models
{
    public class GetTemplateSummaryRequest : TeaModel {
        /// <summary>
        /// The ID of the change set.
        /// 
        /// You can specify only one of the following parameters: TemplateBody, TemplateURL, TemplateId, StackId, ChangeSetId, and StackGroupName.
        /// </summary>
        [NameInMap("ChangeSetId")]
        [Validation(Required=false)]
        public string ChangeSetId { get; set; }

        /// <summary>
        /// The client token that is used to ensure the idempotence of the request. You can use the client to generate the token, but you must make sure that the token is unique among different requests.\
        /// The token can be up to 64 characters in length, and can contain letters, digits, hyphens (-), and underscores (\_).\
        /// For more information, see [Ensure idempotence](~~134212~~).
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// The parameters that are defined in the template.
        /// </summary>
        [NameInMap("Parameters")]
        [Validation(Required=false)]
        public List<GetTemplateSummaryRequestParameters> Parameters { get; set; }
        public class GetTemplateSummaryRequestParameters : TeaModel {
            /// <summary>
            /// The name of parameter N that is defined in the template. If you do not specify the name and value of a parameter, Resource Orchestration Service (ROS) uses the default name and value that are defined in the template.
            /// 
            /// Maximum value of N: 200.
            /// 
            /// > The Parameters parameter is optional. If you specify Parameters, you must specify both Parameters.N.ParameterKey and Parameters.N.ParameterValue.
            /// </summary>
            [NameInMap("ParameterKey")]
            [Validation(Required=false)]
            public string ParameterKey { get; set; }

            /// <summary>
            /// The value of parameter N that is defined in the template.
            /// 
            /// Maximum value of N: 200.
            /// 
            /// > The Parameters parameter is optional. If you specify Parameters, you must specify both Parameters.N.ParameterKey and Parameters.N.ParameterValue.
            /// </summary>
            [NameInMap("ParameterValue")]
            [Validation(Required=false)]
            public string ParameterValue { get; set; }

        }

        /// <summary>
        /// The region ID of the stack or stack group that uses the template. You can call the [DescribeRegions](~~131035~~) operation to query the most recent region list.
        /// 
        /// This parameter takes effect only when one of the following parameters are specified: StackId, ChangeSetId, and StackGroupName.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// The name of the stack group.
        /// 
        /// You can specify only one of the following parameters: TemplateBody, TemplateURL, TemplateId, StackId, ChangeSetId, and StackGroupName.
        /// </summary>
        [NameInMap("StackGroupName")]
        [Validation(Required=false)]
        public string StackGroupName { get; set; }

        /// <summary>
        /// The stack ID.
        /// 
        /// You can specify only one of the following parameters: TemplateBody, TemplateURL, TemplateId, StackId, ChangeSetId, and StackGroupName.
        /// </summary>
        [NameInMap("StackId")]
        [Validation(Required=false)]
        public string StackId { get; set; }

        /// <summary>
        /// The structure that contains the template body. The template body must be 1 to 524,288 bytes in length.\
        /// If the length of the template body exceeds the upper limit, we recommend that you add parameters to the HTTP POST request body to prevent request failures caused by excessively long URLs.\
        /// You can specify only one of the following parameters: TemplateBody, TemplateURL, TemplateId, StackId, ChangeSetId, and StackGroupName.
        /// </summary>
        [NameInMap("TemplateBody")]
        [Validation(Required=false)]
        public string TemplateBody { get; set; }

        /// <summary>
        /// The template ID. This parameter applies to shared and private templates.
        /// 
        /// You can specify only one of the following parameters: TemplateBody, TemplateURL, TemplateId, StackId, ChangeSetId, and StackGroupName.
        /// </summary>
        [NameInMap("TemplateId")]
        [Validation(Required=false)]
        public string TemplateId { get; set; }

        /// <summary>
        /// The URL of the file that contains the template body. The URL must point to a template that is located on an HTTP or HTTPS web server or in an Object Storage Service (OSS) bucket, such as oss://ros/template/demo or oss://ros/template/demo?RegionId=cn-hangzhou. The template body can be up to 524,288 bytes in length.
        /// 
        /// > If you do not specify the region ID of the OSS bucket, the value of RegionId is used.
        /// 
        /// You can specify only one of the following parameters: TemplateBody, TemplateURL, TemplateId, StackId, ChangeSetId, and StackGroupName.
        /// 
        /// The URL can be up to 1,024 bytes in length.
        /// </summary>
        [NameInMap("TemplateURL")]
        [Validation(Required=false)]
        public string TemplateURL { get; set; }

        /// <summary>
        /// The version of the template. This parameter takes effect when TemplateId is specified.
        /// </summary>
        [NameInMap("TemplateVersion")]
        [Validation(Required=false)]
        public string TemplateVersion { get; set; }

    }

}
