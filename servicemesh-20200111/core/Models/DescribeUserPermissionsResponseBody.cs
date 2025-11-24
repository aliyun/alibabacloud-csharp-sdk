// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Servicemesh20200111.Models
{
    public class DescribeUserPermissionsResponseBody : TeaModel {
        /// <summary>
        /// <para>The permissions that are granted to an entity.</para>
        /// </summary>
        [NameInMap("Permissions")]
        [Validation(Required=false)]
        public List<DescribeUserPermissionsResponseBodyPermissions> Permissions { get; set; }
        public class DescribeUserPermissionsResponseBodyPermissions : TeaModel {
            /// <summary>
            /// <para>The entity to which the permissions are granted. A value of <c>true</c> indicates that the permissions are granted to a RAM user. A value of <c>false</c> indicates that the permissions are granted to a RAM role.</para>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("IsRamRole")]
            [Validation(Required=false)]
            public string IsRamRole { get; set; }

            /// <summary>
            /// <para>The value is fixed as <c>0</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("ParentId")]
            [Validation(Required=false)]
            public string ParentId { get; set; }

            /// <summary>
            /// <para>The ID of the ASM instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>c57b848115458460583a4260cb713****</para>
            /// </summary>
            [NameInMap("ResourceId")]
            [Validation(Required=false)]
            public string ResourceId { get; set; }

            /// <summary>
            /// <para>The value is fixed as <c>cluster</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cluster</para>
            /// </summary>
            [NameInMap("ResourceType")]
            [Validation(Required=false)]
            public string ResourceType { get; set; }

            /// <summary>
            /// <para>The name of the permissions. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><c>istio-admin</c>: the permissions of ASM administrators.</description></item>
            /// <item><description><c>istio-ops</c>: the permissions of ASM restricted users.</description></item>
            /// <item><description><c>istio-readonly</c>: the read-only permissions.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>istio-admin</para>
            /// </summary>
            [NameInMap("RoleName")]
            [Validation(Required=false)]
            public string RoleName { get; set; }

            /// <summary>
            /// <para>The value is fixed as <c>custom</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>custom</para>
            /// </summary>
            [NameInMap("RoleType")]
            [Validation(Required=false)]
            public string RoleType { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5A7C9E37-C171-584F-9A99-869B48C4196D</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
