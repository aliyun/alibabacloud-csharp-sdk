// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imageseg20191230.Models
{
    public class SegmentCommodityResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public SegmentCommodityResponseBodyData Data { get; set; }
        public class SegmentCommodityResponseBodyData : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para><a href="http://luban-vgd-invi.oss-cn-hangzhou.aliyuncs.com/upload/result_segmenter/2019-12-20/invi_segmenter_015768355410261076021_Z3t0fc.png?Expires=1577094741&OSSAccessKeyId=LTAI4Fc5SVvzUQ19K1Cz****&Signature=pkaKK3VlfsTR2r%2BYycJzTVEEos">http://luban-vgd-invi.oss-cn-hangzhou.aliyuncs.com/upload/result_segmenter/2019-12-20/invi_segmenter_015768355410261076021_Z3t0fc.png?Expires=1577094741&amp;OSSAccessKeyId=LTAI4Fc5SVvzUQ19K1Cz****&amp;Signature=pkaKK3VlfsTR2r%2BYycJzTVEEos</a>****</para>
            /// </summary>
            [NameInMap("ImageURL")]
            [Validation(Required=false)]
            public string ImageURL { get; set; }

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
