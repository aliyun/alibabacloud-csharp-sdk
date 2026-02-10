// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class DescribeLiveStreamsControlHistoryResponseBody : TeaModel {
        [NameInMap("ControlInfo")]
        [Validation(Required=false)]
        public DescribeLiveStreamsControlHistoryResponseBodyControlInfo ControlInfo { get; set; }
        public class DescribeLiveStreamsControlHistoryResponseBodyControlInfo : TeaModel {
            [NameInMap("LiveStreamControlInfo")]
            [Validation(Required=false)]
            public List<DescribeLiveStreamsControlHistoryResponseBodyControlInfoLiveStreamControlInfo> LiveStreamControlInfo { get; set; }
            public class DescribeLiveStreamsControlHistoryResponseBodyControlInfoLiveStreamControlInfo : TeaModel {
                [NameInMap("Action")]
                [Validation(Required=false)]
                public string Action { get; set; }

                [NameInMap("ClientIP")]
                [Validation(Required=false)]
                public string ClientIP { get; set; }

                [NameInMap("StreamName")]
                [Validation(Required=false)]
                public string StreamName { get; set; }

                [NameInMap("TimeStamp")]
                [Validation(Required=false)]
                public string TimeStamp { get; set; }

            }

        }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>9C31856F-386D-4DB3-BE79-A0AA493D702A</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
