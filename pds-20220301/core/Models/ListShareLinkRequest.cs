// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pds20220301.Models
{
    public class ListShareLinkRequest : TeaModel {
        [NameInMap("creator")]
        [Validation(Required=false)]
        public string Creator { get; set; }

        [NameInMap("include_cancelled")]
        [Validation(Required=false)]
        public bool? IncludeCancelled { get; set; }

        [NameInMap("limit")]
        [Validation(Required=false)]
        public int? Limit { get; set; }

        [NameInMap("marker")]
        [Validation(Required=false)]
        public string Marker { get; set; }

        [NameInMap("order_by")]
        [Validation(Required=false)]
        public string OrderBy { get; set; }

        [NameInMap("order_direction")]
        [Validation(Required=false)]
        public string OrderDirection { get; set; }

    }

}
