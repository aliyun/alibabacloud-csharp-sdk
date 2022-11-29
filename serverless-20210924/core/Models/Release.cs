// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Serverless20210924.Models
{
    public class Release : TeaModel {
        [NameInMap("appConfig")]
        [Validation(Required=false)]
        public Dictionary<string, object> AppConfig { get; set; }

        [NameInMap("codeVersion")]
        [Validation(Required=false)]
        public ReleaseCodeVersion CodeVersion { get; set; }
        public class ReleaseCodeVersion : TeaModel {
            [NameInMap("branch")]
            [Validation(Required=false)]
            public string Branch { get; set; }

            [NameInMap("commit")]
            [Validation(Required=false)]
            public string Commit { get; set; }

        }

        [NameInMap("createdTime")]
        [Validation(Required=false)]
        public string CreatedTime { get; set; }

        [NameInMap("description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        [NameInMap("output")]
        [Validation(Required=false)]
        public Dictionary<string, object> Output { get; set; }

        [NameInMap("status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        [NameInMap("versionId")]
        [Validation(Required=false)]
        public long? VersionId { get; set; }

    }

}
