// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dcdn20180115.Models
{
    public class DescribeDcdnDomainStagingConfigResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("DomainConfigs")]
        [Validation(Required=false)]
        public List<DescribeDcdnDomainStagingConfigResponseBodyDomainConfigs> DomainConfigs { get; set; }
        public class DescribeDcdnDomainStagingConfigResponseBodyDomainConfigs : TeaModel {
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            [NameInMap("ConfigId")]
            [Validation(Required=false)]
            public string ConfigId { get; set; }

            [NameInMap("FunctionName")]
            [Validation(Required=false)]
            public string FunctionName { get; set; }

            [NameInMap("FunctionArgs")]
            [Validation(Required=false)]
            public List<DescribeDcdnDomainStagingConfigResponseBodyDomainConfigsFunctionArgs> FunctionArgs { get; set; }
            public class DescribeDcdnDomainStagingConfigResponseBodyDomainConfigsFunctionArgs : TeaModel {
                [NameInMap("ArgName")]
                [Validation(Required=false)]
                public string ArgName { get; set; }

                [NameInMap("ArgValue")]
                [Validation(Required=false)]
                public string ArgValue { get; set; }

            }

        }

    }

}
