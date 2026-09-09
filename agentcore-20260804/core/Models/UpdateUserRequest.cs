// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentCore20260804.Models
{
    public class UpdateUserRequest : TeaModel {
        /// <summary>
        /// <para>The request body for updating a user.</para>
        /// </summary>
        [NameInMap("body")]
        [Validation(Required=false)]
        public UpdateUserRequestBody Body { get; set; }
        public class UpdateUserRequestBody : TeaModel {
            /// <summary>
            /// <para>The display name of the user. The name must be 1 to 32 characters in length. At least one of displayName, email, and note must be specified.</para>
            /// 
            /// <b>Example:</b>
            /// <para>John</para>
            /// </summary>
            [NameInMap("displayName")]
            [Validation(Required=false)]
            public string DisplayName { get; set; }

            /// <summary>
            /// <para>The email address of the user. The address can be up to 256 characters in length.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="mailto:user-01@example.com">user-01@example.com</a></para>
            /// </summary>
            [NameInMap("email")]
            [Validation(Required=false)]
            public string Email { get; set; }

            /// <summary>
            /// <para>The note for the user. The note can be up to 1,024 characters in length.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Agent operations team member</para>
            /// </summary>
            [NameInMap("note")]
            [Validation(Required=false)]
            public string Note { get; set; }

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
