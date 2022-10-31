// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class DescribeLiveStreamTranscodeStreamNumResponseBody : TeaModel {
        [NameInMap("LazyTranscodedNumber")]
        [Validation(Required=false)]
        public long? LazyTranscodedNumber { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Total")]
        [Validation(Required=false)]
        public long? Total { get; set; }

        [NameInMap("TranscodedNumber")]
        [Validation(Required=false)]
        public long? TranscodedNumber { get; set; }

        [NameInMap("UntranscodeNumber")]
        [Validation(Required=false)]
        public long? UntranscodeNumber { get; set; }

    }

}
