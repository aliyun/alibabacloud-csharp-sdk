// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ModelStudio20260210.Models
{
    public class UpdateApiKeyRequest : TeaModel {
        /// <summary>
        /// <para>The API key permission settings.</para>
        /// </summary>
        [NameInMap("auth")]
        [Validation(Required=false)]
        public UpdateApiKeyRequestAuth Auth { get; set; }
        public class UpdateApiKeyRequestAuth : TeaModel {
            /// <summary>
            /// <para>The IP access whitelist.</para>
            /// <remarks>
            /// <list type="bullet">
            /// <item><description>When you set custom permissions and do not specify the IP access whitelist, the server sets the whitelist to IPv4 (0.0.0.0/0) and IPv6 (::/0) by default, which allows all traffic.</description></item>
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
        /// <para>update description.</para>
        /// </summary>
        [NameInMap("description")]
        [Validation(Required=false)]
        public string Description { get; set; }

    }

}
