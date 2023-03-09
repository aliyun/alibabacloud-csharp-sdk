// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Agency20180703.Models
{
    public class GetBillDetailRequest : TeaModel {
        [NameInMap("AliyunPk")]
        [Validation(Required=false)]
        public long? AliyunPk { get; set; }

        [NameInMap("BillId")]
        [Validation(Required=false)]
        public long? BillId { get; set; }

        [NameInMap("Hid")]
        [Validation(Required=false)]
        public long? Hid { get; set; }

    }

}
