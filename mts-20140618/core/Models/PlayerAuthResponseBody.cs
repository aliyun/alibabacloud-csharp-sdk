// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mts20140618.Models
{
    public class PlayerAuthResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("LogURL")]
        [Validation(Required=false)]
        public string LogURL { get; set; }

        [NameInMap("SwitchList")]
        [Validation(Required=false)]
        public PlayerAuthResponseBodySwitchList SwitchList { get; set; }
        public class PlayerAuthResponseBodySwitchList : TeaModel {
            [NameInMap("Switch")]
            [Validation(Required=false)]
            public List<PlayerAuthResponseBodySwitchListSwitch> Switch { get; set; }
            public class PlayerAuthResponseBodySwitchListSwitch : TeaModel {
                public string FunctionId { get; set; }
                public string FunctionName { get; set; }
                public string State { get; set; }
                public string SwitchId { get; set; }
            }
        };

    }

}
