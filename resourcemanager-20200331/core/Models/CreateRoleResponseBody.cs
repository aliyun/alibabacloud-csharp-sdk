// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ResourceManager20200331.Models
{
    public class CreateRoleResponseBody : TeaModel {
        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>04F0F334-1335-436C-A1D7-6C044FE73368</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The information about the role.</para>
        /// </summary>
        [NameInMap("Role")]
        [Validation(Required=false)]
        public CreateRoleResponseBodyRole Role { get; set; }
        public class CreateRoleResponseBodyRole : TeaModel {
            /// <summary>
            /// <para>The Alibaba Cloud Resource Name (ARN) of the role.</para>
            /// 
            /// <b>Example:</b>
            /// <para>acs:ram::123456789012****:role/ECSAdmin</para>
            /// </summary>
            [NameInMap("Arn")]
            [Validation(Required=false)]
            public string Arn { get; set; }

            /// <summary>
            /// <para>The document of the policy in which the entity that can assume the role is specified.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{ \&quot;Statement\&quot;: [ { \&quot;Action\&quot;: \&quot;sts:AssumeRole\&quot;, \&quot;Effect\&quot;: \&quot;Allow\&quot;, \&quot;Principal\&quot;: { \&quot;RAM\&quot;: \&quot;acs:ram::12345678901234****:root\&quot; } } ], \&quot;Version\&quot;: \&quot;1\&quot; }</para>
            /// </summary>
            [NameInMap("AssumeRolePolicyDocument")]
            [Validation(Required=false)]
            public string AssumeRolePolicyDocument { get; set; }

            /// <summary>
            /// <para>The time when the role was created.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2015-01-23T12:33:18Z</para>
            /// </summary>
            [NameInMap("CreateDate")]
            [Validation(Required=false)]
            public string CreateDate { get; set; }

            /// <summary>
            /// <para>The description of the role.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ECS administrator</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The maximum session duration of the role.</para>
            /// 
            /// <b>Example:</b>
            /// <para>3600</para>
            /// </summary>
            [NameInMap("MaxSessionDuration")]
            [Validation(Required=false)]
            public long? MaxSessionDuration { get; set; }

            /// <summary>
            /// <para>The ID of the role.</para>
            /// 
            /// <b>Example:</b>
            /// <para>90123456789****</para>
            /// </summary>
            [NameInMap("RoleId")]
            [Validation(Required=false)]
            public string RoleId { get; set; }

            /// <summary>
            /// <para>The name of the role.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ECSAdmin</para>
            /// </summary>
            [NameInMap("RoleName")]
            [Validation(Required=false)]
            public string RoleName { get; set; }

            /// <summary>
            /// <para>The name of the role after authorization.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="mailto:ECSAdmin@role.123456.onaliyunservice.com">ECSAdmin@role.123456.onaliyunservice.com</a></para>
            /// </summary>
            [NameInMap("RolePrincipalName")]
            [Validation(Required=false)]
            public string RolePrincipalName { get; set; }

        }

    }

}
