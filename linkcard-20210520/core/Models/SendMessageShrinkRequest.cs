// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Linkcard20210520.Models
{
    public class SendMessageShrinkRequest : TeaModel {
        /// <summary>
        /// Linkcard
        /// </summary>
        [NameInMap("ApiProduct")]
        [Validation(Required=false)]
        public string ApiProduct { get; set; }

        [NameInMap("MessageSendTime")]
        [Validation(Required=false)]
        public long? MessageSendTime { get; set; }

        [NameInMap("MessageTemplateId")]
        [Validation(Required=false)]
        public long? MessageTemplateId { get; set; }

        [NameInMap("MessageVariableParam")]
        [Validation(Required=false)]
        public string MessageVariableParam { get; set; }

        [NameInMap("Msisdns")]
        [Validation(Required=false)]
        public string MsisdnsShrink { get; set; }

        [NameInMap("TaskName")]
        [Validation(Required=false)]
        public string TaskName { get; set; }

    }

}
