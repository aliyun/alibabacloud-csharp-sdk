// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Oosops20190601.Models
{
    public class ListUserInstancePatchesResponseBody : TeaModel {
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        [NameInMap("Patches")]
        [Validation(Required=false)]
        public List<ListUserInstancePatchesResponseBodyPatches> Patches { get; set; }
        public class ListUserInstancePatchesResponseBodyPatches : TeaModel {
            [NameInMap("Classification")]
            [Validation(Required=false)]
            public string Classification { get; set; }

            [NameInMap("InstalledTime")]
            [Validation(Required=false)]
            public string InstalledTime { get; set; }

            [NameInMap("KBId")]
            [Validation(Required=false)]
            public string KBId { get; set; }

            [NameInMap("Severity")]
            [Validation(Required=false)]
            public string Severity { get; set; }

            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            [NameInMap("Title")]
            [Validation(Required=false)]
            public string Title { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
