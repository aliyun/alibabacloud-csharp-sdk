// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.VoiceNavigator20180612.Models
{
    public class AssociateChatbotInstanceRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>chatbot-720edd02b66a</para>
        /// </summary>
        [NameInMap("ChatbotInstanceId")]
        [Validation(Required=false)]
        public string ChatbotInstanceId { get; set; }

        [NameInMap("ChatbotName")]
        [Validation(Required=false)]
        public string ChatbotName { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>af81a389-91f0-4157-8d82-720edd02b66a</para>
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
