// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class DescribeLivePushProxyLogResponseBody : TeaModel {
        /// <summary>
        /// <para>The log information.</para>
        /// </summary>
        [NameInMap("DomainLogDetails")]
        [Validation(Required=false)]
        public DescribeLivePushProxyLogResponseBodyDomainLogDetails DomainLogDetails { get; set; }
        public class DescribeLivePushProxyLogResponseBodyDomainLogDetails : TeaModel {
            [NameInMap("DomainLogDetail")]
            [Validation(Required=false)]
            public List<DescribeLivePushProxyLogResponseBodyDomainLogDetailsDomainLogDetail> DomainLogDetail { get; set; }
            public class DescribeLivePushProxyLogResponseBodyDomainLogDetailsDomainLogDetail : TeaModel {
                /// <summary>
                /// <para>The total number of entries returned on the current page.</para>
                /// 
                /// <b>Example:</b>
                /// <para>10</para>
                /// </summary>
                [NameInMap("LogCount")]
                [Validation(Required=false)]
                public long? LogCount { get; set; }

                /// <summary>
                /// <para>Details about the logs.</para>
                /// </summary>
                [NameInMap("LogInfos")]
                [Validation(Required=false)]
                public DescribeLivePushProxyLogResponseBodyDomainLogDetailsDomainLogDetailLogInfos LogInfos { get; set; }
                public class DescribeLivePushProxyLogResponseBodyDomainLogDetailsDomainLogDetailLogInfos : TeaModel {
                    [NameInMap("LogInfoDetail")]
                    [Validation(Required=false)]
                    public List<DescribeLivePushProxyLogResponseBodyDomainLogDetailsDomainLogDetailLogInfosLogInfoDetail> LogInfoDetail { get; set; }
                    public class DescribeLivePushProxyLogResponseBodyDomainLogDetailsDomainLogDetailLogInfosLogInfoDetail : TeaModel {
                        /// <summary>
                        /// <para>The end of the time range during which data was queried.</para>
                        /// <para>The value is a UNIX timestamp.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>1695189600</para>
                        /// </summary>
                        [NameInMap("EndTime")]
                        [Validation(Required=false)]
                        public string EndTime { get; set; }

                        /// <summary>
                        /// <para>The name of the log file.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>example.com
                        /// _2023_09_20_160000_170000.****.gz</para>
                        /// </summary>
                        [NameInMap("LogName")]
                        [Validation(Required=false)]
                        public string LogName { get; set; }

                        /// <summary>
                        /// <para>The path of the log file.</para>
                        /// </summary>
                        [NameInMap("LogPath")]
                        [Validation(Required=false)]
                        public string LogPath { get; set; }

                        /// <summary>
                        /// <para>The size of the log file.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>512</para>
                        /// </summary>
                        [NameInMap("LogSize")]
                        [Validation(Required=false)]
                        public long? LogSize { get; set; }

                        /// <summary>
                        /// <para>The beginning of the time range during which data was queried.</para>
                        /// <para>The value is a UNIX timestamp.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>1695193200</para>
                        /// </summary>
                        [NameInMap("StartTime")]
                        [Validation(Required=false)]
                        public string StartTime { get; set; }

                    }

                }

                /// <summary>
                /// <para>The page information.</para>
                /// </summary>
                [NameInMap("PageInfos")]
                [Validation(Required=false)]
                public DescribeLivePushProxyLogResponseBodyDomainLogDetailsDomainLogDetailPageInfos PageInfos { get; set; }
                public class DescribeLivePushProxyLogResponseBodyDomainLogDetailsDomainLogDetailPageInfos : TeaModel {
                    /// <summary>
                    /// <para>The page number.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("PageIndex")]
                    [Validation(Required=false)]
                    public long? PageIndex { get; set; }

                    /// <summary>
                    /// <para>The number of entries per page.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>20</para>
                    /// </summary>
                    [NameInMap("PageSize")]
                    [Validation(Required=false)]
                    public long? PageSize { get; set; }

                    /// <summary>
                    /// <para>The total number of entries returned.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>20</para>
                    /// </summary>
                    [NameInMap("Total")]
                    [Validation(Required=false)]
                    public long? Total { get; set; }

                }

            }

        }

        /// <summary>
        /// <para>Push domain.</para>
        /// 
        /// <b>Example:</b>
        /// <para>example.com</para>
        /// </summary>
        [NameInMap("DomainName")]
        [Validation(Required=false)]
        public string DomainName { get; set; }

        /// <summary>
        /// <para>Request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>CF60DB6A-7FD6-426E-9288-122CC1A52FA7</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
