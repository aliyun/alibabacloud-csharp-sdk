// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Oos20190601.Models
{
    public class ListOpsItemsResponseBody : TeaModel {
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        [NameInMap("OpsItems")]
        [Validation(Required=false)]
        public List<ListOpsItemsResponseBodyOpsItems> OpsItems { get; set; }
        public class ListOpsItemsResponseBodyOpsItems : TeaModel {
            [NameInMap("Category")]
            [Validation(Required=false)]
            public string Category { get; set; }

            [NameInMap("CreateDate")]
            [Validation(Required=false)]
            public string CreateDate { get; set; }

            [NameInMap("OpsItemId")]
            [Validation(Required=false)]
            public string OpsItemId { get; set; }

            [NameInMap("Priority")]
            [Validation(Required=false)]
            public int? Priority { get; set; }

            [NameInMap("Resources")]
            [Validation(Required=false)]
            public List<string> Resources { get; set; }

            [NameInMap("Severity")]
            [Validation(Required=false)]
            public string Severity { get; set; }

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

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
