// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EHPC20240730.Models
{
    public class ListNodesShrinkRequest : TeaModel {
        [NameInMap("ClusterId")]
        [Validation(Required=false)]
        public string ClusterId { get; set; }

        [NameInMap("Hostnames")]
        [Validation(Required=false)]
        public string HostnamesShrink { get; set; }

        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("PrivateIpAddress")]
        [Validation(Required=false)]
        public string PrivateIpAddressShrink { get; set; }

        [NameInMap("QueueNames")]
        [Validation(Required=false)]
        public string QueueNamesShrink { get; set; }

        [NameInMap("Sequence")]
        [Validation(Required=false)]
        public string Sequence { get; set; }

        [NameInMap("SortBy")]
        [Validation(Required=false)]
        public string SortBy { get; set; }

        [NameInMap("Status")]
        [Validation(Required=false)]
        public string StatusShrink { get; set; }

    }

}
