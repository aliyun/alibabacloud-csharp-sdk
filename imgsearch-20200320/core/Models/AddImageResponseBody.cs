// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imgsearch20200320.Models
{
    public class AddImageResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public AddImageResponseBodyData Data { get; set; }
        public class AddImageResponseBodyData : TeaModel {
            [NameInMap("DataId")]
            [Validation(Required=false)]
            public string DataId { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
