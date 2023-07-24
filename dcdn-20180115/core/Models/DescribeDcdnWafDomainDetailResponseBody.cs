// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dcdn20180115.Models
{
    public class DescribeDcdnWafDomainDetailResponseBody : TeaModel {
        /// <summary>
        /// The information about the accelerated domain name.
        /// </summary>
        [NameInMap("Domain")]
        [Validation(Required=false)]
        public DescribeDcdnWafDomainDetailResponseBodyDomain Domain { get; set; }
        public class DescribeDcdnWafDomainDetailResponseBodyDomain : TeaModel {
            /// <summary>
            /// The types of the protection policies.
            /// </summary>
            [NameInMap("DefenseScenes")]
            [Validation(Required=false)]
            public List<DescribeDcdnWafDomainDetailResponseBodyDomainDefenseScenes> DefenseScenes { get; set; }
            public class DescribeDcdnWafDomainDetailResponseBodyDomainDefenseScenes : TeaModel {
                /// <summary>
                /// The type of the protection policy. Valid values:
                /// 
                /// *   waf_group: basic web protection
                /// *   custom_acl: custom protection
                /// *   whitelist: whitelist
                /// </summary>
                [NameInMap("DefenseScene")]
                [Validation(Required=false)]
                public string DefenseScene { get; set; }

                /// <summary>
                /// The ID of the protection policy.
                /// </summary>
                [NameInMap("PolicyId")]
                [Validation(Required=false)]
                public long? PolicyId { get; set; }

                [NameInMap("PolicyIds")]
                [Validation(Required=false)]
                public string PolicyIds { get; set; }

            }

            /// <summary>
            /// The accelerated domain name.
            /// </summary>
            [NameInMap("DomainName")]
            [Validation(Required=false)]
            public string DomainName { get; set; }

        }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
