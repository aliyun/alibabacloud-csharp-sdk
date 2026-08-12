// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Starrocks20221019.Models
{
    public class AddBackupPolicyRequest : TeaModel {
        /// <summary>
        /// <para>The number of days to retain the backup data.</para>
        /// 
        /// <b>Example:</b>
        /// <para>7</para>
        /// </summary>
        [NameInMap("ExpireDays")]
        [Validation(Required=false)]
        public int? ExpireDays { get; set; }

        /// <summary>
        /// <para>The hour.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("Hour")]
        [Validation(Required=false)]
        public int? Hour { get; set; }

        /// <summary>
        /// <para>The instance ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>c-0104730e9de40215</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The minute.</para>
        /// 
        /// <b>Example:</b>
        /// <para>30</para>
        /// </summary>
        [NameInMap("Minute")]
        [Validation(Required=false)]
        public int? Minute { get; set; }

        /// <summary>
        /// <para>The recurrence type for the policy. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>DAILY: Daily.</para>
        /// </description></item>
        /// <item><description><para>WEEKLY: Weekly.</para>
        /// </description></item>
        /// <item><description><para>MONTHLY: Monthly.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>MONTHLY</para>
        /// </summary>
        [NameInMap("RecurrenceType")]
        [Validation(Required=false)]
        public string RecurrenceType { get; set; }

        /// <summary>
        /// <para>The values for the recurrence.</para>
        /// </summary>
        [NameInMap("RecurrenceValues")]
        [Validation(Required=false)]
        public List<int?> RecurrenceValues { get; set; }

        /// <summary>
        /// <para>The timeout period for the backup job in seconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3600</para>
        /// </summary>
        [NameInMap("TimeoutSeconds")]
        [Validation(Required=false)]
        public int? TimeoutSeconds { get; set; }

    }

}
