// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SOFA20190815.Models
{
    public class CancelLinkedeploycoreDeploycoreActioncancelRequest : TeaModel {
        [NameInMap("FromApp")]
        [Validation(Required=false)]
        public string FromApp { get; set; }

        [NameInMap("Operator")]
        [Validation(Required=false)]
        public string Operator { get; set; }

        [NameInMap("ActionIdsRepeatList")]
        [Validation(Required=false)]
        public List<int?> ActionIdsRepeatList { get; set; }

    }

}
