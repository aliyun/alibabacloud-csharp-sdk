// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20190101.Models
{
    public class EnableMetricRulesRequest : TeaModel {
        /// <summary>
        /// <para>The client token that is used to ensure the idempotence of the request. You can use the client to generate the value, and you must ensure that the value is unique among different requests. The token can contain only ASCII characters and cannot exceed 64 characters in length. For more information, see How to ensure idempotence.</para>
        /// 
        /// <b>Example:</b>
        /// <para>6868E9A1-56E6-5FD7-9684-E2963BBAFB5F</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>Specifies whether to precheck only this request. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: sends a check request and does not associate a security group with the instance. The check items include whether the required parameters are specified, the request format is valid, and the service limits are met. If the check fails, the corresponding error is returned. If the check succeeds, the error code <c>DryRunOperation</c> is returned.</description></item>
        /// <item><description><b>false</b> (default): sends a regular request. If the check succeeds, an HTTP 2xx status code is returned and the operation is directly performed.</description></item>
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
        /// <para>Valid values of N: 1 to 100.</para>
        /// <para>For more information about how to obtain the ID of an alert rule, see <a href="https://help.aliyun.com/document_detail/114941.html">DescribeMetricRuleList</a>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ab05733c97b7ce239fb1b53393dc1697c123****</para>
        /// </summary>
        [NameInMap("RuleId")]
        [Validation(Required=false)]
        public List<string> RuleId { get; set; }

    }

}
