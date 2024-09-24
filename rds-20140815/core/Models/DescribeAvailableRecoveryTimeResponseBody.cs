// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class DescribeAvailableRecoveryTimeResponseBody : TeaModel {
        /// <summary>
        /// <para>The ID of the cross-region data backup file.</para>
        /// 
        /// <b>Example:</b>
        /// <para>14377</para>
        /// </summary>
        [NameInMap("CrossBackupId")]
        [Validation(Required=false)]
        public int? CrossBackupId { get; set; }

        /// <summary>
        /// <para>The start time from which data can be restored. The time follows the ISO 8601 standard in the yyyy-MM-ddTHH:mm:ssZ format. The time is displayed in UTC.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2019-06-12T05:22:29Z</para>
        /// </summary>
        [NameInMap("RecoveryBeginTime")]
        [Validation(Required=false)]
        public string RecoveryBeginTime { get; set; }

        /// <summary>
        /// <para>The end time to which data can be restored. The time follows the ISO 8601 standard in the yyyy-MM-ddTHH:mm:ssZ format. The time is displayed in UTC.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2019-06-12T07:33:12Z</para>
        /// </summary>
        [NameInMap("RecoveryEndTime")]
        [Validation(Required=false)]
        public string RecoveryEndTime { get; set; }

        /// <summary>
        /// <para>The region where the source instance resides.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
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
