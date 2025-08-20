// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imageseg20191230.Models
{
    public class SegmentFoodResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public SegmentFoodResponseBodyData Data { get; set; }
        public class SegmentFoodResponseBodyData : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para><a href="http://viapi-cn-shanghai-dha-segmenter.oss-cn-shanghai.aliyuncs.com/upload/foodsegmenter-2020-06-17-15-24-00-8658fc85b8-8ds8k/2020-6-18/invi__015924442076191000002_WqJ99N.png?Expires=1592446007&OSSAccessKeyId=LTAI4FoLmvQ9urWXgSRp****&Signature=5ITSd6ndSuP7pUfoDFpgLPUOGg">http://viapi-cn-shanghai-dha-segmenter.oss-cn-shanghai.aliyuncs.com/upload/foodsegmenter-2020-06-17-15-24-00-8658fc85b8-8ds8k/2020-6-18/invi__015924442076191000002_WqJ99N.png?Expires=1592446007&amp;OSSAccessKeyId=LTAI4FoLmvQ9urWXgSRp****&amp;Signature=5ITSd6ndSuP7pUfoDFpgLPUOGg</a>****</para>
            /// </summary>
            [NameInMap("ImageURL")]
            [Validation(Required=false)]
            public string ImageURL { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>38265D08-AD0F-4752-8E96-D1D9FB96C3D9</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
