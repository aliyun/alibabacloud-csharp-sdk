// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20190101.Models
{
    public class DeleteMetricRulesRequest : TeaModel {
        /// <summary>
        /// <para>Ensures the idempotence of the request. Generate a parameter value on your client to ensure that the value is unique across different requests. ClientToken supports only ASCII characters and can be up to 64 characters in length. For more information, see How to ensure idempotence.</para>
        /// 
        /// <b>Example:</b>
        /// <para>6868E9A1-56E6-5FD7-9684-E2963BBAFB5F</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>Specifies whether to perform a dry run only. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: Sends a check request and does not bind the security group to the instance. The check items include whether required parameters are specified, the request format, and service limits. If the check fails, the corresponding error is returned. If the check succeeds, the <c>DryRunOperation</c> error code is returned.</description></item>
        /// <item><description><b>false</b> (default): Sends a normal request. If the check succeeds, an HTTP 2xx status code is returned and the operation is performed.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("DryRun")]
        [Validation(Required=false)]
        public bool? DryRun { get; set; }

        /// <summary>
        /// <para>The IDs of the alert rules to delete.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("Id")]
        [Validation(Required=false)]
        public List<string> Id { get; set; }

        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

    }

}
