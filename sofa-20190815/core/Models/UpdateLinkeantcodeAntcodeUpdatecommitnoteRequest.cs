// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SOFA20190815.Models
{
    public class UpdateLinkeantcodeAntcodeUpdatecommitnoteRequest : TeaModel {
        [NameInMap("Id")]
        [Validation(Required=false)]
        public string Id { get; set; }

        [NameInMap("LabelsRepeatList")]
        [Validation(Required=false)]
        public List<string> LabelsRepeatList { get; set; }

        [NameInMap("Note")]
        [Validation(Required=false)]
        public string Note { get; set; }

        [NameInMap("NoteId")]
        [Validation(Required=false)]
        public string NoteId { get; set; }

        [NameInMap("RequestGitOperate")]
        [Validation(Required=false)]
        public string RequestGitOperate { get; set; }

        [NameInMap("Sha")]
        [Validation(Required=false)]
        public string Sha { get; set; }

        [NameInMap("State")]
        [Validation(Required=false)]
        public string State { get; set; }

    }

}
