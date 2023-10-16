// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.VoiceNavigator20180612.Models
{
    public class CollectedNumberRequest : TeaModel {
        [NameInMap("AdditionalContext")]
        [Validation(Required=false)]
        public string AdditionalContext { get; set; }

        [NameInMap("ConversationId")]
        [Validation(Required=false)]
        public string ConversationId { get; set; }

        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        [NameInMap("InstanceOwnerId")]
        [Validation(Required=false)]
        public long? InstanceOwnerId { get; set; }

        [NameInMap("Number")]
        [Validation(Required=false)]
        public string Number { get; set; }

    }

}
