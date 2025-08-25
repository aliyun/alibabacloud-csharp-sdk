// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imageenhan20190930.Models
{
    public class GenerateDynamicImageResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GenerateDynamicImageResponseBodyData Data { get; set; }
        public class GenerateDynamicImageResponseBodyData : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para><a href="http://vibktprfx-prod-prod-aic-gd-cn-shanghai.oss-cn-shanghai.aliyuncs.com/photo-style-imitation/dynamicPhotoResult/dySkyHair_0d0465eb-b1c9-472a-a7dc-cdff1333f794.avi?Expires=1601196370&OSSAccessKeyId=LTAI4FoLmvQ9urWXgSRp****&Signature=QejSaTZOR2MB2lVHOUH%2Fj8l3P4">http://vibktprfx-prod-prod-aic-gd-cn-shanghai.oss-cn-shanghai.aliyuncs.com/photo-style-imitation/dynamicPhotoResult/dySkyHair_0d0465eb-b1c9-472a-a7dc-cdff1333f794.avi?Expires=1601196370&amp;OSSAccessKeyId=LTAI4FoLmvQ9urWXgSRp****&amp;Signature=QejSaTZOR2MB2lVHOUH%2Fj8l3P4</a>****</para>
            /// </summary>
            [NameInMap("Url")]
            [Validation(Required=false)]
            public string Url { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>3C047FB7-AE01-42CF-948F-D57F224620ED</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
