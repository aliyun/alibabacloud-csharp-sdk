// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class DescribeVodDomainLogResponseBody : TeaModel {
        /// <summary>
        /// The details of CDN logs.
        /// </summary>
        [NameInMap("DomainLogDetails")]
        [Validation(Required=false)]
        public DescribeVodDomainLogResponseBodyDomainLogDetails DomainLogDetails { get; set; }
        public class DescribeVodDomainLogResponseBodyDomainLogDetails : TeaModel {
            [NameInMap("DomainLogDetail")]
            [Validation(Required=false)]
            public List<DescribeVodDomainLogResponseBodyDomainLogDetailsDomainLogDetail> DomainLogDetail { get; set; }
            public class DescribeVodDomainLogResponseBodyDomainLogDetailsDomainLogDetail : TeaModel {
                /// <summary>
                /// The domain name.
                /// </summary>
                [NameInMap("DomainName")]
                [Validation(Required=false)]
                public string DomainName { get; set; }

                /// <summary>
                /// The total number of entries returned on the current page.
                /// </summary>
                [NameInMap("LogCount")]
                [Validation(Required=false)]
                public long? LogCount { get; set; }

                /// <summary>
                /// The queried CDN logs.
                /// </summary>
                [NameInMap("LogInfos")]
                [Validation(Required=false)]
                public DescribeVodDomainLogResponseBodyDomainLogDetailsDomainLogDetailLogInfos LogInfos { get; set; }
                public class DescribeVodDomainLogResponseBodyDomainLogDetailsDomainLogDetailLogInfos : TeaModel {
                    [NameInMap("LogInfoDetail")]
                    [Validation(Required=false)]
                    public List<DescribeVodDomainLogResponseBodyDomainLogDetailsDomainLogDetailLogInfosLogInfoDetail> LogInfoDetail { get; set; }
                    public class DescribeVodDomainLogResponseBodyDomainLogDetailsDomainLogDetailLogInfosLogInfoDetail : TeaModel {
                        /// <summary>
                        /// The end of the time range during which data was queried. The time follows the ISO 8601 standard in the `yyyy-MM-ddTHH:mm:ssZ` format. The time is displayed in UTC.
                        /// </summary>
                        [NameInMap("EndTime")]
                        [Validation(Required=false)]
                        public string EndTime { get; set; }

                        /// <summary>
                        /// The name of the log file.
                        /// </summary>
                        [NameInMap("LogName")]
                        [Validation(Required=false)]
                        public string LogName { get; set; }

                        /// <summary>
                        /// The path of the log file.
                        /// </summary>
                        [NameInMap("LogPath")]
                        [Validation(Required=false)]
                        public string LogPath { get; set; }

                        /// <summary>
                        /// The size of the log file.
                        /// </summary>
                        [NameInMap("LogSize")]
                        [Validation(Required=false)]
                        public long? LogSize { get; set; }

                        /// <summary>
                        /// The beginning of the time range during which data was queried. The time follows the ISO 8601 standard in the `yyyy-MM-ddTHH:mm:ssZ` format. The time is displayed in UTC.
                        /// </summary>
                        [NameInMap("StartTime")]
                        [Validation(Required=false)]
                        public string StartTime { get; set; }

                    }

                }

                /// <summary>
                /// The pagination information.
                /// </summary>
                [NameInMap("PageInfos")]
                [Validation(Required=false)]
                public DescribeVodDomainLogResponseBodyDomainLogDetailsDomainLogDetailPageInfos PageInfos { get; set; }
                public class DescribeVodDomainLogResponseBodyDomainLogDetailsDomainLogDetailPageInfos : TeaModel {
                    /// <summary>
                    /// The page number.
                    /// </summary>
                    [NameInMap("PageNumber")]
                    [Validation(Required=false)]
                    public long? PageNumber { get; set; }

                    /// <summary>
                    /// The number of entries per page.
                    /// </summary>
                    [NameInMap("PageSize")]
                    [Validation(Required=false)]
                    public long? PageSize { get; set; }

                    /// <summary>
                    /// The total number of entries returned.
                    /// </summary>
                    [NameInMap("Total")]
                    [Validation(Required=false)]
                    public long? Total { get; set; }

                }

            }

        }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
