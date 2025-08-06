// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class GetAuditResultResponseBody : TeaModel {
        [NameInMap("AIAuditResult")]
        [Validation(Required=false)]
        public GetAuditResultResponseBodyAIAuditResult AIAuditResult { get; set; }
        public class GetAuditResultResponseBodyAIAuditResult : TeaModel {
            [NameInMap("AbnormalModules")]
            [Validation(Required=false)]
            public string AbnormalModules { get; set; }

            [NameInMap("CoverResult")]
            [Validation(Required=false)]
            public string CoverResult { get; set; }

            [NameInMap("ImageResult")]
            [Validation(Required=false)]
            public string ImageResult { get; set; }

            [NameInMap("Label")]
            [Validation(Required=false)]
            public string Label { get; set; }

            [NameInMap("PornResult")]
            [Validation(Required=false)]
            public string PornResult { get; set; }

            [NameInMap("TerrorismResult")]
            [Validation(Required=false)]
            public string TerrorismResult { get; set; }

            [NameInMap("TitleResult")]
            [Validation(Required=false)]
            public string TitleResult { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
