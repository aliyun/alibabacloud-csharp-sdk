// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ga20191120.Models
{
    public class ListBasicAcceleratorsResponseBody : TeaModel {
        /// <summary>
        /// 全球加速实例列表
        /// </summary>
        [NameInMap("Accelerators")]
        [Validation(Required=false)]
        public List<ListBasicAcceleratorsResponseBodyAccelerators> Accelerators { get; set; }
        public class ListBasicAcceleratorsResponseBodyAccelerators : TeaModel {
            /// <summary>
            /// 全球加速实例Id
            /// </summary>
            [NameInMap("AcceleratorId")]
            [Validation(Required=false)]
            public string AcceleratorId { get; set; }

            /// <summary>
            /// 绑定的基础带宽包
            /// </summary>
            [NameInMap("BasicBandwidthPackage")]
            [Validation(Required=false)]
            public ListBasicAcceleratorsResponseBodyAcceleratorsBasicBandwidthPackage BasicBandwidthPackage { get; set; }
            public class ListBasicAcceleratorsResponseBodyAcceleratorsBasicBandwidthPackage : TeaModel {
                [NameInMap("Bandwidth")]
                [Validation(Required=false)]
                public int? Bandwidth { get; set; }
                [NameInMap("BandwidthType")]
                [Validation(Required=false)]
                public string BandwidthType { get; set; }
                [NameInMap("InstanceId")]
                [Validation(Required=false)]
                public string InstanceId { get; set; }
            };

            /// <summary>
            /// 全球加速实例下车点Id
            /// </summary>
            [NameInMap("BasicEndpointGroupId")]
            [Validation(Required=false)]
            public string BasicEndpointGroupId { get; set; }

            /// <summary>
            /// 全球加速实例上车点Id
            /// </summary>
            [NameInMap("BasicIpSetId")]
            [Validation(Required=false)]
            public string BasicIpSetId { get; set; }

            /// <summary>
            /// 创建时间
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public long? CreateTime { get; set; }

            /// <summary>
            /// 绑定的跨境带宽包
            /// </summary>
            [NameInMap("CrossDomainBandwidthPackage")]
            [Validation(Required=false)]
            public ListBasicAcceleratorsResponseBodyAcceleratorsCrossDomainBandwidthPackage CrossDomainBandwidthPackage { get; set; }
            public class ListBasicAcceleratorsResponseBodyAcceleratorsCrossDomainBandwidthPackage : TeaModel {
                [NameInMap("Bandwidth")]
                [Validation(Required=false)]
                public int? Bandwidth { get; set; }
                [NameInMap("InstanceId")]
                [Validation(Required=false)]
                public string InstanceId { get; set; }
            };

            /// <summary>
            /// 全球加速实例描述
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// 到期时间
            /// </summary>
            [NameInMap("ExpiredTime")]
            [Validation(Required=false)]
            public long? ExpiredTime { get; set; }

            /// <summary>
            /// 全球加速实例计费类型
            /// </summary>
            [NameInMap("InstanceChargeType")]
            [Validation(Required=false)]
            public string InstanceChargeType { get; set; }

            /// <summary>
            /// 全球加速实例名称
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// RegionId
            /// </summary>
            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            /// <summary>
            /// 全球加速实例状态
            /// </summary>
            [NameInMap("State")]
            [Validation(Required=false)]
            public string State { get; set; }

            /// <summary>
            /// 全球加速实例类型
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        /// <summary>
        /// 页码
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// 页大小
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// 请求Id
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// 全球加速实例总数
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
