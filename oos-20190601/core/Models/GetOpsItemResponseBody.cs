// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Oos20190601.Models
{
    public class GetOpsItemResponseBody : TeaModel {
        [NameInMap("OpsItem")]
        [Validation(Required=false)]
        public GetOpsItemResponseBodyOpsItem OpsItem { get; set; }
        public class GetOpsItemResponseBodyOpsItem : TeaModel {
            [NameInMap("Attributes")]
            [Validation(Required=false)]
            public Dictionary<string, object> Attributes { get; set; }

            [NameInMap("Category")]
            [Validation(Required=false)]
            public string Category { get; set; }

            [NameInMap("CreateBy")]
            [Validation(Required=false)]
            public string CreateBy { get; set; }

            [NameInMap("CreateDate")]
            [Validation(Required=false)]
            public string CreateDate { get; set; }

            [NameInMap("DedupString")]
            [Validation(Required=false)]
            public string DedupString { get; set; }

            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            [NameInMap("LastModifiedBy")]
            [Validation(Required=false)]
            public string LastModifiedBy { get; set; }

            [NameInMap("OpsItemId")]
            [Validation(Required=false)]
            public string OpsItemId { get; set; }

            [NameInMap("Priority")]
            [Validation(Required=false)]
            public int? Priority { get; set; }

            [NameInMap("ResourceGroupId")]
            [Validation(Required=false)]
            public string ResourceGroupId { get; set; }

            [NameInMap("Resources")]
            [Validation(Required=false)]
            public List<string> Resources { get; set; }

            [NameInMap("Severity")]
            [Validation(Required=false)]
            public string Severity { get; set; }

            [NameInMap("Solutions")]
            [Validation(Required=false)]
            public List<Dictionary<string, object>> Solutions { get; set; }

            [NameInMap("Source")]
            [Validation(Required=false)]
            public string Source { get; set; }

            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            [NameInMap("Tags")]
            [Validation(Required=false)]
            public Dictionary<string, object> Tags { get; set; }

            [NameInMap("Title")]
            [Validation(Required=false)]
            public string Title { get; set; }

            [NameInMap("UpdateDate")]
            [Validation(Required=false)]
            public string UpdateDate { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
