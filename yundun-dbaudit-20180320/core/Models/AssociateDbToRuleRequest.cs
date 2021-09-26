// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Yundun_dbaudit20180320.Models
{
    public class AssociateDbToRuleRequest : TeaModel {
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        [NameInMap("RuleIds")]
        [Validation(Required=false)]
        public string RuleIds { get; set; }

        [NameInMap("RuleDbRelations")]
        [Validation(Required=false)]
        public string RuleDbRelations { get; set; }

        [NameInMap("OperType")]
        [Validation(Required=false)]
        public string OperType { get; set; }

    }

}
