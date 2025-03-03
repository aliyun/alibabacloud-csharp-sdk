// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ResourceManager20200331.Models
{
    public class CreateServiceLinkedRoleRequest : TeaModel {
        /// <summary>
        /// <para>The suffix of the role name.</para>
        /// <para>The role name (including its suffix) must be 1 to 64 characters in length and can contain letters, digits, periods (.), and hyphens (-).</para>
        /// <para>For example, if the suffix is <c>Example</c>, the role name is <c>ServiceLinkedRoleName_Example</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Example</para>
        /// </summary>
        [NameInMap("CustomSuffix")]
        [Validation(Required=false)]
        public string CustomSuffix { get; set; }

        /// <summary>
        /// <para>The description of the service-linked role.</para>
        /// <para>You must configure this parameter for service-linked roles that support custom suffixes. Otherwise, the preset value is used and cannot be modified.</para>
        /// <para>The description must be 1 to 1,024 characters in length.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Service Linked Role for PolarDB. PolarDB will use this role to access your resources in other services.</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The name of the service.</para>
        /// <para>For more information about the service name, see <a href="https://help.aliyun.com/document_detail/461722.html">Alibaba Cloud services that support service-linked roles</a>.</para>
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
