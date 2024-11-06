// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dcdn20180115.Models
{
    public class DescribeDcdnWafLogsResponseBody : TeaModel {
        /// <summary>
        /// <para>Details about logs returned.</para>
        /// </summary>
        [NameInMap("DomainLogDetails")]
        [Validation(Required=false)]
        public List<DescribeDcdnWafLogsResponseBodyDomainLogDetails> DomainLogDetails { get; set; }
        public class DescribeDcdnWafLogsResponseBodyDomainLogDetails : TeaModel {
            /// <summary>
            /// <para>The WAF domain name.</para>
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
            /// <para>10</para>
            /// </summary>
            [NameInMap("LogCount")]
            [Validation(Required=false)]
            public long? LogCount { get; set; }

            /// <summary>
            /// <para>The log information.</para>
            /// </summary>
            [NameInMap("LogInfos")]
            [Validation(Required=false)]
            public List<DescribeDcdnWafLogsResponseBodyDomainLogDetailsLogInfos> LogInfos { get; set; }
            public class DescribeDcdnWafLogsResponseBodyDomainLogDetailsLogInfos : TeaModel {
                /// <summary>
                /// <para>The end of the time range during which data was queried.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2015-05-23T14:00:00Z</para>
                /// </summary>
                [NameInMap("EndTime")]
                [Validation(Required=false)]
                public string EndTime { get; set; }

                /// <summary>
                /// <para>The name of the log file.</para>
                /// 
                /// <b>Example:</b>
                /// <para>demo.aliyundoc.com_2015_05_23_2100_2200.xxxxxx.gz</para>
                /// </summary>
                [NameInMap("LogName")]
                [Validation(Required=false)]
                public string LogName { get; set; }

                /// <summary>
                /// <para>The path of the log file.</para>
                /// 
                /// <b>Example:</b>
                /// <para>guide.aliyundoc.com-hangzhou.xxx</para>
                /// </summary>
                [NameInMap("LogPath")]
                [Validation(Required=false)]
                public string LogPath { get; set; }

                /// <summary>
                /// <para>The size of the log file. Unit: bytes.</para>
                /// 
                /// <b>Example:</b>
                /// <para>258</para>
                /// </summary>
                [NameInMap("LogSize")]
                [Validation(Required=false)]
                public long? LogSize { get; set; }

                /// <summary>
                /// <para>The beginning of the time range during which data was queried.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2015-05-23T13:00:00Z</para>
                /// </summary>
                [NameInMap("StartTime")]
                [Validation(Required=false)]
                public string StartTime { get; set; }

            }

            /// <summary>
            /// <para>The page information.</para>
            /// </summary>
            [NameInMap("PageInfos")]
            [Validation(Required=false)]
            public DescribeDcdnWafLogsResponseBodyDomainLogDetailsPageInfos PageInfos { get; set; }
            public class DescribeDcdnWafLogsResponseBodyDomainLogDetailsPageInfos : TeaModel {
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

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0985A362-C81E-5A56-891D-90226BEECA7C</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
