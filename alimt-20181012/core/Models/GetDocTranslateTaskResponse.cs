// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alimt20181012.Models
{
    public class GetDocTranslateTaskResponse : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=true)]
        public string RequestId { get; set; }

        [NameInMap("TaskId")]
        [Validation(Required=true)]
        public string TaskId { get; set; }

        [NameInMap("Status")]
        [Validation(Required=true)]
        public string Status { get; set; }

        [NameInMap("TranslateFileUrl")]
        [Validation(Required=true)]
        public string TranslateFileUrl { get; set; }

        [NameInMap("TranslateErrorCode")]
        [Validation(Required=true)]
        public string TranslateErrorCode { get; set; }

        [NameInMap("TranslateErrorMessage")]
        [Validation(Required=true)]
        public string TranslateErrorMessage { get; set; }

        [NameInMap("PageCount")]
        [Validation(Required=true)]
        public int? PageCount { get; set; }

    }

}
