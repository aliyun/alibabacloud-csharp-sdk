// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CloudAPI20160714.Models
{
    public class DescribeSummaryDataResponseBody : TeaModel {
        [NameInMap("ExpireInstanceNum")]
        [Validation(Required=false)]
        public int? ExpireInstanceNum { get; set; }

        [NameInMap("Region")]
        [Validation(Required=false)]
        public string Region { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("UsageApiNum")]
        [Validation(Required=false)]
        public int? UsageApiNum { get; set; }

        [NameInMap("UsageGroupNum")]
        [Validation(Required=false)]
        public int? UsageGroupNum { get; set; }

        [NameInMap("UsageInstanceNum")]
        [Validation(Required=false)]
        public int? UsageInstanceNum { get; set; }

    }

}
