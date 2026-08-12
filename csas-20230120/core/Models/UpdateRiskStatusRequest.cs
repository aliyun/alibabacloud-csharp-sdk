// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Csas20230120.Models
{
    public class UpdateRiskStatusRequest : TeaModel {
        /// <summary>
        /// <para>The manually confirmed risk conclusion. This parameter is required when <c>Status</c> is set to <c>Processed</c>. Do not specify this parameter when <c>Status</c> is set to <c>Unprocess</c> or <c>Processing</c>. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><c>Risk</c>: Confirmed as risky.</description></item>
        /// <item><description><c>Ignore</c>: Confirmed as not risky.</description></item>
        /// <item><description><c>Invalid</c>: Confirmed as a false positive.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Risk</para>
        /// </summary>
        [NameInMap("RiskConfirm")]
        [Validation(Required=false)]
        public string RiskConfirm { get; set; }

        /// <summary>
        /// <para>The description of the risk event handling. The length must be 1 to 128 characters.</para>
        /// 
        /// <b>Example:</b>
        /// <para>After verification, this risk event is a real risk</para>
        /// </summary>
        [NameInMap("RiskConfirmDesc")]
        [Validation(Required=false)]
        public string RiskConfirmDesc { get; set; }

        /// <summary>
        /// <para>The risk event ID. You can obtain the value from the following operation:</para>
        /// <list type="bullet">
        /// <item><description><c>ListRiskItems</c>: Queries the list of risk events.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>69ef648034cf53d7bac7a9c9c912****</para>
        /// </summary>
        [NameInMap("RiskId")]
        [Validation(Required=false)]
        public string RiskId { get; set; }

        /// <summary>
        /// <para>The risk scenario. This parameter is optional. If not specified, the system automatically populates it based on RiskId. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>account_share: Account sharing.</description></item>
        /// <item><description>account_stolen: Account stolen.</description></item>
        /// <item><description>device_share: Device sharing.</description></item>
        /// <item><description>remote_logon: Remote logon.</description></item>
        /// <item><description>sensitive_data_leakage: Sensitive data leakage.</description></item>
        /// <item><description>lateral_scanning: Lateral scanning.</description></item>
        /// <item><description>ai_skill_malware: Malicious skill.</description></item>
        /// <item><description>ai_config_check: AI configuration check.</description></item>
        /// <item><description>openclaw_vulnerability: OpenClaw vulnerability.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>account_stolen</para>
        /// </summary>
        [NameInMap("RiskScene")]
        [Validation(Required=false)]
        public string RiskScene { get; set; }

        /// <summary>
        /// <para>The handling status of the risk event. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><c>Unprocess</c>: Unprocessed.</description></item>
        /// <item><description><c>Processing</c>: Being processed.</description></item>
        /// <item><description><c>Processed</c>: Processed.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Processed</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

    }

}
