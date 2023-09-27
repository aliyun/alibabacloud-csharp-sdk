// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CloudAPI20180601.Models
{
    public class DescribeDomainResolutionResponseBody : TeaModel {
        [NameInMap("DomainResolutions")]
        [Validation(Required=false)]
        public DescribeDomainResolutionResponseBodyDomainResolutions DomainResolutions { get; set; }
        public class DescribeDomainResolutionResponseBodyDomainResolutions : TeaModel {
            [NameInMap("DomainResolution")]
            [Validation(Required=false)]
            public List<DescribeDomainResolutionResponseBodyDomainResolutionsDomainResolution> DomainResolution { get; set; }
            public class DescribeDomainResolutionResponseBodyDomainResolutionsDomainResolution : TeaModel {
                [NameInMap("DomainName")]
                [Validation(Required=false)]
                public string DomainName { get; set; }

                [NameInMap("DomainNameResolution")]
                [Validation(Required=false)]
                public string DomainNameResolution { get; set; }

            }

        }

        [NameInMap("GroupId")]
        [Validation(Required=false)]
        public string GroupId { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
