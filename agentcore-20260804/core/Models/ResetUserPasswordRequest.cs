// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentCore20260804.Models
{
    public class ResetUserPasswordRequest : TeaModel {
        [NameInMap("body")]
        [Validation(Required=false)]
        public ResetUserPasswordRequestBody Body { get; set; }
        public class ResetUserPasswordRequestBody : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>usr-123456</para>
            /// </summary>
            [NameInMap("agentCoreUserId")]
            [Validation(Required=false)]
            public string AgentCoreUserId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>Example@2026</para>
            /// </summary>
            [NameInMap("password")]
            [Validation(Required=false)]
            public string Password { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>user-01</para>
            /// </summary>
            [NameInMap("username")]
            [Validation(Required=false)]
            public string Username { get; set; }

        }

    }

}
