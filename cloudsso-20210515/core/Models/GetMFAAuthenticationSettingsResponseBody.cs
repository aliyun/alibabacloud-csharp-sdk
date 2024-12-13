// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudsso20210515.Models
{
    public class GetMFAAuthenticationSettingsResponseBody : TeaModel {
        /// <summary>
        /// <para>Indicates whether MFA is enabled for all users. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Enabled: MFA is enabled for all users.</description></item>
        /// <item><description>Byuser: User-specific settings are applied.</description></item>
        /// <item><description>Disabled: MFA is disabled for all users.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Enabled</para>
        /// </summary>
        [NameInMap("MFAAuthenticationAdvanceSettings")]
        [Validation(Required=false)]
        public string MFAAuthenticationAdvanceSettings { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>A2BC00C5-76A2-5FFC-A340-927940A98377</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
