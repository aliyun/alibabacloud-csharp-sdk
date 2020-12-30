// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Snsuapi20180709.Models
{
    public class BandStatusQueryResponseBody : TeaModel {
        [NameInMap("ResultModule")]
        [Validation(Required=false)]
        public BandStatusQueryResponseBodyResultModule ResultModule { get; set; }
        public class BandStatusQueryResponseBodyResultModule : TeaModel {
            [NameInMap("UploadTarget")]
            [Validation(Required=false)]
            public int? UploadTarget { get; set; }
            [NameInMap("DownloadTarget")]
            [Validation(Required=false)]
            public int? DownloadTarget { get; set; }
        };

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("ResultMessage")]
        [Validation(Required=false)]
        public string ResultMessage { get; set; }

        [NameInMap("ResultCode")]
        [Validation(Required=false)]
        public string ResultCode { get; set; }

    }

}
