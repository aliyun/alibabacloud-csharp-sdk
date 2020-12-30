// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dyiotapi20171111.Models
{
    public class DoIotIsImeiExistResponseBody : TeaModel {
        [NameInMap("IotImeiExist")]
        [Validation(Required=false)]
        public DoIotIsImeiExistResponseBodyIotImeiExist IotImeiExist { get; set; }
        public class DoIotIsImeiExistResponseBodyIotImeiExist : TeaModel {
            [NameInMap("IsImeiExist")]
            [Validation(Required=false)]
            public bool? IsImeiExist { get; set; }
        };

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

    }

}
