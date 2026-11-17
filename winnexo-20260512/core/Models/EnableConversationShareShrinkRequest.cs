// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.WinNexo20260512.Models
{
    public class EnableConversationShareShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The unique identifier of the function session.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>exampleSessionId</para>
        /// </summary>
        [NameInMap("sessionId")]
        [Validation(Required=false)]
        public string SessionId { get; set; }

        /// <summary>
        /// <para>The sharing scope. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>PUBLIC: accessible to all users</description></item>
        /// <item><description>SPECIFIED: accessible to specified users or user groups</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>PUBLIC</para>
        /// </summary>
        [NameInMap("shareAccessType")]
        [Validation(Required=false)]
        public string ShareAccessType { get; set; }

        /// <summary>
        /// <para>The list of user group IDs for the specified scope. When shareAccessType is set to SPECIFIED, at least one of this list or the user list must not be empty.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[&quot;group-1&quot;]</para>
        /// </summary>
        [NameInMap("shareUserGroupIds")]
        [Validation(Required=false)]
        public string ShareUserGroupIdsShrink { get; set; }

        /// <summary>
        /// <para>The list of platform user IDs for the specified scope. When shareAccessType is set to SPECIFIED, at least one of this list or the user group list must not be empty.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[10001]</para>
        /// </summary>
        [NameInMap("shareUserIds")]
        [Validation(Required=false)]
        public string ShareUserIdsShrink { get; set; }

        /// <summary>
        /// <para>The tenant ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10000</para>
        /// </summary>
        [NameInMap("tenantId")]
        [Validation(Required=false)]
        public string TenantId { get; set; }

    }

}
