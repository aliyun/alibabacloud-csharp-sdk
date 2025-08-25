// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Videoenhan20200320.Models
{
    public class ConvertHdrVideoResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public ConvertHdrVideoResponseBodyData Data { get; set; }
        public class ConvertHdrVideoResponseBodyData : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para><a href="http://vibktprfx-prod-prod-aic-vd-cn-shanghai.oss-cn-shanghai.aliyuncs.com/hdr-enhance/20-12-22/HaKDdTI48i2GQGy7_20-12-22-06-42-45.mp4?Expires=1608621178&OSSAccessKeyId=LTAI4FoLmvQ9urWXgSRp****&Signature=SWc90T0JHg5eWc64x8GmYHKsvX">http://vibktprfx-prod-prod-aic-vd-cn-shanghai.oss-cn-shanghai.aliyuncs.com/hdr-enhance/20-12-22/HaKDdTI48i2GQGy7_20-12-22-06-42-45.mp4?Expires=1608621178&amp;OSSAccessKeyId=LTAI4FoLmvQ9urWXgSRp****&amp;Signature=SWc90T0JHg5eWc64x8GmYHKsvX</a>****</para>
            /// </summary>
            [NameInMap("VideoURL")]
            [Validation(Required=false)]
            public string VideoURL { get; set; }

        }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>E0CF495F-E806-4B9C-B204-E1230608239D</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
