// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class ModifyUniBackupPolicyRequest : TeaModel {
        /// <summary>
        /// <para>The name of the database account.</para>
        /// 
        /// <b>Example:</b>
        /// <para>sa</para>
        /// </summary>
        [NameInMap("AccountName")]
        [Validation(Required=false)]
        public string AccountName { get; set; }

        /// <summary>
        /// <para>The password of the database account.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Sa@****</para>
        /// </summary>
        [NameInMap("AccountPassword")]
        [Validation(Required=false)]
        public string AccountPassword { get; set; }

        /// <summary>
        /// <para>The policy for full backup. The value of this parameter is a JSON string that contains the following fields:</para>
        /// <list type="bullet">
        /// <item><description><b>start</b>: the start time of a backup task</description></item>
        /// <item><description><b>interval</b>: the interval of backup tasks</description></item>
        /// <item><description><b>type</b>: the unit of the interval</description></item>
        /// <item><description><b>days</b>: the days of a week on which a backup task is performed</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;days&quot;:[4],&quot;interval&quot;:1,&quot;planType&quot;:&quot;weekly&quot;,&quot;startTime&quot;:&quot;22:00:00&quot;}</para>
        /// </summary>
        [NameInMap("FullPlan")]
        [Validation(Required=false)]
        public Dictionary<string, object> FullPlan { get; set; }

        /// <summary>
        /// <para>The policy for incremental backup. The value of this parameter is a JSON string that contains the following fields:</para>
        /// <list type="bullet">
        /// <item><description><b>start</b>: the start time of a backup task</description></item>
        /// <item><description><b>interval</b>: the interval of backup tasks</description></item>
        /// <item><description><b>type</b>: the unit of the interval</description></item>
        /// <item><description><b>days</b>: the days of a week on which a backup task is performed</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;interval&quot;:1,&quot;planType&quot;:&quot;daily&quot;,&quot;startTime&quot;:&quot;23:30:00&quot;}</para>
        /// </summary>
        [NameInMap("IncPlan")]
        [Validation(Required=false)]
        public Dictionary<string, object> IncPlan { get; set; }

        /// <summary>
        /// <para>The ID of the anti-ransomware policy.</para>
        /// <remarks>
        /// <para>You can call the <a href="~~DescribeUniBackupPolicies~~">DescribeUniBackupPolicies</a> operation to query the IDs of anti-ransomware policies.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123</para>
        /// </summary>
        [NameInMap("PolicyId")]
        [Validation(Required=false)]
        public long? PolicyId { get; set; }

        /// <summary>
        /// <para>The name of the anti-ransomware policy.</para>
        /// 
        /// <b>Example:</b>
        /// <para>databak</para>
        /// </summary>
        [NameInMap("PolicyName")]
        [Validation(Required=false)]
        public string PolicyName { get; set; }

        /// <summary>
        /// <para>The status of the anti-ransomware policy. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>enabled</b></description></item>
        /// <item><description><b>disabled</b></description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>enabled</para>
        /// </summary>
        [NameInMap("PolicyStatus")]
        [Validation(Required=false)]
        public string PolicyStatus { get; set; }

        /// <summary>
        /// <para>The retention period of the backup snapshot.</para>
        /// 
        /// <b>Example:</b>
        /// <para>7</para>
        /// </summary>
        [NameInMap("Retention")]
        [Validation(Required=false)]
        public int? Retention { get; set; }

        /// <summary>
        /// <para>The maximum network bandwidth that is allowed during data backup. Unit: bytes.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1048576</para>
        /// </summary>
        [NameInMap("SpeedLimiter")]
        [Validation(Required=false)]
        public long? SpeedLimiter { get; set; }

    }

}
