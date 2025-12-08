// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Facebody20191230.Models
{
    public class FaceBeautyResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public FaceBeautyResponseBodyData Data { get; set; }
        public class FaceBeautyResponseBodyData : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para><a href="http://algo-app-taobao-mm-cn-shanghai-prod.oss-cn-shanghai.aliyuncs.com/pixelai-portrait-beauty/2020_03_24/2bbbdb7907901412_facebeauty.jpg?Expires=1585277923&OSSAccessKeyId=LTAI4FoLmvQ9urWXgSRp****&Signature=myOPfNQcRyijgrWBU%2BZ4dPuV5Q">http://algo-app-taobao-mm-cn-shanghai-prod.oss-cn-shanghai.aliyuncs.com/pixelai-portrait-beauty/2020_03_24/2bbbdb7907901412_facebeauty.jpg?Expires=1585277923&amp;OSSAccessKeyId=LTAI4FoLmvQ9urWXgSRp****&amp;Signature=myOPfNQcRyijgrWBU%2BZ4dPuV5Q</a>****</para>
            /// </summary>
            [NameInMap("ImageURL")]
            [Validation(Required=false)]
            public string ImageURL { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>35C284E1-C5F5-4E5E-B7AD-97BBF485CDC8</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
