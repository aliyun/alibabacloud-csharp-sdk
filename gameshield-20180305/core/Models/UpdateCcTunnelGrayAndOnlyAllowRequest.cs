// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Gameshield20180305.Models
{
    public class UpdateCcTunnelGrayAndOnlyAllowRequest : TeaModel {
        [NameInMap("SourceIp")]
        [Validation(Required=false)]
        public string SourceIp { get; set; }

        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        [NameInMap("BizId")]
        [Validation(Required=false)]
        public string BizId { get; set; }

        [NameInMap("OnlyAllow")]
        [Validation(Required=false)]
        public int? OnlyAllow { get; set; }

        [NameInMap("Gray")]
        [Validation(Required=false)]
        public int? Gray { get; set; }

    }

}
