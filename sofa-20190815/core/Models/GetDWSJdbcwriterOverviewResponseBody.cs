// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SOFA20190815.Models
{
    public class GetDWSJdbcwriterOverviewResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("ResultCode")]
        [Validation(Required=false)]
        public string ResultCode { get; set; }

        [NameInMap("ResultMessage")]
        [Validation(Required=false)]
        public string ResultMessage { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetDWSJdbcwriterOverviewResponseBodyData Data { get; set; }
        public class GetDWSJdbcwriterOverviewResponseBodyData : TeaModel {
            [NameInMap("PageTotal")]
            [Validation(Required=false)]
            public long? PageTotal { get; set; }
            [NameInMap("DestDbTypeList")]
            [Validation(Required=false)]
            public List<string> DestDbTypeList { get; set; }
            [NameInMap("JdbcwriterOverviewList")]
            [Validation(Required=false)]
            public List<GetDWSJdbcwriterOverviewResponseBodyDataJdbcwriterOverviewList> JdbcwriterOverviewList { get; set; }
            public class GetDWSJdbcwriterOverviewResponseBodyDataJdbcwriterOverviewList : TeaModel {
                public long? CrawlerDelay { get; set; }
                public string CrawlerName { get; set; }
                public string DestDbtype { get; set; }
                public long? Iops { get; set; }
                public long? JdbcwriterDelay { get; set; }
                public string JdbcwriterName { get; set; }
                public string Location { get; set; }
                public string MonitorTime { get; set; }
                public long? Rps { get; set; }
                public string SourceDbtype { get; set; }
                public long? Status { get; set; }
            }
        };

    }

}
