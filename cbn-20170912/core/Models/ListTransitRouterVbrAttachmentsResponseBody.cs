// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cbn20170912.Models
{
    public class ListTransitRouterVbrAttachmentsResponseBody : TeaModel {
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

        [NameInMap("TransitRouterAttachments")]
        [Validation(Required=false)]
        public List<ListTransitRouterVbrAttachmentsResponseBodyTransitRouterAttachments> TransitRouterAttachments { get; set; }
        public class ListTransitRouterVbrAttachmentsResponseBodyTransitRouterAttachments : TeaModel {
            [NameInMap("AutoPublishRouteEnabled")]
            [Validation(Required=false)]
            public bool? AutoPublishRouteEnabled { get; set; }

            [NameInMap("CreationTime")]
            [Validation(Required=false)]
            public string CreationTime { get; set; }

            [NameInMap("ResourceType")]
            [Validation(Required=false)]
            public string ResourceType { get; set; }

            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            [NameInMap("TransitRouterAttachmentDescription")]
            [Validation(Required=false)]
            public string TransitRouterAttachmentDescription { get; set; }

            [NameInMap("TransitRouterAttachmentId")]
            [Validation(Required=false)]
            public string TransitRouterAttachmentId { get; set; }

            [NameInMap("TransitRouterAttachmentName")]
            [Validation(Required=false)]
            public string TransitRouterAttachmentName { get; set; }

            [NameInMap("TransitRouterId")]
            [Validation(Required=false)]
            public string TransitRouterId { get; set; }

            [NameInMap("VbrId")]
            [Validation(Required=false)]
            public string VbrId { get; set; }

            [NameInMap("VbrOwnerId")]
            [Validation(Required=false)]
            public long? VbrOwnerId { get; set; }

            [NameInMap("VbrRegionId")]
            [Validation(Required=false)]
            public string VbrRegionId { get; set; }

        }

    }

}
