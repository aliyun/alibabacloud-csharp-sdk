// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Yundun_dbaudit20180320.Models
{
    public class ModifyDataSourceAttributeRequest : TeaModel {
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        [NameInMap("AuditMode")]
        [Validation(Required=false)]
        public string AuditMode { get; set; }

        [NameInMap("ResultAuditMode")]
        [Validation(Required=false)]
        public string ResultAuditMode { get; set; }

        [NameInMap("ResultAuditMaxLine")]
        [Validation(Required=false)]
        public int? ResultAuditMaxLine { get; set; }

        [NameInMap("ResultAuditMaxSize")]
        [Validation(Required=false)]
        public int? ResultAuditMaxSize { get; set; }

        [NameInMap("DbIds")]
        [Validation(Required=false)]
        public List<string> DbIds { get; set; }

    }

}
