// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.GEMP20210413.Models
{
    public class ListRouteRulesByAssignWhoIdRequest : TeaModel {
        [NameInMap("assignWhoId")]
        [Validation(Required=false)]
        public long? AssignWhoId { get; set; }

        [NameInMap("assignWhoType")]
        [Validation(Required=false)]
        public long? AssignWhoType { get; set; }

    }

}
