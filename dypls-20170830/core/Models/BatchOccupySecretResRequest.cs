// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dypls20170830.Models
{
    public class BatchOccupySecretResRequest : TeaModel {
        [NameInMap("BatchOccupyList")]
        [Validation(Required=false)]
        public List<BatchOccupySecretResRequestBatchOccupyList> BatchOccupyList { get; set; }
        public class BatchOccupySecretResRequestBatchOccupyList : TeaModel {
            [NameInMap("Count")]
            [Validation(Required=false)]
            public int? Count { get; set; }

            [NameInMap("OrderDetailId")]
            [Validation(Required=false)]
            public long? OrderDetailId { get; set; }

            [NameInMap("OrderId")]
            [Validation(Required=false)]
            public long? OrderId { get; set; }

            [NameInMap("PartnerKey")]
            [Validation(Required=false)]
            public string PartnerKey { get; set; }

            [NameInMap("ResType")]
            [Validation(Required=false)]
            public long? ResType { get; set; }

            [NameInMap("SecretNoType")]
            [Validation(Required=false)]
            public long? SecretNoType { get; set; }

        }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        [NameInMap("ProdCode")]
        [Validation(Required=false)]
        public string ProdCode { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

    }

}
