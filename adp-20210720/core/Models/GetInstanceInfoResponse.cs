// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adp20210720.Models
{
    public class GetInstanceInfoResponse : TeaModel {
        [NameInMap("annotations")]
        [Validation(Required=false)]
        public Dictionary<string, string> Annotations { get; set; }

        [NameInMap("arch")]
        [Validation(Required=false)]
        public string Arch { get; set; }

        [NameInMap("clusterLabels")]
        [Validation(Required=false)]
        public Dictionary<string, string> ClusterLabels { get; set; }

        [NameInMap("clusterTaints")]
        [Validation(Required=false)]
        public List<GetInstanceInfoResponseClusterTaints> ClusterTaints { get; set; }
        public class GetInstanceInfoResponseClusterTaints : TeaModel {
            [NameInMap("effect")]
            [Validation(Required=false)]
            public string Effect { get; set; }

            [NameInMap("key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            [NameInMap("value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        [NameInMap("cpu")]
        [Validation(Required=false)]
        public string Cpu { get; set; }

        [NameInMap("dataDisk")]
        [Validation(Required=false)]
        public List<Disk> DataDisk { get; set; }

        [NameInMap("hostName")]
        [Validation(Required=false)]
        public string HostName { get; set; }

        [NameInMap("identifier")]
        [Validation(Required=false)]
        public string Identifier { get; set; }

        [NameInMap("imageID")]
        [Validation(Required=false)]
        public string ImageID { get; set; }

        [NameInMap("instanceType")]
        [Validation(Required=false)]
        public string InstanceType { get; set; }

        [NameInMap("internetBandwidth")]
        [Validation(Required=false)]
        public int? InternetBandwidth { get; set; }

        [NameInMap("kernel")]
        [Validation(Required=false)]
        public string Kernel { get; set; }

        [NameInMap("labels")]
        [Validation(Required=false)]
        public Dictionary<string, string> Labels { get; set; }

        [NameInMap("macAddress")]
        [Validation(Required=false)]
        public string MacAddress { get; set; }

        [NameInMap("memory")]
        [Validation(Required=false)]
        public string Memory { get; set; }

        [NameInMap("networkCards")]
        [Validation(Required=false)]
        public List<GetInstanceInfoResponseNetworkCards> NetworkCards { get; set; }
        public class GetInstanceInfoResponseNetworkCards : TeaModel {
            [NameInMap("ip")]
            [Validation(Required=false)]
            public string Ip { get; set; }

            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

        }

        [NameInMap("os")]
        [Validation(Required=false)]
        public string Os { get; set; }

        [NameInMap("osVersion")]
        [Validation(Required=false)]
        public string OsVersion { get; set; }

        [NameInMap("privateIP")]
        [Validation(Required=false)]
        public string PrivateIP { get; set; }

        [NameInMap("publicIP")]
        [Validation(Required=false)]
        public string PublicIP { get; set; }

        [NameInMap("rootPassword")]
        [Validation(Required=false)]
        public string RootPassword { get; set; }

        [NameInMap("systemDisk")]
        [Validation(Required=false)]
        public List<Disk> SystemDisk { get; set; }

        [NameInMap("systemInfo")]
        [Validation(Required=false)]
        public string SystemInfo { get; set; }

        [NameInMap("taints")]
        [Validation(Required=false)]
        public List<GetInstanceInfoResponseTaints> Taints { get; set; }
        public class GetInstanceInfoResponseTaints : TeaModel {
            [NameInMap("effect")]
            [Validation(Required=false)]
            public string Effect { get; set; }

            [NameInMap("key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            [NameInMap("value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        [NameInMap("uid")]
        [Validation(Required=false)]
        public string Uid { get; set; }

    }

}
