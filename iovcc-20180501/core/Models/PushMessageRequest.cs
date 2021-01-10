// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Iovcc20180501.Models
{
    public class PushMessageRequest : TeaModel {
        [NameInMap("AppPackage")]
        [Validation(Required=false)]
        public string AppPackage { get; set; }

        [NameInMap("Desc")]
        [Validation(Required=false)]
        public string Desc { get; set; }

        [NameInMap("Act")]
        [Validation(Required=false)]
        public string Act { get; set; }

        [NameInMap("Uri")]
        [Validation(Required=false)]
        public string Uri { get; set; }

        [NameInMap("PkgContent")]
        [Validation(Required=false)]
        public string PkgContent { get; set; }

        [NameInMap("CustomContent")]
        [Validation(Required=false)]
        public string CustomContent { get; set; }

        [NameInMap("ReceiverType")]
        [Validation(Required=false)]
        public string ReceiverType { get; set; }

        [NameInMap("ReceiverValues")]
        [Validation(Required=false)]
        public string ReceiverValues { get; set; }

        [NameInMap("ExpiredTime")]
        [Validation(Required=false)]
        public long? ExpiredTime { get; set; }

        [NameInMap("Title")]
        [Validation(Required=false)]
        public string Title { get; set; }

        [NameInMap("ProjectId")]
        [Validation(Required=false)]
        public string ProjectId { get; set; }

        [NameInMap("AppKey")]
        [Validation(Required=false)]
        public string AppKey { get; set; }

        [NameInMap("Type")]
        [Validation(Required=false)]
        public int? Type { get; set; }

    }

}
