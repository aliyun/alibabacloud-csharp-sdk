// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Facebody20191230.Models
{
    public class RetouchSkinResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public RetouchSkinResponseBodyData Data { get; set; }
        public class RetouchSkinResponseBodyData : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para><a href="http://vibktprfx-prod-prod-aic-gd-cn-shanghai.oss-cn-shanghai.aliyuncs.com/skin-retouch/FD2BF3DF-3D98-1D5D-85BB-C8EC3A9FE347_3467_20210923-094238.jpg?Expires=1632391959&OSSAccessKeyId=LTAI4FoLmvQ9urWXgSRp****&Signature=jXJcFTv3no7Gx%2BLuPvANhRSnc2">http://vibktprfx-prod-prod-aic-gd-cn-shanghai.oss-cn-shanghai.aliyuncs.com/skin-retouch/FD2BF3DF-3D98-1D5D-85BB-C8EC3A9FE347_3467_20210923-094238.jpg?Expires=1632391959&amp;OSSAccessKeyId=LTAI4FoLmvQ9urWXgSRp****&amp;Signature=jXJcFTv3no7Gx%2BLuPvANhRSnc2</a>****</para>
            /// </summary>
            [NameInMap("ImageURL")]
            [Validation(Required=false)]
            public string ImageURL { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>FD2BF3DF-3D98-1D5D-85BB-C8EC3A9FE347</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
