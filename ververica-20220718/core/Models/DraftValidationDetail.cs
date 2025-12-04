// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ververica20220718.Models
{
    public class DraftValidationDetail : TeaModel {
        [NameInMap("draftMetaInfoErrorDetails")]
        [Validation(Required=false)]
        public List<DraftMetaInfoErrorDetail> DraftMetaInfoErrorDetails { get; set; }

        [NameInMap("sqlErrorDetail")]
        [Validation(Required=false)]
        public ValidationErrorDetails SqlErrorDetail { get; set; }

        [NameInMap("sqlValidationResult")]
        [Validation(Required=false)]
        public string SqlValidationResult { get; set; }

    }

}
