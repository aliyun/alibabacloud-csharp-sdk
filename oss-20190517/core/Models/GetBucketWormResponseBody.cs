// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Oss20190517.Models
{
    public class GetBucketWormResponseBody : TeaModel {
        [NameInMap("CreationDate")]
        [Validation(Required=false)]
        public string CreationDate { get; set; }

        [NameInMap("RetentionPeriodInDays")]
        [Validation(Required=false)]
        public int? RetentionPeriodInDays { get; set; }

        [NameInMap("State")]
        [Validation(Required=false)]
        public string State { get; set; }

        [NameInMap("WormId")]
        [Validation(Required=false)]
        public string WormId { get; set; }

    }

}
