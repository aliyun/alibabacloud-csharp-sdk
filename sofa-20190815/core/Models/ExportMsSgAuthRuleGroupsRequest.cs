// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SOFA20190815.Models
{
    public class ExportMsSgAuthRuleGroupsRequest : TeaModel {
        [NameInMap("AuthRuleIds")]
        [Validation(Required=false)]
        public string AuthRuleIds { get; set; }

        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        [NameInMap("IsExportAll")]
        [Validation(Required=false)]
        public bool? IsExportAll { get; set; }

    }

}
