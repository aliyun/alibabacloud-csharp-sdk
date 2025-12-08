// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Facebody20191230.Models
{
    public class BlurFaceResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public BlurFaceResponseBodyData Data { get; set; }
        public class BlurFaceResponseBodyData : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para><a href="http://viapi-cn-shanghai-dha-segmenter.oss-cn-shanghai.aliyuncs.com/upload/result_FaceBlur/2020-8-5/invi_FaceBlur_015966077063461060948_IBdDsq.jpg?Expires=1596609506&OSSAccessKeyId=LTAI4FoLmvQ9urWXgSRp****&Signature=x8n3jq1X91Sq7BKWE4vRHSu6g9">http://viapi-cn-shanghai-dha-segmenter.oss-cn-shanghai.aliyuncs.com/upload/result_FaceBlur/2020-8-5/invi_FaceBlur_015966077063461060948_IBdDsq.jpg?Expires=1596609506&amp;OSSAccessKeyId=LTAI4FoLmvQ9urWXgSRp****&amp;Signature=x8n3jq1X91Sq7BKWE4vRHSu6g9</a>****</para>
            /// </summary>
            [NameInMap("ImageURL")]
            [Validation(Required=false)]
            public string ImageURL { get; set; }

            [NameInMap("MaskURL")]
            [Validation(Required=false)]
            public string MaskURL { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>4C6080B0-64C4-488E-BBA6-245749CA11AD</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
