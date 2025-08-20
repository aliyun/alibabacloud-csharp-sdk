// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imageseg20191230.Models
{
    public class ChangeSkyResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public ChangeSkyResponseBodyData Data { get; set; }
        public class ChangeSkyResponseBodyData : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para><a href="http://viapi-cn-shanghai-dha-segmenter.oss-cn-shanghai.aliyuncs.com/upload/result_skySegmentator/2020-7-24/invi_skySegmentator_015955791588111000000_5pn2QM.jpg?Expires=1595580958&OSSAccessKeyId=LTAI4FoLmvQ9urWXgSRp****&Signature=Sq4po8h3WAj%2BBFrCgTP3ghlXn4">http://viapi-cn-shanghai-dha-segmenter.oss-cn-shanghai.aliyuncs.com/upload/result_skySegmentator/2020-7-24/invi_skySegmentator_015955791588111000000_5pn2QM.jpg?Expires=1595580958&amp;OSSAccessKeyId=LTAI4FoLmvQ9urWXgSRp****&amp;Signature=Sq4po8h3WAj%2BBFrCgTP3ghlXn4</a>****</para>
            /// </summary>
            [NameInMap("ImageURL")]
            [Validation(Required=false)]
            public string ImageURL { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>F9D60817-EC5A-4BAC-9092-4AD42220CFA8</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
