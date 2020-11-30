// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ddoscoo20171228.Models
{
    public class DescribeDDoSEventsRequest : TeaModel {
        [NameInMap("SourceIp")]
        [Validation(Required=false)]
        public string SourceIp { get; set; }

        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        [NameInMap("StartTime")]
        [Validation(Required=true)]
        public long StartTime { get; set; }

        [NameInMap("EndTime")]
        [Validation(Required=true)]
        public long EndTime { get; set; }

        [NameInMap("Eip")]
        [Validation(Required=true)]
        public string Eip { get; set; }

        [NameInMap("Offset")]
        [Validation(Required=true)]
        public int? Offset { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=true)]
        public string PageSize { get; set; }

    }

}
