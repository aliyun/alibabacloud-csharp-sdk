// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ESA20240910.Models
{
    public class DescribeSiteLogsResponseBody : TeaModel {
        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>0AEDAF20-4DDF-4165-8750-47FF9C1929C9</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("SiteLogDetails")]
        [Validation(Required=false)]
        public List<DescribeSiteLogsResponseBodySiteLogDetails> SiteLogDetails { get; set; }
        public class DescribeSiteLogsResponseBodySiteLogDetails : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>300</para>
            /// </summary>
            [NameInMap("LogCount")]
            [Validation(Required=false)]
            public int? LogCount { get; set; }

            [NameInMap("LogInfos")]
            [Validation(Required=false)]
            public List<DescribeSiteLogsResponseBodySiteLogDetailsLogInfos> LogInfos { get; set; }
            public class DescribeSiteLogsResponseBodySiteLogDetailsLogInfos : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>2022-11-06T17:00:00Z</para>
                /// </summary>
                [NameInMap("EndTime")]
                [Validation(Required=false)]
                public string EndTime { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>example.com_2022_11_07_000000_020000.gz.xxxxxx</para>
                /// </summary>
                [NameInMap("LogName")]
                [Validation(Required=false)]
                public string LogName { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>example.aliyundoc.com /v1.l1cache/105252530/example.com/2022_11_07/example.com_2022_11_07_000000_020000.gz.xxxxxx?Expires=1636963354&amp;OSSAccessKeyId=LTAIviCc6zy8****&amp;Signature=u0V6foRfZniHE8i%2BHUdxGOhZsK****</para>
                /// </summary>
                [NameInMap("LogPath")]
                [Validation(Required=false)]
                public string LogPath { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>438304768</para>
                /// </summary>
                [NameInMap("LogSize")]
                [Validation(Required=false)]
                public int? LogSize { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2022-11-06T16:00:00Z</para>
                /// </summary>
                [NameInMap("StartTime")]
                [Validation(Required=false)]
                public string StartTime { get; set; }

            }

            [NameInMap("PageInfos")]
            [Validation(Required=false)]
            public DescribeSiteLogsResponseBodySiteLogDetailsPageInfos PageInfos { get; set; }
            public class DescribeSiteLogsResponseBodySiteLogDetailsPageInfos : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("PageIndex")]
                [Validation(Required=false)]
                public int? PageIndex { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>10</para>
                /// </summary>
                [NameInMap("PageSize")]
                [Validation(Required=false)]
                public int? PageSize { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>47</para>
                /// </summary>
                [NameInMap("TotalCount")]
                [Validation(Required=false)]
                public int? TotalCount { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>123456***</para>
            /// </summary>
            [NameInMap("SiteId")]
            [Validation(Required=false)]
            public long? SiteId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>example.com</para>
            /// </summary>
            [NameInMap("SiteName")]
            [Validation(Required=false)]
            public string SiteName { get; set; }

        }

    }

}
