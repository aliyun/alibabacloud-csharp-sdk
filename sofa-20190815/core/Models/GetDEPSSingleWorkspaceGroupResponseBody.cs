// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SOFA20190815.Models
{
    public class GetDEPSSingleWorkspaceGroupResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("ResultCode")]
        [Validation(Required=false)]
        public string ResultCode { get; set; }

        [NameInMap("ResultMessage")]
        [Validation(Required=false)]
        public string ResultMessage { get; set; }

        [NameInMap("DomainSuffix")]
        [Validation(Required=false)]
        public string DomainSuffix { get; set; }

        [NameInMap("Identity")]
        [Validation(Required=false)]
        public string Identity { get; set; }

        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("ReleaseMode")]
        [Validation(Required=false)]
        public string ReleaseMode { get; set; }

        [NameInMap("Workspaces")]
        [Validation(Required=false)]
        public List<string> Workspaces { get; set; }

    }

}
