// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class ListDutyRostersRequest : TeaModel {
        [NameInMap("DutyRosterName")]
        [Validation(Required=false)]
        public string DutyRosterName { get; set; }

        [NameInMap("DutyRosterOwner")]
        [Validation(Required=false)]
        public string DutyRosterOwner { get; set; }

        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

    }

}
