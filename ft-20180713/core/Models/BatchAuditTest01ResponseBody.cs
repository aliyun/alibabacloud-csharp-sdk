// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ft20180713.Models
{
    public class BatchAuditTest01ResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Demo01")]
        [Validation(Required=false)]
        public BatchAuditTest01ResponseBodyDemo01 Demo01 { get; set; }
        public class BatchAuditTest01ResponseBodyDemo01 : TeaModel {
            [NameInMap("Demo011")]
            [Validation(Required=false)]
            public List<BatchAuditTest01ResponseBodyDemo01Demo011> Demo011 { get; set; }
            public class BatchAuditTest01ResponseBodyDemo01Demo011 : TeaModel {
                public string Demo0111 { get; set; }
            }
        };

        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

    }

}
