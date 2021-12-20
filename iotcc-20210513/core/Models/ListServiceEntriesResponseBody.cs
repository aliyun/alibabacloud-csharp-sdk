// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.IoTCC20210513.Models
{
    public class ListServiceEntriesResponseBody : TeaModel {
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("ServiceEntries")]
        [Validation(Required=false)]
        public List<ListServiceEntriesResponseBodyServiceEntries> ServiceEntries { get; set; }
        public class ListServiceEntriesResponseBodyServiceEntries : TeaModel {
            [NameInMap("ServiceEntryDescription")]
            [Validation(Required=false)]
            public string ServiceEntryDescription { get; set; }

            [NameInMap("ServiceEntryId")]
            [Validation(Required=false)]
            public string ServiceEntryId { get; set; }

            [NameInMap("ServiceEntryName")]
            [Validation(Required=false)]
            public string ServiceEntryName { get; set; }

            [NameInMap("ServiceEntryStatus")]
            [Validation(Required=false)]
            public string ServiceEntryStatus { get; set; }

            [NameInMap("ServiceId")]
            [Validation(Required=false)]
            public string ServiceId { get; set; }

            [NameInMap("Target")]
            [Validation(Required=false)]
            public string Target { get; set; }

            [NameInMap("TargetType")]
            [Validation(Required=false)]
            public string TargetType { get; set; }

        }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
