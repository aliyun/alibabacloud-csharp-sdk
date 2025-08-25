// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Videoenhan20200320.Models
{
    public class ToneSdrVideoResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public ToneSdrVideoResponseBodyData Data { get; set; }
        public class ToneSdrVideoResponseBodyData : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para><a href="http://vibktprfx-prod-prod-aic-vd-cn-shanghai.oss-cn-shanghai.aliyuncs.com/sdr-color-enhance/20-12-22/SxBKgwBhlObusG20_20-12-22-07-59-45.mp4?Expires=1608625795&OSSAccessKeyId=LTAI4FoLmvQ9urWXgSRp****&Signature=maoOZ52y7U9ZuL2KqI0IfGq8%2FR">http://vibktprfx-prod-prod-aic-vd-cn-shanghai.oss-cn-shanghai.aliyuncs.com/sdr-color-enhance/20-12-22/SxBKgwBhlObusG20_20-12-22-07-59-45.mp4?Expires=1608625795&amp;OSSAccessKeyId=LTAI4FoLmvQ9urWXgSRp****&amp;Signature=maoOZ52y7U9ZuL2KqI0IfGq8%2FR</a>****</para>
            /// </summary>
            [NameInMap("VideoURL")]
            [Validation(Required=false)]
            public string VideoURL { get; set; }

        }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>89B5AFF1-8A64-4F76-B391-56AD7D22DE35</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
