// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SOFA20190815.Models
{
    public class MountLinkedeploycoreDeploycoreAppserviceapplyResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("ResultCode")]
        [Validation(Required=false)]
        public string ResultCode { get; set; }

        [NameInMap("ResultMessage")]
        [Validation(Required=false)]
        public string ResultMessage { get; set; }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("ResponseStatusCode")]
        [Validation(Required=false)]
        public long? ResponseStatusCode { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<MountLinkedeploycoreDeploycoreAppserviceapplyResponseBodyData> Data { get; set; }
        public class MountLinkedeploycoreDeploycoreAppserviceapplyResponseBodyData : TeaModel {
            [NameInMap("ActionId")]
            [Validation(Required=false)]
            public long? ActionId { get; set; }

            [NameInMap("AppServiceId")]
            [Validation(Required=false)]
            public long? AppServiceId { get; set; }

            [NameInMap("ConfigId")]
            [Validation(Required=false)]
            public long? ConfigId { get; set; }

            [NameInMap("OrderId")]
            [Validation(Required=false)]
            public long? OrderId { get; set; }

            [NameInMap("OrderUrl")]
            [Validation(Required=false)]
            public string OrderUrl { get; set; }

        }

    }

}
