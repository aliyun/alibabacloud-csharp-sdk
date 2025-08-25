// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Videoenhan20200320.Models
{
    public class EraseVideoLogoResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public EraseVideoLogoResponseBodyData Data { get; set; }
        public class EraseVideoLogoResponseBodyData : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para><a href="http://algo-app-aic-vd-cn-shanghai-prod.oss-cn-shanghai.aliyuncs.com/video-delogo/2020-03-20-11/53%3A56-DGNUGG7AcRlAylhr.mp4?Expires=1584707036&OSSAccessKeyId=LTAI4FoLmvQ9urWXgSRp****&Signature=7CvsX7X1rSU%2B%2FDxnw484lb3LCD">http://algo-app-aic-vd-cn-shanghai-prod.oss-cn-shanghai.aliyuncs.com/video-delogo/2020-03-20-11/53%3A56-DGNUGG7AcRlAylhr.mp4?Expires=1584707036&amp;OSSAccessKeyId=LTAI4FoLmvQ9urWXgSRp****&amp;Signature=7CvsX7X1rSU%2B%2FDxnw484lb3LCD</a>****</para>
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
        /// <para>95532F36-98FC-4DCD-815C-282BB26D2DA1</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
