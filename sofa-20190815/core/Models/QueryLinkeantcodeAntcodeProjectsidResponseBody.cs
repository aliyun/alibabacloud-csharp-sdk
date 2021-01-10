// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SOFA20190815.Models
{
    public class QueryLinkeantcodeAntcodeProjectsidResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("ResultCode")]
        [Validation(Required=false)]
        public string ResultCode { get; set; }

        [NameInMap("ResultMessage")]
        [Validation(Required=false)]
        public string ResultMessage { get; set; }

        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        [NameInMap("HttpUrlToRepo")]
        [Validation(Required=false)]
        public string HttpUrlToRepo { get; set; }

        [NameInMap("Id")]
        [Validation(Required=false)]
        public long? Id { get; set; }

        [NameInMap("LastActivityAt")]
        [Validation(Required=false)]
        public string LastActivityAt { get; set; }

        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("NameWithNamespace")]
        [Validation(Required=false)]
        public string NameWithNamespace { get; set; }

        [NameInMap("Path")]
        [Validation(Required=false)]
        public string Path { get; set; }

        [NameInMap("PathWithNamespace")]
        [Validation(Required=false)]
        public string PathWithNamespace { get; set; }

        [NameInMap("RepositorySize")]
        [Validation(Required=false)]
        public string RepositorySize { get; set; }

        [NameInMap("ResponseStatusCode")]
        [Validation(Required=false)]
        public long? ResponseStatusCode { get; set; }

        [NameInMap("SshUrlToRepo")]
        [Validation(Required=false)]
        public string SshUrlToRepo { get; set; }

        [NameInMap("VisibilityLevel")]
        [Validation(Required=false)]
        public long? VisibilityLevel { get; set; }

    }

}
