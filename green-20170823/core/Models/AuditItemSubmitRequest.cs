/**
 *
 */
// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Green20170823.Models
{
    public class AuditItemSubmitRequest : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<AuditItemSubmitRequestData> Data { get; set; }
        public class AuditItemSubmitRequestData : TeaModel {
            [NameInMap("CustomResult")]
            [Validation(Required=false)]
            public string CustomResult { get; set; }

            [NameInMap("CustomRiskType")]
            [Validation(Required=false)]
            public string CustomRiskType { get; set; }

            [NameInMap("Id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

        }

    }

}
