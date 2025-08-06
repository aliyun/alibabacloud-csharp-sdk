// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class GetAuditResultDetailResponseBody : TeaModel {
        [NameInMap("AIAuditResultDetail")]
        [Validation(Required=false)]
        public GetAuditResultDetailResponseBodyAIAuditResultDetail AIAuditResultDetail { get; set; }
        public class GetAuditResultDetailResponseBodyAIAuditResultDetail : TeaModel {
            [NameInMap("List")]
            [Validation(Required=false)]
            public List<GetAuditResultDetailResponseBodyAIAuditResultDetailList> List { get; set; }
            public class GetAuditResultDetailResponseBodyAIAuditResultDetailList : TeaModel {
                [NameInMap("Index")]
                [Validation(Required=false)]
                public string Index { get; set; }

                [NameInMap("Object")]
                [Validation(Required=false)]
                public string Object { get; set; }

                [NameInMap("PornLabel")]
                [Validation(Required=false)]
                public string PornLabel { get; set; }

                [NameInMap("PornScore")]
                [Validation(Required=false)]
                public string PornScore { get; set; }

                [NameInMap("TerrorismLabel")]
                [Validation(Required=false)]
                public string TerrorismLabel { get; set; }

                [NameInMap("TerrorismScore")]
                [Validation(Required=false)]
                public string TerrorismScore { get; set; }

                [NameInMap("Timestamp")]
                [Validation(Required=false)]
                public string Timestamp { get; set; }

            }

            [NameInMap("Total")]
            [Validation(Required=false)]
            public int? Total { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
