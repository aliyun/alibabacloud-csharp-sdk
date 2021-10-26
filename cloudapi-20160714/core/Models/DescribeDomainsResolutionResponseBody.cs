// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CloudAPI20160714.Models
{
    public class DescribeDomainsResolutionResponseBody : TeaModel {
        [NameInMap("GroupId")]
        [Validation(Required=false)]
        public string GroupId { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("DomainResolutions")]
        [Validation(Required=false)]
        public DescribeDomainsResolutionResponseBodyDomainResolutions DomainResolutions { get; set; }
        public class DescribeDomainsResolutionResponseBodyDomainResolutions : TeaModel {
            [NameInMap("DomainResolution")]
            [Validation(Required=false)]
            public List<DescribeDomainsResolutionResponseBodyDomainResolutionsDomainResolution> DomainResolution { get; set; }
            public class DescribeDomainsResolutionResponseBodyDomainResolutionsDomainResolution : TeaModel {
                public string DomainResolutionStatus { get; set; }
                public string DomainName { get; set; }
            }
        };

    }

}
