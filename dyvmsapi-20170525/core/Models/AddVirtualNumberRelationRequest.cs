// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dyvmsapi20170525.Models
{
    public class AddVirtualNumberRelationRequest : TeaModel {
        [NameInMap("CorpNameList")]
        [Validation(Required=false)]
        public string CorpNameList { get; set; }

        [NameInMap("NumberList")]
        [Validation(Required=false)]
        public string NumberList { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        [NameInMap("PhoneNum")]
        [Validation(Required=false)]
        public string PhoneNum { get; set; }

        [NameInMap("ProdCode")]
        [Validation(Required=false)]
        public string ProdCode { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        [NameInMap("RouteType")]
        [Validation(Required=false)]
        public int? RouteType { get; set; }

    }

}
