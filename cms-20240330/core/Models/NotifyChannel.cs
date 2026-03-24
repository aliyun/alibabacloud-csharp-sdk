// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20240330.Models
{
    public class NotifyChannel : TeaModel {
        [NameInMap("channelType")]
        [Validation(Required=false)]
        public string ChannelType { get; set; }

        [NameInMap("enabledSubChannels")]
        [Validation(Required=false)]
        public List<string> EnabledSubChannels { get; set; }

        [NameInMap("receivers")]
        [Validation(Required=false)]
        public List<string> Receivers { get; set; }

    }

}
