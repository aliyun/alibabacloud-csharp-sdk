// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imageenhan20190930.Models
{
    public class RemoveImageWatermarkResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public RemoveImageWatermarkResponseBodyData Data { get; set; }
        public class RemoveImageWatermarkResponseBodyData : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para><a href="http://algo-app-aic-vd-cn-shanghai-prod.oss-cn-shanghai.aliyuncs.com/image-delogo/2020-03-27-03/00%3A06-5a6f0a0f-c940-4955-af75-79e8267f1699.jpg?Expires=1585279806&OSSAccessKeyId=LTAI4FoLmvQ9urWXgSRp****&Signature=R4OC2R5%2Fkw08XYFXmCWjgk7Y9N">http://algo-app-aic-vd-cn-shanghai-prod.oss-cn-shanghai.aliyuncs.com/image-delogo/2020-03-27-03/00%3A06-5a6f0a0f-c940-4955-af75-79e8267f1699.jpg?Expires=1585279806&amp;OSSAccessKeyId=LTAI4FoLmvQ9urWXgSRp****&amp;Signature=R4OC2R5%2Fkw08XYFXmCWjgk7Y9N</a>****</para>
            /// </summary>
            [NameInMap("ImageURL")]
            [Validation(Required=false)]
            public string ImageURL { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>885070A7-E721-4062-99A0-80C0EBBF9406</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
