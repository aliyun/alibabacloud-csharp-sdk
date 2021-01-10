// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SOFA20190815.Models
{
    public class GetDWSCrawlerOverviewResponseBody : TeaModel {
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
        public GetDWSCrawlerOverviewResponseBodyData Data { get; set; }
        public class GetDWSCrawlerOverviewResponseBodyData : TeaModel {
            [NameInMap("PageTotal")]
            [Validation(Required=false)]
            public long? PageTotal { get; set; }
            [NameInMap("DbTypeList")]
            [Validation(Required=false)]
            public List<string> DbTypeList { get; set; }
            [NameInMap("CrawlerOverviewList")]
            [Validation(Required=false)]
            public List<GetDWSCrawlerOverviewResponseBodyDataCrawlerOverviewList> CrawlerOverviewList { get; set; }
            public class GetDWSCrawlerOverviewResponseBodyDataCrawlerOverviewList : TeaModel {
                public string BeginTimeStamp { get; set; }
                public long? Conn { get; set; }
                public long? CrawlerDelay { get; set; }
                public string CrawlerName { get; set; }
                public string DbType { get; set; }
                public string EndTimeStamp { get; set; }
                public long? Ios { get; set; }
                public string Location { get; set; }
                public string MonitorTime { get; set; }
                public string Status { get; set; }
                public string Tps { get; set; }
            }
        };

    }

}
