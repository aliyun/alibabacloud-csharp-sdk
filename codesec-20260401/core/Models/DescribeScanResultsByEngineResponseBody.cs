// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CodeSec20260401.Models
{
    public class DescribeScanResultsByEngineResponseBody : TeaModel {
        [NameInMap("engine")]
        [Validation(Required=false)]
        public string Engine { get; set; }

        [NameInMap("items")]
        [Validation(Required=false)]
        public List<DescribeScanResultsByEngineResponseBodyItems> Items { get; set; }
        public class DescribeScanResultsByEngineResponseBodyItems : TeaModel {
            [NameInMap("baselineState")]
            [Validation(Required=false)]
            public string BaselineState { get; set; }

            [NameInMap("category")]
            [Validation(Required=false)]
            public string Category { get; set; }

            [NameInMap("codeSnippet")]
            [Validation(Required=false)]
            public string CodeSnippet { get; set; }

            [NameInMap("confidence")]
            [Validation(Required=false)]
            public double? Confidence { get; set; }

            /// <summary>
            /// <para>发现记录创建时间（RFC3339）</para>
            /// </summary>
            [NameInMap("createdAt")]
            [Validation(Required=false)]
            public string CreatedAt { get; set; }

            [NameInMap("cweId")]
            [Validation(Required=false)]
            public string CweId { get; set; }

            [NameInMap("description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            [NameInMap("endLine")]
            [Validation(Required=false)]
            public long? EndLine { get; set; }

            [NameInMap("filePath")]
            [Validation(Required=false)]
            public string FilePath { get; set; }

            [NameInMap("id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            [NameInMap("itemSummary")]
            [Validation(Required=false)]
            public string ItemSummary { get; set; }

            [NameInMap("owaspCategory")]
            [Validation(Required=false)]
            public string OwaspCategory { get; set; }

            [NameInMap("projectName")]
            [Validation(Required=false)]
            public string ProjectName { get; set; }

            [NameInMap("remediationCodeExample")]
            [Validation(Required=false)]
            public string RemediationCodeExample { get; set; }

            [NameInMap("remediationSuggestion")]
            [Validation(Required=false)]
            public string RemediationSuggestion { get; set; }

            [NameInMap("ruleId")]
            [Validation(Required=false)]
            public string RuleId { get; set; }

            [NameInMap("scaComponent")]
            [Validation(Required=false)]
            public DescribeScanResultsByEngineResponseBodyItemsScaComponent ScaComponent { get; set; }
            public class DescribeScanResultsByEngineResponseBodyItemsScaComponent : TeaModel {
                [NameInMap("cveCount")]
                [Validation(Required=false)]
                public long? CveCount { get; set; }

                [NameInMap("cveDetails")]
                [Validation(Required=false)]
                public List<DescribeScanResultsByEngineResponseBodyItemsScaComponentCveDetails> CveDetails { get; set; }
                public class DescribeScanResultsByEngineResponseBodyItemsScaComponentCveDetails : TeaModel {
                    [NameInMap("cveId")]
                    [Validation(Required=false)]
                    public string CveId { get; set; }

                    [NameInMap("cvss")]
                    [Validation(Required=false)]
                    public double? Cvss { get; set; }

                    [NameInMap("cvssVersion")]
                    [Validation(Required=false)]
                    public string CvssVersion { get; set; }

                    [NameInMap("description")]
                    [Validation(Required=false)]
                    public string Description { get; set; }

                    [NameInMap("references")]
                    [Validation(Required=false)]
                    public List<string> References { get; set; }

                    [NameInMap("severity")]
                    [Validation(Required=false)]
                    public string Severity { get; set; }

                }

                [NameInMap("introPaths")]
                [Validation(Required=false)]
                public List<string> IntroPaths { get; set; }

                [NameInMap("isDirect")]
                [Validation(Required=false)]
                public bool? IsDirect { get; set; }

                [NameInMap("packageName")]
                [Validation(Required=false)]
                public string PackageName { get; set; }

                [NameInMap("remediation")]
                [Validation(Required=false)]
                public string Remediation { get; set; }

                [NameInMap("version")]
                [Validation(Required=false)]
                public string Version { get; set; }

            }

            [NameInMap("scanId")]
            [Validation(Required=false)]
            public long? ScanId { get; set; }

            [NameInMap("severity")]
            [Validation(Required=false)]
            public string Severity { get; set; }

            [NameInMap("source")]
            [Validation(Required=false)]
            public string Source { get; set; }

            [NameInMap("startLine")]
            [Validation(Required=false)]
            public long? StartLine { get; set; }

            [NameInMap("status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            [NameInMap("taintFlow")]
            [Validation(Required=false)]
            public List<DescribeScanResultsByEngineResponseBodyItemsTaintFlow> TaintFlow { get; set; }
            public class DescribeScanResultsByEngineResponseBodyItemsTaintFlow : TeaModel {
                [NameInMap("code")]
                [Validation(Required=false)]
                public string Code { get; set; }

                [NameInMap("file")]
                [Validation(Required=false)]
                public string File { get; set; }

                [NameInMap("kind")]
                [Validation(Required=false)]
                public string Kind { get; set; }

                [NameInMap("line")]
                [Validation(Required=false)]
                public int? Line { get; set; }

                [NameInMap("note")]
                [Validation(Required=false)]
                public string Note { get; set; }

                [NameInMap("step")]
                [Validation(Required=false)]
                public int? Step { get; set; }

            }

            [NameInMap("taintFlowSummary")]
            [Validation(Required=false)]
            public string TaintFlowSummary { get; set; }

            [NameInMap("title")]
            [Validation(Required=false)]
            public string Title { get; set; }

        }

        [NameInMap("maxResults")]
        [Validation(Required=false)]
        public long? MaxResults { get; set; }

        [NameInMap("nextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        [NameInMap("projectId")]
        [Validation(Required=false)]
        public long? ProjectId { get; set; }

        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("scanId")]
        [Validation(Required=false)]
        public long? ScanId { get; set; }

        [NameInMap("totalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
