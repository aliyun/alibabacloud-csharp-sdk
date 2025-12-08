// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Facebody20191230.Models
{
    public class MergeImageFaceResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public MergeImageFaceResponseBodyData Data { get; set; }
        public class MergeImageFaceResponseBodyData : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para><a href="http://vibktprfx-prod-prod-aic-gd-cn-shanghai.oss-cn-shanghai.aliyuncs.com/image-face-fusion/09dedc78-c355-442a-9312-7ab074d6de49_54dc_20210129-025407.jpg?Expires=1611890647&OSSAccessKeyId=LTAI4FoLmvQ9urWXgSRp****&Signature=2mk2OgIrwMqrvA%2FvDdp0MNaoVU">http://vibktprfx-prod-prod-aic-gd-cn-shanghai.oss-cn-shanghai.aliyuncs.com/image-face-fusion/09dedc78-c355-442a-9312-7ab074d6de49_54dc_20210129-025407.jpg?Expires=1611890647&amp;OSSAccessKeyId=LTAI4FoLmvQ9urWXgSRp****&amp;Signature=2mk2OgIrwMqrvA%2FvDdp0MNaoVU</a>****</para>
            /// </summary>
            [NameInMap("ImageURL")]
            [Validation(Required=false)]
            public string ImageURL { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>8473A5E5-488E-4612-800E-F95B42381570</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
