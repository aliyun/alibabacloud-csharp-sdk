// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class RefreshMediaPlayUrlsRequest : TeaModel {
        [NameInMap("Definitions")]
        [Validation(Required=false)]
        public string Definitions { get; set; }

        [NameInMap("Formats")]
        [Validation(Required=false)]
        public string Formats { get; set; }

        [NameInMap("MediaIds")]
        [Validation(Required=false)]
        public string MediaIds { get; set; }

        [NameInMap("ResultType")]
        [Validation(Required=false)]
        public string ResultType { get; set; }

        [NameInMap("SliceCount")]
        [Validation(Required=false)]
        public int? SliceCount { get; set; }

        [NameInMap("SliceFlag")]
        [Validation(Required=false)]
        public bool? SliceFlag { get; set; }

        [NameInMap("StreamType")]
        [Validation(Required=false)]
        public string StreamType { get; set; }

        [NameInMap("TaskType")]
        [Validation(Required=false)]
        public string TaskType { get; set; }

        [NameInMap("UserData")]
        [Validation(Required=false)]
        public string UserData { get; set; }

    }

}
