// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class DeleteDataServiceApiAuthorityRequest : TeaModel {
        [NameInMap("ApiId")]
        [Validation(Required=false)]
        public long? ApiId { get; set; }

        [NameInMap("AuthorizedProjectId")]
        [Validation(Required=false)]
        public long? AuthorizedProjectId { get; set; }

        [NameInMap("ProjectId")]
        [Validation(Required=false)]
        public long? ProjectId { get; set; }

        [NameInMap("TenantId")]
        [Validation(Required=false)]
        public long? TenantId { get; set; }

    }

}
