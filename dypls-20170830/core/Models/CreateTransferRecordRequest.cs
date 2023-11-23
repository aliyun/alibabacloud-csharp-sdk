// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dypls20170830.Models
{
    public class CreateTransferRecordRequest : TeaModel {
        [NameInMap("City")]
        [Validation(Required=false)]
        public string City { get; set; }

        [NameInMap("NumberList")]
        [Validation(Required=false)]
        public string NumberList { get; set; }

        [NameInMap("OriginBillId")]
        [Validation(Required=false)]
        public string OriginBillId { get; set; }

        [NameInMap("OriginName")]
        [Validation(Required=false)]
        public string OriginName { get; set; }

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

        [NameInMap("TargetBillId")]
        [Validation(Required=false)]
        public string TargetBillId { get; set; }

        [NameInMap("TargetName")]
        [Validation(Required=false)]
        public string TargetName { get; set; }

        [NameInMap("Total")]
        [Validation(Required=false)]
        public int? Total { get; set; }

        [NameInMap("TransferType")]
        [Validation(Required=false)]
        public int? TransferType { get; set; }

    }

}
