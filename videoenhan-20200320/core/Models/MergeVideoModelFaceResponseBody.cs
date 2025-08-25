// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Videoenhan20200320.Models
{
    public class MergeVideoModelFaceResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public MergeVideoModelFaceResponseBodyData Data { get; set; }
        public class MergeVideoModelFaceResponseBodyData : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para><a href="http://vibktprfx-prod-prod-aic-gd-cn-shanghai.oss-cn-shanghai.aliyuncs.com/video-face-fusion/334F180F-3B50-51CB-B4CB-9A86A542D3BC-5716-20210906-074905.mp4?Expires=1630916420&OSSAccessKeyId=LTAI4FoLmvQ9urWXgSRp****&Signature=OEtNqVYxXRwkyO4BrsYVJ8q5bx">http://vibktprfx-prod-prod-aic-gd-cn-shanghai.oss-cn-shanghai.aliyuncs.com/video-face-fusion/334F180F-3B50-51CB-B4CB-9A86A542D3BC-5716-20210906-074905.mp4?Expires=1630916420&amp;OSSAccessKeyId=LTAI4FoLmvQ9urWXgSRp****&amp;Signature=OEtNqVYxXRwkyO4BrsYVJ8q5bx</a>****</para>
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
        /// <para>334F180F-3B50-51CB-B4CB-9A86A542D3BC</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
