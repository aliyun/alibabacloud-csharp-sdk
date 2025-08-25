// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Videoenhan20200320.Models
{
    public class InterpolateVideoFrameResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public InterpolateVideoFrameResponseBodyData Data { get; set; }
        public class InterpolateVideoFrameResponseBodyData : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para><a href="http://vibktprfx-prod-prod-aic-vd-cn-shanghai.oss-cn-shanghai.aliyuncs.com/video-interp/20-12-22/mRsPNVunG7717nne_20-12-22-07-29-51.mp4?Expires=1608624020&OSSAccessKeyId=LTAI4FoLmvQ9urWXgSRp****&Signature=NFjSLll8E7E1tkuLPFyTpr6ULi">http://vibktprfx-prod-prod-aic-vd-cn-shanghai.oss-cn-shanghai.aliyuncs.com/video-interp/20-12-22/mRsPNVunG7717nne_20-12-22-07-29-51.mp4?Expires=1608624020&amp;OSSAccessKeyId=LTAI4FoLmvQ9urWXgSRp****&amp;Signature=NFjSLll8E7E1tkuLPFyTpr6ULi</a>****</para>
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
        /// <para>7EF85B5B-FB44-4C3E-9B8F-08C6CD912CEB</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
