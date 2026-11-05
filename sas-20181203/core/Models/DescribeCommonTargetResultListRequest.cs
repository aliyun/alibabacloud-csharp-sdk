// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeCommonTargetResultListRequest : TeaModel {
        /// <summary>
        /// <para>The source IP address to query.</para>
        /// 
        /// <b>Example:</b>
        /// <para>113.57.XX.XX</para>
        /// </summary>
        [NameInMap("SourceIp")]
        [Validation(Required=false)]
        public string SourceIp { get; set; }

        /// <summary>
        /// <para>The type of the configuration rule. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>webshell_timescan</b>: Web shell detection and removal.</description></item>
        /// <item><description><b>aliscriptengine</b>: Deep inspection engine.</description></item>
        /// <item><description><b>alidetect</b>: Installation scope of the local file detection engine.</description></item>
        /// <item><description><b>alidetect-scan-enable</b>: Scan scope of the local file detection engine.</description></item>
        /// </list>
        /// <remarks>
        /// <para>You can call the <a href="~~ListClientUserDefineRules~~">ListClientUserDefineRules</a> and <a href="~~ListSystemClientRules~~">ListSystemClientRules</a> operations to obtain more custom and system-defined rule types.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>webshell_timescan</para>
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
