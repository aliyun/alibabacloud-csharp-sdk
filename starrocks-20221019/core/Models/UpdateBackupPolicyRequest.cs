// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Starrocks20221019.Models
{
    public class UpdateBackupPolicyRequest : TeaModel {
        /// <summary>
        /// <para>Validity period in days.</para>
        /// 
        /// <b>Example:</b>
        /// <para>7</para>
        /// </summary>
        [NameInMap("ExpireDays")]
        [Validation(Required=false)]
        public int? ExpireDays { get; set; }

        /// <summary>
        /// <para>Trigger time: hour.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("Hour")]
        [Validation(Required=false)]
        public int? Hour { get; set; }

        /// <summary>
        /// <para>Instance ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>c-0104730e9de40215</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>Trigger time: minute.</para>
        /// 
        /// <b>Example:</b>
        /// <para>15</para>
        /// </summary>
        [NameInMap("Minute")]
        [Validation(Required=false)]
        public int? Minute { get; set; }

        /// <summary>
        /// <para>Backup policy ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>bk-9812023</para>
        /// </summary>
        [NameInMap("PolicyId")]
        [Validation(Required=false)]
        public string PolicyId { get; set; }

        /// <summary>
        /// <para>Numerical values for the policy execution cycle.</para>
        /// </summary>
        [NameInMap("RecurrenceValues")]
        [Validation(Required=false)]
        public List<int?> RecurrenceValues { get; set; }

        /// <summary>
        /// <para>Timeout duration for the backup policy.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3600</para>
        /// </summary>
        [NameInMap("TimeoutSeconds")]
        [Validation(Required=false)]
        public int? TimeoutSeconds { get; set; }

    }

}
