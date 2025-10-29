// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.IQS20241111.Models
{
    public class ReadPageItem : TeaModel {
        [NameInMap("errorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        [NameInMap("html")]
        [Validation(Required=false)]
        public string Html { get; set; }

        [NameInMap("markdown")]
        [Validation(Required=false)]
        public string Markdown { get; set; }

        [NameInMap("rawHtml")]
        [Validation(Required=false)]
        public string RawHtml { get; set; }

        [NameInMap("screenshot")]
        [Validation(Required=false)]
        public string Screenshot { get; set; }

        [NameInMap("statusCode")]
        [Validation(Required=false)]
        public int? StatusCode { get; set; }

        [NameInMap("text")]
        [Validation(Required=false)]
        public string Text { get; set; }

    }

}
