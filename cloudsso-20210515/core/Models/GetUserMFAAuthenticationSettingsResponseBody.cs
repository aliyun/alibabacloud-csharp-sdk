// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudsso20210515.Models
{
    public class GetUserMFAAuthenticationSettingsResponseBody : TeaModel {
        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5B598B62-85E6-5792-9DF1-246D251B07DA</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether MFA is enabled for the user. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Enabled: MFA is enabled for the user.</description></item>
        /// <item><description>Disabled: MFA is disabled for the user.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Enabled</para>
        /// </summary>
        [NameInMap("UserMFAAuthenticationSettings")]
        [Validation(Required=false)]
        public string UserMFAAuthenticationSettings { get; set; }

    }

}
