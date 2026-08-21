// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class GetMediaAiAnalysisResponseBody : TeaModel {
        [NameInMap("AiAnalysisResultList")]
        [Validation(Required=false)]
        public GetMediaAiAnalysisResponseBodyAiAnalysisResultList AiAnalysisResultList { get; set; }
        public class GetMediaAiAnalysisResponseBodyAiAnalysisResultList : TeaModel {
            [NameInMap("AiAnalysisResult")]
            [Validation(Required=false)]
            public List<GetMediaAiAnalysisResponseBodyAiAnalysisResultListAiAnalysisResult> AiAnalysisResult { get; set; }
            public class GetMediaAiAnalysisResponseBodyAiAnalysisResultListAiAnalysisResult : TeaModel {
                [NameInMap("Content")]
                [Validation(Required=false)]
                public string Content { get; set; }

                [NameInMap("Extra")]
                [Validation(Required=false)]
                public string Extra { get; set; }

                [NameInMap("ResultType")]
                [Validation(Required=false)]
                public string ResultType { get; set; }

                [NameInMap("Summary")]
                [Validation(Required=false)]
                public string Summary { get; set; }

                [NameInMap("Title")]
                [Validation(Required=false)]
                public string Title { get; set; }

            }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>746FFA07-8BBB-46B1-3E94E3B2915E****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
