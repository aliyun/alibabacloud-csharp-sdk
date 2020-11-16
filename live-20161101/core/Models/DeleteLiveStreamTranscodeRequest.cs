// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class DeleteLiveStreamTranscodeRequest : TeaModel {
        [NameInMap("SecurityToken")]
        [Validation(Required=false)]
        public string SecurityToken { get; set; }

        [NameInMap("Domain")]
        [Validation(Required=true)]
        public string Domain { get; set; }

        [NameInMap("App")]
        [Validation(Required=true)]
        public string App { get; set; }

        [NameInMap("Template")]
        [Validation(Required=true)]
        public string Template { get; set; }

    }

}
