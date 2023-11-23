// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dypls20170830.Models
{
    public class BindResourceRequest : TeaModel {
        [NameInMap("AsrModelId")]
        [Validation(Required=false)]
        public string AsrModelId { get; set; }

        [NameInMap("AsrStatus")]
        [Validation(Required=false)]
        public bool? AsrStatus { get; set; }

        [NameInMap("AxnExtensionB")]
        [Validation(Required=false)]
        public string AxnExtensionB { get; set; }

        [NameInMap("BillId")]
        [Validation(Required=false)]
        public string BillId { get; set; }

        [NameInMap("ExpTime")]
        [Validation(Required=false)]
        public string ExpTime { get; set; }

        [NameInMap("IsRecord")]
        [Validation(Required=false)]
        public bool? IsRecord { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        [NameInMap("PhoneNoA")]
        [Validation(Required=false)]
        public string PhoneNoA { get; set; }

        [NameInMap("PhoneNoB")]
        [Validation(Required=false)]
        public string PhoneNoB { get; set; }

        [NameInMap("ProdCode")]
        [Validation(Required=false)]
        public string ProdCode { get; set; }

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
