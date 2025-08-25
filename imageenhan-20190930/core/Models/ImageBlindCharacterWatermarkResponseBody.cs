// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imageenhan20190930.Models
{
    public class ImageBlindCharacterWatermarkResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public ImageBlindCharacterWatermarkResponseBodyData Data { get; set; }
        public class ImageBlindCharacterWatermarkResponseBodyData : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para><a href="http://algo-app-taobao-mm-cn-shanghai-prod.oss-cn-shanghai.aliyuncs.com/pixelai-portrait-beauty%2F2020_03_04%2F61f544a1a5004c88a2bf29452db494e9.jpeg?OSSAccessKeyId=LTAI4Fmdm1gQonFLrghJ****&Expires=158340****&Signature=Heet1ivG0xFP3YlO6usvd0pmrH">http://algo-app-taobao-mm-cn-shanghai-prod.oss-cn-shanghai.aliyuncs.com/pixelai-portrait-beauty%2F2020_03_04%2F61f544a1a5004c88a2bf29452db494e9.jpeg?OSSAccessKeyId=LTAI4Fmdm1gQonFLrghJ****&amp;Expires=158340****&amp;Signature=Heet1ivG0xFP3YlO6usvd0pmrH</a>****</para>
            /// </summary>
            [NameInMap("TextImageURL")]
            [Validation(Required=false)]
            public string TextImageURL { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para><a href="http://algo-app-taobao-mm-cn-shanghai-prod.oss-cn-shanghai.aliyuncs.com/pixelai-portrait-beauty%2F2020_03_04%2F61f544a1a5004c88a2bf29452db494e9.jpeg?OSSAccessKeyId=LTAI4Fmdm1gQonFLrghJ****&Expires=158340****&Signature=Heet1ivG0xFP3YlO6usvd0pmrH">http://algo-app-taobao-mm-cn-shanghai-prod.oss-cn-shanghai.aliyuncs.com/pixelai-portrait-beauty%2F2020_03_04%2F61f544a1a5004c88a2bf29452db494e9.jpeg?OSSAccessKeyId=LTAI4Fmdm1gQonFLrghJ****&amp;Expires=158340****&amp;Signature=Heet1ivG0xFP3YlO6usvd0pmrH</a>****</para>
            /// </summary>
            [NameInMap("WatermarkImageURL")]
            [Validation(Required=false)]
            public string WatermarkImageURL { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2457E1ED-9C76-4386-B9A2-7E41B7D6E849</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
