// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aliding20230426.Models
{
    public class SaveFormRemarkRequest : TeaModel {
        [NameInMap("AppType")]
        [Validation(Required=false)]
        public string AppType { get; set; }

        [NameInMap("AtUserId")]
        [Validation(Required=false)]
        public string AtUserId { get; set; }

        [NameInMap("Content")]
        [Validation(Required=false)]
        public string Content { get; set; }

        [NameInMap("FormInstanceId")]
        [Validation(Required=false)]
        public string FormInstanceId { get; set; }

        [NameInMap("Language")]
        [Validation(Required=false)]
        public string Language { get; set; }

        [NameInMap("ReplyId")]
        [Validation(Required=false)]
        public long? ReplyId { get; set; }

        [NameInMap("SystemToken")]
        [Validation(Required=false)]
        public string SystemToken { get; set; }

    }

}
