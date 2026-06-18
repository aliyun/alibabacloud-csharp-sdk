// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.FCSandbox20260509.Models
{
    public class E2BLifecycle : TeaModel {
        [NameInMap("autoResume")]
        [Validation(Required=false)]
        public bool? AutoResume { get; set; }

        [NameInMap("onTimeout")]
        [Validation(Required=false)]
        public string OnTimeout { get; set; }

    }

}
