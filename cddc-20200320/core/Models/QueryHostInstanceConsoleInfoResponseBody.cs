// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cddc20200320.Models
{
    public class QueryHostInstanceConsoleInfoResponseBody : TeaModel {
        /// <summary>
        /// The queried instances.
        /// </summary>
        [NameInMap("HostInstanceConsoleInfos")]
        [Validation(Required=false)]
        public List<QueryHostInstanceConsoleInfoResponseBodyHostInstanceConsoleInfos> HostInstanceConsoleInfos { get; set; }
        public class QueryHostInstanceConsoleInfoResponseBodyHostInstanceConsoleInfos : TeaModel {
            /// <summary>
            /// The number of CPU cores of the instance.
            /// </summary>
            [NameInMap("CpuCores")]
            [Validation(Required=false)]
            public int? CpuCores { get; set; }

            /// <summary>
            /// The maximum number of CPU cores of the instance.
            /// </summary>
            [NameInMap("CpuIncreaseRatioValue")]
            [Validation(Required=false)]
            public int? CpuIncreaseRatioValue { get; set; }

            /// <summary>
            /// The description of the instance.
            /// </summary>
            [NameInMap("DBInstanceDescription")]
            [Validation(Required=false)]
            public string DBInstanceDescription { get; set; }

            /// <summary>
            /// The instance ID.
            /// </summary>
            [NameInMap("DBInstanceId")]
            [Validation(Required=false)]
            public string DBInstanceId { get; set; }

            /// <summary>
            /// The storage capacity of the instance. Unit: GB.
            /// </summary>
            [NameInMap("DiskSize")]
            [Validation(Required=false)]
            public int? DiskSize { get; set; }

            /// <summary>
            /// The database engine of the instance.
            /// </summary>
            [NameInMap("Engine")]
            [Validation(Required=false)]
            public string Engine { get; set; }

            /// <summary>
            /// The version of the database engine.
            /// </summary>
            [NameInMap("EngineVersion")]
            [Validation(Required=false)]
            public string EngineVersion { get; set; }

            /// <summary>
            /// The IP address of the host on which the instance is deployed.
            /// </summary>
            [NameInMap("Ip")]
            [Validation(Required=false)]
            public string Ip { get; set; }

            /// <summary>
            /// The instance type of the instance.
            /// </summary>
            [NameInMap("LevelName")]
            [Validation(Required=false)]
            public string LevelName { get; set; }

            /// <summary>
            /// The maximum number of connections to the instance.
            /// </summary>
            [NameInMap("MaxConnIncreaseRatioValue")]
            [Validation(Required=false)]
            public int? MaxConnIncreaseRatioValue { get; set; }

            /// <summary>
            /// The memory size of the instance. Unit: GB.
            /// </summary>
            [NameInMap("MemSize")]
            [Validation(Required=false)]
            public int? MemSize { get; set; }

            /// <summary>
            /// The maximum memory size of the instance.
            /// </summary>
            [NameInMap("MemoryIncreaseRatioValue")]
            [Validation(Required=false)]
            public int? MemoryIncreaseRatioValue { get; set; }

            /// <summary>
            /// The performance information of the host on which the instance is deployed.
            /// </summary>
            [NameInMap("PerfInfo")]
            [Validation(Required=false)]
            public QueryHostInstanceConsoleInfoResponseBodyHostInstanceConsoleInfosPerfInfo PerfInfo { get; set; }
            public class QueryHostInstanceConsoleInfoResponseBodyHostInstanceConsoleInfosPerfInfo : TeaModel {
                /// <summary>
                /// The number of CPU cores of the host.
                /// </summary>
                [NameInMap("CpuRatio")]
                [Validation(Required=false)]
                public float? CpuRatio { get; set; }

                /// <summary>
                /// The disk storage of the host. Unit: GB.
                /// </summary>
                [NameInMap("DiskCurr")]
                [Validation(Required=false)]
                public float? DiskCurr { get; set; }

                /// <summary>
                /// The memory size of the host. Unit: GB.
                /// </summary>
                [NameInMap("MemRatio")]
                [Validation(Required=false)]
                public float? MemRatio { get; set; }

                /// <summary>
                /// The number of physical I/O operations performed on the host.
                /// </summary>
                [NameInMap("PerfIdbPio")]
                [Validation(Required=false)]
                public float? PerfIdbPio { get; set; }

            }

            /// <summary>
            /// The port number of the host.
            /// </summary>
            [NameInMap("Port")]
            [Validation(Required=false)]
            public string Port { get; set; }

            /// <summary>
            /// The role of the instance.
            /// </summary>
            [NameInMap("Role")]
            [Validation(Required=false)]
            public string Role { get; set; }

            /// <summary>
            /// The state of the instance.
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
