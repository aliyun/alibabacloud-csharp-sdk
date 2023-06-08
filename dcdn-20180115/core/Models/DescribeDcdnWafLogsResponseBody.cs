// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dcdn20180115.Models
{
    public class DescribeDcdnWafLogsResponseBody : TeaModel {
        /// <summary>
        /// Details about logs returned.
        /// </summary>
        [NameInMap("DomainLogDetails")]
        [Validation(Required=false)]
        public List<DescribeDcdnWafLogsResponseBodyDomainLogDetails> DomainLogDetails { get; set; }
        public class DescribeDcdnWafLogsResponseBodyDomainLogDetails : TeaModel {
            /// <summary>
            /// The WAF domain name.
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
            /// The log information.
            /// </summary>
            [NameInMap("LogInfos")]
            [Validation(Required=false)]
            public List<DescribeDcdnWafLogsResponseBodyDomainLogDetailsLogInfos> LogInfos { get; set; }
            public class DescribeDcdnWafLogsResponseBodyDomainLogDetailsLogInfos : TeaModel {
                /// <summary>
                /// The end of the time range during which data was queried.
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
                /// The size of the log file. Unit: bytes.
                /// </summary>
                [NameInMap("LogSize")]
                [Validation(Required=false)]
                public long? LogSize { get; set; }

                /// <summary>
                /// The beginning of the time range during which data was queried.
                /// </summary>
                [NameInMap("StartTime")]
                [Validation(Required=false)]
                public string StartTime { get; set; }

            }

            /// <summary>
            /// The page information.
            /// </summary>
            [NameInMap("PageInfos")]
            [Validation(Required=false)]
            public DescribeDcdnWafLogsResponseBodyDomainLogDetailsPageInfos PageInfos { get; set; }
            public class DescribeDcdnWafLogsResponseBodyDomainLogDetailsPageInfos : TeaModel {
                /// <summary>
                /// The page number of the returned page.
                /// </summary>
                [NameInMap("PageIndex")]
                [Validation(Required=false)]
                public long? PageIndex { get; set; }

                /// <summary>
                /// The number of entries returned per page.
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

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
