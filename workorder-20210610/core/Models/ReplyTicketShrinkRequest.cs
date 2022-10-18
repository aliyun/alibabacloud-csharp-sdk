// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Workorder20210610.Models
{
    public class ReplyTicketShrinkRequest : TeaModel {
        [NameInMap("Content")]
        [Validation(Required=false)]
        public string Content { get; set; }

        [NameInMap("Encrypt")]
        [Validation(Required=false)]
        public bool? Encrypt { get; set; }

        [NameInMap("FileNameList")]
        [Validation(Required=false)]
        public string FileNameListShrink { get; set; }

        [NameInMap("TicketId")]
        [Validation(Required=false)]
        public string TicketId { get; set; }

    }

}
