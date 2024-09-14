// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class ListVpcPublishedRouteEntriesResponseBody : TeaModel {
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("RouteEntries")]
        [Validation(Required=false)]
        public List<ListVpcPublishedRouteEntriesResponseBodyRouteEntries> RouteEntries { get; set; }
        public class ListVpcPublishedRouteEntriesResponseBodyRouteEntries : TeaModel {
            [NameInMap("DestinationCidrBlock")]
            [Validation(Required=false)]
            public string DestinationCidrBlock { get; set; }

            [NameInMap("RouteEntryId")]
            [Validation(Required=false)]
            public string RouteEntryId { get; set; }

            [NameInMap("RoutePublishTargets")]
            [Validation(Required=false)]
            public List<ListVpcPublishedRouteEntriesResponseBodyRouteEntriesRoutePublishTargets> RoutePublishTargets { get; set; }
            public class ListVpcPublishedRouteEntriesResponseBodyRouteEntriesRoutePublishTargets : TeaModel {
                [NameInMap("PublishStatus")]
                [Validation(Required=false)]
                public string PublishStatus { get; set; }

                [NameInMap("PublishTargetInstanceId")]
                [Validation(Required=false)]
                public string PublishTargetInstanceId { get; set; }

                [NameInMap("PublishTargetType")]
                [Validation(Required=false)]
                public string PublishTargetType { get; set; }

            }

            [NameInMap("RouteTableId")]
            [Validation(Required=false)]
            public string RouteTableId { get; set; }

        }

    }

}
