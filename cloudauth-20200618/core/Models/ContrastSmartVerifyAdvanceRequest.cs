// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudauth20200618.Models
{
    public class ContrastSmartVerifyAdvanceRequest : TeaModel {
        [NameInMap("FacePicFileObject")]
        [Validation(Required=true)]
        public Stream FacePicFileObject { get; set; }

        [NameInMap("SceneId")]
        [Validation(Required=true)]
        public long SceneId { get; set; }

        [NameInMap("OuterOrderNo")]
        [Validation(Required=true)]
        public string OuterOrderNo { get; set; }

        [NameInMap("Mode")]
        [Validation(Required=true)]
        public string Mode { get; set; }

        [NameInMap("CertType")]
        [Validation(Required=true)]
        public string CertType { get; set; }

        [NameInMap("Mobile")]
        [Validation(Required=false)]
        public string Mobile { get; set; }

        [NameInMap("Ip")]
        [Validation(Required=false)]
        public string Ip { get; set; }

        [NameInMap("UserId")]
        [Validation(Required=false)]
        public string UserId { get; set; }

        [NameInMap("CertName")]
        [Validation(Required=true)]
        public string CertName { get; set; }

        [NameInMap("CertNo")]
        [Validation(Required=true)]
        public string CertNo { get; set; }

        [NameInMap("FacePicUrl")]
        [Validation(Required=false)]
        public string FacePicUrl { get; set; }

        [NameInMap("FacePicString")]
        [Validation(Required=false)]
        public string FacePicString { get; set; }

    }

}
