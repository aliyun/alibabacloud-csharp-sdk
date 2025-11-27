// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PAICopilot20250731.Models
{
    public class Feedback : TeaModel {
        [NameInMap("ChatId")]
        [Validation(Required=false)]
        public string ChatId { get; set; }

        [NameInMap("FeedbackAction")]
        [Validation(Required=false)]
        public string FeedbackAction { get; set; }

        [NameInMap("FeedbackId")]
        [Validation(Required=false)]
        public string FeedbackId { get; set; }

        [NameInMap("FeedbackMessage")]
        [Validation(Required=false)]
        public string FeedbackMessage { get; set; }

        /// <summary>
        /// <para>Use the UTC time format: yyyy-MM-ddTHH:mm:ssZ</para>
        /// </summary>
        [NameInMap("GmtCreateTime")]
        [Validation(Required=false)]
        public string GmtCreateTime { get; set; }

        /// <summary>
        /// <para>Use the UTC time format: yyyy-MM-ddTHH:mm:ssZ</para>
        /// </summary>
        [NameInMap("GmtModified")]
        [Validation(Required=false)]
        public string GmtModified { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public string OwnerId { get; set; }

        [NameInMap("SessionId")]
        [Validation(Required=false)]
        public string SessionId { get; set; }

        [NameInMap("UserId")]
        [Validation(Required=false)]
        public string UserId { get; set; }

    }

}
