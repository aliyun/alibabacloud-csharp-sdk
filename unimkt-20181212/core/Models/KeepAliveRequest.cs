// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.UniMkt20181212.Models
{
    public class KeepAliveRequest : TeaModel {
        [NameInMap("CellId")]
        [Validation(Required=false)]
        public string CellId { get; set; }

        [NameInMap("ChannelId")]
        [Validation(Required=false)]
        public string ChannelId { get; set; }

        [NameInMap("DeviceSn")]
        [Validation(Required=false)]
        public string DeviceSn { get; set; }

        [NameInMap("NetworkType")]
        [Validation(Required=false)]
        public int? NetworkType { get; set; }

        [NameInMap("Tac")]
        [Validation(Required=false)]
        public string Tac { get; set; }

    }

}
