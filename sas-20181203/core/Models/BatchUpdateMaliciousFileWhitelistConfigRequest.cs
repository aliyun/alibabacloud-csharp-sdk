// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class BatchUpdateMaliciousFileWhitelistConfigRequest : TeaModel {
        [NameInMap("ConfigList")]
        [Validation(Required=false)]
        public List<BatchUpdateMaliciousFileWhitelistConfigRequestConfigList> ConfigList { get; set; }
        public class BatchUpdateMaliciousFileWhitelistConfigRequestConfigList : TeaModel {
            [NameInMap("ConfigId")]
            [Validation(Required=false)]
            public long? ConfigId { get; set; }

            [NameInMap("EventName")]
            [Validation(Required=false)]
            public string EventName { get; set; }

            [NameInMap("Field")]
            [Validation(Required=false)]
            public string Field { get; set; }

            [NameInMap("FieldValue")]
            [Validation(Required=false)]
            public string FieldValue { get; set; }

            [NameInMap("Operator")]
            [Validation(Required=false)]
            public string Operator { get; set; }

            [NameInMap("Source")]
            [Validation(Required=false)]
            public string Source { get; set; }

            [NameInMap("TargetType")]
            [Validation(Required=false)]
            public string TargetType { get; set; }

            [NameInMap("TargetValue")]
            [Validation(Required=false)]
            public string TargetValue { get; set; }

        }

    }

}
