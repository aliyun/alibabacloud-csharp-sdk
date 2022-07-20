// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class GetMediaAuditResultResponseBody : TeaModel {
        [NameInMap("AudioResult")]
        [Validation(Required=false)]
        public GetMediaAuditResultResponseBodyAudioResult AudioResult { get; set; }
        public class GetMediaAuditResultResponseBodyAudioResult : TeaModel {
            [NameInMap("Label")]
            [Validation(Required=false)]
            public string Label { get; set; }
            [NameInMap("Scene")]
            [Validation(Required=false)]
            public string Scene { get; set; }
            [NameInMap("Score")]
            [Validation(Required=false)]
            public string Score { get; set; }
            [NameInMap("Suggestion")]
            [Validation(Required=false)]
            public string Suggestion { get; set; }
        };

        [NameInMap("CoverResult")]
        [Validation(Required=false)]
        public GetMediaAuditResultResponseBodyCoverResult CoverResult { get; set; }
        public class GetMediaAuditResultResponseBodyCoverResult : TeaModel {
            [NameInMap("Label")]
            [Validation(Required=false)]
            public string Label { get; set; }
            [NameInMap("Scene")]
            [Validation(Required=false)]
            public string Scene { get; set; }
            [NameInMap("Score")]
            [Validation(Required=false)]
            public string Score { get; set; }
            [NameInMap("Suggestion")]
            [Validation(Required=false)]
            public string Suggestion { get; set; }
        };

        [NameInMap("DescResult")]
        [Validation(Required=false)]
        public GetMediaAuditResultResponseBodyDescResult DescResult { get; set; }
        public class GetMediaAuditResultResponseBodyDescResult : TeaModel {
            [NameInMap("Label")]
            [Validation(Required=false)]
            public string Label { get; set; }
            [NameInMap("Scene")]
            [Validation(Required=false)]
            public string Scene { get; set; }
            [NameInMap("Score")]
            [Validation(Required=false)]
            public string Score { get; set; }
            [NameInMap("Suggestion")]
            [Validation(Required=false)]
            public string Suggestion { get; set; }
        };

        [NameInMap("MediaAuditResult")]
        [Validation(Required=false)]
        public GetMediaAuditResultResponseBodyMediaAuditResult MediaAuditResult { get; set; }
        public class GetMediaAuditResultResponseBodyMediaAuditResult : TeaModel {
            [NameInMap("AbnormalModules")]
            [Validation(Required=false)]
            public string AbnormalModules { get; set; }
            [NameInMap("Label")]
            [Validation(Required=false)]
            public string Label { get; set; }
            [NameInMap("Suggestion")]
            [Validation(Required=false)]
            public string Suggestion { get; set; }
        };

        /// <summary>
        /// RequestId
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("TitleResult")]
        [Validation(Required=false)]
        public GetMediaAuditResultResponseBodyTitleResult TitleResult { get; set; }
        public class GetMediaAuditResultResponseBodyTitleResult : TeaModel {
            [NameInMap("Label")]
            [Validation(Required=false)]
            public string Label { get; set; }
            [NameInMap("Scene")]
            [Validation(Required=false)]
            public string Scene { get; set; }
            [NameInMap("Score")]
            [Validation(Required=false)]
            public string Score { get; set; }
            [NameInMap("Suggestion")]
            [Validation(Required=false)]
            public string Suggestion { get; set; }
        };

        [NameInMap("VideoResult")]
        [Validation(Required=false)]
        public GetMediaAuditResultResponseBodyVideoResult VideoResult { get; set; }
        public class GetMediaAuditResultResponseBodyVideoResult : TeaModel {
            [NameInMap("Label")]
            [Validation(Required=false)]
            public string Label { get; set; }
            [NameInMap("Scene")]
            [Validation(Required=false)]
            public string Scene { get; set; }
            [NameInMap("Score")]
            [Validation(Required=false)]
            public string Score { get; set; }
            [NameInMap("Suggestion")]
            [Validation(Required=false)]
            public string Suggestion { get; set; }
        };

    }

}
