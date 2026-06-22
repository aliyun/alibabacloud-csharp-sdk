// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class ModifyVulTargetConfigRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether to enable or disable vulnerability detection. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>on</b>: Enable vulnerability detection.</description></item>
        /// <item><description><b>off</b>: Disable vulnerability detection.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>off</para>
        /// </summary>
        [NameInMap("Config")]
        [Validation(Required=false)]
        public string Config { get; set; }

        /// <summary>
        /// <para>The IP address of the access source.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1.2.XX.XX</para>
        /// </summary>
        [NameInMap("SourceIp")]
        [Validation(Required=false)]
        public string SourceIp { get; set; }

        /// <summary>
        /// <para>The type of vulnerability detection to configure. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>cve</b>: Linux software vulnerability</description></item>
        /// <item><description><b>sys</b>: Windows system vulnerability</description></item>
        /// <item><description><b>cms</b>: Web-CMS vulnerability</description></item>
        /// <item><description><b>emg</b>: urgent vulnerability.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cve</para>
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

        /// <summary>
        /// <para>The UUID of the server to configure.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>inet-7c676676-06fa-442e-90fb-b802e5d6****</para>
        /// </summary>
        [NameInMap("Uuid")]
        [Validation(Required=false)]
        public string Uuid { get; set; }

    }

}
