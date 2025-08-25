// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imageenhan20190930.Models
{
    public class ColorizeImageResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public ColorizeImageResponseBodyData Data { get; set; }
        public class ColorizeImageResponseBodyData : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para><a href="http://algo-app-aic-vc-cn-shanghai-prod.oss-cn-shanghai.aliyuncs.com/face-enhancement/2020_11_26/20201126_182812286268_079260.jpg?Expires=1606388292&OSSAccessKeyId=LTAI4FoLmvQ9urWXgSRp****&Signature=f71Bx37g%2BGhM%2B6FOXM0EbNL8W4">http://algo-app-aic-vc-cn-shanghai-prod.oss-cn-shanghai.aliyuncs.com/face-enhancement/2020_11_26/20201126_182812286268_079260.jpg?Expires=1606388292&amp;OSSAccessKeyId=LTAI4FoLmvQ9urWXgSRp****&amp;Signature=f71Bx37g%2BGhM%2B6FOXM0EbNL8W4</a>****</para>
            /// </summary>
            [NameInMap("ImageURL")]
            [Validation(Required=false)]
            public string ImageURL { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>124A4B09-68EF-4178-B98D-319089D4268B</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
