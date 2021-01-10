// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mts20140618.Models
{
    public class RefreshCdnDomainConfigsCacheResponseBody : TeaModel {
        [NameInMap("SucessDomains")]
        [Validation(Required=false)]
        public RefreshCdnDomainConfigsCacheResponseBodySucessDomains SucessDomains { get; set; }
        public class RefreshCdnDomainConfigsCacheResponseBodySucessDomains : TeaModel {
            [NameInMap("String")]
            [Validation(Required=false)]
            public List<string> String { get; set; }
        };

        [NameInMap("FailedDomains")]
        [Validation(Required=false)]
        public RefreshCdnDomainConfigsCacheResponseBodyFailedDomains FailedDomains { get; set; }
        public class RefreshCdnDomainConfigsCacheResponseBodyFailedDomains : TeaModel {
            [NameInMap("String")]
            [Validation(Required=false)]
            public List<string> String { get; set; }
        };

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
