// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Scdn20171115.Models
{
    public class DescribeScdnCcTopIpResponseBody : TeaModel {
        [NameInMap("AttackIpDataList")]
        [Validation(Required=false)]
        public DescribeScdnCcTopIpResponseBodyAttackIpDataList AttackIpDataList { get; set; }
        public class DescribeScdnCcTopIpResponseBodyAttackIpDataList : TeaModel {
            [NameInMap("AttackIpDatas")]
            [Validation(Required=false)]
            public List<DescribeScdnCcTopIpResponseBodyAttackIpDataListAttackIpDatas> AttackIpDatas { get; set; }
            public class DescribeScdnCcTopIpResponseBodyAttackIpDataListAttackIpDatas : TeaModel {
                [NameInMap("AttackCount")]
                [Validation(Required=false)]
                public string AttackCount { get; set; }

                [NameInMap("Ip")]
                [Validation(Required=false)]
                public string Ip { get; set; }

            }

        }

        [NameInMap("DomainName")]
        [Validation(Required=false)]
        public string DomainName { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Total")]
        [Validation(Required=false)]
        public string Total { get; set; }

    }

}
