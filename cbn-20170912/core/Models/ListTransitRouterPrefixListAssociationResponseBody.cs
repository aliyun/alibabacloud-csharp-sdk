// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cbn20170912.Models
{
    public class ListTransitRouterPrefixListAssociationResponseBody : TeaModel {
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("PrefixLists")]
        [Validation(Required=false)]
        public List<ListTransitRouterPrefixListAssociationResponseBodyPrefixLists> PrefixLists { get; set; }
        public class ListTransitRouterPrefixListAssociationResponseBodyPrefixLists : TeaModel {
            [NameInMap("NextHop")]
            [Validation(Required=false)]
            public string NextHop { get; set; }

            [NameInMap("NextHopInstanceId")]
            [Validation(Required=false)]
            public string NextHopInstanceId { get; set; }

            [NameInMap("NextHopType")]
            [Validation(Required=false)]
            public string NextHopType { get; set; }

            [NameInMap("OwnerUid")]
            [Validation(Required=false)]
            public long? OwnerUid { get; set; }

            [NameInMap("PrefixListId")]
            [Validation(Required=false)]
            public string PrefixListId { get; set; }

            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            [NameInMap("TransitRouterId")]
            [Validation(Required=false)]
            public string TransitRouterId { get; set; }

            [NameInMap("TransitRouterTableId")]
            [Validation(Required=false)]
            public string TransitRouterTableId { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
