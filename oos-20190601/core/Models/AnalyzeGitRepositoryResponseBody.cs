// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Oos20190601.Models
{
    public class AnalyzeGitRepositoryResponseBody : TeaModel {
        [NameInMap("AnalysisResults")]
        [Validation(Required=false)]
        public List<AnalyzeGitRepositoryResponseBodyAnalysisResults> AnalysisResults { get; set; }
        public class AnalyzeGitRepositoryResponseBodyAnalysisResults : TeaModel {
            [NameInMap("BuildFiles")]
            [Validation(Required=false)]
            public List<AnalyzeGitRepositoryResponseBodyAnalysisResultsBuildFiles> BuildFiles { get; set; }
            public class AnalyzeGitRepositoryResponseBodyAnalysisResultsBuildFiles : TeaModel {
                [NameInMap("FileType")]
                [Validation(Required=false)]
                public string FileType { get; set; }

                [NameInMap("Paths")]
                [Validation(Required=false)]
                public List<string> Paths { get; set; }

            }

            [NameInMap("BuildType")]
            [Validation(Required=false)]
            public string BuildType { get; set; }

            [NameInMap("RuntimeType")]
            [Validation(Required=false)]
            public string RuntimeType { get; set; }

        }

        [NameInMap("Count")]
        [Validation(Required=false)]
        public int? Count { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
