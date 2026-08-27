// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ram20150501.Models
{
    public class CreateRoleShrinkRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether console logon is allowed for the RAM role. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: Console logon is allowed.</description></item>
        /// <item><description>false: Console logon is not allowed.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// 
        /// <b>if can be null:</b>
        /// <c>false</c>
        /// </summary>
        [NameInMap("AllowConsoleLogin")]
        [Validation(Required=false)]
        public bool? AllowConsoleLogin { get; set; }

        /// <summary>
        /// <para>The trust policy. Specifies one or more principals that are allowed to assume the RAM role. The principal can be an Alibaba Cloud account, an Alibaba Cloud service, or an identity provider.</para>
        /// <remarks>
        /// <para>Resource Access Management (RAM) users cannot assume RAM roles whose trusted entity is an Alibaba Cloud service.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;Statement&quot;:[{&quot;Action&quot;:&quot;sts:AssumeRole&quot;,&quot;Effect&quot;:&quot;Allow&quot;,&quot;Principal&quot;:{&quot;RAM&quot;:&quot;acs:ram::123456789012****:root&quot;}}],&quot;Version&quot;:&quot;1&quot;}</para>
        /// </summary>
        [NameInMap("AssumeRolePolicyDocument")]
        [Validation(Required=false)]
        public string AssumeRolePolicyDocument { get; set; }

        /// <summary>
        /// <para>The description of the RAM role.</para>
        /// <para>The description must be 1 to 1024 characters in length.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ECS management role.</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The maximum session duration of the RAM role.</para>
        /// <para>Valid values: 3600 to 43200. Unit: seconds. Default value: 3600.</para>
        /// <para>If you leave this parameter empty, the default value is used.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3600</para>
        /// </summary>
        [NameInMap("MaxSessionDuration")]
        [Validation(Required=false)]
        public long? MaxSessionDuration { get; set; }

        /// <summary>
        /// <para>The name of the RAM role.</para>
        /// <para>The name must be 1 to 64 characters in length and can contain letters, digits, periods (.), and hyphens (-).</para>
        /// 
        /// <b>Example:</b>
        /// <para>ECSAdmin</para>
        /// </summary>
        [NameInMap("RoleName")]
        [Validation(Required=false)]
        public string RoleName { get; set; }

        /// <summary>
        /// <para>The tags.</para>
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public string TagShrink { get; set; }

    }

}
