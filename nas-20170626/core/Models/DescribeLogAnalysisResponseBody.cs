// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.NAS20170626.Models
{
    public class DescribeLogAnalysisResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

        [NameInMap("Analyses")]
        [Validation(Required=false)]
        public DescribeLogAnalysisResponseBodyAnalyses Analyses { get; set; }
        public class DescribeLogAnalysisResponseBodyAnalyses : TeaModel {
            [NameInMap("Analysis")]
            [Validation(Required=false)]
            public List<DescribeLogAnalysisResponseBodyAnalysesAnalysis> Analysis { get; set; }
            public class DescribeLogAnalysisResponseBodyAnalysesAnalysis : TeaModel {
                public string MetaKey { get; set; }
                public DescribeLogAnalysisResponseBodyAnalysesAnalysisMetaValue MetaValue { get; set; }
                public class DescribeLogAnalysisResponseBodyAnalysesAnalysisMetaValue : TeaModel {
                    [NameInMap("Logstore")]
                    [Validation(Required=false)]
                    public string Logstore { get; set; }

                    [NameInMap("RoleArn")]
                    [Validation(Required=false)]
                    public string RoleArn { get; set; }

                    [NameInMap("Project")]
                    [Validation(Required=false)]
                    public string Project { get; set; }

                    [NameInMap("Region")]
                    [Validation(Required=false)]
                    public string Region { get; set; }

                }
            }
        };

    }

}
