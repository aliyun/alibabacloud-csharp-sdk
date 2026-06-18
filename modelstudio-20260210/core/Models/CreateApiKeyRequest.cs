// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ModelStudio20260210.Models
{
    public class CreateApiKeyRequest : TeaModel {
        /// <summary>
        /// <para>The API key permission settings.</para>
        /// </summary>
        [NameInMap("auth")]
        [Validation(Required=false)]
        public CreateApiKeyRequestAuth Auth { get; set; }
        public class CreateApiKeyRequestAuth : TeaModel {
            /// <summary>
            /// <para>The IP address whitelist.</para>
            /// <remarks>
            /// <list type="bullet">
            /// <item><description>When you use custom permissions, if you do not specify the IP address whitelist, the server sets it to IPv4 (0.0.0.0/0) and IPv6 (::/0) by default, which allows all traffic.</description></item>
            /// </list>
            /// </remarks>
            /// </summary>
            [NameInMap("accessIps")]
            [Validation(Required=false)]
            public List<string> AccessIps { get; set; }

            /// <summary>
            /// <para>Valid values:</para>
            /// <list type="bullet">
            /// <item><description>All: all permissions.</description></item>
            /// <item><description>Custom: custom permissions.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Custom</para>
            /// </summary>
            [NameInMap("type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        /// <summary>
        /// <para>The description.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The workspace ID.</para>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>If you leave this parameter empty, the created API key is automatically assigned to the default workspace.</description></item>
        /// </list>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>ws-8af73c50f5596193</para>
        /// </summary>
        [NameInMap("workspaceId")]
        [Validation(Required=false)]
        public string WorkspaceId { get; set; }

    }

}
