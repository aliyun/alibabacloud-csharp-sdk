// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cbn20170912.Models
{
    public class ListTransitRouterCidrResponseBody : TeaModel {
        [NameInMap("CidrLists")]
        [Validation(Required=false)]
        public List<ListTransitRouterCidrResponseBodyCidrLists> CidrLists { get; set; }
        public class ListTransitRouterCidrResponseBodyCidrLists : TeaModel {
            [NameInMap("Cidr")]
            [Validation(Required=false)]
            public string Cidr { get; set; }

            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            [NameInMap("Family")]
            [Validation(Required=false)]
            public string Family { get; set; }

            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("PublishCidrRoute")]
            [Validation(Required=false)]
            public bool? PublishCidrRoute { get; set; }

            [NameInMap("TransitRouterCidrId")]
            [Validation(Required=false)]
            public string TransitRouterCidrId { get; set; }

            [NameInMap("TransitRouterId")]
            [Validation(Required=false)]
            public string TransitRouterId { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
