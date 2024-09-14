// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Hsm20231113.Models
{
    public class GetClusterResponseBody : TeaModel {
        [NameInMap("Cluster")]
        [Validation(Required=false)]
        public GetClusterResponseBodyCluster Cluster { get; set; }
        public class GetClusterResponseBodyCluster : TeaModel {
            [NameInMap("ClusterCertificate")]
            [Validation(Required=false)]
            public string ClusterCertificate { get; set; }

            [NameInMap("ClusterCsr")]
            [Validation(Required=false)]
            public string ClusterCsr { get; set; }

            [NameInMap("ClusterId")]
            [Validation(Required=false)]
            public string ClusterId { get; set; }

            [NameInMap("ClusterName")]
            [Validation(Required=false)]
            public string ClusterName { get; set; }

            [NameInMap("ClusterOwnerCertificate")]
            [Validation(Required=false)]
            public string ClusterOwnerCertificate { get; set; }

            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public long? CreateTime { get; set; }

            [NameInMap("DeviceType")]
            [Validation(Required=false)]
            public string DeviceType { get; set; }

            [NameInMap("Instances")]
            [Validation(Required=false)]
            public List<GetClusterResponseBodyClusterInstances> Instances { get; set; }
            public class GetClusterResponseBodyClusterInstances : TeaModel {
                [NameInMap("InstanceId")]
                [Validation(Required=false)]
                public string InstanceId { get; set; }

                [NameInMap("Master")]
                [Validation(Required=false)]
                public bool? Master { get; set; }

                [NameInMap("NodeId")]
                [Validation(Required=false)]
                public int? NodeId { get; set; }

            }

            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            [NameInMap("Size")]
            [Validation(Required=false)]
            public int? Size { get; set; }

            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            [NameInMap("VpcId")]
            [Validation(Required=false)]
            public string VpcId { get; set; }

            [NameInMap("Whitelist")]
            [Validation(Required=false)]
            public string Whitelist { get; set; }

            [NameInMap("Zones")]
            [Validation(Required=false)]
            public List<GetClusterResponseBodyClusterZones> Zones { get; set; }
            public class GetClusterResponseBodyClusterZones : TeaModel {
                [NameInMap("VSwitchId")]
                [Validation(Required=false)]
                public string VSwitchId { get; set; }

                [NameInMap("ZoneId")]
                [Validation(Required=false)]
                public string ZoneId { get; set; }

            }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
