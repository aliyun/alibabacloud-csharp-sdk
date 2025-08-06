// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class DescribeCdnDomainLogsResponseBody : TeaModel {
        [NameInMap("DomainLogModel")]
        [Validation(Required=false)]
        public DescribeCdnDomainLogsResponseBodyDomainLogModel DomainLogModel { get; set; }
        public class DescribeCdnDomainLogsResponseBodyDomainLogModel : TeaModel {
            [NameInMap("DomainLogDetails")]
            [Validation(Required=false)]
            public DescribeCdnDomainLogsResponseBodyDomainLogModelDomainLogDetails DomainLogDetails { get; set; }
            public class DescribeCdnDomainLogsResponseBodyDomainLogModelDomainLogDetails : TeaModel {
                [NameInMap("DomainLogDetail")]
                [Validation(Required=false)]
                public List<DescribeCdnDomainLogsResponseBodyDomainLogModelDomainLogDetailsDomainLogDetail> DomainLogDetail { get; set; }
                public class DescribeCdnDomainLogsResponseBodyDomainLogModelDomainLogDetailsDomainLogDetail : TeaModel {
                    [NameInMap("EndTime")]
                    [Validation(Required=false)]
                    public string EndTime { get; set; }

                    [NameInMap("LogName")]
                    [Validation(Required=false)]
                    public string LogName { get; set; }

                    [NameInMap("LogPath")]
                    [Validation(Required=false)]
                    public string LogPath { get; set; }

                    [NameInMap("LogSize")]
                    [Validation(Required=false)]
                    public long? LogSize { get; set; }

                    [NameInMap("StartTime")]
                    [Validation(Required=false)]
                    public string StartTime { get; set; }

                }

            }

            [NameInMap("DomainName")]
            [Validation(Required=false)]
            public string DomainName { get; set; }

        }

        [NameInMap("PageNo")]
        [Validation(Required=false)]
        public long? PageNo { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Total")]
        [Validation(Required=false)]
        public long? Total { get; set; }

    }

}
