// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SOFA20190815.Models
{
    public class QueryCasLoadbalanceMountResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("ResultCode")]
        [Validation(Required=false)]
        public string ResultCode { get; set; }

        [NameInMap("ResultMessage")]
        [Validation(Required=false)]
        public string ResultMessage { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<QueryCasLoadbalanceMountResponseBodyData> Data { get; set; }
        public class QueryCasLoadbalanceMountResponseBodyData : TeaModel {
            [NameInMap("Domain")]
            [Validation(Required=false)]
            public string Domain { get; set; }

            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            [NameInMap("Weight")]
            [Validation(Required=false)]
            public long? Weight { get; set; }

            [NameInMap("Computer")]
            [Validation(Required=false)]
            public QueryCasLoadbalanceMountResponseBodyDataComputer Computer { get; set; }
            public class QueryCasLoadbalanceMountResponseBodyDataComputer : TeaModel {
                [NameInMap("AppId")]
                [Validation(Required=false)]
                public string AppId { get; set; }
                [NameInMap("Bandwidth")]
                [Validation(Required=false)]
                public long? Bandwidth { get; set; }
                [NameInMap("CommonImage")]
                [Validation(Required=false)]
                public bool? CommonImage { get; set; }
                [NameInMap("Cpu")]
                [Validation(Required=false)]
                public long? Cpu { get; set; }
                [NameInMap("CpuShared")]
                [Validation(Required=false)]
                public bool? CpuShared { get; set; }
                [NameInMap("CreationTime")]
                [Validation(Required=false)]
                public string CreationTime { get; set; }
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }
                [NameInMap("ElasticIp")]
                [Validation(Required=false)]
                public string ElasticIp { get; set; }
                [NameInMap("ExpiredTime")]
                [Validation(Required=false)]
                public string ExpiredTime { get; set; }
                [NameInMap("IaasId")]
                [Validation(Required=false)]
                public string IaasId { get; set; }
                [NameInMap("IaasStatus")]
                [Validation(Required=false)]
                public string IaasStatus { get; set; }
                [NameInMap("Id")]
                [Validation(Required=false)]
                public string Id { get; set; }
                [NameInMap("ImageIaasId")]
                [Validation(Required=false)]
                public string ImageIaasId { get; set; }
                [NameInMap("ImageId")]
                [Validation(Required=false)]
                public string ImageId { get; set; }
                [NameInMap("ImageName")]
                [Validation(Required=false)]
                public string ImageName { get; set; }
                [NameInMap("Initialized")]
                [Validation(Required=false)]
                public bool? Initialized { get; set; }
                [NameInMap("IoOptimized")]
                [Validation(Required=false)]
                public bool? IoOptimized { get; set; }
                [NameInMap("LastOpsOrderId")]
                [Validation(Required=false)]
                public string LastOpsOrderId { get; set; }
                [NameInMap("LastOpsType")]
                [Validation(Required=false)]
                public string LastOpsType { get; set; }
                [NameInMap("Memory")]
                [Validation(Required=false)]
                public long? Memory { get; set; }
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }
                [NameInMap("Os")]
                [Validation(Required=false)]
                public string Os { get; set; }
                [NameInMap("OsBit")]
                [Validation(Required=false)]
                public long? OsBit { get; set; }
                [NameInMap("OsVersion")]
                [Validation(Required=false)]
                public string OsVersion { get; set; }
                [NameInMap("PaasStatus")]
                [Validation(Required=false)]
                public string PaasStatus { get; set; }
                [NameInMap("Password")]
                [Validation(Required=false)]
                public string Password { get; set; }
                [NameInMap("PrivateIp")]
                [Validation(Required=false)]
                public string PrivateIp { get; set; }
                [NameInMap("ProviderId")]
                [Validation(Required=false)]
                public string ProviderId { get; set; }
                [NameInMap("PublicIp")]
                [Validation(Required=false)]
                public string PublicIp { get; set; }
                [NameInMap("SerialNumber")]
                [Validation(Required=false)]
                public string SerialNumber { get; set; }
                [NameInMap("SpecIaasId")]
                [Validation(Required=false)]
                public string SpecIaasId { get; set; }
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }
                [NameInMap("ThreadsPerCore")]
                [Validation(Required=false)]
                public long? ThreadsPerCore { get; set; }
                [NameInMap("WorkspaceId")]
                [Validation(Required=false)]
                public string WorkspaceId { get; set; }
                [NameInMap("SystemDisk")]
                [Validation(Required=false)]
                public QueryCasLoadbalanceMountResponseBodyDataComputerSystemDisk SystemDisk { get; set; }
                public class QueryCasLoadbalanceMountResponseBodyDataComputerSystemDisk : TeaModel {
                    [NameInMap("Category")]
                    [Validation(Required=false)]
                    public string Category { get; set; }

                    [NameInMap("DeleteAutoSnapshot")]
                    [Validation(Required=false)]
                    public bool? DeleteAutoSnapshot { get; set; }

                    [NameInMap("DeleteWithComputer")]
                    [Validation(Required=false)]
                    public bool? DeleteWithComputer { get; set; }

                    [NameInMap("Device")]
                    [Validation(Required=false)]
                    public string Device { get; set; }

                    [NameInMap("EnableAutoSnapshot")]
                    [Validation(Required=false)]
                    public bool? EnableAutoSnapshot { get; set; }

                    [NameInMap("ImageId")]
                    [Validation(Required=false)]
                    public string ImageId { get; set; }

                    [NameInMap("Portable")]
                    [Validation(Required=false)]
                    public bool? Portable { get; set; }

                    [NameInMap("Size")]
                    [Validation(Required=false)]
                    public long? Size { get; set; }

                    [NameInMap("Status")]
                    [Validation(Required=false)]
                    public string Status { get; set; }

                    [NameInMap("Type")]
                    [Validation(Required=false)]
                    public string Type { get; set; }

                }
            };

            [NameInMap("Loadbalancer")]
            [Validation(Required=false)]
            public QueryCasLoadbalanceMountResponseBodyDataLoadbalancer Loadbalancer { get; set; }
            public class QueryCasLoadbalanceMountResponseBodyDataLoadbalancer : TeaModel {
                [NameInMap("Bandwidth")]
                [Validation(Required=false)]
                public long? Bandwidth { get; set; }
                [NameInMap("ClusterId")]
                [Validation(Required=false)]
                public string ClusterId { get; set; }
                [NameInMap("ClusterMode")]
                [Validation(Required=false)]
                public bool? ClusterMode { get; set; }
                [NameInMap("Id")]
                [Validation(Required=false)]
                public string Id { get; set; }
                [NameInMap("InternetChargeType")]
                [Validation(Required=false)]
                public string InternetChargeType { get; set; }
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }
                [NameInMap("NetworkType")]
                [Validation(Required=false)]
                public string NetworkType { get; set; }
                [NameInMap("ShareMode")]
                [Validation(Required=false)]
                public bool? ShareMode { get; set; }
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }
                [NameInMap("VipAddressType")]
                [Validation(Required=false)]
                public string VipAddressType { get; set; }
                [NameInMap("VipType")]
                [Validation(Required=false)]
                public string VipType { get; set; }
                [NameInMap("VpcId")]
                [Validation(Required=false)]
                public string VpcId { get; set; }
                [NameInMap("VswitchIaasId")]
                [Validation(Required=false)]
                public string VswitchIaasId { get; set; }
                [NameInMap("WorkspaceId")]
                [Validation(Required=false)]
                public string WorkspaceId { get; set; }
                [NameInMap("Domains")]
                [Validation(Required=false)]
                public List<string> Domains { get; set; }
                [NameInMap("VipAddresses")]
                [Validation(Required=false)]
                public List<string> VipAddresses { get; set; }
                [NameInMap("Scope")]
                [Validation(Required=false)]
                public QueryCasLoadbalanceMountResponseBodyDataLoadbalancerScope Scope { get; set; }
                public class QueryCasLoadbalanceMountResponseBodyDataLoadbalancerScope : TeaModel {
                    [NameInMap("Cell")]
                    [Validation(Required=false)]
                    public string Cell { get; set; }

                    [NameInMap("Cluster")]
                    [Validation(Required=false)]
                    public string Cluster { get; set; }

                    [NameInMap("Region")]
                    [Validation(Required=false)]
                    public string Region { get; set; }

                    [NameInMap("Tenant")]
                    [Validation(Required=false)]
                    public string Tenant { get; set; }

                    [NameInMap("Workspace")]
                    [Validation(Required=false)]
                    public string Workspace { get; set; }

                    [NameInMap("WorkspaceGroup")]
                    [Validation(Required=false)]
                    public string WorkspaceGroup { get; set; }

                    [NameInMap("Zone")]
                    [Validation(Required=false)]
                    public string Zone { get; set; }

                }
            };

        }

    }

}
