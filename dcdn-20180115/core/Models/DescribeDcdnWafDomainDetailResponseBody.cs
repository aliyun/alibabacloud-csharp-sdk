// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dcdn20180115.Models
{
    public class DescribeDcdnWafDomainDetailResponseBody : TeaModel {
        [NameInMap("Domain")]
        [Validation(Required=false)]
        public DescribeDcdnWafDomainDetailResponseBodyDomain Domain { get; set; }
        public class DescribeDcdnWafDomainDetailResponseBodyDomain : TeaModel {
            [NameInMap("DefenseScenes")]
            [Validation(Required=false)]
            public List<DescribeDcdnWafDomainDetailResponseBodyDomainDefenseScenes> DefenseScenes { get; set; }
            public class DescribeDcdnWafDomainDetailResponseBodyDomainDefenseScenes : TeaModel {
                public string DefenseScene { get; set; }
                public long? PolicyId { get; set; }
            }
            [NameInMap("DomainName")]
            [Validation(Required=false)]
            public string DomainName { get; set; }
        };

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
