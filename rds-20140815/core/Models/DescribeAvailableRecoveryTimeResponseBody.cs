// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class DescribeAvailableRecoveryTimeResponseBody : TeaModel {
        /// <summary>
        /// <para>The ID of the cross-region backup file.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1249****</para>
        /// </summary>
        [NameInMap("CrossBackupId")]
        [Validation(Required=false)]
        public int? CrossBackupId { get; set; }

        /// <summary>
        /// <para>The start time of the restorable time range for the cross-region backup file. The time follows the format: yyyy-MM-ddTHH:mm:ssZ (UTC).</para>
        /// 
        /// <b>Example:</b>
        /// <para>2024-03-04T21:00:47Z</para>
        /// </summary>
        [NameInMap("RecoveryBeginTime")]
        [Validation(Required=false)]
        public string RecoveryBeginTime { get; set; }

        /// <summary>
        /// <para>The end time of the restorable time range for the cross-region backup file. The time follows the format: yyyy-MM-ddTHH:mm:ssZ (UTC).</para>
        /// 
        /// <b>Example:</b>
        /// <para>2024-03-07T02:23:26Z</para>
        /// </summary>
        [NameInMap("RecoveryEndTime")]
        [Validation(Required=false)]
        public string RecoveryEndTime { get; set; }

        /// <summary>
        /// <para>The region where the source instance resides.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-chengdu</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>8CCBF4BA-7CE1-47E1-B49F-E97EA200A40D</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
