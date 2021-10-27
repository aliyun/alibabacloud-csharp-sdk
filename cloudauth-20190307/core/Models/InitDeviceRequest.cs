// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudauth20190307.Models
{
    public class InitDeviceRequest : TeaModel {
        [NameInMap("AppVersion")]
        [Validation(Required=false)]
        public string AppVersion { get; set; }

        [NameInMap("BizData")]
        [Validation(Required=false)]
        public string BizData { get; set; }

        [NameInMap("CertifyId")]
        [Validation(Required=false)]
        public string CertifyId { get; set; }

        [NameInMap("CertifyPrincipal")]
        [Validation(Required=false)]
        public string CertifyPrincipal { get; set; }

        [NameInMap("Channel")]
        [Validation(Required=false)]
        public string Channel { get; set; }

        [NameInMap("DeviceToken")]
        [Validation(Required=false)]
        public string DeviceToken { get; set; }

        [NameInMap("Merchant")]
        [Validation(Required=false)]
        public string Merchant { get; set; }

        [NameInMap("MetaInfo")]
        [Validation(Required=false)]
        public string MetaInfo { get; set; }

        [NameInMap("OuterOrderNo")]
        [Validation(Required=false)]
        public string OuterOrderNo { get; set; }

        [NameInMap("ProduceNode")]
        [Validation(Required=false)]
        public string ProduceNode { get; set; }

        [NameInMap("ProductName")]
        [Validation(Required=false)]
        public string ProductName { get; set; }

        [NameInMap("UaToken")]
        [Validation(Required=false)]
        public string UaToken { get; set; }

        [NameInMap("WebUmidToken")]
        [Validation(Required=false)]
        public string WebUmidToken { get; set; }

    }

}
