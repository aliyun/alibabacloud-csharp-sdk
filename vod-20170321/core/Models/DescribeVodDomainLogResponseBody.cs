// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class DescribeVodDomainLogResponseBody : TeaModel {
        /// <summary>
        /// <para>The details of CDN logs.</para>
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
                /// <para>The domain name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>example.com</para>
                /// </summary>
                [NameInMap("DomainName")]
                [Validation(Required=false)]
                public string DomainName { get; set; }

                /// <summary>
                /// <para>The total number of entries returned on the current page.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2</para>
                /// </summary>
                [NameInMap("LogCount")]
                [Validation(Required=false)]
                public long? LogCount { get; set; }

                /// <summary>
                /// <para>The queried CDN logs.</para>
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
                        /// <para>The end of the time range during which data was queried. The time follows the ISO 8601 standard in the <c>yyyy-MM-ddTHH:mm:ssZ</c> format. The time is displayed in UTC.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>2018-05-31T05:00:00Z</para>
                        /// </summary>
                        [NameInMap("EndTime")]
                        [Validation(Required=false)]
                        public string EndTime { get; set; }

                        /// <summary>
                        /// <para>The name of the log file.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>example.com_2018_03_25_180000_19****.gz</para>
                        /// </summary>
                        [NameInMap("LogName")]
                        [Validation(Required=false)]
                        public string LogName { get; set; }

                        /// <summary>
                        /// <para>The path of the log file.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>example.com/2018_03_25/example.com_2018_03_25_180000_19****.gz?Expires=1522659931&amp;OSSAccessKeyId=<b><b>&amp;Signature=</b></b></para>
                        /// </summary>
                        [NameInMap("LogPath")]
                        [Validation(Required=false)]
                        public string LogPath { get; set; }

                        /// <summary>
                        /// <para>The size of the log file.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>2645401</para>
                        /// </summary>
                        [NameInMap("LogSize")]
                        [Validation(Required=false)]
                        public long? LogSize { get; set; }

                        /// <summary>
                        /// <para>The beginning of the time range during which data was queried. The time follows the ISO 8601 standard in the <c>yyyy-MM-ddTHH:mm:ssZ</c> format. The time is displayed in UTC.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>2018-05-31T04:00:00Z</para>
                        /// </summary>
                        [NameInMap("StartTime")]
                        [Validation(Required=false)]
                        public string StartTime { get; set; }

                    }

                }

                /// <summary>
                /// <para>The pagination information.</para>
                /// </summary>
                [NameInMap("PageInfos")]
                [Validation(Required=false)]
                public DescribeVodDomainLogResponseBodyDomainLogDetailsDomainLogDetailPageInfos PageInfos { get; set; }
                public class DescribeVodDomainLogResponseBodyDomainLogDetailsDomainLogDetailPageInfos : TeaModel {
                    /// <summary>
                    /// <para>The page number.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("PageNumber")]
                    [Validation(Required=false)]
                    public long? PageNumber { get; set; }

                    /// <summary>
                    /// <para>The number of entries per page.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>300</para>
                    /// </summary>
                    [NameInMap("PageSize")]
                    [Validation(Required=false)]
                    public long? PageSize { get; set; }

                    /// <summary>
                    /// <para>The total number of entries returned.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>2</para>
                    /// </summary>
                    [NameInMap("Total")]
                    [Validation(Required=false)]
                    public long? Total { get; set; }

                }

            }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>077D0284-F041-4A41-4D3C-B48377FD****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
