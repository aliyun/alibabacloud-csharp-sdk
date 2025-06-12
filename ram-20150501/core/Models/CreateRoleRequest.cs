// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ram20150501.Models
{
    public class CreateRoleRequest : TeaModel {
        /// <summary>
        /// <para>The trust policy that specifies one or more trusted entities to assume the RAM role. The trusted entities can be Alibaba Cloud accounts, Alibaba Cloud services, or identity providers (IdPs).</para>
        /// <remarks>
        /// <para> RAM users cannot assume the RAM roles of trusted Alibaba Cloud services.</para>
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
        /// <para>The description must be 1 to 1,024 characters in length.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ECS administrator</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The maximum session time of the RAM role.</para>
        /// <para>Valid values: 3600 to 43200. Unit: seconds. Default value: 3600.</para>
        /// <para>If you do not specify this parameter, the default value is used.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3600</para>
        /// </summary>
        [NameInMap("MaxSessionDuration")]
        [Validation(Required=false)]
        public long? MaxSessionDuration { get; set; }

        /// <summary>
        /// <para>The name of the RAM role.</para>
        /// <para>The name must be 1 to 64 characters in length, and can contain letters, digits, periods (.), and hyphens (-).</para>
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
        public List<CreateRoleRequestTag> Tag { get; set; }
        public class CreateRoleRequestTag : TeaModel {
            /// <summary>
            /// <para>The key of the tag.</para>
            /// 
            /// <b>Example:</b>
            /// <para>k1</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The value of the tag.</para>
            /// 
            /// <b>Example:</b>
            /// <para>v1</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

    }

}
