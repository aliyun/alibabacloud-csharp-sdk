// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ROS20190910.Models
{
    public class RegisterResourceTypeRequest : TeaModel {
        /// <summary>
        /// The client token that is used to ensure the idempotence of the request. You can use the client to generate the token, but you must make sure that the token is unique among different requests.\
        /// The token can be up to 64 characters in length, and can contain letters, digits, hyphens (-), and underscores (\_).\
        /// For more information, see [Ensure idempotence](~~134212~~).
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// The description of the resource type. The description can be up to 512 characters in length.
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// The entity type. Set the value to Module.
        /// </summary>
        [NameInMap("EntityType")]
        [Validation(Required=false)]
        public string EntityType { get; set; }

        /// <summary>
        /// The resource type.
        /// </summary>
        [NameInMap("ResourceType")]
        [Validation(Required=false)]
        public string ResourceType { get; set; }

        /// <summary>
        /// The structure that contains the template body. The template body must be 1 to 524,288 bytes in length. The template body is used as the module content. If the length of the template body exceeds the upper limit, we recommend that you add parameters to the HTTP POST request body to prevent request failures caused by excessively long URLs.
        /// 
        /// 
        /// > - This parameter takes effect only when EntityType is set to Module.
        /// > - You can specify only one of the TemplateBody and TemplateURL parameters.
        /// </summary>
        [NameInMap("TemplateBody")]
        [Validation(Required=false)]
        public string TemplateBody { get; set; }

        /// <summary>
        /// The URL of the file that contains the template body. The URL must point to a template that is located on an HTTP or HTTPS web server or in an Object Storage Service (OSS) bucket, such as oss://ros/template/demo or oss://ros/template/demo?RegionId=cn-hangzhou. The template body can be up to 524,288 bytes in length. The template body is used as the module content.
        /// 
        /// > - If you do not specify the region ID of the OSS bucket, the value of RegionId is used.
        /// > -  This parameter takes effect only when EntityType is set to Module.
        /// > -  You can specify only one of the TemplateBody and TemplateURL parameters.
        /// 
        /// The URL can be up to 1,024 bytes in length.
        /// </summary>
        [NameInMap("TemplateURL")]
        [Validation(Required=false)]
        public string TemplateURL { get; set; }

    }

}
