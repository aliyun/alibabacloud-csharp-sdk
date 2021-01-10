// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SOFA20190815.Models
{
    public class ListMsSgAuditLogsRequest : TeaModel {
        [NameInMap("BeginTime")]
        [Validation(Required=false)]
        public string BeginTime { get; set; }

        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        [NameInMap("ObjectId")]
        [Validation(Required=false)]
        public string ObjectId { get; set; }

        [NameInMap("ObjectType")]
        [Validation(Required=false)]
        public string ObjectType { get; set; }

        [NameInMap("OperateType")]
        [Validation(Required=false)]
        public string OperateType { get; set; }

        [NameInMap("Operator")]
        [Validation(Required=false)]
        public string Operator { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

        [NameInMap("Start")]
        [Validation(Required=false)]
        public long? Start { get; set; }

        [NameInMap("Status")]
        [Validation(Required=false)]
        public long? Status { get; set; }

    }

}
