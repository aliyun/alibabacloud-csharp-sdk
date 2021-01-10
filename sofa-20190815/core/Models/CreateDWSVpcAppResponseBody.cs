// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SOFA20190815.Models
{
    public class CreateDWSVpcAppResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public CreateDWSVpcAppResponseBodyData Data { get; set; }
        public class CreateDWSVpcAppResponseBodyData : TeaModel {
            [NameInMap("VpcAddressPoolId")]
            [Validation(Required=false)]
            public string VpcAddressPoolId { get; set; }
            [NameInMap("AppName")]
            [Validation(Required=false)]
            public string AppName { get; set; }
            [NameInMap("VpcAddressPool")]
            [Validation(Required=false)]
            public string VpcAddressPool { get; set; }
            [NameInMap("AppId")]
            [Validation(Required=false)]
            public string AppId { get; set; }
            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }
        };

        [NameInMap("ResultMessage")]
        [Validation(Required=false)]
        public string ResultMessage { get; set; }

        [NameInMap("ResultCode")]
        [Validation(Required=false)]
        public string ResultCode { get; set; }

    }

}
