// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Oosops20190601.Models
{
    public class ListUserInventoryEntriesResponseBody : TeaModel {
        [NameInMap("CaptureTime")]
        [Validation(Required=false)]
        public string CaptureTime { get; set; }

        [NameInMap("Entries")]
        [Validation(Required=false)]
        public List<Dictionary<string, object>> Entries { get; set; }

        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("SchemaVersion")]
        [Validation(Required=false)]
        public string SchemaVersion { get; set; }

        [NameInMap("TypeName")]
        [Validation(Required=false)]
        public string TypeName { get; set; }

    }

}
