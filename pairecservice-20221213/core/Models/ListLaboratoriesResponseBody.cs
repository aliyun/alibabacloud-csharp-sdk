// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PaiRecService20221213.Models
{
    public class ListLaboratoriesResponseBody : TeaModel {
        [NameInMap("Laboratories")]
        [Validation(Required=false)]
        public List<ListLaboratoriesResponseBodyLaboratories> Laboratories { get; set; }
        public class ListLaboratoriesResponseBodyLaboratories : TeaModel {
            [NameInMap("BucketCount")]
            [Validation(Required=false)]
            public int? BucketCount { get; set; }

            [NameInMap("BucketType")]
            [Validation(Required=false)]
            public string BucketType { get; set; }

            [NameInMap("Buckets")]
            [Validation(Required=false)]
            public string Buckets { get; set; }

            [NameInMap("CrowdId")]
            [Validation(Required=false)]
            public string CrowdId { get; set; }

            [NameInMap("DebugCrowdId")]
            [Validation(Required=false)]
            public string DebugCrowdId { get; set; }

            [NameInMap("DebugUsers")]
            [Validation(Required=false)]
            public string DebugUsers { get; set; }

            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            [NameInMap("Environment")]
            [Validation(Required=false)]
            public string Environment { get; set; }

            [NameInMap("Filter")]
            [Validation(Required=false)]
            public string Filter { get; set; }

            [NameInMap("LaboratoryId")]
            [Validation(Required=false)]
            public string LaboratoryId { get; set; }

            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("SceneId")]
            [Validation(Required=false)]
            public string SceneId { get; set; }

            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        /// <summary>
        /// Id of the request
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
