// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SOFA20190815.Models
{
    public class UpdateLinkeantcodeAntcodeCurrenttenantResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("ResultCode")]
        [Validation(Required=false)]
        public string ResultCode { get; set; }

        [NameInMap("ResultMessage")]
        [Validation(Required=false)]
        public string ResultMessage { get; set; }

        [NameInMap("CreatedAt")]
        [Validation(Required=false)]
        public string CreatedAt { get; set; }

        [NameInMap("Id")]
        [Validation(Required=false)]
        public long? Id { get; set; }

        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("Path")]
        [Validation(Required=false)]
        public string Path { get; set; }

        [NameInMap("ResponseStatusCode")]
        [Validation(Required=false)]
        public long? ResponseStatusCode { get; set; }

        [NameInMap("UpdatedAt")]
        [Validation(Required=false)]
        public string UpdatedAt { get; set; }

        [NameInMap("WhileListIp")]
        [Validation(Required=false)]
        public string WhileListIp { get; set; }

        [NameInMap("Permission")]
        [Validation(Required=false)]
        public UpdateLinkeantcodeAntcodeCurrenttenantResponseBodyPermission Permission { get; set; }
        public class UpdateLinkeantcodeAntcodeCurrenttenantResponseBodyPermission : TeaModel {
            [NameInMap("GroupAccess")]
            [Validation(Required=false)]
            public string GroupAccess { get; set; }
            [NameInMap("ProjectAccess")]
            [Validation(Required=false)]
            public string ProjectAccess { get; set; }
            [NameInMap("ReviewAccess")]
            [Validation(Required=false)]
            public string ReviewAccess { get; set; }
            [NameInMap("TenantAccess")]
            [Validation(Required=false)]
            public string TenantAccess { get; set; }
        };

    }

}
