// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mts20140618.Models
{
    public class QueryIProductionJobListResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Jobs")]
        [Validation(Required=false)]
        public QueryIProductionJobListResponseBodyJobs Jobs { get; set; }
        public class QueryIProductionJobListResponseBodyJobs : TeaModel {
            [NameInMap("String")]
            [Validation(Required=false)]
            public List<string> String { get; set; }
        };

        [NameInMap("NextPageToken")]
        [Validation(Required=false)]
        public string NextPageToken { get; set; }

        [NameInMap("NonExistIds")]
        [Validation(Required=false)]
        public QueryIProductionJobListResponseBodyNonExistIds NonExistIds { get; set; }
        public class QueryIProductionJobListResponseBodyNonExistIds : TeaModel {
            [NameInMap("String")]
            [Validation(Required=false)]
            public List<string> String { get; set; }
        };

    }

}
