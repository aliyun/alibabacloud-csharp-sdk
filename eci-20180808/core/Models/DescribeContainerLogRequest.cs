// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eci20180808.Models
{
    public class DescribeContainerLogRequest : TeaModel {
        /// <summary>
        /// The instance ID.
        /// </summary>
        [NameInMap("ContainerGroupId")]
        [Validation(Required=false)]
        public string ContainerGroupId { get; set; }

        /// <summary>
        /// The name of the container.
        /// </summary>
        [NameInMap("ContainerName")]
        [Validation(Required=false)]
        public string ContainerName { get; set; }

        /// <summary>
        /// Specifies whether to query the logs of the previous container if the container exits and restarts. Valid values:
        /// 
        /// *   true
        /// *   false
        /// 
        /// Default value: false.
        /// </summary>
        [NameInMap("LastTime")]
        [Validation(Required=false)]
        public bool? LastTime { get; set; }

        /// <summary>
        /// The limit on the total size of logs. Unit: bytes. Valid values: 1 to 1048576(1 MB).
        /// </summary>
        [NameInMap("LimitBytes")]
        [Validation(Required=false)]
        public long? LimitBytes { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// The region ID of the elastic container instance.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        /// <summary>
        /// A relative time in seconds before the current time from which to show logs. Examples: 10, 20, and 30.
        /// </summary>
        [NameInMap("SinceSeconds")]
        [Validation(Required=false)]
        public int? SinceSeconds { get; set; }

        /// <summary>
        /// The beginning of the time range to query. Specify the time in the RFC 3339 standard. The time must be in UTC.
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

        /// <summary>
        /// The number of log entries that you want to query. Default value: 500. Maximum value: 2000. A maximum of 1 MB of logs can be returned.
        /// </summary>
        [NameInMap("Tail")]
        [Validation(Required=false)]
        public int? Tail { get; set; }

        /// <summary>
        /// Specifies whether to return the timestamps of logs. Valid values:
        /// 
        /// *   true
        /// *   false
        /// 
        /// Default value: false.
        /// </summary>
        [NameInMap("Timestamps")]
        [Validation(Required=false)]
        public bool? Timestamps { get; set; }

    }

}
