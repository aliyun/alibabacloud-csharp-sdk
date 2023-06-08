// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dcdn20180115.Models
{
    public class DescribeDcdnDomainCnameResponseBody : TeaModel {
        /// <summary>
        /// The CNAME information.
        /// </summary>
        [NameInMap("CnameDatas")]
        [Validation(Required=false)]
        public DescribeDcdnDomainCnameResponseBodyCnameDatas CnameDatas { get; set; }
        public class DescribeDcdnDomainCnameResponseBodyCnameDatas : TeaModel {
            [NameInMap("Data")]
            [Validation(Required=false)]
            public List<DescribeDcdnDomainCnameResponseBodyCnameDatasData> Data { get; set; }
            public class DescribeDcdnDomainCnameResponseBodyCnameDatasData : TeaModel {
                /// <summary>
                /// The CNAME assigned to the domain name.
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
                /// The configuration status of the CNAME record. If the operation returns 0 for the parameter, the configuration was successful. Otherwise, the configuration failed.
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
