// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class ModifyStartVulScanRequest : TeaModel {
        /// <summary>
        /// <para>The types of vulnerabilities that can be detected. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>cve</b>: Linux software vulnerabilities</description></item>
        /// <item><description><b>sys</b>: Windows system vulnerabilities</description></item>
        /// <item><description><b>cms</b>: Web-CMS vulnerabilities</description></item>
        /// <item><description><b>app</b>: application vulnerabilities</description></item>
        /// <item><description><b>emg</b>: urgent vulnerabilities</description></item>
        /// <item><description><b>image</b>: container image vulnerabilities</description></item>
        /// <item><description><b>sca</b>: vulnerabilities that are detected based on software component analysis</description></item>
        /// </list>
        /// <remarks>
        /// <para>If you leave this parameter empty, all types of vulnerabilities can be detected.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>&quot;cve,sys,cms,app,emg&quot;</para>
        /// </summary>
        [NameInMap("Types")]
        [Validation(Required=false)]
        public string Types { get; set; }

        /// <summary>
        /// <para>The UUIDs of servers.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;i-sdada-xxxxx&quot;,&quot;i-ifaedada-sfsasdxxx&quot;}</para>
        /// </summary>
        [NameInMap("Uuids")]
        [Validation(Required=false)]
        public string Uuids { get; set; }

    }

}
