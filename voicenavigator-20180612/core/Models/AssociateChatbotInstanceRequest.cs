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
        [NameInMap("ChatbotInstanceId")]
        [Validation(Required=false)]
        public string ChatbotInstanceId { get; set; }

        [NameInMap("ChatbotName")]
        [Validation(Required=false)]
        public string ChatbotName { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        [NameInMap("NluServiceParamsJson")]
        [Validation(Required=false)]
        public string NluServiceParamsJson { get; set; }

        [NameInMap("NluServiceType")]
        [Validation(Required=false)]
        public string NluServiceType { get; set; }

        [NameInMap("UnionSource")]
        [Validation(Required=false)]
        public string UnionSource { get; set; }

    }

}
