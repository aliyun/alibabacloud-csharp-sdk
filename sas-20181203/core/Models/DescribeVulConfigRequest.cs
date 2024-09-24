// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeVulConfigRequest : TeaModel {
        /// <summary>
        /// <para>The source IP address of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>113.110.XX.XX</para>
        /// </summary>
        [NameInMap("SourceIp")]
        [Validation(Required=false)]
        public string SourceIp { get; set; }

        /// <summary>
        /// <para>The type of configuration. By default, all types of configurations are queried. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>cve</b>: Linux software vulnerability.</description></item>
        /// <item><description><b>sys</b>: Windows system vulnerability.</description></item>
        /// <item><description><b>cms</b>: Web-CMS vulnerability.</description></item>
        /// <item><description><b>app</b>: application vulnerability that is detected by using web scanner.</description></item>
        /// <item><description><b>emg</b>: urgent vulnerability.</description></item>
        /// <item><description><b>scanMode</b>: displays easily exploitable vulnerability.</description></item>
        /// <item><description><b>imageVulClean</b>: vulnerability retention duration.</description></item>
        /// <item><description><b>yum</b>: preferentially uses YUM or APT sources of Alibaba Cloud to fix vulnerabilities.</description></item>
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
