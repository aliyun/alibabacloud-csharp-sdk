// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.IntelligentCreation20240313.Models
{
    public class StartAvatarSessionRequest : TeaModel {
        [NameInMap("channelToken")]
        [Validation(Required=false)]
        public string ChannelToken { get; set; }

        [NameInMap("customPushUrl")]
        [Validation(Required=false)]
        public string CustomPushUrl { get; set; }

        [NameInMap("customUserId")]
        [Validation(Required=false)]
        public string CustomUserId { get; set; }

        [NameInMap("projectId")]
        [Validation(Required=false)]
        public string ProjectId { get; set; }

        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
