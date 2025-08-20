// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imageseg20191230.Models
{
    public class RefineMaskResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public RefineMaskResponseBodyData Data { get; set; }
        public class RefineMaskResponseBodyData : TeaModel {
            [NameInMap("Elements")]
            [Validation(Required=false)]
            public List<RefineMaskResponseBodyDataElements> Elements { get; set; }
            public class RefineMaskResponseBodyDataElements : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para><a href="http://algo-app-taobao-mm-cn-shanghai-prod.oss-cn-shanghai.aliyuncs.com/pixelai-portrait-beauty%2F2020_03_04%2F61f544a1a5004c88a2bf29452db494e9.jpeg?OSSAccessKeyId=LTAI4Fmdm1gQonFLrghJ****&Expires=1583406122&Signature=Heet1ivG0xFP3YlO6usvd0pmrH">http://algo-app-taobao-mm-cn-shanghai-prod.oss-cn-shanghai.aliyuncs.com/pixelai-portrait-beauty%2F2020_03_04%2F61f544a1a5004c88a2bf29452db494e9.jpeg?OSSAccessKeyId=LTAI4Fmdm1gQonFLrghJ****&amp;Expires=1583406122&amp;Signature=Heet1ivG0xFP3YlO6usvd0pmrH</a>****</para>
                /// </summary>
                [NameInMap("ImageURL")]
                [Validation(Required=false)]
                public string ImageURL { get; set; }

            }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>E948F80B-86D9-54E0-9FF9-ACF3B1DA83C4</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
