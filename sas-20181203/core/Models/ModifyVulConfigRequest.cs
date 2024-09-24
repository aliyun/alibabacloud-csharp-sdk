// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class ModifyVulConfigRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether to enable the vulnerability scan feature. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>on</b>: enables the feature</description></item>
        /// <item><description><b>off</b>: disables the feature</description></item>
        /// </list>
        /// <remarks>
        /// <para>Valid values when you set the Type parameter to scanMode:</para>
        /// </remarks>
        /// <list type="bullet">
        /// <item><description><para><b>real</b>: displays only easily exploitable vulnerabilities.</para>
        /// </description></item>
        /// <item><description><para><b>all</b>: displays all vulnerabilities.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>on</para>
        /// </summary>
        [NameInMap("Config")]
        [Validation(Required=false)]
        public string Config { get; set; }

        /// <summary>
        /// <para>The type of the vulnerability. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>cve</b>: Linux software vulnerability</description></item>
        /// <item><description><b>sys</b>: Windows system vulnerability</description></item>
        /// <item><description><b>cms</b>: Web-CMS vulnerability</description></item>
        /// <item><description><b>emg</b>: urgent vulnerability</description></item>
        /// <item><description><b>app</b>: application vulnerability</description></item>
        /// <item><description><b>yum</b>: YUM and APT source configuration</description></item>
        /// <item><description><b>scanMode</b>: easily exploitable vulnerability</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>cve</para>
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
