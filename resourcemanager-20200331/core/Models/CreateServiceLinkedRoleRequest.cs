// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ResourceManager20200331.Models
{
    public class CreateServiceLinkedRoleRequest : TeaModel {
        /// <summary>
        /// The suffix of the role name.
        /// 
        /// The role name (including its suffix) must be 1 to 64 characters in length and can contain letters, digits, periods (.), and hyphens (-).
        /// 
        /// For example, if the suffix is `Example`, the role name is `ServiceLinkedRoleName_Example`.
        /// </summary>
        [NameInMap("CustomSuffix")]
        [Validation(Required=false)]
        public string CustomSuffix { get; set; }

        /// <summary>
        /// The description of the service-linked role.
        /// 
        /// You must configure this parameter for service-linked roles that support custom suffixes. Otherwise, the preset value is used and cannot be modified.
        /// 
        /// The description must be 1 to 1,024 characters in length.
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// The name of the service.
        /// 
        /// For more information about the service name, see [Alibaba Cloud services that support service-linked roles](~~461722~~).
        /// </summary>
        [NameInMap("ServiceName")]
        [Validation(Required=false)]
        public string ServiceName { get; set; }

    }

}
