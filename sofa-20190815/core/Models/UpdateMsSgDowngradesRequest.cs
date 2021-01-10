// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SOFA20190815.Models
{
    public class UpdateMsSgDowngradesRequest : TeaModel {
        [NameInMap("AppName")]
        [Validation(Required=false)]
        public string AppName { get; set; }

        [NameInMap("DowngradeMethod")]
        [Validation(Required=false)]
        public string DowngradeMethod { get; set; }

        [NameInMap("DowngradeService")]
        [Validation(Required=false)]
        public string DowngradeService { get; set; }

        [NameInMap("GroupId")]
        [Validation(Required=false)]
        public long? GroupId { get; set; }

        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        [NameInMap("Mode")]
        [Validation(Required=false)]
        public string Mode { get; set; }

        [NameInMap("RuleId")]
        [Validation(Required=false)]
        public long? RuleId { get; set; }

        [NameInMap("RuleName")]
        [Validation(Required=false)]
        public string RuleName { get; set; }

        [NameInMap("Strategy")]
        [Validation(Required=false)]
        public string Strategy { get; set; }

    }

}
