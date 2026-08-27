// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ram20150501.Models
{
    public class CreateServiceLinkedRoleRequest : TeaModel {
        /// <summary>
        /// <para>The suffix of the role name.</para>
        /// <para>The total length of the role name (including the suffix) is 1 to 64 characters and can contain letters, digits, periods (.), and hyphens (-).</para>
        /// <para>Example: If the suffix is Example, the role name is ServiceLinkedRoleName_Example, and the maximum length cannot exceed 64 characters.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Example</para>
        /// </summary>
        [NameInMap("CustomSuffix")]
        [Validation(Required=false)]
        public string CustomSuffix { get; set; }

        /// <summary>
        /// <para>The description of the service-linked role.</para>
        /// <para>You can specify a role description only for service-linked roles that allow custom suffixes. Otherwise, the role description uses a preset value and cannot be modified.</para>
        /// <para>The description must be 1 to 1,024 characters in length.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Service Linked Role for PolarDB. PolarDB will use this role to access your resources in other services.</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The cloud service name associated with the service-linked role.</para>
        /// <para>For more information, see the <b>Cloud service identity</b> column in <a href="https://help.aliyun.com/document_detail/461722.html">Cloud services that support service-linked roles</a>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>polardb.aliyuncs.com</para>
        /// </summary>
        [NameInMap("ServiceName")]
        [Validation(Required=false)]
        public string ServiceName { get; set; }

    }

}
