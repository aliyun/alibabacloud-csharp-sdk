// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dypls20170830.Models
{
    public class PoolConfigRequest : TeaModel {
        [NameInMap("BillId")]
        [Validation(Required=false)]
        public string BillId { get; set; }

        [NameInMap("CallbackType")]
        [Validation(Required=false)]
        public int? CallbackType { get; set; }

        [NameInMap("FrozenDay")]
        [Validation(Required=false)]
        public int? FrozenDay { get; set; }

        [NameInMap("NeedAllCallRecords")]
        [Validation(Required=false)]
        public bool? NeedAllCallRecords { get; set; }

        [NameInMap("OpenSmsWhite")]
        [Validation(Required=false)]
        public bool? OpenSmsWhite { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        [NameInMap("PoolWarningLimit")]
        [Validation(Required=false)]
        public int? PoolWarningLimit { get; set; }

        [NameInMap("ProdCode")]
        [Validation(Required=false)]
        public string ProdCode { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        [NameInMap("SelectXMode")]
        [Validation(Required=false)]
        public string SelectXMode { get; set; }

        [NameInMap("SmartSmsWhitelist")]
        [Validation(Required=false)]
        public string SmartSmsWhitelist { get; set; }

        [NameInMap("SmsChannel")]
        [Validation(Required=false)]
        public string SmsChannel { get; set; }

    }

}
