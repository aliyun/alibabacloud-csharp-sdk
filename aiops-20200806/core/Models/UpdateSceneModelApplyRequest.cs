// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aiops20200806.Models
{
    public class UpdateSceneModelApplyRequest : TeaModel {
        [NameInMap("ApplyContent")]
        [Validation(Required=false)]
        public string ApplyContent { get; set; }

        [NameInMap("ApplyId")]
        [Validation(Required=false)]
        public long? ApplyId { get; set; }

        [NameInMap("ApplyStatus")]
        [Validation(Required=false)]
        public int? ApplyStatus { get; set; }

        [NameInMap("OperaUid")]
        [Validation(Required=false)]
        public string OperaUid { get; set; }

    }

}
