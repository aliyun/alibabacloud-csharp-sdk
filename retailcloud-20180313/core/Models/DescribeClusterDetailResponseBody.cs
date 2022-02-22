// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Retailcloud20180313.Models
{
    public class DescribeClusterDetailResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        [NameInMap("ErrMsg")]
        [Validation(Required=false)]
        public string ErrMsg { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Result")]
        [Validation(Required=false)]
        public DescribeClusterDetailResponseBodyResult Result { get; set; }
        public class DescribeClusterDetailResponseBodyResult : TeaModel {
            [NameInMap("BasicInfo")]
            [Validation(Required=false)]
            public DescribeClusterDetailResponseBodyResultBasicInfo BasicInfo { get; set; }
            public class DescribeClusterDetailResponseBodyResultBasicInfo : TeaModel {
                [NameInMap("BusinessCode")]
                [Validation(Required=false)]
                public string BusinessCode { get; set; }

                [NameInMap("ClusterId")]
                [Validation(Required=false)]
                public long? ClusterId { get; set; }

                [NameInMap("ClusterInstanceId")]
                [Validation(Required=false)]
                public string ClusterInstanceId { get; set; }

                [NameInMap("ClusterName")]
                [Validation(Required=false)]
                public string ClusterName { get; set; }

                [NameInMap("EcsIds")]
                [Validation(Required=false)]
                public List<string> EcsIds { get; set; }

                [NameInMap("EnvType")]
                [Validation(Required=false)]
                public string EnvType { get; set; }

                [NameInMap("HasInstallArmsPilot")]
                [Validation(Required=false)]
                public bool? HasInstallArmsPilot { get; set; }

                [NameInMap("HasInstallLogController")]
                [Validation(Required=false)]
                public bool? HasInstallLogController { get; set; }

                [NameInMap("InstallArmsInProcess")]
                [Validation(Required=false)]
                public bool? InstallArmsInProcess { get; set; }

                [NameInMap("InstallLogInProcess")]
                [Validation(Required=false)]
                public bool? InstallLogInProcess { get; set; }

                [NameInMap("MainUserId")]
                [Validation(Required=false)]
                public string MainUserId { get; set; }

                [NameInMap("RegionId")]
                [Validation(Required=false)]
                public string RegionId { get; set; }

                [NameInMap("RegionName")]
                [Validation(Required=false)]
                public string RegionName { get; set; }

                [NameInMap("UserNick")]
                [Validation(Required=false)]
                public string UserNick { get; set; }

                [NameInMap("VpcId")]
                [Validation(Required=false)]
                public string VpcId { get; set; }

                [NameInMap("Vswitchs")]
                [Validation(Required=false)]
                public List<string> Vswitchs { get; set; }

            }
            [NameInMap("InstanceInfo")]
            [Validation(Required=false)]
            public DescribeClusterDetailResponseBodyResultInstanceInfo InstanceInfo { get; set; }
            public class DescribeClusterDetailResponseBodyResultInstanceInfo : TeaModel {
                [NameInMap("AllocatePodCount")]
                [Validation(Required=false)]
                public int? AllocatePodCount { get; set; }

                [NameInMap("AllocatedPodInfoList")]
                [Validation(Required=false)]
                public List<DescribeClusterDetailResponseBodyResultInstanceInfoAllocatedPodInfoList> AllocatedPodInfoList { get; set; }
                public class DescribeClusterDetailResponseBodyResultInstanceInfoAllocatedPodInfoList : TeaModel {
                    [NameInMap("AppId")]
                    [Validation(Required=false)]
                    public long? AppId { get; set; }

                    [NameInMap("AppName")]
                    [Validation(Required=false)]
                    public string AppName { get; set; }

                    [NameInMap("CupRequest")]
                    [Validation(Required=false)]
                    public string CupRequest { get; set; }

                    [NameInMap("EnvId")]
                    [Validation(Required=false)]
                    public long? EnvId { get; set; }

                    [NameInMap("EnvName")]
                    [Validation(Required=false)]
                    public string EnvName { get; set; }

                    [NameInMap("MemRequest")]
                    [Validation(Required=false)]
                    public string MemRequest { get; set; }

                    [NameInMap("PodCount")]
                    [Validation(Required=false)]
                    public int? PodCount { get; set; }

                }

                [NameInMap("AppCount")]
                [Validation(Required=false)]
                public int? AppCount { get; set; }

                [NameInMap("AvailablePodInfoList")]
                [Validation(Required=false)]
                public List<DescribeClusterDetailResponseBodyResultInstanceInfoAvailablePodInfoList> AvailablePodInfoList { get; set; }
                public class DescribeClusterDetailResponseBodyResultInstanceInfoAvailablePodInfoList : TeaModel {
                    [NameInMap("AvailablePodCount")]
                    [Validation(Required=false)]
                    public int? AvailablePodCount { get; set; }

                    [NameInMap("CupRequest")]
                    [Validation(Required=false)]
                    public string CupRequest { get; set; }

                    [NameInMap("MemRequest")]
                    [Validation(Required=false)]
                    public string MemRequest { get; set; }

                }

            }
            [NameInMap("NetInfo")]
            [Validation(Required=false)]
            public DescribeClusterDetailResponseBodyResultNetInfo NetInfo { get; set; }
            public class DescribeClusterDetailResponseBodyResultNetInfo : TeaModel {
                [NameInMap("NetPlugType")]
                [Validation(Required=false)]
                public string NetPlugType { get; set; }

                [NameInMap("ProdCIDR")]
                [Validation(Required=false)]
                public string ProdCIDR { get; set; }

                [NameInMap("ServiceCIDR")]
                [Validation(Required=false)]
                public string ServiceCIDR { get; set; }

            }
            [NameInMap("NodeWorkLoadList")]
            [Validation(Required=false)]
            public List<DescribeClusterDetailResponseBodyResultNodeWorkLoadList> NodeWorkLoadList { get; set; }
            public class DescribeClusterDetailResponseBodyResultNodeWorkLoadList : TeaModel {
                public int? AppPodCount { get; set; }
                public string CpuRequest { get; set; }
                public string CpuTotal { get; set; }
                public string CpuUse { get; set; }
                public string InstanceId { get; set; }
                public string MemRequest { get; set; }
                public string MemTotal { get; set; }
                public string MemUse { get; set; }
                public string NodeName { get; set; }
                public int? PodCount { get; set; }
                public bool? Ready { get; set; }
                public bool? Unschedulable { get; set; }
            }
            [NameInMap("WorkLoad")]
            [Validation(Required=false)]
            public DescribeClusterDetailResponseBodyResultWorkLoad WorkLoad { get; set; }
            public class DescribeClusterDetailResponseBodyResultWorkLoad : TeaModel {
                [NameInMap("AllNodeCount")]
                [Validation(Required=false)]
                public int? AllNodeCount { get; set; }

                [NameInMap("AllocateAllPodCount")]
                [Validation(Required=false)]
                public int? AllocateAllPodCount { get; set; }

                [NameInMap("AllocateAppPodCount")]
                [Validation(Required=false)]
                public int? AllocateAppPodCount { get; set; }

                [NameInMap("CpuCapacityTotal")]
                [Validation(Required=false)]
                public string CpuCapacityTotal { get; set; }

                [NameInMap("CpuLevel")]
                [Validation(Required=false)]
                public string CpuLevel { get; set; }

                [NameInMap("CpuRequest")]
                [Validation(Required=false)]
                public string CpuRequest { get; set; }

                [NameInMap("CpuRequestPercent")]
                [Validation(Required=false)]
                public string CpuRequestPercent { get; set; }

                [NameInMap("CpuTotal")]
                [Validation(Required=false)]
                public string CpuTotal { get; set; }

                [NameInMap("CpuUse")]
                [Validation(Required=false)]
                public string CpuUse { get; set; }

                [NameInMap("CpuUsePercent")]
                [Validation(Required=false)]
                public string CpuUsePercent { get; set; }

                [NameInMap("MemCapacityTotal")]
                [Validation(Required=false)]
                public string MemCapacityTotal { get; set; }

                [NameInMap("MemLevel")]
                [Validation(Required=false)]
                public string MemLevel { get; set; }

                [NameInMap("MemRequest")]
                [Validation(Required=false)]
                public string MemRequest { get; set; }

                [NameInMap("MemRequestPercent")]
                [Validation(Required=false)]
                public string MemRequestPercent { get; set; }

                [NameInMap("MemTotal")]
                [Validation(Required=false)]
                public string MemTotal { get; set; }

                [NameInMap("MemUse")]
                [Validation(Required=false)]
                public string MemUse { get; set; }

                [NameInMap("MemUsePercent")]
                [Validation(Required=false)]
                public string MemUsePercent { get; set; }

            }
        };

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
