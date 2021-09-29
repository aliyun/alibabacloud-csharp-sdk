// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Iovcc20180501.Models
{
    public class ExecuteCameraShootingCommandResponseBody : TeaModel {
        /// <summary>
        /// 请求ID
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("ShootingRecord")]
        [Validation(Required=false)]
        public ExecuteCameraShootingCommandResponseBodyShootingRecord ShootingRecord { get; set; }
        public class ExecuteCameraShootingCommandResponseBodyShootingRecord : TeaModel {
            [NameInMap("Id")]
            [Validation(Required=false)]
            public long? Id { get; set; }
            [NameInMap("ShootingType")]
            [Validation(Required=false)]
            public long? ShootingType { get; set; }
            [NameInMap("Number")]
            [Validation(Required=false)]
            public long? Number { get; set; }
            [NameInMap("Time")]
            [Validation(Required=false)]
            public long? Time { get; set; }
            [NameInMap("RecordTime")]
            [Validation(Required=false)]
            public long? RecordTime { get; set; }
            [NameInMap("Status")]
            [Validation(Required=false)]
            public long? Status { get; set; }
        };

    }

}
