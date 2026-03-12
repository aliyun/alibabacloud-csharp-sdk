// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Domain20160511.Models
{
    public class QueryContactTemplateRequest : TeaModel {
        [NameInMap("AuditStatus")]
        [Validation(Required=false)]
        public string AuditStatus { get; set; }

        [NameInMap("CCompany")]
        [Validation(Required=false)]
        public string CCompany { get; set; }

        [NameInMap("ContactTemplateId")]
        [Validation(Required=false)]
        public long? ContactTemplateId { get; set; }

        [NameInMap("DefaultTemplate")]
        [Validation(Required=false)]
        public bool? DefaultTemplate { get; set; }

        [NameInMap("ECompany")]
        [Validation(Required=false)]
        public string ECompany { get; set; }

        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        [NameInMap("PageNum")]
        [Validation(Required=false)]
        public int? PageNum { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("RegType")]
        [Validation(Required=false)]
        public string RegType { get; set; }

        [NameInMap("UserClientIp")]
        [Validation(Required=false)]
        public string UserClientIp { get; set; }

    }

}
