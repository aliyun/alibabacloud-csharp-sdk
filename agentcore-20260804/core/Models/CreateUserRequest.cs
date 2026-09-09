// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentCore20260804.Models
{
    public class CreateUserRequest : TeaModel {
        /// <summary>
        /// <para>The request body for creating a user.</para>
        /// </summary>
        [NameInMap("body")]
        [Validation(Required=false)]
        public CreateUserRequestBody Body { get; set; }
        public class CreateUserRequestBody : TeaModel {
            /// <summary>
            /// <para>The display name of the user. The display name must be 1 to 32 characters in length.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>John Smith</para>
            /// </summary>
            [NameInMap("displayName")]
            [Validation(Required=false)]
            public string DisplayName { get; set; }

            /// <summary>
            /// <para>The email address of the user. The email address can be up to 256 characters in length.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="mailto:user-01@example.com">user-01@example.com</a></para>
            /// </summary>
            [NameInMap("email")]
            [Validation(Required=false)]
            public string Email { get; set; }

            /// <summary>
            /// <para>The username. The username must be unique within the workspace and can contain only lowercase letters, digits, and hyphens. It must start and end with a lowercase letter or digit and be 1 to 32 characters in length. Reserved names such as manager, admin, or names starting with worker- cannot be used.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>user-01</para>
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The remarks of the user. The remarks can be up to 1024 characters in length.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Member of the agent operations team</para>
            /// </summary>
            [NameInMap("note")]
            [Validation(Required=false)]
            public string Note { get; set; }

            /// <summary>
            /// <para>The initial password of the user. The password must be 8 to 32 characters in length and contain uppercase letters, lowercase letters, digits, and special characters. The password cannot contain the username. If this parameter is not specified, the server generates a random password and returns it in the initialPassword field of the response.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Example@2026</para>
            /// </summary>
            [NameInMap("password")]
            [Validation(Required=false)]
            public string Password { get; set; }

        }

        /// <summary>
        /// <para>Not supported.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Not supported</para>
        /// </summary>
        [NameInMap("clientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

    }

}
