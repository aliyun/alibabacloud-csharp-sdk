// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Scdn20171115.Models
{
    public class DescribeScdnCcTopUrlResponseBody : TeaModel {
        [NameInMap("AttackUrlDataList")]
        [Validation(Required=false)]
        public DescribeScdnCcTopUrlResponseBodyAttackUrlDataList AttackUrlDataList { get; set; }
        public class DescribeScdnCcTopUrlResponseBodyAttackUrlDataList : TeaModel {
            [NameInMap("AttackUrlDatas")]
            [Validation(Required=false)]
            public List<DescribeScdnCcTopUrlResponseBodyAttackUrlDataListAttackUrlDatas> AttackUrlDatas { get; set; }
            public class DescribeScdnCcTopUrlResponseBodyAttackUrlDataListAttackUrlDatas : TeaModel {
                [NameInMap("AttackCount")]
                [Validation(Required=false)]
                public string AttackCount { get; set; }

                [NameInMap("Url")]
                [Validation(Required=false)]
                public string Url { get; set; }

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
