// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ram20150501.Models
{
    public class UpdateRoleRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether the RAM role is allowed to log on to the console.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("NewAllowConsoleLogin")]
        [Validation(Required=false)]
        public bool? NewAllowConsoleLogin { get; set; }

        /// <summary>
        /// <para>The trust policy of the RAM role.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{ &quot;Statement&quot;: [ { &quot;Action&quot;: &quot;sts:AssumeRole&quot;, &quot;Effect&quot;: &quot;Allow&quot;, &quot;Principal&quot;: { &quot;RAM&quot;: &quot;acs:ram::12345678901234****:root&quot; } } ], &quot;Version&quot;: &quot;1&quot; }</para>
        /// </summary>
        [NameInMap("NewAssumeRolePolicyDocument")]
        [Validation(Required=false)]
        public string NewAssumeRolePolicyDocument { get; set; }

        /// <summary>
        /// <para>The description of the RAM role.</para>
        /// <para>The description must be 1 to 1024 characters in length.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ECS management role</para>
        /// </summary>
        [NameInMap("NewDescription")]
        [Validation(Required=false)]
        public string NewDescription { get; set; }

        /// <summary>
        /// <para>The maximum session duration of the RAM role.</para>
        /// <para>Valid values: 3600 to 43200. Unit: seconds. Default value: 3600.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3600</para>
        /// </summary>
        [NameInMap("NewMaxSessionDuration")]
        [Validation(Required=false)]
        public long? NewMaxSessionDuration { get; set; }

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

    }

}
