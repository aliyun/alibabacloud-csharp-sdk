// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudauth20190307.Models
{
    public class Vehicle5ItemQueryResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("ResultObject")]
        [Validation(Required=false)]
        public Vehicle5ItemQueryResponseBodyResultObject ResultObject { get; set; }
        public class Vehicle5ItemQueryResponseBodyResultObject : TeaModel {
            [NameInMap("BizCode")]
            [Validation(Required=false)]
            public string BizCode { get; set; }

            [NameInMap("VehicleInfo")]
            [Validation(Required=false)]
            public string VehicleInfo { get; set; }

        }

    }

}
