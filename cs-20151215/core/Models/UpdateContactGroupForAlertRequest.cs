// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CS20151215.Models
{
    public class UpdateContactGroupForAlertRequest : TeaModel {
        [NameInMap("alert_rule_group_name")]
        [Validation(Required=false)]
        public string AlertRuleGroupName { get; set; }

        [NameInMap("contact_group_ids")]
        [Validation(Required=false)]
        public List<long?> ContactGroupIds { get; set; }

        [NameInMap("cr_name")]
        [Validation(Required=false)]
        public string CrName { get; set; }

        [NameInMap("namespace")]
        [Validation(Required=false)]
        public string Namespace { get; set; }

    }

}
