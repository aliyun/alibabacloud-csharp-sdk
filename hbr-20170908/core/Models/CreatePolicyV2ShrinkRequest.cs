// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Hbr20170908.Models
{
    public class CreatePolicyV2ShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The description of the backup policy.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Data is backed up at 10:00:00 every day and replicated to the China (Shanghai) region for geo-redundancy.</para>
        /// </summary>
        [NameInMap("PolicyDescription")]
        [Validation(Required=false)]
        public string PolicyDescription { get; set; }

        /// <summary>
        /// <para>The name of the backup policy.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Daily Local Backup + Remote Backup</para>
        /// </summary>
        [NameInMap("PolicyName")]
        [Validation(Required=false)]
        public string PolicyName { get; set; }

        /// <summary>
        /// <para>The policy type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>STANDARD</b>: the general backup policy. This type of policy applies to backups other than Elastic Compute Service (ECS) instance backup.</description></item>
        /// <item><description><b>UDM_ECS_ONLY</b>: This type of policy applies only to ECS instance backup.</description></item>
        /// </list>
        /// <para>If the policy type is not specified, Cloud Backup automatically sets the policy type based on whether the backup vault is specified in the rules of the policy:</para>
        /// <list type="bullet">
        /// <item><description>If the backup vault is specified, Cloud Backup sets the policy type to <b>STANDARD</b>.</description></item>
        /// <item><description>If the backup vault is not specified, Cloud Backup sets the policy type to <b>UDM_ECS_ONLY</b>.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>STANDARD</para>
        /// </summary>
        [NameInMap("PolicyType")]
        [Validation(Required=false)]
        public string PolicyType { get; set; }

        /// <summary>
        /// <para>The rules in the backup policy.</para>
        /// </summary>
        [NameInMap("Rules")]
        [Validation(Required=false)]
        public string RulesShrink { get; set; }

    }

}
