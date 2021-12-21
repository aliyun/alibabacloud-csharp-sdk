// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cbn20170912.Models
{
    public class DeleteCenChildInstanceRouteEntryToCenRequest : TeaModel {
        [NameInMap("CenId")]
        [Validation(Required=false)]
        public string CenId { get; set; }

        [NameInMap("ChildInstanceAliUid")]
        [Validation(Required=false)]
        public long? ChildInstanceAliUid { get; set; }

        [NameInMap("ChildInstanceId")]
        [Validation(Required=false)]
        public string ChildInstanceId { get; set; }

        [NameInMap("ChildInstanceRegionId")]
        [Validation(Required=false)]
        public string ChildInstanceRegionId { get; set; }

        [NameInMap("ChildInstanceType")]
        [Validation(Required=false)]
        public string ChildInstanceType { get; set; }

        [NameInMap("DestinationCidrBlock")]
        [Validation(Required=false)]
        public string DestinationCidrBlock { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        [NameInMap("RouteTableId")]
        [Validation(Required=false)]
        public string RouteTableId { get; set; }

    }

}
