// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cdn20180510.Models
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

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
