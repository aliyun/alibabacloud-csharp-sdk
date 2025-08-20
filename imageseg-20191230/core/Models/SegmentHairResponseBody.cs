// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imageseg20191230.Models
{
    public class SegmentHairResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public SegmentHairResponseBodyData Data { get; set; }
        public class SegmentHairResponseBodyData : TeaModel {
            [NameInMap("Elements")]
            [Validation(Required=false)]
            public List<SegmentHairResponseBodyDataElements> Elements { get; set; }
            public class SegmentHairResponseBodyDataElements : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>180</para>
                /// </summary>
                [NameInMap("Height")]
                [Validation(Required=false)]
                public int? Height { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para><a href="http://viapi-cn-shanghai-dha-segmenter.oss-cn-shanghai.aliyuncs.com/upload/result_HeadSegmenter/2021-12-31/invi_HeadSegmenter_016409228383064285967296_iPLUXA.png?Expires=1640924638&OSSAccessKeyId=LTAI4FoLmvQ9urWXgSRp****&Signature=wpKOqSar1bYvGmlTMryfEH2Q9I">http://viapi-cn-shanghai-dha-segmenter.oss-cn-shanghai.aliyuncs.com/upload/result_HeadSegmenter/2021-12-31/invi_HeadSegmenter_016409228383064285967296_iPLUXA.png?Expires=1640924638&amp;OSSAccessKeyId=LTAI4FoLmvQ9urWXgSRp****&amp;Signature=wpKOqSar1bYvGmlTMryfEH2Q9I</a>****</para>
                /// </summary>
                [NameInMap("ImageURL")]
                [Validation(Required=false)]
                public string ImageURL { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>113</para>
                /// </summary>
                [NameInMap("Width")]
                [Validation(Required=false)]
                public int? Width { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>446</para>
                /// </summary>
                [NameInMap("X")]
                [Validation(Required=false)]
                public int? X { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>102</para>
                /// </summary>
                [NameInMap("Y")]
                [Validation(Required=false)]
                public int? Y { get; set; }

            }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>D6C24839-91A7-41DA-B31F-98F08EF80CC0</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
