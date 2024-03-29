// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ddoscoo20171228.Models
{
    public class DescribeDDoSTrafficRequest : TeaModel {
        [NameInMap("SourceIp")]
        [Validation(Required=false)]
        public string SourceIp { get; set; }

        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        [NameInMap("StartTime")]
        [Validation(Required=true)]
        public long? StartTime { get; set; }

        [NameInMap("Interval")]
        [Validation(Required=true)]
        public int? Interval { get; set; }

        [NameInMap("EndTime")]
        [Validation(Required=true)]
        public long? EndTime { get; set; }

        [NameInMap("Eip")]
        [Validation(Required=true)]
        public string Eip { get; set; }

    }

}
