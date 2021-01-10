// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SOFA20190815.Models
{
    public class ExecLinkeLinklogKnowledgefeedbackResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("ResponseStatusCode")]
        [Validation(Required=false)]
        public long? ResponseStatusCode { get; set; }

        [NameInMap("ResponseContentRange")]
        [Validation(Required=false)]
        public string ResponseContentRange { get; set; }

        [NameInMap("ErrorMsg")]
        [Validation(Required=false)]
        public string ErrorMsg { get; set; }

        [NameInMap("ResponseContentType")]
        [Validation(Required=false)]
        public string ResponseContentType { get; set; }

        [NameInMap("ResultMessage")]
        [Validation(Required=false)]
        public string ResultMessage { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        [NameInMap("ResultCode")]
        [Validation(Required=false)]
        public string ResultCode { get; set; }

        [NameInMap("Result")]
        [Validation(Required=false)]
        public ExecLinkeLinklogKnowledgefeedbackResponseBodyResult Result { get; set; }
        public class ExecLinkeLinklogKnowledgefeedbackResponseBodyResult : TeaModel {
            [NameInMap("CurrentPage")]
            [Validation(Required=false)]
            public long? CurrentPage { get; set; }
            [NameInMap("EndMills")]
            [Validation(Required=false)]
            public long? EndMills { get; set; }
            [NameInMap("Result")]
            [Validation(Required=false)]
            public long? Result { get; set; }
            [NameInMap("KnowledgeId")]
            [Validation(Required=false)]
            public long? KnowledgeId { get; set; }
            [NameInMap("End")]
            [Validation(Required=false)]
            public long? End { get; set; }
            [NameInMap("GmtModified")]
            [Validation(Required=false)]
            public long? GmtModified { get; set; }
            [NameInMap("BeginMills")]
            [Validation(Required=false)]
            public long? BeginMills { get; set; }
            [NameInMap("StoreId")]
            [Validation(Required=false)]
            public long? StoreId { get; set; }
            [NameInMap("IsOptions")]
            [Validation(Required=false)]
            public long? IsOptions { get; set; }
            [NameInMap("Sorter")]
            [Validation(Required=false)]
            public string Sorter { get; set; }
            [NameInMap("TagList")]
            [Validation(Required=false)]
            public List<string> TagList { get; set; }
            [NameInMap("Begin")]
            [Validation(Required=false)]
            public long? Begin { get; set; }
            [NameInMap("LogId")]
            [Validation(Required=false)]
            public long? LogId { get; set; }
            [NameInMap("GmtCreate")]
            [Validation(Required=false)]
            public long? GmtCreate { get; set; }
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public long? PageSize { get; set; }
            [NameInMap("Feedback")]
            [Validation(Required=false)]
            public string Feedback { get; set; }
            [NameInMap("Id")]
            [Validation(Required=false)]
            public long? Id { get; set; }
        };

    }

}
