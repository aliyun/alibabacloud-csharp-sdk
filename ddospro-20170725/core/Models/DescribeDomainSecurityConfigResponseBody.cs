// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.DDoSPro20170725.Models
{
    public class DescribeDomainSecurityConfigResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("CcInfo")]
        [Validation(Required=false)]
        public DescribeDomainSecurityConfigResponseBodyCcInfo CcInfo { get; set; }
        public class DescribeDomainSecurityConfigResponseBodyCcInfo : TeaModel {
            [NameInMap("CcCustomRuleCount")]
            [Validation(Required=false)]
            public int? CcCustomRuleCount { get; set; }
            [NameInMap("CcSwitch")]
            [Validation(Required=false)]
            public bool? CcSwitch { get; set; }
            [NameInMap("CcTemplate")]
            [Validation(Required=false)]
            public string CcTemplate { get; set; }
            [NameInMap("CcCustomRuleEnable")]
            [Validation(Required=false)]
            public bool? CcCustomRuleEnable { get; set; }
        };

        [NameInMap("CnameEnable")]
        [Validation(Required=false)]
        public bool? CnameEnable { get; set; }

        [NameInMap("WhiteList")]
        [Validation(Required=false)]
        public string WhiteList { get; set; }

        [NameInMap("BlackList")]
        [Validation(Required=false)]
        public string BlackList { get; set; }

        [NameInMap("CnameMode")]
        [Validation(Required=false)]
        public int? CnameMode { get; set; }

    }

}
