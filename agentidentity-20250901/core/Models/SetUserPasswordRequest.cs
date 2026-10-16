// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentIdentity20250901.Models
{
    public class SetUserPasswordRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether to generate a random password. If this parameter is set to true, the system automatically generates a random password that complies with the password policy. This parameter is mutually exclusive with Password.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("GenerateRandomPassword")]
        [Validation(Required=false)]
        public bool? GenerateRandomPassword { get; set; }

        /// <summary>
        /// <para>The password of the user. The password must comply with the password policy of the user pool and is mutually exclusive with GenerateRandomPassword.</para>
        /// 
        /// <b>Example:</b>
        /// <para>P@ssw0rd!2026</para>
        /// </summary>
        [NameInMap("Password")]
        [Validation(Required=false)]
        public string Password { get; set; }

        /// <summary>
        /// <para>The username.</para>
        /// 
        /// <b>Example:</b>
        /// <para>alice</para>
        /// </summary>
        [NameInMap("UserName")]
        [Validation(Required=false)]
        public string UserName { get; set; }

        /// <summary>
        /// <para>The name of the user pool.</para>
        /// 
        /// <b>Example:</b>
        /// <para>my-agent-userpool</para>
        /// </summary>
        [NameInMap("UserPoolName")]
        [Validation(Required=false)]
        public string UserPoolName { get; set; }

    }

}
