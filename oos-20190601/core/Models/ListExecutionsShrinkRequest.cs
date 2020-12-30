// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Oos20190601.Models
{
    public class ListExecutionsShrinkRequest : TeaModel {
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("TemplateName")]
        [Validation(Required=false)]
        public string TemplateName { get; set; }

        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        [NameInMap("ExecutionId")]
        [Validation(Required=false)]
        public string ExecutionId { get; set; }

        [NameInMap("StartDateBefore")]
        [Validation(Required=false)]
        public string StartDateBefore { get; set; }

        [NameInMap("StartDateAfter")]
        [Validation(Required=false)]
        public string StartDateAfter { get; set; }

        [NameInMap("EndDateBefore")]
        [Validation(Required=false)]
        public string EndDateBefore { get; set; }

        [NameInMap("EndDateAfter")]
        [Validation(Required=false)]
        public string EndDateAfter { get; set; }

        [NameInMap("Mode")]
        [Validation(Required=false)]
        public string Mode { get; set; }

        [NameInMap("ExecutedBy")]
        [Validation(Required=false)]
        public string ExecutedBy { get; set; }

        [NameInMap("ParentExecutionId")]
        [Validation(Required=false)]
        public string ParentExecutionId { get; set; }

        [NameInMap("RamRole")]
        [Validation(Required=false)]
        public string RamRole { get; set; }

        [NameInMap("IncludeChildExecution")]
        [Validation(Required=false)]
        public bool? IncludeChildExecution { get; set; }

        [NameInMap("Category")]
        [Validation(Required=false)]
        public string Category { get; set; }

        [NameInMap("Tags")]
        [Validation(Required=false)]
        public string TagsShrink { get; set; }

        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        [NameInMap("SortField")]
        [Validation(Required=false)]
        public string SortField { get; set; }

        [NameInMap("SortOrder")]
        [Validation(Required=false)]
        public string SortOrder { get; set; }

        [NameInMap("ResourceId")]
        [Validation(Required=false)]
        public string ResourceId { get; set; }

        [NameInMap("ResourceTemplateName")]
        [Validation(Required=false)]
        public string ResourceTemplateName { get; set; }

    }

}
