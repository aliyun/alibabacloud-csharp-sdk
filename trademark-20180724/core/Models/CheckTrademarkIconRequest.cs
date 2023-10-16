// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Trademark20180724.Models
{
    public class CheckTrademarkIconRequest : TeaModel {
        [NameInMap("EventSceneType")]
        [Validation(Required=false)]
        public int? EventSceneType { get; set; }

        [NameInMap("TrademarkIconOssKey")]
        [Validation(Required=false)]
        public string TrademarkIconOssKey { get; set; }

    }

}
