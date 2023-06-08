// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dcdn20180115.Models
{
    public class DescribeDcdnWafDomainDetailResponseBody : TeaModel {
        /// <summary>
        /// The IDs of the protection policies. Multiple IDs are separated by commas (,).
        /// </summary>
        [NameInMap("Domain")]
        [Validation(Required=false)]
        public DescribeDcdnWafDomainDetailResponseBodyDomain Domain { get; set; }
        public class DescribeDcdnWafDomainDetailResponseBodyDomain : TeaModel {
            [NameInMap("DefenseScenes")]
            [Validation(Required=false)]
            public List<DescribeDcdnWafDomainDetailResponseBodyDomainDefenseScenes> DefenseScenes { get; set; }
            public class DescribeDcdnWafDomainDetailResponseBodyDomainDefenseScenes : TeaModel {
                [NameInMap("DefenseScene")]
                [Validation(Required=false)]
                public string DefenseScene { get; set; }

                [NameInMap("PolicyId")]
                [Validation(Required=false)]
                public long? PolicyId { get; set; }

                [NameInMap("PolicyIds")]
                [Validation(Required=false)]
                public string PolicyIds { get; set; }

            }

            [NameInMap("DomainName")]
            [Validation(Required=false)]
            public string DomainName { get; set; }

        }

        /// <summary>
        /// The type of the protection policy. Valid values:
        /// 
        /// *   waf_group: basic web protection
        /// *   custom_acl: custom protection
        /// *   whitelist: IP address whitelist
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
