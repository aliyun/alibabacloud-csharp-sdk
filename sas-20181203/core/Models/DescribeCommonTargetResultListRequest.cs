// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeCommonTargetResultListRequest : TeaModel {
        /// <summary>
        /// <para>The source IP address of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>113.57.XX.XX</para>
        /// </summary>
        [NameInMap("SourceIp")]
        [Validation(Required=false)]
        public string SourceIp { get; set; }

        /// <summary>
        /// <para>The type of the configuration item. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>webshell_timescan</b>: webshell detection and removal</description></item>
        /// <item><description><b>aliscriptengine</b>: in-depth detection engine</description></item>
        /// <item><description><b>alidetect</b>: installation scope of local file detection</description></item>
        /// <item><description><b>alidetect-scan-enable</b>: detection scope of local file detection</description></item>
        /// </list>
        /// <remarks>
        /// <para> You can call the <a href="~~ListClientUserDefineRules~~">ListClientUserDefineRules</a> and <a href="~~ListSystemClientRules~~">ListSystemClientRules</a> operations to obtain more types of custom and system configuration items.</para>
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
