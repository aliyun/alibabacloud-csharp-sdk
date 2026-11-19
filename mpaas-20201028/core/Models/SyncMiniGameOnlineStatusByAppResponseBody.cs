// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.MPaaS20201028.Models
{
    public class SyncMiniGameOnlineStatusByAppResponseBody : TeaModel {
        [NameInMap("AccessDeniedDetail")]
        [Validation(Required=false)]
        public string AccessDeniedDetail { get; set; }

        [NameInMap("Content")]
        [Validation(Required=false)]
        public SyncMiniGameOnlineStatusByAppResponseBodyContent Content { get; set; }
        public class SyncMiniGameOnlineStatusByAppResponseBodyContent : TeaModel {
            [NameInMap("CurrentOnlineStatus")]
            [Validation(Required=false)]
            public int? CurrentOnlineStatus { get; set; }

            [NameInMap("MiniProgramCode")]
            [Validation(Required=false)]
            public string MiniProgramCode { get; set; }

            [NameInMap("StatusChanged")]
            [Validation(Required=false)]
            public bool? StatusChanged { get; set; }

        }

        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("ResultMsg")]
        [Validation(Required=false)]
        public string ResultMsg { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
