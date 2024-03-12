// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ExpressConnectRouter20230901.Models
{
    public class CreateExpressConnectRouterAssociationRequest : TeaModel {
        [NameInMap("AllowedPrefixes")]
        [Validation(Required=false)]
        public List<string> AllowedPrefixes { get; set; }

        [NameInMap("AssociationRegionId")]
        [Validation(Required=false)]
        public string AssociationRegionId { get; set; }

        [NameInMap("CenId")]
        [Validation(Required=false)]
        public string CenId { get; set; }

        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        [NameInMap("CreateAttachment")]
        [Validation(Required=false)]
        public bool? CreateAttachment { get; set; }

        [NameInMap("DryRun")]
        [Validation(Required=false)]
        public bool? DryRun { get; set; }

        [NameInMap("EcrId")]
        [Validation(Required=false)]
        public string EcrId { get; set; }

        [NameInMap("TransitRouterId")]
        [Validation(Required=false)]
        public string TransitRouterId { get; set; }

        [NameInMap("TransitRouterOwnerId")]
        [Validation(Required=false)]
        public long? TransitRouterOwnerId { get; set; }

        [NameInMap("VpcId")]
        [Validation(Required=false)]
        public string VpcId { get; set; }

        [NameInMap("VpcOwnerId")]
        [Validation(Required=false)]
        public long? VpcOwnerId { get; set; }

    }

}
