// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class ModifyVulTargetRequest : TeaModel {
        /// <summary>
        /// <para>The configurations. The value of this parameter is in the JSON format and contains the following fields:</para>
        /// <list type="bullet">
        /// <item><description><para><b>vulType</b>: the type of the vulnerabilities to scan. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>cve</b>: Linux software vulnerabilities</description></item>
        /// <item><description><b>sys</b>: Windows system vulnerabilities</description></item>
        /// <item><description><b>cms</b>: Web-CMS vulnerabilities</description></item>
        /// <item><description><b>emg</b>: urgent vulnerabilities</description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>{\&quot;vulType\&quot;:\&quot;sys\&quot;}</para>
        /// </summary>
        [NameInMap("Config")]
        [Validation(Required=false)]
        public string Config { get; set; }

        /// <summary>
        /// <para>The operation. The value of this parameter is in the JSON format and contains the following fields:</para>
        /// <list type="bullet">
        /// <item><description><para><b>target</b>: the UUID of the server.</para>
        /// </description></item>
        /// <item><description><para><b>targetType</b>: the application scope of the operation. Set the value to uuid.</para>
        /// </description></item>
        /// <item><description><para><b>flag</b>: the type of the operation. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>add</b>: select</description></item>
        /// <item><description><b>del</b>: deselect</description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>[{\&quot;target\&quot;: \&quot;9cd5c684-7201-4de5-ad2c-cea89a5e****\&quot;, \&quot;targetType\&quot;: \&quot;uuid\&quot;, \&quot;flag\&quot;: \&quot;add\&quot;}]</para>
        /// </summary>
        [NameInMap("Target")]
        [Validation(Required=false)]
        public string Target { get; set; }

    }

}
