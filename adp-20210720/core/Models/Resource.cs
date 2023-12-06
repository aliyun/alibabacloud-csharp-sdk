// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adp20210720.Models
{
    public class Resource : TeaModel {
        [NameInMap("cpu")]
        [Validation(Required=false)]
        public ResourceCpu Cpu { get; set; }
        public class ResourceCpu : TeaModel {
            [NameInMap("required")]
            [Validation(Required=false)]
            public int? Required { get; set; }

        }

        [NameInMap("hostname")]
        [Validation(Required=false)]
        public string Hostname { get; set; }

        [NameInMap("identifier")]
        [Validation(Required=false)]
        public string Identifier { get; set; }

        [NameInMap("image")]
        [Validation(Required=false)]
        public ResourceImage Image { get; set; }
        public class ResourceImage : TeaModel {
            [NameInMap("id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            [NameInMap("nameRegex")]
            [Validation(Required=false)]
            public string NameRegex { get; set; }

        }

        [NameInMap("instanceType")]
        [Validation(Required=false)]
        public string InstanceType { get; set; }

        [NameInMap("memory")]
        [Validation(Required=false)]
        public ResourceMemory Memory { get; set; }
        public class ResourceMemory : TeaModel {
            [NameInMap("required")]
            [Validation(Required=false)]
            public int? Required { get; set; }

        }

        [NameInMap("ports")]
        [Validation(Required=false)]
        public List<ExportPort> Ports { get; set; }

        [NameInMap("publicIP")]
        [Validation(Required=false)]
        public ResourcePublicIP PublicIP { get; set; }
        public class ResourcePublicIP : TeaModel {
            [NameInMap("bandwidth")]
            [Validation(Required=false)]
            public int? Bandwidth { get; set; }

            [NameInMap("required")]
            [Validation(Required=false)]
            public int? Required { get; set; }

        }

        [NameInMap("replica")]
        [Validation(Required=false)]
        public int? Replica { get; set; }

        [NameInMap("storage")]
        [Validation(Required=false)]
        public List<ResourceStorage> Storage { get; set; }
        public class ResourceStorage : TeaModel {
            [NameInMap("required")]
            [Validation(Required=false)]
            public int? Required { get; set; }

        }

    }

}
