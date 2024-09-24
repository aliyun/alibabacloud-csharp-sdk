// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeSuspiciousUUIDConfigRequest : TeaModel {
        /// <summary>
        /// <para>The type of proactive defense. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>auto_breaking</b>: virus defense</description></item>
        /// <item><description><b>ransomware_breaking</b>: ransomware capture</description></item>
        /// <item><description><b>webshell_cloud_breaking</b>: webshell defense</description></item>
        /// <item><description><b>alinet</b>: malicious behavior defense</description></item>
        /// <item><description><b>alisecguard</b>: client protection</description></item>
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
