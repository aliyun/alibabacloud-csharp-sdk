// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imageseg20191230.Models
{
    public class SegmentClothResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public SegmentClothResponseBodyData Data { get; set; }
        public class SegmentClothResponseBodyData : TeaModel {
            [NameInMap("Elements")]
            [Validation(Required=false)]
            public List<SegmentClothResponseBodyDataElements> Elements { get; set; }
            public class SegmentClothResponseBodyDataElements : TeaModel {
                [NameInMap("ClassUrl")]
                [Validation(Required=false)]
                public Dictionary<string, string> ClassUrl { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para><a href="http://viapi-cn-shanghai-dha-segmenter.oss-cn-shanghai.aliyuncs.com/upload/clothingsegmentation-2020-06-17-16-54-40-688c84cbbd-hnqfq/2020-6-18/invi__015924459307821000041_IIVHoM.png?Expires=1592447730&OSSAccessKeyId=LTAI4FoLmvQ9urWXgSRp****&Signature=Hy8pn3IQj8nuKN0LEaC57cee9L">http://viapi-cn-shanghai-dha-segmenter.oss-cn-shanghai.aliyuncs.com/upload/clothingsegmentation-2020-06-17-16-54-40-688c84cbbd-hnqfq/2020-6-18/invi__015924459307821000041_IIVHoM.png?Expires=1592447730&amp;OSSAccessKeyId=LTAI4FoLmvQ9urWXgSRp****&amp;Signature=Hy8pn3IQj8nuKN0LEaC57cee9L</a>****</para>
                /// </summary>
                [NameInMap("ImageURL")]
                [Validation(Required=false)]
                public string ImageURL { get; set; }

            }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>BCE049A3-FE69-41CF-A870-5970156388A7</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
