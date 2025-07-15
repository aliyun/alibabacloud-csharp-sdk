// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class DescribeLiveStreamsControlHistoryResponseBody : TeaModel {
        /// <summary>
        /// <para>The operation records.</para>
        /// </summary>
        [NameInMap("ControlInfo")]
        [Validation(Required=false)]
        public DescribeLiveStreamsControlHistoryResponseBodyControlInfo ControlInfo { get; set; }
        public class DescribeLiveStreamsControlHistoryResponseBodyControlInfo : TeaModel {
            [NameInMap("LiveStreamControlInfo")]
            [Validation(Required=false)]
            public List<DescribeLiveStreamsControlHistoryResponseBodyControlInfoLiveStreamControlInfo> LiveStreamControlInfo { get; set; }
            public class DescribeLiveStreamsControlHistoryResponseBodyControlInfoLiveStreamControlInfo : TeaModel {
                /// <summary>
                /// <para>The name of the operation performed.</para>
                /// 
                /// <b>Example:</b>
                /// <para>DescribeLiveStreamsControlHistory</para>
                /// </summary>
                [NameInMap("Action")]
                [Validation(Required=false)]
                public string Action { get; set; }

                /// <summary>
                /// <para>The IP address that is used by the client for live streaming.</para>
                /// 
                /// <b>Example:</b>
                /// <para>10.207.XX.XX</para>
                /// </summary>
                [NameInMap("ClientIP")]
                [Validation(Required=false)]
                public string ClientIP { get; set; }

                /// <summary>
                /// <para>The name of the live stream.</para>
                /// 
                /// <b>Example:</b>
                /// <para>liveStream****</para>
                /// </summary>
                [NameInMap("StreamName")]
                [Validation(Required=false)]
                public string StreamName { get; set; }

                /// <summary>
                /// <para>The time when the operation was performed. The time follows the ISO 8601 standard in the <em>yyyy-MM-dd</em>T<em>HH:mm:ss</em>Z format. The time is displayed in UTC.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2015-12-01T16:36:18Z</para>
                /// </summary>
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
