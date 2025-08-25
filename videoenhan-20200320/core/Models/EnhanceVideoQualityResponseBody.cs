// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Videoenhan20200320.Models
{
    public class EnhanceVideoQualityResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public EnhanceVideoQualityResponseBodyData Data { get; set; }
        public class EnhanceVideoQualityResponseBodyData : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para><a href="http://vibktprfx-prod-prod-aic-vd-cn-shanghai.oss-cn-shanghai.aliyuncs.com/uhd-enhance/20-11-20/Wwzf9z75GO5XdisS_20-11-20-07-13-48.mp4?Expires=1605858272&OSSAccessKeyId=LTAI4FoLmvQ9urWXgSRp****&Signature=vvY0D%2Bl5eEzp%2BD7mPOWz0zMU7v">http://vibktprfx-prod-prod-aic-vd-cn-shanghai.oss-cn-shanghai.aliyuncs.com/uhd-enhance/20-11-20/Wwzf9z75GO5XdisS_20-11-20-07-13-48.mp4?Expires=1605858272&amp;OSSAccessKeyId=LTAI4FoLmvQ9urWXgSRp****&amp;Signature=vvY0D%2Bl5eEzp%2BD7mPOWz0zMU7v</a>****</para>
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
        /// <para>881F39DC-C107-4817-A6D5-000BE833CC2A</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
