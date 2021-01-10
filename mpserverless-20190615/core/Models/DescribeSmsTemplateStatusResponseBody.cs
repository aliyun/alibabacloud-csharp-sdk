// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.MPServerless20190615.Models
{
    public class DescribeSmsTemplateStatusResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("TemplateStatuses")]
        [Validation(Required=false)]
        public List<DescribeSmsTemplateStatusResponseBodyTemplateStatuses> TemplateStatuses { get; set; }
        public class DescribeSmsTemplateStatusResponseBodyTemplateStatuses : TeaModel {
            [NameInMap("TemplateCode")]
            [Validation(Required=false)]
            public string TemplateCode { get; set; }

            [NameInMap("TemplateStatus")]
            [Validation(Required=false)]
            public string TemplateStatus { get; set; }

            [NameInMap("Reason")]
            [Validation(Required=false)]
            public string Reason { get; set; }

        }

    }

}
