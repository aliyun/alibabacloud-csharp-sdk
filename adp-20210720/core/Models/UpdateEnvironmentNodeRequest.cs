// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adp20210720.Models
{
    public class UpdateEnvironmentNodeRequest : TeaModel {
        [NameInMap("applicationDisk")]
        [Validation(Required=false)]
        public string ApplicationDisk { get; set; }

        [NameInMap("etcdDisk")]
        [Validation(Required=false)]
        public string EtcdDisk { get; set; }

        [NameInMap("labels")]
        [Validation(Required=false)]
        public Dictionary<string, object> Labels { get; set; }

        [NameInMap("rootPassword")]
        [Validation(Required=false)]
        public string RootPassword { get; set; }

        [NameInMap("taints")]
        [Validation(Required=false)]
        public List<UpdateEnvironmentNodeRequestTaints> Taints { get; set; }
        public class UpdateEnvironmentNodeRequestTaints : TeaModel {
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

    }

}
