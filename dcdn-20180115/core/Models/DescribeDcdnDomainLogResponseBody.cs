// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dcdn20180115.Models
{
    public class DescribeDcdnDomainLogResponseBody : TeaModel {
        /// <summary>
        /// <para>The log information. The log information is indicated by the DomainLogDetail parameter.</para>
        /// </summary>
        [NameInMap("DomainLogDetails")]
        [Validation(Required=false)]
        public DescribeDcdnDomainLogResponseBodyDomainLogDetails DomainLogDetails { get; set; }
        public class DescribeDcdnDomainLogResponseBodyDomainLogDetails : TeaModel {
            [NameInMap("DomainLogDetail")]
            [Validation(Required=false)]
            public List<DescribeDcdnDomainLogResponseBodyDomainLogDetailsDomainLogDetail> DomainLogDetail { get; set; }
            public class DescribeDcdnDomainLogResponseBodyDomainLogDetailsDomainLogDetail : TeaModel {
                /// <summary>
                /// <para>The total number of entries returned on the current page.</para>
                /// 
                /// <b>Example:</b>
                /// <para>4</para>
                /// </summary>
                [NameInMap("LogCount")]
                [Validation(Required=false)]
                public long? LogCount { get; set; }

                /// <summary>
                /// <para>The log information. The log information is indicated by the LogInfoDetail parameter.</para>
                /// </summary>
                [NameInMap("LogInfos")]
                [Validation(Required=false)]
                public DescribeDcdnDomainLogResponseBodyDomainLogDetailsDomainLogDetailLogInfos LogInfos { get; set; }
                public class DescribeDcdnDomainLogResponseBodyDomainLogDetailsDomainLogDetailLogInfos : TeaModel {
                    [NameInMap("LogInfoDetail")]
                    [Validation(Required=false)]
                    public List<DescribeDcdnDomainLogResponseBodyDomainLogDetailsDomainLogDetailLogInfosLogInfoDetail> LogInfoDetail { get; set; }
                    public class DescribeDcdnDomainLogResponseBodyDomainLogDetailsDomainLogDetailLogInfosLogInfoDetail : TeaModel {
                        /// <summary>
                        /// <para>The end of the time range during which data was queried.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>2021-11-07T18:00:00Z</para>
                        /// </summary>
                        [NameInMap("EndTime")]
                        [Validation(Required=false)]
                        public string EndTime { get; set; }

                        /// <summary>
                        /// <para>The name of the log file.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>example.com_2021_11_08_010000_020000.gz</para>
                        /// </summary>
                        [NameInMap("LogName")]
                        [Validation(Required=false)]
                        public string LogName { get; set; }

                        /// <summary>
                        /// <para>The path of the log file.</para>
                        /// <para>Take note of the Expires field (expiration timestamp) in the response parameter LogPath. If the log download URL expires, you must obtain it again. For more information, see <a href="https://help.aliyun.com/document_detail/31952.html">LogPath field</a>.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>example.aliyundoc.com /v1.l1cache/105252530/example.com/2021_11_08/example.com_2021_11_08_010000_020000.gz?Expires=1636963354&amp;OSSAccessKeyId=LTAIviCc6zy8****&amp;Signature=u0V6foRfZniHE8i%2BHUdxGOhZsK****</para>
                        /// </summary>
                        [NameInMap("LogPath")]
                        [Validation(Required=false)]
                        public string LogPath { get; set; }

                        /// <summary>
                        /// <para>The size of the log file. Unit: bytes.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>192</para>
                        /// </summary>
                        [NameInMap("LogSize")]
                        [Validation(Required=false)]
                        public long? LogSize { get; set; }

                        /// <summary>
                        /// <para>The start of the time range during which data was queried.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>2021-11-07T17:00:00Z</para>
                        /// </summary>
                        [NameInMap("StartTime")]
                        [Validation(Required=false)]
                        public string StartTime { get; set; }

                    }

                }

                /// <summary>
                /// <para>The page information. The page information is indicated by the PageInfoDetail parameter.</para>
                /// </summary>
                [NameInMap("PageInfos")]
                [Validation(Required=false)]
                public DescribeDcdnDomainLogResponseBodyDomainLogDetailsDomainLogDetailPageInfos PageInfos { get; set; }
                public class DescribeDcdnDomainLogResponseBodyDomainLogDetailsDomainLogDetailPageInfos : TeaModel {
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
                    /// <para>10</para>
                    /// </summary>
                    [NameInMap("PageSize")]
                    [Validation(Required=false)]
                    public long? PageSize { get; set; }

                    /// <summary>
                    /// <para>The total number of entries returned.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>4</para>
                    /// </summary>
                    [NameInMap("Total")]
                    [Validation(Required=false)]
                    public long? Total { get; set; }

                }

            }

        }

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
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>95594003-CAC5-5636-AF72-2A094364****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
