// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.DocumentParseService20260414.Models
{
    public class DocumentParseOnlineApiRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para><a href="https://maas-multimodal.oss-cn-hangzhou.aliyuncs.com/yuhui%2Ftmp%2Fsample500%2Ftmp%2F01e67f7c18d739a47f09d6c6b4a3d478_35.jpg?OSSAccessKeyId=LTAI5tGFE7dDsowkX8eWZMEe&Expires=1779229955&Signature=8sjYEYUHOsqCV11hC2MN%2Bs%2BguSI%3D">https://maas-multimodal.oss-cn-hangzhou.aliyuncs.com/yuhui%2Ftmp%2Fsample500%2Ftmp%2F01e67f7c18d739a47f09d6c6b4a3d478_35.jpg?OSSAccessKeyId=LTAI5tGFE7dDsowkX8eWZMEe&amp;Expires=1779229955&amp;Signature=8sjYEYUHOsqCV11hC2MN%2Bs%2BguSI%3D</a></para>
        /// </summary>
        [NameInMap("ImageUrl")]
        [Validation(Required=false)]
        public string ImageUrl { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public long? Type { get; set; }

    }

}
