// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SOFA20190815.Models
{
    public class SetCasDatabaseShareRequest : TeaModel {
        [NameInMap("IdsRepeatList")]
        [Validation(Required=false)]
        public List<string> IdsRepeatList { get; set; }

        [NameInMap("WorkspaceIdsRepeatList")]
        [Validation(Required=false)]
        public List<string> WorkspaceIdsRepeatList { get; set; }

    }

}
