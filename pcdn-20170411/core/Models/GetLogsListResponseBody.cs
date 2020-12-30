// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pcdn20170411.Models
{
    public class GetLogsListResponseBody : TeaModel {
        [NameInMap("LogList")]
        [Validation(Required=false)]
        public GetLogsListResponseBodyLogList LogList { get; set; }
        public class GetLogsListResponseBodyLogList : TeaModel {
            [NameInMap("Log")]
            [Validation(Required=false)]
            public List<GetLogsListResponseBodyLogListLog> Log { get; set; }
            public class GetLogsListResponseBodyLogListLog : TeaModel {
                public string EndDate { get; set; }
                public string Url { get; set; }
                public string StartDate { get; set; }
                public string FileName { get; set; }
            }
        };

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

    }

}
