// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeCommonTargetResultListRequest : TeaModel {
        /// <summary>
        /// <para>The IP address of the access source to query.</para>
        /// 
        /// <b>Example:</b>
        /// <para>113.57.XX.XX</para>
        /// </summary>
        [NameInMap("SourceIp")]
        [Validation(Required=false)]
        public string SourceIp { get; set; }

        /// <summary>
        /// <para>The configuration rule type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>webshell_timescan</b>: web shell scan.</description></item>
        /// <item><description><b>aliscriptengine</b>: deep detection engine.</description></item>
        /// <item><description><b>alidetect</b>: installation scope of the local file detection engine.</description></item>
        /// <item><description><b>alidetect-scan-enable</b>: detection scope of the local file detection engine.</description></item>
        /// </list>
        /// <remarks>
        /// <para>You can call <a href="~~ListClientUserDefineRules~~">ListClientUserDefineRules</a> and <a href="~~ListSystemClientRules~~">ListSystemClientRules</a> to obtain more custom and system-configured rule types.</para>
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
