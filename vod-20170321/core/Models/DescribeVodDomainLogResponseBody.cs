// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class DescribeVodDomainLogResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("DomainLogDetails")]
        [Validation(Required=false)]
        public DescribeVodDomainLogResponseBodyDomainLogDetails DomainLogDetails { get; set; }
        public class DescribeVodDomainLogResponseBodyDomainLogDetails : TeaModel {
            [NameInMap("DomainLogDetail")]
            [Validation(Required=false)]
            public List<DescribeVodDomainLogResponseBodyDomainLogDetailsDomainLogDetail> DomainLogDetail { get; set; }
            public class DescribeVodDomainLogResponseBodyDomainLogDetailsDomainLogDetail : TeaModel {
                public DescribeVodDomainLogResponseBodyDomainLogDetailsDomainLogDetailPageInfos PageInfos { get; set; }
                public class DescribeVodDomainLogResponseBodyDomainLogDetailsDomainLogDetailPageInfos : TeaModel {
                    [NameInMap("PageNumber")]
                    [Validation(Required=false)]
                    public long? PageNumber { get; set; }

                    [NameInMap("PageSize")]
                    [Validation(Required=false)]
                    public long? PageSize { get; set; }

                    [NameInMap("Total")]
                    [Validation(Required=false)]
                    public long? Total { get; set; }

                }
                public long? LogCount { get; set; }
                public string DomainName { get; set; }
                public DescribeVodDomainLogResponseBodyDomainLogDetailsDomainLogDetailLogInfos LogInfos { get; set; }
                public class DescribeVodDomainLogResponseBodyDomainLogDetailsDomainLogDetailLogInfos : TeaModel {
                    [NameInMap("LogInfoDetail")]
                    [Validation(Required=false)]
                    public List<DescribeVodDomainLogResponseBodyDomainLogDetailsDomainLogDetailLogInfosLogInfoDetail> LogInfoDetail { get; set; }
                    public class DescribeVodDomainLogResponseBodyDomainLogDetailsDomainLogDetailLogInfosLogInfoDetail : TeaModel {
                        [NameInMap("EndTime")]
                        [Validation(Required=false)]
                        public string EndTime { get; set; }

                        [NameInMap("StartTime")]
                        [Validation(Required=false)]
                        public string StartTime { get; set; }

                        [NameInMap("LogPath")]
                        [Validation(Required=false)]
                        public string LogPath { get; set; }

                        [NameInMap("LogSize")]
                        [Validation(Required=false)]
                        public long? LogSize { get; set; }

                        [NameInMap("LogName")]
                        [Validation(Required=false)]
                        public string LogName { get; set; }

                    }

                }
            }
        };

    }

}
