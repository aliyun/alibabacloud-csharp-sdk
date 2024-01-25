// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vdmeter20210425.Models
{
    public class DescribeHuYaTranscodeByDomainResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Result")]
        [Validation(Required=false)]
        public string Result { get; set; }

        [NameInMap("ResultDesc")]
        [Validation(Required=false)]
        public List<DescribeHuYaTranscodeByDomainResponseBodyResultDesc> ResultDesc { get; set; }
        public class DescribeHuYaTranscodeByDomainResponseBodyResultDesc : TeaModel {
            [NameInMap("BusinessType")]
            [Validation(Required=false)]
            public string BusinessType { get; set; }

            [NameInMap("Domain")]
            [Validation(Required=false)]
            public string Domain { get; set; }

            [NameInMap("Time")]
            [Validation(Required=false)]
            public string Time { get; set; }

            [NameInMap("TranscodeDuration")]
            [Validation(Required=false)]
            public long? TranscodeDuration { get; set; }

            [NameInMap("TranscodeNum")]
            [Validation(Required=false)]
            public long? TranscodeNum { get; set; }

            [NameInMap("TranscodeType")]
            [Validation(Required=false)]
            public string TranscodeType { get; set; }

        }

        [NameInMap("Status")]
        [Validation(Required=false)]
        public int? Status { get; set; }

    }

}
