// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Oosops20190601.Models
{
    public class ListPublicPatchBaselinesResponseBody : TeaModel {
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        [NameInMap("PatchBaselines")]
        [Validation(Required=false)]
        public List<ListPublicPatchBaselinesResponseBodyPatchBaselines> PatchBaselines { get; set; }
        public class ListPublicPatchBaselinesResponseBodyPatchBaselines : TeaModel {
            [NameInMap("CreatedBy")]
            [Validation(Required=false)]
            public string CreatedBy { get; set; }

            [NameInMap("CreatedDate")]
            [Validation(Required=false)]
            public string CreatedDate { get; set; }

            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            [NameInMap("Id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            [NameInMap("IsDefault")]
            [Validation(Required=false)]
            public bool? IsDefault { get; set; }

            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("OperationSystem")]
            [Validation(Required=false)]
            public string OperationSystem { get; set; }

            [NameInMap("ShareType")]
            [Validation(Required=false)]
            public string ShareType { get; set; }

            [NameInMap("UpdatedBy")]
            [Validation(Required=false)]
            public string UpdatedBy { get; set; }

            [NameInMap("UpdatedDate")]
            [Validation(Required=false)]
            public string UpdatedDate { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
