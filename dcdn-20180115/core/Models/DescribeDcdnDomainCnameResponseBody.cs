// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dcdn20180115.Models
{
    public class DescribeDcdnDomainCnameResponseBody : TeaModel {
        [NameInMap("CnameDatas")]
        [Validation(Required=false)]
        public DescribeDcdnDomainCnameResponseBodyCnameDatas CnameDatas { get; set; }
        public class DescribeDcdnDomainCnameResponseBodyCnameDatas : TeaModel {
            [NameInMap("Data")]
            [Validation(Required=false)]
            public List<DescribeDcdnDomainCnameResponseBodyCnameDatasData> Data { get; set; }
            public class DescribeDcdnDomainCnameResponseBodyCnameDatasData : TeaModel {
                public string Cname { get; set; }
                public string Domain { get; set; }
                public int? Status { get; set; }
            }
        };

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
