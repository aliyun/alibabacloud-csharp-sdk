// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentCore20260804.Models
{
    public class ResetUserPasswordRequest : TeaModel {
        /// <summary>
        /// <para>The request body for resetting the user password.</para>
        /// </summary>
        [NameInMap("body")]
        [Validation(Required=false)]
        public ResetUserPasswordRequestBody Body { get; set; }
        public class ResetUserPasswordRequestBody : TeaModel {
            /// <summary>
            /// <para>The user ID. You must specify at least one of agentCoreUserId and username. If both are specified, agentCoreUserId takes precedence.</para>
            /// 
            /// <b>Example:</b>
            /// <para>usr-123456</para>
            /// </summary>
            [NameInMap("agentCoreUserId")]
            [Validation(Required=false)]
            public string AgentCoreUserId { get; set; }

            /// <summary>
            /// <para>The new password. The password must be 8 to 32 characters in length and must contain uppercase letters, lowercase letters, digits, and special characters. It cannot contain the username. If you do not specify this parameter, the server generates a random password.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Example@2026</para>
            /// </summary>
            [NameInMap("password")]
            [Validation(Required=false)]
            public string Password { get; set; }

            /// <summary>
            /// <para>The username. You must specify at least one of agentCoreUserId and username.</para>
            /// 
            /// <b>Example:</b>
            /// <para>user-01</para>
            /// </summary>
            [NameInMap("username")]
            [Validation(Required=false)]
            public string Username { get; set; }

        }

    }

}
