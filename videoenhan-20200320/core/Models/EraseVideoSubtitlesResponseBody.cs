// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Videoenhan20200320.Models
{
    public class EraseVideoSubtitlesResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public EraseVideoSubtitlesResponseBodyData Data { get; set; }
        public class EraseVideoSubtitlesResponseBodyData : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para><a href="http://algo-app-aic-vd-cn-shanghai-prod.oss-cn-shanghai.aliyuncs.com/video-desubtitle/2021-04-13-10/41%3A57-TcFd6Zug7gXwbeqs.mp4?Expires=1618312317&OSSAccessKeyId=LTAI4FoLmvQ9urWXgSRp****&Signature=LZnGSQ8019%2Br5rcR4vKOaaT2UE">http://algo-app-aic-vd-cn-shanghai-prod.oss-cn-shanghai.aliyuncs.com/video-desubtitle/2021-04-13-10/41%3A57-TcFd6Zug7gXwbeqs.mp4?Expires=1618312317&amp;OSSAccessKeyId=LTAI4FoLmvQ9urWXgSRp****&amp;Signature=LZnGSQ8019%2Br5rcR4vKOaaT2UE</a>****</para>
            /// </summary>
            [NameInMap("VideoUrl")]
            [Validation(Required=false)]
            public string VideoUrl { get; set; }

        }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>CCB082BF-A6B1-4C28-9E49-562EEE7DE639</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
