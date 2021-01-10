// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SOFA20190815.Models
{
    public class DeleteCasLoadbalanceMountRequest : TeaModel {
        [NameInMap("Id")]
        [Validation(Required=false)]
        public string Id { get; set; }

        [NameInMap("ComputerIdsRepeatList")]
        [Validation(Required=false)]
        public List<string> ComputerIdsRepeatList { get; set; }

    }

}
