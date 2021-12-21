// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cbn20170912.Models
{
    public class CreateTransitRouterVpcAttachmentRequest : TeaModel {
        [NameInMap("CenId")]
        [Validation(Required=false)]
        public string CenId { get; set; }

        [NameInMap("ChargeType")]
        [Validation(Required=false)]
        public string ChargeType { get; set; }

        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        [NameInMap("DryRun")]
        [Validation(Required=false)]
        public bool? DryRun { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        [NameInMap("TransitRouterAttachmentDescription")]
        [Validation(Required=false)]
        public string TransitRouterAttachmentDescription { get; set; }

        [NameInMap("TransitRouterAttachmentName")]
        [Validation(Required=false)]
        public string TransitRouterAttachmentName { get; set; }

        [NameInMap("TransitRouterId")]
        [Validation(Required=false)]
        public string TransitRouterId { get; set; }

        [NameInMap("VpcId")]
        [Validation(Required=false)]
        public string VpcId { get; set; }

        [NameInMap("VpcOwnerId")]
        [Validation(Required=false)]
        public long? VpcOwnerId { get; set; }

        [NameInMap("ZoneMappings")]
        [Validation(Required=false)]
        public List<CreateTransitRouterVpcAttachmentRequestZoneMappings> ZoneMappings { get; set; }
        public class CreateTransitRouterVpcAttachmentRequestZoneMappings : TeaModel {
            [NameInMap("VSwitchId")]
            [Validation(Required=false)]
            public string VSwitchId { get; set; }

            [NameInMap("ZoneId")]
            [Validation(Required=false)]
            public string ZoneId { get; set; }

        }

    }

}
