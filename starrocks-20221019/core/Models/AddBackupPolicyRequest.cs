// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Starrocks20221019.Models
{
    public class AddBackupPolicyRequest : TeaModel {
        /// <summary>
        /// <para>The number of days that the backup data remains valid.</para>
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
        /// <para>Specifies the execution type of the time rule. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>DAILY: Repeats daily.</description></item>
        /// <item><description>WEEKLY: Repeats weekly.</description></item>
        /// <item><description>MONTHLY: Repeats monthly.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>MONTHLY</para>
        /// </summary>
        [NameInMap("RecurrenceType")]
        [Validation(Required=false)]
        public string RecurrenceType { get; set; }

        /// <summary>
        /// <para>The values for the policy execution cycle.</para>
        /// </summary>
        [NameInMap("RecurrenceValues")]
        [Validation(Required=false)]
        public List<int?> RecurrenceValues { get; set; }

        /// <summary>
        /// <para>The timeout period for the backup task, in seconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3600</para>
        /// </summary>
        [NameInMap("TimeoutSeconds")]
        [Validation(Required=false)]
        public int? TimeoutSeconds { get; set; }

    }

}
