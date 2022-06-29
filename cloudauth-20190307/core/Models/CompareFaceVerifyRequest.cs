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
    public class CompareFaceVerifyRequest : TeaModel {
        [NameInMap("Crop")]
        [Validation(Required=false)]
        public string Crop { get; set; }

        [NameInMap("OuterOrderNo")]
        [Validation(Required=false)]
        public string OuterOrderNo { get; set; }

        [NameInMap("ProductCode")]
        [Validation(Required=false)]
        public string ProductCode { get; set; }

        [NameInMap("SceneId")]
        [Validation(Required=false)]
        public long? SceneId { get; set; }

        [NameInMap("SourceCertifyId")]
        [Validation(Required=false)]
        public string SourceCertifyId { get; set; }

        [NameInMap("SourceFaceContrastPicture")]
        [Validation(Required=false)]
        public string SourceFaceContrastPicture { get; set; }

        [NameInMap("SourceFaceContrastPictureUrl")]
        [Validation(Required=false)]
        public string SourceFaceContrastPictureUrl { get; set; }

        [NameInMap("SourceOssBucketName")]
        [Validation(Required=false)]
        public string SourceOssBucketName { get; set; }

        [NameInMap("SourceOssObjectName")]
        [Validation(Required=false)]
        public string SourceOssObjectName { get; set; }

        [NameInMap("TargetCertifyId")]
        [Validation(Required=false)]
        public string TargetCertifyId { get; set; }

        [NameInMap("TargetFaceContrastPicture")]
        [Validation(Required=false)]
        public string TargetFaceContrastPicture { get; set; }

        [NameInMap("TargetFaceContrastPictureUrl")]
        [Validation(Required=false)]
        public string TargetFaceContrastPictureUrl { get; set; }

        [NameInMap("TargetOssBucketName")]
        [Validation(Required=false)]
        public string TargetOssBucketName { get; set; }

        [NameInMap("TargetOssObjectName")]
        [Validation(Required=false)]
        public string TargetOssObjectName { get; set; }

    }

}
