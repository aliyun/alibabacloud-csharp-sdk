// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imageenhan20190930.Models
{
    public class GenerateSuperResolutionImageResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GenerateSuperResolutionImageResponseBodyData Data { get; set; }
        public class GenerateSuperResolutionImageResponseBodyData : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para><a href="http://vibktprfx-prod-prod-damo-eas-cn-shanghai.oss-cn-shanghai.aliyuncs.com/diffusion-sr/2023-02-07/d01cede5-28bf-4719-96d9-77198d51c2f2/20230207_150650515242_3dbctnjy5f.jpg?Expires=1675755681&amp;OSSAccessKeyId=LTAI4FoLmvQ9urWXgSRp****&amp;Signature=4FeDXpp0DilXsHdt7qc%2Ffh3zoC">http://vibktprfx-prod-prod-damo-eas-cn-shanghai.oss-cn-shanghai.aliyuncs.com/diffusion-sr/2023-02-07/d01cede5-28bf-4719-96d9-77198d51c2f2/20230207_150650515242_3dbctnjy5f.jpg?Expires=1675755681&amp;OSSAccessKeyId=LTAI4FoLmvQ9urWXgSRp****&amp;Signature=4FeDXpp0DilXsHdt7qc%2Ffh3zoC</a>****</para>
            /// </summary>
            [NameInMap("ResultUrl")]
            [Validation(Required=false)]
            public string ResultUrl { get; set; }

        }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>4ad5c3ef-5ac4-4e1c-b14f-90d939aa73eb</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
