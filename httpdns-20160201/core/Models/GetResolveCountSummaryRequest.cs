// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Httpdns20160201.Models
{
    public class GetResolveCountSummaryRequest : TeaModel {
        [NameInMap("Granularity")]
        [Validation(Required=false)]
        public string Granularity { get; set; }

        [NameInMap("TimeSpan")]
        [Validation(Required=false)]
        public int? TimeSpan { get; set; }

    }

}
