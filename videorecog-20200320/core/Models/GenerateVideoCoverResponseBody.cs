// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Videorecog20200320.Models
{
    public class GenerateVideoCoverResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GenerateVideoCoverResponseBodyData Data { get; set; }
        public class GenerateVideoCoverResponseBodyData : TeaModel {
            [NameInMap("Outputs")]
            [Validation(Required=false)]
            public List<GenerateVideoCoverResponseBodyDataOutputs> Outputs { get; set; }
            public class GenerateVideoCoverResponseBodyDataOutputs : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>6.1819260887924425</para>
                /// </summary>
                [NameInMap("Confidence")]
                [Validation(Required=false)]
                public float? Confidence { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para><a href="http://algo-app-aic-vd-cn-shanghai-prod.oss-cn-shanghai.aliyuncs.com/video-cover/2020-05-11-07/pic_lOyxGGAqQYSANGxP.mp4_202_544_960_c9f88b2a5f75e17c093d1a65f5edff4d_beautified.png?Expires=1589185385&OSSAccessKeyId=LTAI4FoLmvQ9urWXgSRp****&Signature=PAalKsfeZC4UQzYDTU%2F3D1G7Xt">http://algo-app-aic-vd-cn-shanghai-prod.oss-cn-shanghai.aliyuncs.com/video-cover/2020-05-11-07/pic_lOyxGGAqQYSANGxP.mp4_202_544_960_c9f88b2a5f75e17c093d1a65f5edff4d_beautified.png?Expires=1589185385&amp;OSSAccessKeyId=LTAI4FoLmvQ9urWXgSRp****&amp;Signature=PAalKsfeZC4UQzYDTU%2F3D1G7Xt</a>****</para>
                /// </summary>
                [NameInMap("ImageURL")]
                [Validation(Required=false)]
                public string ImageURL { get; set; }

            }

        }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>5B95B724-C5B9-4F77-A743-0CA4EA95CC82</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
