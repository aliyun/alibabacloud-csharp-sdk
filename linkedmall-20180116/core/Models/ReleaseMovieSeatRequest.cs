// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Linkedmall20180116.Models
{
    public class ReleaseMovieSeatRequest : TeaModel {
        [NameInMap("BizId")]
        [Validation(Required=false)]
        public string BizId { get; set; }

        [NameInMap("BizUid")]
        [Validation(Required=false)]
        public string BizUid { get; set; }

        [NameInMap("ExtJson")]
        [Validation(Required=false)]
        public string ExtJson { get; set; }

        [NameInMap("LockSeatApplyKey")]
        [Validation(Required=false)]
        public string LockSeatApplyKey { get; set; }

    }

}
