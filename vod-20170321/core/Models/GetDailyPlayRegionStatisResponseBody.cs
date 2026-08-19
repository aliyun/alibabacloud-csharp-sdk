// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class GetDailyPlayRegionStatisResponseBody : TeaModel {
        /// <summary>
        /// <para>The CSV file information returned.</para>
        /// </summary>
        [NameInMap("DailyPlayRegionStatisList")]
        [Validation(Required=false)]
        public List<GetDailyPlayRegionStatisResponseBodyDailyPlayRegionStatisList> DailyPlayRegionStatisList { get; set; }
        public class GetDailyPlayRegionStatisResponseBodyDailyPlayRegionStatisList : TeaModel {
            /// <summary>
            /// <para>The playback date, in days. Format: yyyy-MM-dd.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2025-03-20</para>
            /// </summary>
            [NameInMap("Date")]
            [Validation(Required=false)]
            public string Date { get; set; }

            /// <summary>
            /// <para>The download URL of the CSV file.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="https://outin-e70266d4ed*******0163e1403e7.oss-cn-shanghai.aliyuncs.com/dataexport/play/cn_hangzhou_20250320_video_traffic.csv">https://outin-e70266d4ed*******0163e1403e7.oss-cn-shanghai.aliyuncs.com/dataexport/play/cn_hangzhou_20250320_video_traffic.csv</a>?*******</para>
            /// </summary>
            [NameInMap("FileUrl")]
            [Validation(Required=false)]
            public string FileUrl { get; set; }

        }

        /// <summary>
        /// <para>If no playback data exists on a specific day, the date is displayed in this field.</para>
        /// </summary>
        [NameInMap("EmptyDates")]
        [Validation(Required=false)]
        public List<string> EmptyDates { get; set; }

        /// <summary>
        /// <para>If the playback data export fails on a specific day, the date is displayed in this field.</para>
        /// </summary>
        [NameInMap("FailDates")]
        [Validation(Required=false)]
        public List<string> FailDates { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>67720502-CDDB-3F1C-8A91-12258*******</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
