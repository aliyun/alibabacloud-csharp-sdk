// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ddoscoo20171228.Models
{
    public class DescribeDomainSlsStatusResponseBody : TeaModel {
        [NameInMap("SlsProject")]
        [Validation(Required=false)]
        public string SlsProject { get; set; }

        [NameInMap("SlsStatus")]
        [Validation(Required=false)]
        public bool? SlsStatus { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("SlsLogstore")]
        [Validation(Required=false)]
        public string SlsLogstore { get; set; }

    }

}
