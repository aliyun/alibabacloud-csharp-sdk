// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SOFA20190815.Models
{
    public class DescribeDSTSlsConfigResponseBody : TeaModel {
        [NameInMap("SupportBizLog")]
        [Validation(Required=false)]
        public bool? SupportBizLog { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("CreateTime")]
        [Validation(Required=false)]
        public string CreateTime { get; set; }

        [NameInMap("SlsMachineGroup")]
        [Validation(Required=false)]
        public string SlsMachineGroup { get; set; }

        [NameInMap("ResultMessage")]
        [Validation(Required=false)]
        public string ResultMessage { get; set; }

        [NameInMap("OpenStatus")]
        [Validation(Required=false)]
        public string OpenStatus { get; set; }

        [NameInMap("TokenRedirectUrl")]
        [Validation(Required=false)]
        public string TokenRedirectUrl { get; set; }

        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

        [NameInMap("TenantId")]
        [Validation(Required=false)]
        public string TenantId { get; set; }

        [NameInMap("TokenValid")]
        [Validation(Required=false)]
        public bool? TokenValid { get; set; }

        [NameInMap("Valid")]
        [Validation(Required=false)]
        public bool? Valid { get; set; }

        [NameInMap("AccessKeyId")]
        [Validation(Required=false)]
        public string AccessKeyId { get; set; }

        [NameInMap("UpdateTime")]
        [Validation(Required=false)]
        public string UpdateTime { get; set; }

        [NameInMap("AccessKey")]
        [Validation(Required=false)]
        public string AccessKey { get; set; }

        [NameInMap("ResultCode")]
        [Validation(Required=false)]
        public string ResultCode { get; set; }

    }

}
