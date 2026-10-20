// This file is auto-generated, don't edit it. Thanks.

using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;
using Darabonba;
using Darabonba.Utils;

namespace AlibabaCloud.SDK.CS20151215.Models
{
    public class Hugepage : Darabonba.Model {
        [NameInMap("khugepagedAllocSleepMillisecs")]
        [Validation(Required=false)]
        public long? KhugepagedAllocSleepMillisecs { get; set; }

        [NameInMap("khugepagedDefrag")]
        [Validation(Required=false)]
        public long? KhugepagedDefrag { get; set; }

        [NameInMap("khugepagedPagesToScan")]
        [Validation(Required=false)]
        public long? KhugepagedPagesToScan { get; set; }

        [NameInMap("khugepagedScanSleepMillisecs")]
        [Validation(Required=false)]
        public long? KhugepagedScanSleepMillisecs { get; set; }

        [NameInMap("transparentDefrag")]
        [Validation(Required=false)]
        public string TransparentDefrag { get; set; }

        [NameInMap("transparentEnabled")]
        [Validation(Required=false)]
        public string TransparentEnabled { get; set; }

    }

}

