// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dypls20170830.Models
{
    public class OccupySecretResRequest : TeaModel {
        [NameInMap("City")]
        [Validation(Required=false)]
        public string City { get; set; }

        [NameInMap("IsDisplayPool")]
        [Validation(Required=false)]
        public bool? IsDisplayPool { get; set; }

        [NameInMap("NoLike")]
        [Validation(Required=false)]
        public string NoLike { get; set; }

        [NameInMap("OrderDetailId")]
        [Validation(Required=false)]
        public long? OrderDetailId { get; set; }

        [NameInMap("OrderId")]
        [Validation(Required=false)]
        public long? OrderId { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        [NameInMap("PartnerKey")]
        [Validation(Required=false)]
        public string PartnerKey { get; set; }

        [NameInMap("ProdCode")]
        [Validation(Required=false)]
        public string ProdCode { get; set; }

        [NameInMap("ResType")]
        [Validation(Required=false)]
        public long? ResType { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        [NameInMap("SecretNoType")]
        [Validation(Required=false)]
        public int? SecretNoType { get; set; }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

        [NameInMap("secretNo")]
        [Validation(Required=false)]
        public string SecretNo { get; set; }

    }

}
