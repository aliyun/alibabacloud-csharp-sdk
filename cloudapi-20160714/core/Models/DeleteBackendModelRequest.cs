// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CloudAPI20160714.Models
{
    public class DeleteBackendModelRequest : TeaModel {
        [NameInMap("BackendId")]
        [Validation(Required=false)]
        public string BackendId { get; set; }

        [NameInMap("BackendModelId")]
        [Validation(Required=false)]
        public string BackendModelId { get; set; }

        [NameInMap("SecurityToken")]
        [Validation(Required=false)]
        public string SecurityToken { get; set; }

        [NameInMap("StageName")]
        [Validation(Required=false)]
        public string StageName { get; set; }

    }

}
