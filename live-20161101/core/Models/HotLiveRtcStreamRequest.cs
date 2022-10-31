// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class HotLiveRtcStreamRequest : TeaModel {
        [NameInMap("AppName")]
        [Validation(Required=false)]
        public string AppName { get; set; }

        [NameInMap("AudioMsid")]
        [Validation(Required=false)]
        public string AudioMsid { get; set; }

        [NameInMap("ConnectionTimeout")]
        [Validation(Required=false)]
        public string ConnectionTimeout { get; set; }

        [NameInMap("DomainName")]
        [Validation(Required=false)]
        public string DomainName { get; set; }

        [NameInMap("MediaTimeout")]
        [Validation(Required=false)]
        public string MediaTimeout { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        [NameInMap("RegionCode")]
        [Validation(Required=false)]
        public string RegionCode { get; set; }

        [NameInMap("StreamName")]
        [Validation(Required=false)]
        public string StreamName { get; set; }

        [NameInMap("VideoMsid")]
        [Validation(Required=false)]
        public string VideoMsid { get; set; }

    }

}
