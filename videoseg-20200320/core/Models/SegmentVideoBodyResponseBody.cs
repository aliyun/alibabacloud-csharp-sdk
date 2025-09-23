// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Videoseg20200320.Models
{
    public class SegmentVideoBodyResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public SegmentVideoBodyResponseBodyData Data { get; set; }
        public class SegmentVideoBodyResponseBodyData : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para><a href="http://algo-app-aic-vd-cn-shanghai-prod.oss-cn-shanghai.aliyuncs.com/video-human-segmentation/D86DDFBC-B8ED-4780-9E6A-E5BA98D7CC9F.mp4?Expires=1584709406&OSSAccessKeyId=LTAI4FoLmvQ9urWXgSRp****&Signature=Fx5HVxvRjAMIjWL2OvhTlOO4cC">http://algo-app-aic-vd-cn-shanghai-prod.oss-cn-shanghai.aliyuncs.com/video-human-segmentation/D86DDFBC-B8ED-4780-9E6A-E5BA98D7CC9F.mp4?Expires=1584709406&amp;OSSAccessKeyId=LTAI4FoLmvQ9urWXgSRp****&amp;Signature=Fx5HVxvRjAMIjWL2OvhTlOO4cC</a>****</para>
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
        /// <para>49E2CC28-ED1D-4CC5-854D-7D0AE2B20976</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
