// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class SetBoardCallbackRequest : TeaModel {
        [NameInMap("AppId")]
        [Validation(Required=true)]
        public string AppId { get; set; }

        [NameInMap("AuthKey")]
        [Validation(Required=false)]
        public string AuthKey { get; set; }

        [NameInMap("AuthSwitch")]
        [Validation(Required=false)]
        public string AuthSwitch { get; set; }

        [NameInMap("CallbackEnable")]
        [Validation(Required=true)]
        public int? CallbackEnable { get; set; }

        [NameInMap("CallbackUri")]
        [Validation(Required=false)]
        public string CallbackUri { get; set; }

        [NameInMap("CallbackEvents")]
        [Validation(Required=false)]
        public string CallbackEvents { get; set; }

    }

}
