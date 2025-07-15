// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class DescribeLiveDomainLogExTtlResponseBody : TeaModel {
        [NameInMap("DomainLogDetails")]
        [Validation(Required=false)]
        public DescribeLiveDomainLogExTtlResponseBodyDomainLogDetails DomainLogDetails { get; set; }
        public class DescribeLiveDomainLogExTtlResponseBodyDomainLogDetails : TeaModel {
            [NameInMap("DomainLogDetail")]
            [Validation(Required=false)]
            public List<DescribeLiveDomainLogExTtlResponseBodyDomainLogDetailsDomainLogDetail> DomainLogDetail { get; set; }
            public class DescribeLiveDomainLogExTtlResponseBodyDomainLogDetailsDomainLogDetail : TeaModel {
                [NameInMap("LogCount")]
                [Validation(Required=false)]
                public long? LogCount { get; set; }

                [NameInMap("LogInfos")]
                [Validation(Required=false)]
                public DescribeLiveDomainLogExTtlResponseBodyDomainLogDetailsDomainLogDetailLogInfos LogInfos { get; set; }
                public class DescribeLiveDomainLogExTtlResponseBodyDomainLogDetailsDomainLogDetailLogInfos : TeaModel {
                    [NameInMap("LogInfoDetail")]
                    [Validation(Required=false)]
                    public List<DescribeLiveDomainLogExTtlResponseBodyDomainLogDetailsDomainLogDetailLogInfosLogInfoDetail> LogInfoDetail { get; set; }
                    public class DescribeLiveDomainLogExTtlResponseBodyDomainLogDetailsDomainLogDetailLogInfosLogInfoDetail : TeaModel {
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
                public DescribeLiveDomainLogExTtlResponseBodyDomainLogDetailsDomainLogDetailPageInfos PageInfos { get; set; }
                public class DescribeLiveDomainLogExTtlResponseBodyDomainLogDetailsDomainLogDetailPageInfos : TeaModel {
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
