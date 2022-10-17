// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudauth20190307.Models
{
    public class ContrastFaceVerifyAdvanceRequest : TeaModel {
        [NameInMap("CertName")]
        [Validation(Required=false)]
        public string CertName { get; set; }

        [NameInMap("CertNo")]
        [Validation(Required=false)]
        public string CertNo { get; set; }

        [NameInMap("CertType")]
        [Validation(Required=false)]
        public string CertType { get; set; }

        [NameInMap("CertifyId")]
        [Validation(Required=false)]
        public string CertifyId { get; set; }

        [NameInMap("Crop")]
        [Validation(Required=false)]
        public string Crop { get; set; }

        [NameInMap("DeviceToken")]
        [Validation(Required=false)]
        public string DeviceToken { get; set; }

        [NameInMap("EncryptType")]
        [Validation(Required=false)]
        public string EncryptType { get; set; }

        [NameInMap("FaceContrastFile")]
        [Validation(Required=false)]
        public Stream FaceContrastFileObject { get; set; }

        [NameInMap("FaceContrastPicture")]
        [Validation(Required=false)]
        public string FaceContrastPicture { get; set; }

        [NameInMap("FaceContrastPictureUrl")]
        [Validation(Required=false)]
        public string FaceContrastPictureUrl { get; set; }

        [NameInMap("Ip")]
        [Validation(Required=false)]
        public string Ip { get; set; }

        [NameInMap("Mobile")]
        [Validation(Required=false)]
        public string Mobile { get; set; }

        [NameInMap("Model")]
        [Validation(Required=false)]
        public string Model { get; set; }

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

        [NameInMap("UserId")]
        [Validation(Required=false)]
        public string UserId { get; set; }

    }

}
