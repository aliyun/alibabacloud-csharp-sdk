// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alimt20181012.Models
{
    public class GetDocTranslateTaskResponseBody : TeaModel {
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("TranslateFileUrl")]
        [Validation(Required=false)]
        public string TranslateFileUrl { get; set; }

        [NameInMap("TranslateErrorCode")]
        [Validation(Required=false)]
        public string TranslateErrorCode { get; set; }

        [NameInMap("PageCount")]
        [Validation(Required=false)]
        public int? PageCount { get; set; }

        [NameInMap("TaskId")]
        [Validation(Required=false)]
        public string TaskId { get; set; }

        [NameInMap("TranslateErrorMessage")]
        [Validation(Required=false)]
        public string TranslateErrorMessage { get; set; }

    }

}
