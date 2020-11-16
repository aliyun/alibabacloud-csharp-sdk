// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class DescribeLiveStreamTranscodeStreamNumResponse : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=true)]
        public string RequestId { get; set; }

        [NameInMap("Total")]
        [Validation(Required=true)]
        public long Total { get; set; }

        [NameInMap("TranscodedNumber")]
        [Validation(Required=true)]
        public long TranscodedNumber { get; set; }

        [NameInMap("UntranscodeNumber")]
        [Validation(Required=true)]
        public long UntranscodeNumber { get; set; }

        [NameInMap("LazyTranscodedNumber")]
        [Validation(Required=true)]
        public long LazyTranscodedNumber { get; set; }

    }

}
