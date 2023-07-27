// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Oss20190517.Models
{
    public class ListAccessPointsResult : TeaModel {
        [NameInMap("AccessPoints")]
        [Validation(Required=false)]
        public List<AccessPoint> AccessPoints { get; set; }

        [NameInMap("AccountId")]
        [Validation(Required=false)]
        public string AccountId { get; set; }

        [NameInMap("IsTruncated")]
        [Validation(Required=false)]
        public string IsTruncated { get; set; }

        [NameInMap("NextContinuationToken")]
        [Validation(Required=false)]
        public string NextContinuationToken { get; set; }

    }

}
