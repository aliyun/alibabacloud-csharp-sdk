// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ResourceManager20200331.Models
{
    public class CreateRoleRequest : TeaModel {
        /// <summary>
        /// <para>The content of the access policy for assuming the role.</para>
        /// <para>Specifies one or more entities that are allowed to assume the role. The trusted entity can be an Alibaba Cloud account, an Alibaba Cloud service, or an identity provider.</para>
        /// <remarks>
        /// <para>A Resource Access Management (RAM) user cannot assume a RAM role whose trusted entity is an Alibaba Cloud service.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{ &quot;Statement&quot;: [ { &quot;Action&quot;: &quot;sts:AssumeRole&quot;, &quot;Effect&quot;: &quot;Allow&quot;, &quot;Principal&quot;: { &quot;RAM&quot;: &quot;acs:ram::12345678901234****:root&quot; } } ], &quot;Version&quot;: &quot;1&quot; }</para>
        /// </summary>
        [NameInMap("AssumeRolePolicyDocument")]
        [Validation(Required=false)]
        public string AssumeRolePolicyDocument { get; set; }

        /// <summary>
        /// <para>The description of the role.</para>
        /// <para>The description must be 1 to 1,024 characters in length.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ECS management role</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The maximum session duration of the role.</para>
        /// <para>Valid values: 3600 to 43200. Unit: seconds. Default value: 3600.</para>
        /// <para>If this parameter is left empty, the default value is used.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3600</para>
        /// </summary>
        [NameInMap("MaxSessionDuration")]
        [Validation(Required=false)]
        public long? MaxSessionDuration { get; set; }

        /// <summary>
        /// <para>The name of the role.</para>
        /// <para>The name must be 1 to 64 characters in length and can contain letters, digits, periods (.), and hyphens (-).</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ECSAdmin</para>
        /// </summary>
        [NameInMap("RoleName")]
        [Validation(Required=false)]
        public string RoleName { get; set; }

    }

}
