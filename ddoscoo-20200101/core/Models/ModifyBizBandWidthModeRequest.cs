// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ddoscoo20200101.Models
{
    public class ModifyBizBandWidthModeRequest : TeaModel {
        /// <summary>
        /// The ID of the instance.
        /// 
        /// > You can call the [DescribeInstanceIds](~~157459~~) operation to query the IDs of all instances.
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// The metering method of the burstable clean bandwidth feature. Valid values:
        /// 
        /// *   **month**: the metering method of monthly 95th percentile
        /// *   **day**: the metering method of daily 95th percentile
        /// </summary>
        [NameInMap("Mode")]
        [Validation(Required=false)]
        public string Mode { get; set; }

    }

}
