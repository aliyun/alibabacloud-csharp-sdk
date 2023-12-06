// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adp20210720.Models
{
    public class AddEnvironmentNodesRequest : TeaModel {
        [NameInMap("applicationDisk")]
        [Validation(Required=false)]
        public string ApplicationDisk { get; set; }

        [NameInMap("cpu")]
        [Validation(Required=false)]
        public int? Cpu { get; set; }

        [NameInMap("dataDisk")]
        [Validation(Required=false)]
        public List<AddEnvironmentNodesRequestDataDisk> DataDisk { get; set; }
        public class AddEnvironmentNodesRequestDataDisk : TeaModel {
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("required")]
            [Validation(Required=false)]
            public int? Required { get; set; }

        }

        [NameInMap("etcdDisk")]
        [Validation(Required=false)]
        public string EtcdDisk { get; set; }

        [NameInMap("hostName")]
        [Validation(Required=false)]
        public string HostName { get; set; }

        [NameInMap("labels")]
        [Validation(Required=false)]
        public Dictionary<string, object> Labels { get; set; }

        [NameInMap("masterPrivateIPs")]
        [Validation(Required=false)]
        public List<string> MasterPrivateIPs { get; set; }

        [NameInMap("memory")]
        [Validation(Required=false)]
        public int? Memory { get; set; }

        [NameInMap("os")]
        [Validation(Required=false)]
        public string Os { get; set; }

        [NameInMap("rootPassword")]
        [Validation(Required=false)]
        public string RootPassword { get; set; }

        [NameInMap("systemDisk")]
        [Validation(Required=false)]
        public List<AddEnvironmentNodesRequestSystemDisk> SystemDisk { get; set; }
        public class AddEnvironmentNodesRequestSystemDisk : TeaModel {
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("required")]
            [Validation(Required=false)]
            public int? Required { get; set; }

        }

        [NameInMap("taints")]
        [Validation(Required=false)]
        public List<AddEnvironmentNodesRequestTaints> Taints { get; set; }
        public class AddEnvironmentNodesRequestTaints : TeaModel {
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

        [NameInMap("tridentSystemDisk")]
        [Validation(Required=false)]
        public string TridentSystemDisk { get; set; }

        [NameInMap("tridentSystemSizeDisk")]
        [Validation(Required=false)]
        public int? TridentSystemSizeDisk { get; set; }

        [NameInMap("workerPrivateIPs")]
        [Validation(Required=false)]
        public List<string> WorkerPrivateIPs { get; set; }

    }

}
