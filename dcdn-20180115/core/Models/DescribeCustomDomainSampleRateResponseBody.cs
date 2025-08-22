// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dcdn20180115.Models
{
    public class DescribeCustomDomainSampleRateResponseBody : TeaModel {
        [NameInMap("Content")]
        [Validation(Required=false)]
        public DescribeCustomDomainSampleRateResponseBodyContent Content { get; set; }
        public class DescribeCustomDomainSampleRateResponseBodyContent : TeaModel {
            [NameInMap("DomainContent")]
            [Validation(Required=false)]
            public List<DescribeCustomDomainSampleRateResponseBodyContentDomainContent> DomainContent { get; set; }
            public class DescribeCustomDomainSampleRateResponseBodyContentDomainContent : TeaModel {
                [NameInMap("DomainName")]
                [Validation(Required=false)]
                public string DomainName { get; set; }

                [NameInMap("SampleRate")]
                [Validation(Required=false)]
                public float? SampleRate { get; set; }

            }

            [NameInMap("PageNumber")]
            [Validation(Required=false)]
            public long? PageNumber { get; set; }

            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public long? PageSize { get; set; }

            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public long? TotalCount { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
