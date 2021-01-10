/**
 *
 */
// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.VoiceNavigator20180612.Models
{
    public class AssociateChatbotInstanceRequest : TeaModel {
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        [NameInMap("ChatbotInstanceId")]
        [Validation(Required=false)]
        public string ChatbotInstanceId { get; set; }

        [NameInMap("ChatbotName")]
        [Validation(Required=false)]
        public string ChatbotName { get; set; }

    }

}
