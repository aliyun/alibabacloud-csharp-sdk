// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adb20211201.Models
{
    public class SparkSession : TeaModel {
        [NameInMap("Active")]
        [Validation(Required=false)]
        public string Active { get; set; }

        [NameInMap("AliyunUid")]
        [Validation(Required=false)]
        public long? AliyunUid { get; set; }

        [NameInMap("SessionId")]
        [Validation(Required=false)]
        public long? SessionId { get; set; }

        [NameInMap("State")]
        [Validation(Required=false)]
        public string State { get; set; }

    }

}
