// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class DescribeLiveTrafficDomainLogResponseBody : TeaModel {
        [NameInMap("DomainLogDetails")]
        [Validation(Required=false)]
        public DescribeLiveTrafficDomainLogResponseBodyDomainLogDetails DomainLogDetails { get; set; }
        public class DescribeLiveTrafficDomainLogResponseBodyDomainLogDetails : TeaModel {
            [NameInMap("DomainLogDetail")]
            [Validation(Required=false)]
            public List<DescribeLiveTrafficDomainLogResponseBodyDomainLogDetailsDomainLogDetail> DomainLogDetail { get; set; }
            public class DescribeLiveTrafficDomainLogResponseBodyDomainLogDetailsDomainLogDetail : TeaModel {
                [NameInMap("LogCount")]
                [Validation(Required=false)]
                public long? LogCount { get; set; }

                [NameInMap("LogInfos")]
                [Validation(Required=false)]
                public DescribeLiveTrafficDomainLogResponseBodyDomainLogDetailsDomainLogDetailLogInfos LogInfos { get; set; }
                public class DescribeLiveTrafficDomainLogResponseBodyDomainLogDetailsDomainLogDetailLogInfos : TeaModel {
                    [NameInMap("LogInfoDetail")]
                    [Validation(Required=false)]
                    public List<DescribeLiveTrafficDomainLogResponseBodyDomainLogDetailsDomainLogDetailLogInfosLogInfoDetail> LogInfoDetail { get; set; }
                    public class DescribeLiveTrafficDomainLogResponseBodyDomainLogDetailsDomainLogDetailLogInfosLogInfoDetail : TeaModel {
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

                [NameInMap("PageInfos")]
                [Validation(Required=false)]
                public DescribeLiveTrafficDomainLogResponseBodyDomainLogDetailsDomainLogDetailPageInfos PageInfos { get; set; }
                public class DescribeLiveTrafficDomainLogResponseBodyDomainLogDetailsDomainLogDetailPageInfos : TeaModel {
                    [NameInMap("PageIndex")]
                    [Validation(Required=false)]
                    public long? PageIndex { get; set; }

                    [NameInMap("PageSize")]
                    [Validation(Required=false)]
                    public long? PageSize { get; set; }

                    [NameInMap("Total")]
                    [Validation(Required=false)]
                    public long? Total { get; set; }

                }

            }

        }

        [NameInMap("DomainName")]
        [Validation(Required=false)]
        public string DomainName { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
