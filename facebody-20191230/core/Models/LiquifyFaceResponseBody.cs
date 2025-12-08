// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Facebody20191230.Models
{
    public class LiquifyFaceResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public LiquifyFaceResponseBodyData Data { get; set; }
        public class LiquifyFaceResponseBodyData : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para><a href="http://vibktprfx-prod-prod-aic-gd-cn-shanghai.oss-cn-shanghai.aliyuncs.com/face-liquify/CA1C8937-B30C-15E6-B804-41C357BA413B_5eca_20210923-093411.jpg?Expires=1632391451&OSSAccessKeyId=LTAI4FoLmvQ9urWXgSRp****&Signature=46apJQVNBz%2FFzDLEYn2M1w9MKA">http://vibktprfx-prod-prod-aic-gd-cn-shanghai.oss-cn-shanghai.aliyuncs.com/face-liquify/CA1C8937-B30C-15E6-B804-41C357BA413B_5eca_20210923-093411.jpg?Expires=1632391451&amp;OSSAccessKeyId=LTAI4FoLmvQ9urWXgSRp****&amp;Signature=46apJQVNBz%2FFzDLEYn2M1w9MKA</a>****</para>
            /// </summary>
            [NameInMap("ImageURL")]
            [Validation(Required=false)]
            public string ImageURL { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>CA1C8937-B30C-15E6-B804-41C357BA413B</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
