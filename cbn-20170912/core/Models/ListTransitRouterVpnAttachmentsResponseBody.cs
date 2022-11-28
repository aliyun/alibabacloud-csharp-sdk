// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cbn20170912.Models
{
    public class ListTransitRouterVpnAttachmentsResponseBody : TeaModel {
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
        public List<ListTransitRouterVpnAttachmentsResponseBodyTransitRouterAttachments> TransitRouterAttachments { get; set; }
        public class ListTransitRouterVpnAttachmentsResponseBodyTransitRouterAttachments : TeaModel {
            [NameInMap("AutoPublishRouteEnabled")]
            [Validation(Required=false)]
            public bool? AutoPublishRouteEnabled { get; set; }

            [NameInMap("ChargeType")]
            [Validation(Required=false)]
            public string ChargeType { get; set; }

            [NameInMap("CreationTime")]
            [Validation(Required=false)]
            public string CreationTime { get; set; }

            [NameInMap("ResourceType")]
            [Validation(Required=false)]
            public string ResourceType { get; set; }

            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            [NameInMap("Tags")]
            [Validation(Required=false)]
            public List<ListTransitRouterVpnAttachmentsResponseBodyTransitRouterAttachmentsTags> Tags { get; set; }
            public class ListTransitRouterVpnAttachmentsResponseBodyTransitRouterAttachmentsTags : TeaModel {
                [NameInMap("Key")]
                [Validation(Required=false)]
                public string Key { get; set; }

                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

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

            [NameInMap("VpnId")]
            [Validation(Required=false)]
            public string VpnId { get; set; }

            [NameInMap("VpnOwnerId")]
            [Validation(Required=false)]
            public long? VpnOwnerId { get; set; }

            [NameInMap("VpnRegionId")]
            [Validation(Required=false)]
            public string VpnRegionId { get; set; }

            [NameInMap("Zones")]
            [Validation(Required=false)]
            public List<ListTransitRouterVpnAttachmentsResponseBodyTransitRouterAttachmentsZones> Zones { get; set; }
            public class ListTransitRouterVpnAttachmentsResponseBodyTransitRouterAttachmentsZones : TeaModel {
                [NameInMap("ZoneId")]
                [Validation(Required=false)]
                public string ZoneId { get; set; }

            }

        }

    }

}
