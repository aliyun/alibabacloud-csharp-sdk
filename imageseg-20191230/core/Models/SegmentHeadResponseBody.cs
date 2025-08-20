// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imageseg20191230.Models
{
    public class SegmentHeadResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public SegmentHeadResponseBodyData Data { get; set; }
        public class SegmentHeadResponseBodyData : TeaModel {
            [NameInMap("Elements")]
            [Validation(Required=false)]
            public List<SegmentHeadResponseBodyDataElements> Elements { get; set; }
            public class SegmentHeadResponseBodyDataElements : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>180</para>
                /// </summary>
                [NameInMap("Height")]
                [Validation(Required=false)]
                public int? Height { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para><a href="http://viapi-cn-shanghai-dha-segmenter.oss-cn-shanghai.aliyuncs.com/upload/result_headsegmenter/2020-6-2/invi_headsegmenter_015910809094981099086_TAamhR.png?Expires=1591082709&OSSAccessKeyId=LTAI4FoLmvQ9urWXgSRp****&Signature=xuUE%2FbYeB9LpR18VXawOVeutQU">http://viapi-cn-shanghai-dha-segmenter.oss-cn-shanghai.aliyuncs.com/upload/result_headsegmenter/2020-6-2/invi_headsegmenter_015910809094981099086_TAamhR.png?Expires=1591082709&amp;OSSAccessKeyId=LTAI4FoLmvQ9urWXgSRp****&amp;Signature=xuUE%2FbYeB9LpR18VXawOVeutQU</a>****</para>
                /// </summary>
                [NameInMap("ImageURL")]
                [Validation(Required=false)]
                public string ImageURL { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>116</para>
                /// </summary>
                [NameInMap("Width")]
                [Validation(Required=false)]
                public int? Width { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>445</para>
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
        /// <para>89BBDA42-E1CA-426E-9A46-C703D8DBB1E2</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
