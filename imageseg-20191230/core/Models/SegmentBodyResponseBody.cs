// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imageseg20191230.Models
{
    public class SegmentBodyResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public SegmentBodyResponseBodyData Data { get; set; }
        public class SegmentBodyResponseBodyData : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para><a href="http://viapi-cn-shanghai-dha-segmenter.oss-cn-shanghai.aliyuncs.com/upload/result_humansegmenter/2021-3-31/invi_humansegmenter_016171823500001081370_Ej0WwO.jpg?Expires=1617184150&OSSAccessKeyId=LTAI4FoLmvQ9urWXgSRp****&Signature=ZwaWXpAOMzHar%2B1wVO7zeSD83r">http://viapi-cn-shanghai-dha-segmenter.oss-cn-shanghai.aliyuncs.com/upload/result_humansegmenter/2021-3-31/invi_humansegmenter_016171823500001081370_Ej0WwO.jpg?Expires=1617184150&amp;OSSAccessKeyId=LTAI4FoLmvQ9urWXgSRp****&amp;Signature=ZwaWXpAOMzHar%2B1wVO7zeSD83r</a>****</para>
            /// </summary>
            [NameInMap("ImageURL")]
            [Validation(Required=false)]
            public string ImageURL { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>30EDCEEA-2806-44C6-AF0B-0988849106FE</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
