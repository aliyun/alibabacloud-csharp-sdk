// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Actiontrail20171204.Models
{
    public class GetTrailStatusRequest : TeaModel {
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("IsOrganizationTrail")]
        [Validation(Required=false)]
        public bool? IsOrganizationTrail { get; set; }

    }

}
