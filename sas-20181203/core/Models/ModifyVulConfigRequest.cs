// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class ModifyVulConfigRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether to enable or disable vulnerability detection. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>on</b>: Enable vulnerability detection.</description></item>
        /// <item><description><b>off</b>: Disable vulnerability detection.</description></item>
        /// </list>
        /// <remarks>
        /// <para>If the type is set to real risk, valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>real</b>: Real risk vulnerabilities.</description></item>
        /// <item><description><b>all</b>: All vulnerabilities.</description></item>
        /// </list>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>on</para>
        /// </summary>
        [NameInMap("Config")]
        [Validation(Required=false)]
        public string Config { get; set; }

        /// <summary>
        /// <para>The type of vulnerability to modify. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>cve</b>: Linux vulnerability</description></item>
        /// <item><description><b>sys</b>: Windows vulnerability</description></item>
        /// <item><description><b>cms</b>: WebCMS vulnerability</description></item>
        /// <item><description><b>emg</b>: emergency vulnerability</description></item>
        /// <item><description><b>app</b>: application vulnerability</description></item>
        /// <item><description><b>yum</b>: YUM/APT source configuration</description></item>
        /// <item><description><b>scanMode</b>: real risk.</description></item>
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
