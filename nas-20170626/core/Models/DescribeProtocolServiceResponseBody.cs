// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.NAS20170626.Models
{
    public class DescribeProtocolServiceResponseBody : TeaModel {
        /// <summary>
        /// A pagination token. It can be used in the next request to retrieve a new page of results.
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// The information about protocol services.
        /// </summary>
        [NameInMap("ProtocolServices")]
        [Validation(Required=false)]
        public List<DescribeProtocolServiceResponseBodyProtocolServices> ProtocolServices { get; set; }
        public class DescribeProtocolServiceResponseBodyProtocolServices : TeaModel {
            /// <summary>
            /// The time when the protocol service was created. The time is displayed in UTC.
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// The description of the protocol service.
            /// 
            /// Limits:
            /// 
            /// *   The description must be 2 to 128 characters in length.
            /// *   The description must start with a letter and cannot start with `http://` or `https://`.
            /// *   The description can contain letters, digits, colons (:), underscores (\_), and hyphens (-).
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// The ID of the file system.
            /// </summary>
            [NameInMap("FileSystemId")]
            [Validation(Required=false)]
            public string FileSystemId { get; set; }

            /// <summary>
            /// The base throughput of the protocol service. Unit: MB/s.
            /// </summary>
            [NameInMap("InstanceBaseThroughput")]
            [Validation(Required=false)]
            public int? InstanceBaseThroughput { get; set; }

            /// <summary>
            /// The burst throughput of the protocol service. Unit: MB/s.
            /// </summary>
            [NameInMap("InstanceBurstThroughput")]
            [Validation(Required=false)]
            public int? InstanceBurstThroughput { get; set; }

            /// <summary>
            /// The memory cache size of the protocol service. Unit: GiB.
            /// </summary>
            [NameInMap("InstanceRAM")]
            [Validation(Required=false)]
            public int? InstanceRAM { get; set; }

            /// <summary>
            /// The time when the protocol service was modified. The time is displayed in UTC.
            /// </summary>
            [NameInMap("ModifyTime")]
            [Validation(Required=false)]
            public string ModifyTime { get; set; }

            /// <summary>
            /// The total number of CPFS directories and filesets exported in the protocol service.
            /// </summary>
            [NameInMap("MountTargetCount")]
            [Validation(Required=false)]
            public int? MountTargetCount { get; set; }

            /// <summary>
            /// The ID of the protocol service.
            /// </summary>
            [NameInMap("ProtocolServiceId")]
            [Validation(Required=false)]
            public string ProtocolServiceId { get; set; }

            /// <summary>
            /// The specification of the protocol service.
            /// 
            /// *   Valid value: General.
            /// *   Default value: General.
            /// </summary>
            [NameInMap("ProtocolSpec")]
            [Validation(Required=false)]
            public string ProtocolSpec { get; set; }

            /// <summary>
            /// The throughput of the protocol service. Unit: MB/s.
            /// </summary>
            [NameInMap("ProtocolThroughput")]
            [Validation(Required=false)]
            public int? ProtocolThroughput { get; set; }

            /// <summary>
            /// The protocol type supported by the protocol service.
            /// 
            /// Valid values:
            /// 
            /// *   NFS: The protocol service supports access over the Network File System (NFS) protocol.
            /// </summary>
            [NameInMap("ProtocolType")]
            [Validation(Required=false)]
            public string ProtocolType { get; set; }

            /// <summary>
            /// The status of the protocol service.
            /// 
            /// Valid values:
            /// 
            /// *   Creating: The protocol service is being created.
            /// *   Starting: The protocol service is being started.
            /// *   Running: The protocol service is running.
            /// *   Updating: The protocol service is being updated.
            /// *   Deleting: The protocol service is being deleted.
            /// *   Stopping: The protocol service is being stopped.
            /// *   Stopped: The protocol service is stopped.
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

        }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
