// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Scdn20171115.Models
{
    public class DescribeScdnDomainCnameResponseBody : TeaModel {
        [NameInMap("CnameDatas")]
        [Validation(Required=false)]
        public DescribeScdnDomainCnameResponseBodyCnameDatas CnameDatas { get; set; }
        public class DescribeScdnDomainCnameResponseBodyCnameDatas : TeaModel {
            [NameInMap("Data")]
            [Validation(Required=false)]
            public List<DescribeScdnDomainCnameResponseBodyCnameDatasData> Data { get; set; }
            public class DescribeScdnDomainCnameResponseBodyCnameDatasData : TeaModel {
                /// <summary>
                /// Cname
                /// </summary>
                [NameInMap("Cname")]
                [Validation(Required=false)]
                public string Cname { get; set; }

                [NameInMap("Domain")]
                [Validation(Required=false)]
                public string Domain { get; set; }

                [NameInMap("Status")]
                [Validation(Required=false)]
                public int? Status { get; set; }

            }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
