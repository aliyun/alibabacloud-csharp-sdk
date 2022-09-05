// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Quotas20200510.Models
{
    public class ModifyQuotaTemplateServiceStatusResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("TemplateServiceStatus")]
        [Validation(Required=false)]
        public ModifyQuotaTemplateServiceStatusResponseBodyTemplateServiceStatus TemplateServiceStatus { get; set; }
        public class ModifyQuotaTemplateServiceStatusResponseBodyTemplateServiceStatus : TeaModel {
            [NameInMap("ResourceDirectoryId")]
            [Validation(Required=false)]
            public string ResourceDirectoryId { get; set; }

            [NameInMap("ServiceStatus")]
            [Validation(Required=false)]
            public int? ServiceStatus { get; set; }

        }

    }

}
