// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ARMS20210422.Models
{
    public class UpdateAlertRuleRequest : TeaModel {
        [NameInMap("AlertId")]
        [Validation(Required=false)]
        public long? AlertId { get; set; }

        [NameInMap("ContactGroupIds")]
        [Validation(Required=false)]
        public string ContactGroupIds { get; set; }

        [NameInMap("IsAutoStart")]
        [Validation(Required=false)]
        public bool? IsAutoStart { get; set; }

        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("TemplageAlertConfig")]
        [Validation(Required=false)]
        public string TemplageAlertConfig { get; set; }

    }

}
