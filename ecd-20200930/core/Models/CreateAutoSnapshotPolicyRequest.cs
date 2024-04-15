// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecd20200930.Models
{
    public class CreateAutoSnapshotPolicyRequest : TeaModel {
        /// <summary>
        /// The CRON expression for periodic scheduling.
        /// </summary>
        [NameInMap("CronExpression")]
        [Validation(Required=false)]
        public string CronExpression { get; set; }

        /// <summary>
        /// The name of the automatic snapshot policy. The name must be 2 to 128 characters in length. The name must start with a letter but cannot start with `http://` or `https://`. The name can contain letters, digits, colons (:), underscores (\_), and hyphens (-). This parameter is empty by default.
        /// </summary>
        [NameInMap("PolicyName")]
        [Validation(Required=false)]
        public string PolicyName { get; set; }

        /// <summary>
        /// The region ID. You can call the [DescribeRegions](~~196646~~) operation to query the most recent region list.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// The retention period of the automatic snapshots. Unit: days. Valid values: 1 to 180.
        /// </summary>
        [NameInMap("RetentionDays")]
        [Validation(Required=false)]
        public int? RetentionDays { get; set; }

    }

}
