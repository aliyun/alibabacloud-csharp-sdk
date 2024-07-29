// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Clickhouse20230522.Models
{
    public class UpgradeMinorVersionResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public UpgradeMinorVersionResponseBodyData Data { get; set; }
        public class UpgradeMinorVersionResponseBodyData : TeaModel {
            [NameInMap("DBInstanceName")]
            [Validation(Required=false)]
            public string DBInstanceName { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
