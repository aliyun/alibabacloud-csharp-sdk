// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class DescribeVodDomainCnameResponseBody : TeaModel {
        [NameInMap("CnameDatas")]
        [Validation(Required=false)]
        public DescribeVodDomainCnameResponseBodyCnameDatas CnameDatas { get; set; }
        public class DescribeVodDomainCnameResponseBodyCnameDatas : TeaModel {
            [NameInMap("Data")]
            [Validation(Required=false)]
            public List<DescribeVodDomainCnameResponseBodyCnameDatasData> Data { get; set; }
            public class DescribeVodDomainCnameResponseBodyCnameDatasData : TeaModel {
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
