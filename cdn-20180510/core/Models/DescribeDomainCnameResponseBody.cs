// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cdn20180510.Models
{
    public class DescribeDomainCnameResponseBody : TeaModel {
        /// <summary>
        /// Details about the CNAME detection results.
        /// </summary>
        [NameInMap("CnameDatas")]
        [Validation(Required=false)]
        public DescribeDomainCnameResponseBodyCnameDatas CnameDatas { get; set; }
        public class DescribeDomainCnameResponseBodyCnameDatas : TeaModel {
            [NameInMap("Data")]
            [Validation(Required=false)]
            public List<DescribeDomainCnameResponseBodyCnameDatasData> Data { get; set; }
            public class DescribeDomainCnameResponseBodyCnameDatasData : TeaModel {
                /// <summary>
                /// The CNAME assigned to the domain name by Alibaba Cloud CDN.
                /// </summary>
                [NameInMap("Cname")]
                [Validation(Required=false)]
                public string Cname { get; set; }

                /// <summary>
                /// The accelerated domain name.
                /// </summary>
                [NameInMap("Domain")]
                [Validation(Required=false)]
                public string Domain { get; set; }

                /// <summary>
                /// The CNAME detection result. Valid values:
                /// 
                /// *   0: The DNS can detect the CNAME assigned to the domain name.
                /// *   Value other than 0: The DNS cannot detect the CNAME assigned to the domain name.
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public int? Status { get; set; }

            }

        }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
