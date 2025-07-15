// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class DescribeLiveDomainLogResponseBody : TeaModel {
        /// <summary>
        /// <para>The log information.</para>
        /// </summary>
        [NameInMap("DomainLogDetails")]
        [Validation(Required=false)]
        public DescribeLiveDomainLogResponseBodyDomainLogDetails DomainLogDetails { get; set; }
        public class DescribeLiveDomainLogResponseBodyDomainLogDetails : TeaModel {
            [NameInMap("DomainLogDetail")]
            [Validation(Required=false)]
            public List<DescribeLiveDomainLogResponseBodyDomainLogDetailsDomainLogDetail> DomainLogDetail { get; set; }
            public class DescribeLiveDomainLogResponseBodyDomainLogDetailsDomainLogDetail : TeaModel {
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
                public DescribeLiveDomainLogResponseBodyDomainLogDetailsDomainLogDetailLogInfos LogInfos { get; set; }
                public class DescribeLiveDomainLogResponseBodyDomainLogDetailsDomainLogDetailLogInfos : TeaModel {
                    [NameInMap("LogInfoDetail")]
                    [Validation(Required=false)]
                    public List<DescribeLiveDomainLogResponseBodyDomainLogDetailsDomainLogDetailLogInfosLogInfoDetail> LogInfoDetail { get; set; }
                    public class DescribeLiveDomainLogResponseBodyDomainLogDetailsDomainLogDetailLogInfosLogInfoDetail : TeaModel {
                        /// <summary>
                        /// <para>The end of the time range for which the logs were queried.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>2016-10-20T05:00:00Z</para>
                        /// </summary>
                        [NameInMap("EndTime")]
                        [Validation(Required=false)]
                        public string EndTime { get; set; }

                        /// <summary>
                        /// <para>The name of the log file.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>developer.aliyundoc.com_2016_10_20_040000_050000.gz</para>
                        /// </summary>
                        [NameInMap("LogName")]
                        [Validation(Required=false)]
                        public string LogName { get; set; }

                        /// <summary>
                        /// <para>The path of the log file.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>learn.aliyundoc.com/developer.aliyundoc.com/2016_10_20/example.aliyundoc.com_2016_10_20_040000_050000.gz?Expires=1522659931&amp;OSSAccessKeyId=LTAI******eo4ZEuA&amp;Signature=C01p%2BtA%******KP9Sru2Oxwy7Do0%3D</para>
                        /// </summary>
                        [NameInMap("LogPath")]
                        [Validation(Required=false)]
                        public string LogPath { get; set; }

                        /// <summary>
                        /// <para>The size of the log file.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>10</para>
                        /// </summary>
                        [NameInMap("LogSize")]
                        [Validation(Required=false)]
                        public long? LogSize { get; set; }

                        /// <summary>
                        /// <para>The beginning of the time range for which the logs were queried.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>2016-10-20T04:00:00Z</para>
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
                public DescribeLiveDomainLogResponseBodyDomainLogDetailsDomainLogDetailPageInfos PageInfos { get; set; }
                public class DescribeLiveDomainLogResponseBodyDomainLogDetailsDomainLogDetailPageInfos : TeaModel {
                    /// <summary>
                    /// <para>The page number of the returned page.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("PageIndex")]
                    [Validation(Required=false)]
                    public long? PageIndex { get; set; }

                    /// <summary>
                    /// <para>The number of entries returned per page.</para>
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
        /// <para>The streaming domain or ingest domain.</para>
        /// 
        /// <b>Example:</b>
        /// <para>example.com</para>
        /// </summary>
        [NameInMap("DomainName")]
        [Validation(Required=false)]
        public string DomainName { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>16A96B9A-F203-4EC5-8E43-CB92E68F4CD8</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
