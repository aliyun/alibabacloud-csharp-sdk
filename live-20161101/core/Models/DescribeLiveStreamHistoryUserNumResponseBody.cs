// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class DescribeLiveStreamHistoryUserNumResponseBody : TeaModel {
        [NameInMap("LiveStreamUserNumInfos")]
        [Validation(Required=false)]
        public DescribeLiveStreamHistoryUserNumResponseBodyLiveStreamUserNumInfos LiveStreamUserNumInfos { get; set; }
        public class DescribeLiveStreamHistoryUserNumResponseBodyLiveStreamUserNumInfos : TeaModel {
            [NameInMap("LiveStreamUserNumInfo")]
            [Validation(Required=false)]
            public List<DescribeLiveStreamHistoryUserNumResponseBodyLiveStreamUserNumInfosLiveStreamUserNumInfo> LiveStreamUserNumInfo { get; set; }
            public class DescribeLiveStreamHistoryUserNumResponseBodyLiveStreamUserNumInfosLiveStreamUserNumInfo : TeaModel {
                [NameInMap("StreamTime")]
                [Validation(Required=false)]
                public string StreamTime { get; set; }

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
