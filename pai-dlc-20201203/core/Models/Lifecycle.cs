// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pai_dlc20201203.Models
{
    public class Lifecycle : TeaModel {
        [NameInMap("PostStart")]
        [Validation(Required=false)]
        public LifecyclePostStart PostStart { get; set; }
        public class LifecyclePostStart : TeaModel {
            [NameInMap("Exec")]
            [Validation(Required=false)]
            public LifecyclePostStartExec Exec { get; set; }
            public class LifecyclePostStartExec : TeaModel {
                [NameInMap("Command")]
                [Validation(Required=false)]
                public List<string> Command { get; set; }

            }

        }

        [NameInMap("PreStop")]
        [Validation(Required=false)]
        public LifecyclePreStop PreStop { get; set; }
        public class LifecyclePreStop : TeaModel {
            [NameInMap("Exec")]
            [Validation(Required=false)]
            public LifecyclePreStopExec Exec { get; set; }
            public class LifecyclePreStopExec : TeaModel {
                [NameInMap("Command")]
                [Validation(Required=false)]
                public List<string> Command { get; set; }

            }

        }

    }

}
