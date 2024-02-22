/**
 *
 */
// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudauth20190307.Models
{
    public class AIGCFaceVerifyRequest : TeaModel {
        [NameInMap("FaceContrastPicture")]
        [Validation(Required=false)]
        public string FaceContrastPicture { get; set; }

        [NameInMap("FaceContrastPictureUrl")]
        [Validation(Required=false)]
        public string FaceContrastPictureUrl { get; set; }

        [NameInMap("OssBucketName")]
        [Validation(Required=false)]
        public string OssBucketName { get; set; }

        [NameInMap("OssObjectName")]
        [Validation(Required=false)]
        public string OssObjectName { get; set; }

        [NameInMap("OuterOrderNo")]
        [Validation(Required=false)]
        public string OuterOrderNo { get; set; }

        [NameInMap("ProductCode")]
        [Validation(Required=false)]
        public string ProductCode { get; set; }

        [NameInMap("SceneId")]
        [Validation(Required=false)]
        public long? SceneId { get; set; }

    }

}
