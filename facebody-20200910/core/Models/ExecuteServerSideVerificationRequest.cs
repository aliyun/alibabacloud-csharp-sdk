// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Facebody20200910.Models
{
    public class ExecuteServerSideVerificationRequest : TeaModel {
        [NameInMap("certificateName")]
        [Validation(Required=false)]
        public string CertificateName { get; set; }

        [NameInMap("certificateNumber")]
        [Validation(Required=false)]
        public string CertificateNumber { get; set; }

        [NameInMap("facialPictureData")]
        [Validation(Required=false)]
        public byte[] FacialPictureData { get; set; }

        [NameInMap("facialPictureUrl")]
        [Validation(Required=false)]
        public string FacialPictureUrl { get; set; }

        [NameInMap("sceneType")]
        [Validation(Required=false)]
        public string SceneType { get; set; }

    }

}
