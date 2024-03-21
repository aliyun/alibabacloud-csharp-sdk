// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Trademark20190902.Models
{
    public class CheckTrademarkNameRequest : TeaModel {
        [NameInMap("EventSceneType")]
        [Validation(Required=false)]
        public int? EventSceneType { get; set; }

        [NameInMap("TrademarkName")]
        [Validation(Required=false)]
        public string TrademarkName { get; set; }

    }

}
