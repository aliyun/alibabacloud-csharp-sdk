// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imageseg20191230.Models
{
    public class SegmentHDCommonImageResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public SegmentHDCommonImageResponseBodyData Data { get; set; }
        public class SegmentHDCommonImageResponseBodyData : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para><a href="http://viapi-cn-shanghai-dha-segmenter.oss-cn-shanghai.aliyuncs.com/upload/result_commoditysegmenter/2020-10-27/invi_commoditysegmenter_016037842193171000000_5pn2QM.png?Expires=1603786019&OSSAccessKeyId=LTAI4FoLmvQ9urWXgSRp****&Signature=HwUztguGBYXmXGEmuTh%2FL3ztoh">http://viapi-cn-shanghai-dha-segmenter.oss-cn-shanghai.aliyuncs.com/upload/result_commoditysegmenter/2020-10-27/invi_commoditysegmenter_016037842193171000000_5pn2QM.png?Expires=1603786019&amp;OSSAccessKeyId=LTAI4FoLmvQ9urWXgSRp****&amp;Signature=HwUztguGBYXmXGEmuTh%2FL3ztoh</a>****</para>
            /// </summary>
            [NameInMap("ImageUrl")]
            [Validation(Required=false)]
            public string ImageUrl { get; set; }

        }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>EC994171-7964-44B3-85AF-A715CB56747D</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
