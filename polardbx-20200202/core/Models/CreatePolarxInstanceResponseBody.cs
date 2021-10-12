// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardbx20200202.Models
{
    public class CreatePolarxInstanceResponseBody : TeaModel {
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public CreatePolarxInstanceResponseBodyData Data { get; set; }
        public class CreatePolarxInstanceResponseBodyData : TeaModel {
            [NameInMap("OrderId")]
            [Validation(Required=false)]
            public long? OrderId { get; set; }
            [NameInMap("DrdsInstanceIdList")]
            [Validation(Required=false)]
            public CreatePolarxInstanceResponseBodyDataDrdsInstanceIdList DrdsInstanceIdList { get; set; }
            public class CreatePolarxInstanceResponseBodyDataDrdsInstanceIdList : TeaModel {
                [NameInMap("drdsInstanceIdList")]
                [Validation(Required=false)]
                public List<string> DrdsInstanceIdList { get; set; }

            }
        };

    }

}
