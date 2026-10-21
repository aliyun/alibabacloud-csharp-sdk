// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms20250414.Models
{
    public class GetAgenticAgentByInstallTokenRequest : TeaModel {
        /// <summary>
        /// <para>The one-time install token issued by IssueAgenticInstallToken. The token starts with dit_ followed by 40 URL-safe Base64 characters, making a total length of 44 characters.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>dit_0123456789abcdefghijklmnopqrstuvwxyzABCD</para>
        /// </summary>
        [NameInMap("InstallToken")]
        [Validation(Required=false)]
        public string InstallToken { get; set; }

    }

}
