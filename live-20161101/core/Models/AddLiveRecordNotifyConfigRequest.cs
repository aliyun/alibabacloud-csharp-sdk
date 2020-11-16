// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class AddLiveRecordNotifyConfigRequest : TeaModel {
        [NameInMap("SecurityToken")]
        [Validation(Required=false)]
        public string SecurityToken { get; set; }

        [NameInMap("DomainName")]
        [Validation(Required=true)]
        public string DomainName { get; set; }

        [NameInMap("NotifyUrl")]
        [Validation(Required=true)]
        public string NotifyUrl { get; set; }

        [NameInMap("NeedStatusNotify")]
        [Validation(Required=false)]
        public bool? NeedStatusNotify { get; set; }

        [NameInMap("OnDemandUrl")]
        [Validation(Required=false)]
        public string OnDemandUrl { get; set; }

    }

}
