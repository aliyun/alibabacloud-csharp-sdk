// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EasyGene20210315.Models
{
    public class ListRunsRequest : TeaModel {
        [NameInMap("AppName")]
        [Validation(Required=false)]
        public string AppName { get; set; }

        [NameInMap("AppRevision")]
        [Validation(Required=false)]
        public string AppRevision { get; set; }

        [NameInMap("EntityName")]
        [Validation(Required=false)]
        public string EntityName { get; set; }

        [NameInMap("EntityType")]
        [Validation(Required=false)]
        public string EntityType { get; set; }

        [NameInMap("GetTotal")]
        [Validation(Required=false)]
        public bool? GetTotal { get; set; }

        [NameInMap("IsReversed")]
        [Validation(Required=false)]
        public bool? IsReversed { get; set; }

        [NameInMap("LabelSelector")]
        [Validation(Required=false)]
        public string LabelSelector { get; set; }

        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        [NameInMap("OrderBy")]
        [Validation(Required=false)]
        public string OrderBy { get; set; }

        [NameInMap("Search")]
        [Validation(Required=false)]
        public string Search { get; set; }

        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        [NameInMap("SubmissionId")]
        [Validation(Required=false)]
        public string SubmissionId { get; set; }

        [NameInMap("Workspace")]
        [Validation(Required=false)]
        public string Workspace { get; set; }

    }

}
