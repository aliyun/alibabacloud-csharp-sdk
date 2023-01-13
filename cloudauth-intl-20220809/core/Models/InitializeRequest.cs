// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudauth_intl20220809.Models
{
    public class InitializeRequest : TeaModel {
        [NameInMap("DocType")]
        [Validation(Required=false)]
        public string DocType { get; set; }

        [NameInMap("FacePictureBase64")]
        [Validation(Required=false)]
        public string FacePictureBase64 { get; set; }

        [NameInMap("FacePictureUrl")]
        [Validation(Required=false)]
        public string FacePictureUrl { get; set; }

        [NameInMap("FlowType")]
        [Validation(Required=false)]
        public string FlowType { get; set; }

        [NameInMap("MerchantBizId")]
        [Validation(Required=false)]
        public string MerchantBizId { get; set; }

        [NameInMap("MerchantUserId")]
        [Validation(Required=false)]
        public string MerchantUserId { get; set; }

        [NameInMap("MetaInfo")]
        [Validation(Required=false)]
        public string MetaInfo { get; set; }

        [NameInMap("OperationMode")]
        [Validation(Required=false)]
        public string OperationMode { get; set; }

        [NameInMap("Pages")]
        [Validation(Required=false)]
        public string Pages { get; set; }

        [NameInMap("ProductCode")]
        [Validation(Required=false)]
        public string ProductCode { get; set; }

        [NameInMap("ProductConfig")]
        [Validation(Required=false)]
        public string ProductConfig { get; set; }

        [NameInMap("SceneCode")]
        [Validation(Required=false)]
        public string SceneCode { get; set; }

        [NameInMap("ServiceLevel")]
        [Validation(Required=false)]
        public string ServiceLevel { get; set; }

    }

}
