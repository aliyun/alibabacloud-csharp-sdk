// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pcdn20170411.Models
{
    public class GetLogsListResponse : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=true)]
        public string RequestId { get; set; }

        [NameInMap("Code")]
        [Validation(Required=true)]
        public int? Code { get; set; }

        [NameInMap("LogList")]
        [Validation(Required=true)]
        public GetLogsListResponseLogList LogList { get; set; }
        public class GetLogsListResponseLogList : TeaModel {
            [NameInMap("Log")]
            [Validation(Required=true)]
            public List<GetLogsListResponseLogListLog> Log { get; set; }
            public class GetLogsListResponseLogListLog : TeaModel {
                public string Url { get; set; }
                public string FileName { get; set; }
                public string StartDate { get; set; }
                public string EndDate { get; set; }
            }
        };

    }

}
