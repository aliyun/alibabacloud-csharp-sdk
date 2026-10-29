// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20190101.Models
{
    public class DisableMetricRulesRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether to perform a dry run of the request. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: sends a dry run request and does not bind a security group to the instance. Check items include whether required parameters are specified, the request format, and service limits. If the request fails the check, the corresponding error is returned. If the request passes the check, the <c>DryRunOperation</c> error code is returned.</description></item>
        /// <item><description><b>false</b> (default): sends a normal request. If the request passes the check, an HTTP 2xx status code is returned and the operation is performed.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("DryRun")]
        [Validation(Required=false)]
        public bool? DryRun { get; set; }

        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The ID of the alert rule.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("RuleId")]
        [Validation(Required=false)]
        public List<string> RuleId { get; set; }

    }

}
