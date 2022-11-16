// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CloudAPI20160714.Models
{
    public class ImportOASRequest : TeaModel {
        [NameInMap("AuthType")]
        [Validation(Required=false)]
        public string AuthType { get; set; }

        [NameInMap("BackendName")]
        [Validation(Required=false)]
        public string BackendName { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public string Data { get; set; }

        [NameInMap("GroupId")]
        [Validation(Required=false)]
        public string GroupId { get; set; }

        [NameInMap("IgnoreWarning")]
        [Validation(Required=false)]
        public bool? IgnoreWarning { get; set; }

        [NameInMap("OASVersion")]
        [Validation(Required=false)]
        public string OASVersion { get; set; }

        [NameInMap("Overwrite")]
        [Validation(Required=false)]
        public bool? Overwrite { get; set; }

        [NameInMap("RequestMode")]
        [Validation(Required=false)]
        public string RequestMode { get; set; }

        [NameInMap("SecurityToken")]
        [Validation(Required=false)]
        public string SecurityToken { get; set; }

        [NameInMap("SkipDryRun")]
        [Validation(Required=false)]
        public bool? SkipDryRun { get; set; }

    }

}
