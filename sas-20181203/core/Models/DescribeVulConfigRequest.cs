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
        /// <para>The type of vulnerability management configuration. By default, all types of configurations are queried. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>cve</b>: Linux software vulnerability</description></item>
        /// <item><description><b>sys</b>: Windows system vulnerability</description></item>
        /// <item><description><b>cms</b>: Web-CMS vulnerability</description></item>
        /// <item><description><b>app</b>: application vulnerability (web scanner)</description></item>
        /// <item><description><b>emg</b>: emergency vulnerability</description></item>
        /// <item><description><b>scanMode</b>: display real-risk vulnerabilities</description></item>
        /// <item><description><b>imageVulClean</b>: vulnerability retention period</description></item>
        /// <item><description><b>yum</b>: prioritize Alibaba Cloud sources for vulnerability fixing.</description></item>
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
