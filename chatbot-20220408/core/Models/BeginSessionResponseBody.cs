// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Chatbot20220408.Models
{
    public class BeginSessionResponseBody : TeaModel {
        [NameInMap("AsrMaxEndSilence")]
        [Validation(Required=false)]
        public int? AsrMaxEndSilence { get; set; }

        [NameInMap("Interruptible")]
        [Validation(Required=false)]
        public bool? Interruptible { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// 静默超时时间
        /// </summary>
        [NameInMap("SilenceReplyTimeout")]
        [Validation(Required=false)]
        public int? SilenceReplyTimeout { get; set; }

        [NameInMap("WelcomeMessage")]
        [Validation(Required=false)]
        public string WelcomeMessage { get; set; }

    }

}
