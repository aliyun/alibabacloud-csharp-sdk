// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vcs20200515.Models
{
    public class SaveVideoSummaryTaskVideoRequest : TeaModel {
        [NameInMap("CorpId")]
        [Validation(Required=true)]
        public string CorpId { get; set; }

        [NameInMap("TaskId")]
        [Validation(Required=true)]
        public long TaskId { get; set; }

        [NameInMap("SaveVideo")]
        [Validation(Required=true)]
        public bool? SaveVideo { get; set; }

    }

}
