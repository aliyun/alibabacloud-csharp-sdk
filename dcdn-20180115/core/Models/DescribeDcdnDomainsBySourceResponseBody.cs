// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dcdn20180115.Models
{
    public class DescribeDcdnDomainsBySourceResponseBody : TeaModel {
        [NameInMap("DomainInfo")]
        [Validation(Required=false)]
        public List<DescribeDcdnDomainsBySourceResponseBodyDomainInfo> DomainInfo { get; set; }
        public class DescribeDcdnDomainsBySourceResponseBodyDomainInfo : TeaModel {
            [NameInMap("DomainList")]
            [Validation(Required=false)]
            public List<DescribeDcdnDomainsBySourceResponseBodyDomainInfoDomainList> DomainList { get; set; }
            public class DescribeDcdnDomainsBySourceResponseBodyDomainInfoDomainList : TeaModel {
                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public string CreateTime { get; set; }

                /// <summary>
                /// CNAME。
                /// </summary>
                [NameInMap("DomainCname")]
                [Validation(Required=false)]
                public string DomainCname { get; set; }

                [NameInMap("DomainName")]
                [Validation(Required=false)]
                public string DomainName { get; set; }

                [NameInMap("DomainType")]
                [Validation(Required=false)]
                public string DomainType { get; set; }

                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                [NameInMap("UpdateTime")]
                [Validation(Required=false)]
                public string UpdateTime { get; set; }

            }

            [NameInMap("Source")]
            [Validation(Required=false)]
            public string Source { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
