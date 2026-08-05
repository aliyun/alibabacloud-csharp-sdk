// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class DescribeRtcMPUEventSubResponseBody : TeaModel {
        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para><b><b><b>3B-0E1A-586A-AC29-742247</b></b></b></para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The event callback information.</para>
        /// </summary>
        [NameInMap("SubInfo")]
        [Validation(Required=false)]
        public DescribeRtcMPUEventSubResponseBodySubInfo SubInfo { get; set; }
        public class DescribeRtcMPUEventSubResponseBodySubInfo : TeaModel {
            /// <summary>
            /// <para>The ID of the subscribed application.</para>
            /// 
            /// <b>Example:</b>
            /// <para>yourAppId</para>
            /// </summary>
            [NameInMap("AppId")]
            [Validation(Required=false)]
            public string AppId { get; set; }

            /// <summary>
            /// <para>The callback URL.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="http://testcallback***.com/callback">http://testcallback***.com/callback</a></para>
            /// </summary>
            [NameInMap("CallbackUrl")]
            [Validation(Required=false)]
            public string CallbackUrl { get; set; }

            /// <summary>
            /// <para>The channel IDs of stream mixing tasks that receive callbacks, separated by commas (,). If this field is empty, all channels receive callbacks.</para>
            /// 
            /// <b>Example:</b>
            /// <para>yourCh1,yourCh2</para>
            /// </summary>
            [NameInMap("ChannelIds")]
            [Validation(Required=false)]
            public string ChannelIds { get; set; }

            /// <summary>
            /// <para>The creation time of the event callback, in the format of yyyy-MM-ddTHH:mm:ssZ (UTC).</para>
            /// 
            /// <b>Example:</b>
            /// <para>2024-04-09 18:00:00Z</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <para>The event callback ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Sub-<b><b><b>9799B2C4500</b></b></b></para>
            /// </summary>
            [NameInMap("SubId")]
            [Validation(Required=false)]
            public string SubId { get; set; }

        }

    }

}
