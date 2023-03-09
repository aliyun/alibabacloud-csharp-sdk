// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Agency20180703.Models
{
    public class GetOrderDetailRequest : TeaModel {
        [NameInMap("AliyunPk")]
        [Validation(Required=false)]
        public long? AliyunPk { get; set; }

        [NameInMap("OrderNo")]
        [Validation(Required=false)]
        public long? OrderNo { get; set; }

    }

}
