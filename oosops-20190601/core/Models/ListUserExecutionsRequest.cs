// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Oosops20190601.Models
{
    public class ListUserExecutionsRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("AliUid")]
        [Validation(Required=false)]
        public string AliUid { get; set; }

        [NameInMap("EndDateAfter")]
        [Validation(Required=false)]
        public string EndDateAfter { get; set; }

        [NameInMap("EndDateBefore")]
        [Validation(Required=false)]
        public string EndDateBefore { get; set; }

        [NameInMap("ExecutedBy")]
        [Validation(Required=false)]
        public string ExecutedBy { get; set; }

        [NameInMap("ExecutionId")]
        [Validation(Required=false)]
        public string ExecutionId { get; set; }

        [NameInMap("IncludeChildExecution")]
        [Validation(Required=false)]
        public bool? IncludeChildExecution { get; set; }

        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        [NameInMap("Mode")]
        [Validation(Required=false)]
        public string Mode { get; set; }

        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        [NameInMap("ParentExecutionId")]
        [Validation(Required=false)]
        public string ParentExecutionId { get; set; }

        [NameInMap("RamRole")]
        [Validation(Required=false)]
        public string RamRole { get; set; }

        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("SortField")]
        [Validation(Required=false)]
        public string SortField { get; set; }

        [NameInMap("SortOrder")]
        [Validation(Required=false)]
        public string SortOrder { get; set; }

        [NameInMap("StartDateAfter")]
        [Validation(Required=false)]
        public string StartDateAfter { get; set; }

        [NameInMap("StartDateBefore")]
        [Validation(Required=false)]
        public string StartDateBefore { get; set; }

        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        [NameInMap("TemplateName")]
        [Validation(Required=false)]
        public string TemplateName { get; set; }

    }

}
