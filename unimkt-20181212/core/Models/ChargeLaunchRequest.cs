// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.UniMkt20181212.Models
{
    public class ChargeLaunchRequest : TeaModel {
        [NameInMap("AlipayOpenId")]
        [Validation(Required=false)]
        public string AlipayOpenId { get; set; }

        [NameInMap("ChannelId")]
        [Validation(Required=false)]
        public string ChannelId { get; set; }

        [NameInMap("Extra")]
        [Validation(Required=false)]
        public string Extra { get; set; }

        [NameInMap("OuterCode")]
        [Validation(Required=false)]
        public string OuterCode { get; set; }

    }

}
