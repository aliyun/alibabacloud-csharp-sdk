// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imageenhan20190930.Models
{
    public class GenerateCartoonizedImageResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GenerateCartoonizedImageResponseBodyData Data { get; set; }
        public class GenerateCartoonizedImageResponseBodyData : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para><a href="http://vibktprfx-prod-prod-damo-eas-cn-shanghai.oss-cn-shanghai.aliyuncs.com/generative-cartoon/2023-02-02/5a3e5760-ff27-4321-8976-d05656fb716a/20230202_154009511910_pclb0gomva.jpg?Expires=1675325422&amp;OSSAccessKeyId=LTAI4FoLmvQ9urWXgSRp****&amp;Signature=UmAa7HxeumVkDfrdoL02dtztwS">http://vibktprfx-prod-prod-damo-eas-cn-shanghai.oss-cn-shanghai.aliyuncs.com/generative-cartoon/2023-02-02/5a3e5760-ff27-4321-8976-d05656fb716a/20230202_154009511910_pclb0gomva.jpg?Expires=1675325422&amp;OSSAccessKeyId=LTAI4FoLmvQ9urWXgSRp****&amp;Signature=UmAa7HxeumVkDfrdoL02dtztwS</a>****</para>
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
        /// <para>48f38719-f0c2-4784-a9cc-30df95e393a9</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
