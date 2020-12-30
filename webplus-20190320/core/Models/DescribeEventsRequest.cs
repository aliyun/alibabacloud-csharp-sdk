// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.WebPlus20190320.Models
{
    public class DescribeEventsRequest : TeaModel {
        [NameInMap("EnvId")]
        [Validation(Required=false)]
        public string EnvId { get; set; }

        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public long? StartTime { get; set; }

        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public long? EndTime { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        [NameInMap("ChangeId")]
        [Validation(Required=false)]
        public string ChangeId { get; set; }

        [NameInMap("LastChangeEvents")]
        [Validation(Required=false)]
        public bool? LastChangeEvents { get; set; }

        [NameInMap("ReverseByTimestamp")]
        [Validation(Required=false)]
        public bool? ReverseByTimestamp { get; set; }

    }

}
