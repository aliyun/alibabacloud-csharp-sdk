// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ddoscoo20171228.Models
{
    public class DescribeDomainSlsStatusResponse : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=true)]
        public string RequestId { get; set; }

        [NameInMap("SlsStatus")]
        [Validation(Required=true)]
        public bool? SlsStatus { get; set; }

        [NameInMap("SlsLogstore")]
        [Validation(Required=true)]
        public string SlsLogstore { get; set; }

        [NameInMap("SlsProject")]
        [Validation(Required=true)]
        public string SlsProject { get; set; }

    }

}
