// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CS20151215.Models
{
    public class DescribeEventsRequest : TeaModel {
        [NameInMap("cluster_id")]
        [Validation(Required=false)]
        public string ClusterId { get; set; }

        [NameInMap("page_number")]
        [Validation(Required=false)]
        public long? PageNumber { get; set; }

        [NameInMap("page_size")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

        [NameInMap("type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
