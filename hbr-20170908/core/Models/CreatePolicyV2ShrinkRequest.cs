// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Hbr20170908.Models
{
    public class CreatePolicyV2ShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The policy description.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Backup once every day at 10:00 AM, with cross-region backup to Shanghai.</para>
        /// </summary>
        [NameInMap("PolicyDescription")]
        [Validation(Required=false)]
        public string PolicyDescription { get; set; }

        /// <summary>
        /// <para>The policy name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Daily local backup + geo-redundancy</para>
        /// </summary>
        [NameInMap("PolicyName")]
        [Validation(Required=false)]
        public string PolicyName { get; set; }

        /// <summary>
        /// <para>The policy type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>STANDARD</b>: general backup policy. Supports backing up data sources other than ECS full-server backup.</description></item>
        /// <item><description><b>UDM_ECS_ONLY</b>: full-server backup policy. Supports only ECS full-server backup.</description></item>
        /// </list>
        /// <para>If the policy type is not specified, Cloud Backup automatically sets the policy type based on whether a backup vault is specified in the policy rules:</para>
        /// <list type="bullet">
        /// <item><description>Backup vault specified in policy rules: <b>STANDARD</b></description></item>
        /// <item><description>Backup vault not specified in policy rules: <b>UDM_ECS_ONLY</b></description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>STANDARD</para>
        /// </summary>
        [NameInMap("PolicyType")]
        [Validation(Required=false)]
        public string PolicyType { get; set; }

        /// <summary>
        /// <para>The list of policy rules.</para>
        /// </summary>
        [NameInMap("Rules")]
        [Validation(Required=false)]
        public string RulesShrink { get; set; }

    }

}
