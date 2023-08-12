// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ROS20190910.Models
{
    public class CreateTemplateRequest : TeaModel {
        /// <summary>
        /// The description of the template. The description can be up to 256 characters in length.
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// The ID of the resource group.\
        /// For more information about resource groups, see [Resource groups](~~94475~~).
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// The tags of the template.
        /// </summary>
        [NameInMap("Tags")]
        [Validation(Required=false)]
        public List<CreateTemplateRequestTags> Tags { get; set; }
        public class CreateTemplateRequestTags : TeaModel {
            /// <summary>
            /// The tag key of the template.
            /// 
            /// > Tags is optional. If you need to specify Tags, you must also specify Key.
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// The tag value of the template.
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// The structure of the template body. The template body must be 1 to 524,288 bytes in length. If the length of the template body exceeds the upper limit, we recommend that you add parameters to the HTTP POST request body to prevent request failures caused by excessively long URLs.
        /// 
        /// > You must specify TemplateBody or TemplateURL.
        /// 
        /// You can create a Terraform template based on your business requirements. The following sample code provides an example on how to create a Terraform template:
        /// 
        ///     {
        ///       "ROSTemplateFormatVersion": "2015-09-01",
        ///       "Transform": "Aliyun::Terraform-v1.0",
        ///       "Workspace": {
        ///         "main.tf": "variable  \"name\" {  default = \"auto_provisioning_group\"}"
        ///       },
        ///       "Outputs": {}
        ///     }
        /// 
        /// For more information about Terraform templates, see [Structure of Terraform templates](~~184397~~).
        /// </summary>
        [NameInMap("TemplateBody")]
        [Validation(Required=false)]
        public string TemplateBody { get; set; }

        /// <summary>
        /// The name of the template.\
        /// The name can be up to 255 characters in length and can contain digits, letters, hyphens (-), and underscores (\_). It must start with a digit or a letter.
        /// </summary>
        [NameInMap("TemplateName")]
        [Validation(Required=false)]
        public string TemplateName { get; set; }

        /// <summary>
        /// The URL of the file that contains the template body. The URL must point to a template that is located on an HTTP or HTTPS web server or in an Alibaba Cloud Object Storage Service (OSS) bucket, such as oss://ros/stack-policy/demo or oss://ros/stack-policy/demo?RegionId=cn-hangzhou. The template body must be 1 to 1,024 bytes in length. If you do not specify the region of the OSS bucket, the value of RegionId is used.
        /// 
        /// > You must specify TemplateBody or TemplateURL.
        /// </summary>
        [NameInMap("TemplateURL")]
        [Validation(Required=false)]
        public string TemplateURL { get; set; }

    }

}
