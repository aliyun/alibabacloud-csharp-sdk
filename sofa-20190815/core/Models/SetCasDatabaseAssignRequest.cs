// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SOFA20190815.Models
{
    public class SetCasDatabaseAssignRequest : TeaModel {
        [NameInMap("AppIdsRepeatList")]
        [Validation(Required=false)]
        public List<string> AppIdsRepeatList { get; set; }

        [NameInMap("AppServiceIdsRepeatList")]
        [Validation(Required=false)]
        public List<string> AppServiceIdsRepeatList { get; set; }

        [NameInMap("IdsRepeatList")]
        [Validation(Required=false)]
        public List<string> IdsRepeatList { get; set; }

        [NameInMap("Workspace")]
        [Validation(Required=false)]
        public string Workspace { get; set; }

    }

}
