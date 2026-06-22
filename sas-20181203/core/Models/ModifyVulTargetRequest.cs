// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class ModifyVulTargetRequest : TeaModel {
        /// <summary>
        /// <para>The configuration target. This parameter is in JSON format and contains the following fields:</para>
        /// <list type="bullet">
        /// <item><description><b>vulType</b>: The vulnerability type. Valid values:<list type="bullet">
        /// <item><description><b>cve</b>: Linux software vulnerability.</description></item>
        /// <item><description><b>sys</b>: Windows system vulnerability.</description></item>
        /// <item><description><b>cms</b>: Web-CMS vulnerability.</description></item>
        /// <item><description><b>emg</b>: Emergency vulnerability.</description></item>
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
        /// <para>The operation target. This parameter is in JSON format and contains the following fields:</para>
        /// <list type="bullet">
        /// <item><description><b>target</b>: The UUID of the target machine.</description></item>
        /// <item><description><b>targetType</b>: The target type. Fixed value: uuid.</description></item>
        /// <item><description><b>flag</b>: The flag. Valid values:<list type="bullet">
        /// <item><description><b>add</b>: Selected.</description></item>
        /// <item><description><b>del</b>: Deselected.</description></item>
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
