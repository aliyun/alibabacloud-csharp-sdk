// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Actiontrail20171204.Models
{
    public class DescribeTrailsRequest : TeaModel {
        [NameInMap("IncludeShadowTrails")]
        [Validation(Required=false)]
        public bool? IncludeShadowTrails { get; set; }

        [NameInMap("NameList")]
        [Validation(Required=false)]
        public string NameList { get; set; }

        [NameInMap("IncludeOrganizationTrail")]
        [Validation(Required=false)]
        public bool? IncludeOrganizationTrail { get; set; }

    }

}
