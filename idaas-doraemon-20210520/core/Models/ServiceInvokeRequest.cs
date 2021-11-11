// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Idaas_doraemon20210520.Models
{
    public class ServiceInvokeRequest : TeaModel {
        [NameInMap("ApplicationExternalId")]
        [Validation(Required=false)]
        public string ApplicationExternalId { get; set; }

        [NameInMap("DoraemonAction")]
        [Validation(Required=false)]
        public string DoraemonAction { get; set; }

        [NameInMap("MobileExtendParamsJson")]
        [Validation(Required=false)]
        public string MobileExtendParamsJson { get; set; }

        [NameInMap("MobileExtendParamsJsonSign")]
        [Validation(Required=false)]
        public string MobileExtendParamsJsonSign { get; set; }

        [NameInMap("ServerExtendParamsJson")]
        [Validation(Required=false)]
        public string ServerExtendParamsJson { get; set; }

        [NameInMap("ServiceCode")]
        [Validation(Required=false)]
        public string ServiceCode { get; set; }

        [NameInMap("TestModel")]
        [Validation(Required=false)]
        public bool? TestModel { get; set; }

        [NameInMap("XClientIp")]
        [Validation(Required=false)]
        public string XClientIp { get; set; }

    }

}
