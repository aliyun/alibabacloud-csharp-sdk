// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Videoenhan20200320.Models
{
    public class SuperResolveVideoResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public SuperResolveVideoResponseBodyData Data { get; set; }
        public class SuperResolveVideoResponseBodyData : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para><a href="http://algo-app-aic-vd-cn-shanghai-prod.oss-cn-shanghai.aliyuncs.com/video-super-resolution/2020-03-20-12/12%3A11-UlLVELFzIy5EAyEh.mp4?Expires=1584708132&OSSAccessKeyId=LTAI4FoLmvQ9urWXgSRp****&Signature=0V8yKrCVybC4KIPtRuGKJDJaQT">http://algo-app-aic-vd-cn-shanghai-prod.oss-cn-shanghai.aliyuncs.com/video-super-resolution/2020-03-20-12/12%3A11-UlLVELFzIy5EAyEh.mp4?Expires=1584708132&amp;OSSAccessKeyId=LTAI4FoLmvQ9urWXgSRp****&amp;Signature=0V8yKrCVybC4KIPtRuGKJDJaQT</a>****</para>
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
        /// <para>186AC396-0EEC-46F1-AAA1-BF3585227427</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
