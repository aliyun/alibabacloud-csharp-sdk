// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Drds20190123.Models
{
    public class CreateDrdsInstanceResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public CreateDrdsInstanceResponseBodyData Data { get; set; }
        public class CreateDrdsInstanceResponseBodyData : TeaModel {
            [NameInMap("DrdsInstanceIdList")]
            [Validation(Required=false)]
            public CreateDrdsInstanceResponseBodyDataDrdsInstanceIdList DrdsInstanceIdList { get; set; }
            public class CreateDrdsInstanceResponseBodyDataDrdsInstanceIdList : TeaModel {
                [NameInMap("drdsInstanceIdList")]
                [Validation(Required=false)]
                public List<string> DrdsInstanceIdList { get; set; }

            }
            [NameInMap("OrderId")]
            [Validation(Required=false)]
            public long? OrderId { get; set; }
        };

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
