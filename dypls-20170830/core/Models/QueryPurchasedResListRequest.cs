// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dypls20170830.Models
{
    public class QueryPurchasedResListRequest : TeaModel {
        [NameInMap("BillId")]
        [Validation(Required=false)]
        public string BillId { get; set; }

        [NameInMap("City")]
        [Validation(Required=false)]
        public string City { get; set; }

        [NameInMap("IsDisplayPool")]
        [Validation(Required=false)]
        public bool? IsDisplayPool { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        [NameInMap("PageNo")]
        [Validation(Required=false)]
        public int? PageNo { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("ProdCode")]
        [Validation(Required=false)]
        public string ProdCode { get; set; }

        [NameInMap("ResBindStatus")]
        [Validation(Required=false)]
        public int? ResBindStatus { get; set; }

        [NameInMap("ResType")]
        [Validation(Required=false)]
        public int? ResType { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        [NameInMap("SecretNo")]
        [Validation(Required=false)]
        public string SecretNo { get; set; }

    }

}
