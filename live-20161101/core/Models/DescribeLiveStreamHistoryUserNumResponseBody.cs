// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class DescribeLiveStreamHistoryUserNumResponseBody : TeaModel {
        /// <summary>
        /// <para>The number of historical online users for the live stream.</para>
        /// </summary>
        [NameInMap("LiveStreamUserNumInfos")]
        [Validation(Required=false)]
        public DescribeLiveStreamHistoryUserNumResponseBodyLiveStreamUserNumInfos LiveStreamUserNumInfos { get; set; }
        public class DescribeLiveStreamHistoryUserNumResponseBodyLiveStreamUserNumInfos : TeaModel {
            [NameInMap("LiveStreamUserNumInfo")]
            [Validation(Required=false)]
            public List<DescribeLiveStreamHistoryUserNumResponseBodyLiveStreamUserNumInfosLiveStreamUserNumInfo> LiveStreamUserNumInfo { get; set; }
            public class DescribeLiveStreamHistoryUserNumResponseBodyLiveStreamUserNumInfosLiveStreamUserNumInfo : TeaModel {
                /// <summary>
                /// <para>The time when the stream started. The time follows the ISO 8601 standard in the <em>yyyy-MM-dd</em>T<em>HH:mm:ss</em>Z format. The time is displayed in UTC.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2017-10-20T06:20:00Z</para>
                /// </summary>
                [NameInMap("StreamTime")]
                [Validation(Required=false)]
                public string StreamTime { get; set; }

                /// <summary>
                /// <para>The number of users at the current point in time.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("UserNum")]
                [Validation(Required=false)]
                public string UserNum { get; set; }

            }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>16A96B9A-F203-4EC5-8E43-CB92E68F5FF8</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
