// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eflo_controller20221215.Models
{
    public class DescribeNodeGroupResponseBody : TeaModel {
        [NameInMap("Az")]
        [Validation(Required=false)]
        public string Az { get; set; }

        [NameInMap("ClusterId")]
        [Validation(Required=false)]
        public string ClusterId { get; set; }

        [NameInMap("ClusterName")]
        [Validation(Required=false)]
        public string ClusterName { get; set; }

        [NameInMap("CreateTime")]
        [Validation(Required=false)]
        public string CreateTime { get; set; }

        [NameInMap("FileSystemMountEnabled")]
        [Validation(Required=false)]
        public bool? FileSystemMountEnabled { get; set; }

        [NameInMap("ImageId")]
        [Validation(Required=false)]
        public string ImageId { get; set; }

        [NameInMap("ImageName")]
        [Validation(Required=false)]
        public string ImageName { get; set; }

        [NameInMap("KeyPairName")]
        [Validation(Required=false)]
        public string KeyPairName { get; set; }

        [NameInMap("LoginType")]
        [Validation(Required=false)]
        public string LoginType { get; set; }

        [NameInMap("MachineType")]
        [Validation(Required=false)]
        public string MachineType { get; set; }

        [NameInMap("NodeCount")]
        [Validation(Required=false)]
        public string NodeCount { get; set; }

        [NameInMap("NodeGroupDescription")]
        [Validation(Required=false)]
        public string NodeGroupDescription { get; set; }

        [NameInMap("NodeGroupId")]
        [Validation(Required=false)]
        public string NodeGroupId { get; set; }

        [NameInMap("NodeGroupName")]
        [Validation(Required=false)]
        public string NodeGroupName { get; set; }

        /// <summary>
        /// <para>Id of the request</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("SystemDisk")]
        [Validation(Required=false)]
        public DescribeNodeGroupResponseBodySystemDisk SystemDisk { get; set; }
        public class DescribeNodeGroupResponseBodySystemDisk : TeaModel {
            [NameInMap("Category")]
            [Validation(Required=false)]
            public string Category { get; set; }

            [NameInMap("PerformanceLevel")]
            [Validation(Required=false)]
            public string PerformanceLevel { get; set; }

            [NameInMap("Size")]
            [Validation(Required=false)]
            public int? Size { get; set; }

        }

        [NameInMap("UpdateTime")]
        [Validation(Required=false)]
        public string UpdateTime { get; set; }

        [NameInMap("UserData")]
        [Validation(Required=false)]
        public string UserData { get; set; }

        [NameInMap("VirtualGpuEnabled")]
        [Validation(Required=false)]
        public bool? VirtualGpuEnabled { get; set; }

    }

}
