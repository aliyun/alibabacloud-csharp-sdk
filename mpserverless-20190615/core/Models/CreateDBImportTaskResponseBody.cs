// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.MPServerless20190615.Models
{
    public class CreateDBImportTaskResponseBody : TeaModel {
        [NameInMap("AccessKeyId")]
        [Validation(Required=false)]
        public string AccessKeyId { get; set; }

        [NameInMap("ExpireTime")]
        [Validation(Required=false)]
        public string ExpireTime { get; set; }

        [NameInMap("FileKey")]
        [Validation(Required=false)]
        public string FileKey { get; set; }

        [NameInMap("Host")]
        [Validation(Required=false)]
        public string Host { get; set; }

        [NameInMap("Policy")]
        [Validation(Required=false)]
        public string Policy { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Signature")]
        [Validation(Required=false)]
        public string Signature { get; set; }

        [NameInMap("TaskId")]
        [Validation(Required=false)]
        public string TaskId { get; set; }

    }

}
