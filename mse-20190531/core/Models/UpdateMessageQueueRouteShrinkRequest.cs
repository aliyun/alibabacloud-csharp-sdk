// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mse20190531.Models
{
    public class UpdateMessageQueueRouteShrinkRequest : TeaModel {
        [NameInMap("AcceptLanguage")]
        [Validation(Required=false)]
        public string AcceptLanguage { get; set; }

        [NameInMap("AppId")]
        [Validation(Required=false)]
        public string AppId { get; set; }

        [NameInMap("Enable")]
        [Validation(Required=false)]
        public bool? Enable { get; set; }

        [NameInMap("Region")]
        [Validation(Required=false)]
        public string Region { get; set; }

        [NameInMap("Tags")]
        [Validation(Required=false)]
        public string TagsShrink { get; set; }

    }

}
