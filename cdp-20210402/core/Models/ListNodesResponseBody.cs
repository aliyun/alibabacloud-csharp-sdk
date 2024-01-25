// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cdp20210402.Models
{
    public class ListNodesResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<ListNodesResponseBodyData> Data { get; set; }
        public class ListNodesResponseBodyData : TeaModel {
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public long? CreateTime { get; set; }

            [NameInMap("EcsNodeDtoList")]
            [Validation(Required=false)]
            public List<ListNodesResponseBodyDataEcsNodeDtoList> EcsNodeDtoList { get; set; }
            public class ListNodesResponseBodyDataEcsNodeDtoList : TeaModel {
                [NameInMap("BeginTime")]
                [Validation(Required=false)]
                public string BeginTime { get; set; }

                [NameInMap("CpuCount")]
                [Validation(Required=false)]
                public int? CpuCount { get; set; }

                [NameInMap("DiskCapacity")]
                [Validation(Required=false)]
                public int? DiskCapacity { get; set; }

                [NameInMap("DiskCount")]
                [Validation(Required=false)]
                public int? DiskCount { get; set; }

                [NameInMap("DiskType")]
                [Validation(Required=false)]
                public string DiskType { get; set; }

                [NameInMap("ExpireTime")]
                [Validation(Required=false)]
                public long? ExpireTime { get; set; }

                [NameInMap("GmtCreate")]
                [Validation(Required=false)]
                public string GmtCreate { get; set; }

                [NameInMap("GmtModified")]
                [Validation(Required=false)]
                public string GmtModified { get; set; }

                [NameInMap("Index")]
                [Validation(Required=false)]
                public int? Index { get; set; }

                [NameInMap("InstanceType")]
                [Validation(Required=false)]
                public string InstanceType { get; set; }

                [NameInMap("MemorySize")]
                [Validation(Required=false)]
                public int? MemorySize { get; set; }

                [NameInMap("NodeGroupId")]
                [Validation(Required=false)]
                public string NodeGroupId { get; set; }

                [NameInMap("NodeGroupName")]
                [Validation(Required=false)]
                public string NodeGroupName { get; set; }

                [NameInMap("NodeGroupType")]
                [Validation(Required=false)]
                public string NodeGroupType { get; set; }

                [NameInMap("NodeId")]
                [Validation(Required=false)]
                public string NodeId { get; set; }

                [NameInMap("NodeName")]
                [Validation(Required=false)]
                public string NodeName { get; set; }

                [NameInMap("NodeResourceType")]
                [Validation(Required=false)]
                public string NodeResourceType { get; set; }

                [NameInMap("NodeStatus")]
                [Validation(Required=false)]
                public string NodeStatus { get; set; }

                [NameInMap("PrivateIp")]
                [Validation(Required=false)]
                public string PrivateIp { get; set; }

                [NameInMap("PublicIp")]
                [Validation(Required=false)]
                public string PublicIp { get; set; }

                [NameInMap("RunningTime")]
                [Validation(Required=false)]
                public long? RunningTime { get; set; }

                [NameInMap("SerialNumber")]
                [Validation(Required=false)]
                public string SerialNumber { get; set; }

                [NameInMap("SystemDiskCapacity")]
                [Validation(Required=false)]
                public int? SystemDiskCapacity { get; set; }

                [NameInMap("SystemDiskCount")]
                [Validation(Required=false)]
                public int? SystemDiskCount { get; set; }

                [NameInMap("SystemDiskType")]
                [Validation(Required=false)]
                public string SystemDiskType { get; set; }

            }

            [NameInMap("ExpireTime")]
            [Validation(Required=false)]
            public long? ExpireTime { get; set; }

            [NameInMap("InstanceConf")]
            [Validation(Required=false)]
            public Dictionary<string, object> InstanceConf { get; set; }

            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            [NameInMap("InstanceName")]
            [Validation(Required=false)]
            public string InstanceName { get; set; }

        }

        [NameInMap("ErrCode")]
        [Validation(Required=false)]
        public string ErrCode { get; set; }

        [NameInMap("ErrMessage")]
        [Validation(Required=false)]
        public string ErrMessage { get; set; }

        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
