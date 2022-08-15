// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BtripOpen20220520.Models
{
    public class CostCenterSaveRequest : TeaModel {
        [NameInMap("alipay_no")]
        [Validation(Required=false)]
        public string AlipayNo { get; set; }

        [NameInMap("number")]
        [Validation(Required=false)]
        public string Number { get; set; }

        [NameInMap("scope")]
        [Validation(Required=false)]
        public long? Scope { get; set; }

        [NameInMap("thirdpart_id")]
        [Validation(Required=false)]
        public string ThirdpartId { get; set; }

        [NameInMap("title")]
        [Validation(Required=false)]
        public string Title { get; set; }

    }

}
