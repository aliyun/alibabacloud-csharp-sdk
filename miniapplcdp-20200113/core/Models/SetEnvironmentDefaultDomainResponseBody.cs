// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Miniapplcdp20200113.Models
{
    public class SetEnvironmentDefaultDomainResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public SetEnvironmentDefaultDomainResponseBodyData Data { get; set; }
        public class SetEnvironmentDefaultDomainResponseBodyData : TeaModel {
            [NameInMap("ConfigChanged")]
            [Validation(Required=false)]
            public bool? ConfigChanged { get; set; }

            [NameInMap("DefaultMasterDomain")]
            [Validation(Required=false)]
            public string DefaultMasterDomain { get; set; }

            [NameInMap("DefaultStaticDomain")]
            [Validation(Required=false)]
            public string DefaultStaticDomain { get; set; }

            [NameInMap("MasterDomain")]
            [Validation(Required=false)]
            public string MasterDomain { get; set; }

            [NameInMap("MasterDomainApplied")]
            [Validation(Required=false)]
            public bool? MasterDomainApplied { get; set; }

            [NameInMap("StaticDomain")]
            [Validation(Required=false)]
            public string StaticDomain { get; set; }

            [NameInMap("StaticDomainApplied")]
            [Validation(Required=false)]
            public bool? StaticDomainApplied { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
