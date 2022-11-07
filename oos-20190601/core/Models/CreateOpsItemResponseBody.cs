// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Oos20190601.Models
{
    public class CreateOpsItemResponseBody : TeaModel {
        [NameInMap("OpsItem")]
        [Validation(Required=false)]
        public CreateOpsItemResponseBodyOpsItem OpsItem { get; set; }
        public class CreateOpsItemResponseBodyOpsItem : TeaModel {
            [NameInMap("Attributes")]
            [Validation(Required=false)]
            public string Attributes { get; set; }

            [NameInMap("Category")]
            [Validation(Required=false)]
            public string Category { get; set; }

            [NameInMap("CreateDate")]
            [Validation(Required=false)]
            public string CreateDate { get; set; }

            [NameInMap("CreatedBy")]
            [Validation(Required=false)]
            public string CreatedBy { get; set; }

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
            public string Resources { get; set; }

            [NameInMap("Severity")]
            [Validation(Required=false)]
            public string Severity { get; set; }

            [NameInMap("Solutions")]
            [Validation(Required=false)]
            public string Solutions { get; set; }

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
