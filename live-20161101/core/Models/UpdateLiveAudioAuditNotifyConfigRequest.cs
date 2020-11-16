// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class UpdateLiveAudioAuditNotifyConfigRequest : TeaModel {
        [NameInMap("DomainName")]
        [Validation(Required=true)]
        public string DomainName { get; set; }

        [NameInMap("Callback")]
        [Validation(Required=false)]
        public string Callback { get; set; }

        [NameInMap("CallbackTemplate")]
        [Validation(Required=false)]
        public string CallbackTemplate { get; set; }

    }

}
