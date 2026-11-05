// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeSuspiciousUUIDConfigRequest : TeaModel {
        /// <summary>
        /// <para>The defense type of the proactive defense to query. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>auto_breaking</b>: Anti-virus.</description></item>
        /// <item><description><b>ransomware_breaking</b>: Anti-ransomware (bait capture).</description></item>
        /// <item><description><b>webshell_cloud_breaking</b>: Web shell connection defense.</description></item>
        /// <item><description><b>alinet</b>: Malicious network behavior defense.</description></item>
        /// <item><description><b>alisecguard</b>: Client self-protection.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>alinet</para>
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
