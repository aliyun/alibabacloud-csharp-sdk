// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class GetMediaAuditResultDetailResponseBody : TeaModel {
        [NameInMap("AuditResultDetails")]
        [Validation(Required=false)]
        public List<GetMediaAuditResultDetailResponseBodyAuditResultDetails> AuditResultDetails { get; set; }
        public class GetMediaAuditResultDetailResponseBodyAuditResultDetails : TeaModel {
            [NameInMap("AdLabel")]
            [Validation(Required=false)]
            public string AdLabel { get; set; }

            [NameInMap("AdScore")]
            [Validation(Required=false)]
            public string AdScore { get; set; }

            [NameInMap("LiveLabel")]
            [Validation(Required=false)]
            public string LiveLabel { get; set; }

            [NameInMap("LiveScore")]
            [Validation(Required=false)]
            public string LiveScore { get; set; }

            [NameInMap("LogoLabel")]
            [Validation(Required=false)]
            public string LogoLabel { get; set; }

            [NameInMap("LogoScore")]
            [Validation(Required=false)]
            public string LogoScore { get; set; }

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

            [NameInMap("Url")]
            [Validation(Required=false)]
            public string Url { get; set; }

        }

        /// <summary>
        /// RequestId
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Total")]
        [Validation(Required=false)]
        public string Total { get; set; }

    }

}
