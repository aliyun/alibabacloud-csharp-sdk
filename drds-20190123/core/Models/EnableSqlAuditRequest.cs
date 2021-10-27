// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Drds20190123.Models
{
    public class EnableSqlAuditRequest : TeaModel {
        [NameInMap("DbName")]
        [Validation(Required=false)]
        public string DbName { get; set; }

        [NameInMap("DrdsInstanceId")]
        [Validation(Required=false)]
        public string DrdsInstanceId { get; set; }

        [NameInMap("IsRecall")]
        [Validation(Required=false)]
        public bool? IsRecall { get; set; }

        [NameInMap("RecallEndTimestamp")]
        [Validation(Required=false)]
        public string RecallEndTimestamp { get; set; }

        [NameInMap("RecallStartTimestamp")]
        [Validation(Required=false)]
        public string RecallStartTimestamp { get; set; }

    }

}
