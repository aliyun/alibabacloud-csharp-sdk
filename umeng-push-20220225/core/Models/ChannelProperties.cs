// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Umeng_push20220225.Models
{
    public class ChannelProperties : TeaModel {
        [NameInMap("channelActivity")]
        [Validation(Required=false)]
        public string ChannelActivity { get; set; }

        [NameInMap("mainActivity")]
        [Validation(Required=false)]
        public string MainActivity { get; set; }

        [NameInMap("oppoChannelId")]
        [Validation(Required=false)]
        public string OppoChannelId { get; set; }

        [NameInMap("vivoClassification")]
        [Validation(Required=false)]
        public string VivoClassification { get; set; }

        [NameInMap("xiaomiChannelId")]
        [Validation(Required=false)]
        public string XiaomiChannelId { get; set; }

    }

}
