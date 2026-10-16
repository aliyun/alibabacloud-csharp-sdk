// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentIdentity20250901.Models
{
    public class UpdateUserRequest : TeaModel {
        /// <summary>
        /// <para>The description of the user. The description must be 0 to 256 characters in length.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Senior data analyst</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The display name of the user. The display name must be 0 to 128 characters in length.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Alice Wang</para>
        /// </summary>
        [NameInMap("DisplayName")]
        [Validation(Required=false)]
        public string DisplayName { get; set; }

        /// <summary>
        /// <para>The email address of the user.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="mailto:alice.wang@example.com">alice.wang@example.com</a></para>
        /// </summary>
        [NameInMap("Email")]
        [Validation(Required=false)]
        public string Email { get; set; }

        /// <summary>
        /// <para>The status of the user. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Enabled: The user is enabled.</description></item>
        /// <item><description>Disabled: The user is disabled.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Enabled</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <para>The username of the user to be updated. The username can contain letters, digits, underscores (_), periods (.), and hyphens (-), and must be 3 to 128 characters in length.</para>
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
