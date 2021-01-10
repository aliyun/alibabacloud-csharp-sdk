// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class SetLiveStreamDelayConfigRequest : TeaModel {
        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        [NameInMap("DomainName")]
        [Validation(Required=false)]
        public string DomainName { get; set; }

        [NameInMap("HlsDelay")]
        [Validation(Required=false)]
        public int? HlsDelay { get; set; }

        [NameInMap("HlsLevel")]
        [Validation(Required=false)]
        public string HlsLevel { get; set; }

        [NameInMap("FlvDelay")]
        [Validation(Required=false)]
        public int? FlvDelay { get; set; }

        [NameInMap("FlvLevel")]
        [Validation(Required=false)]
        public string FlvLevel { get; set; }

        [NameInMap("RtmpDelay")]
        [Validation(Required=false)]
        public int? RtmpDelay { get; set; }

        [NameInMap("RtmpLevel")]
        [Validation(Required=false)]
        public string RtmpLevel { get; set; }

    }

}
