// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ResourceManager20200331.Models
{
    public class CreateServiceLinkedRoleResponseBody : TeaModel {
        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>FE58D7CF-03BC-432A-B42D-BC3390C8C2E1</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The information about the role.</para>
        /// </summary>
        [NameInMap("Role")]
        [Validation(Required=false)]
        public CreateServiceLinkedRoleResponseBodyRole Role { get; set; }
        public class CreateServiceLinkedRoleResponseBodyRole : TeaModel {
            /// <summary>
            /// <para>The Alibaba Cloud Resource Name (ARN) of the role.</para>
            /// 
            /// <b>Example:</b>
            /// <para>acs:ram::177242285274****:role/aliyunserviceroleforpolardb</para>
            /// </summary>
            [NameInMap("Arn")]
            [Validation(Required=false)]
            public string Arn { get; set; }

            /// <summary>
            /// <para>The document of the trust policy for the role.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{\&quot;Statement\&quot;:[{\&quot;Action\&quot;:\&quot;sts:AssumeRole\&quot;,\&quot;Effect\&quot;:\&quot;Allow\&quot;,\&quot;Principal\&quot;:{\&quot;Service\&quot;:[\&quot;polardb.aliyuncs.com\&quot;]}}],\&quot;Version\&quot;:\&quot;1\&quot;}</para>
            /// </summary>
            [NameInMap("AssumeRolePolicyDocument")]
            [Validation(Required=false)]
            public string AssumeRolePolicyDocument { get; set; }

            /// <summary>
            /// <para>The time when the role was created. The time is displayed in UTC.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2020-06-30T08:14:16Z</para>
            /// </summary>
            [NameInMap("CreateDate")]
            [Validation(Required=false)]
            public string CreateDate { get; set; }

            /// <summary>
            /// <para>The description of the role.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Service Linked Role for PolarDB. PolarDB will use this role to access your resources in other services.</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>Indicates whether the role is a service-linked role. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>true</description></item>
            /// <item><description>false</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("IsServiceLinkedRole")]
            [Validation(Required=false)]
            public bool? IsServiceLinkedRole { get; set; }

            /// <summary>
            /// <para>The ID of the role.</para>
            /// 
            /// <b>Example:</b>
            /// <para>32833240981067****</para>
            /// </summary>
            [NameInMap("RoleId")]
            [Validation(Required=false)]
            public string RoleId { get; set; }

            /// <summary>
            /// <para>The name of the role.</para>
            /// 
            /// <b>Example:</b>
            /// <para>AliyunServiceRoleForPolarDB</para>
            /// </summary>
            [NameInMap("RoleName")]
            [Validation(Required=false)]
            public string RoleName { get; set; }

            /// <summary>
            /// <para>The role name that uses a domain name as the suffix.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="mailto:AliyunServiceRoleForPolarDB@role.test.onaliyunservice.com">AliyunServiceRoleForPolarDB@role.test.onaliyunservice.com</a></para>
            /// </summary>
            [NameInMap("RolePrincipalName")]
            [Validation(Required=false)]
            public string RolePrincipalName { get; set; }

        }

    }

}
