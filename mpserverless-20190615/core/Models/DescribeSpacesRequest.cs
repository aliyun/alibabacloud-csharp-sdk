// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.MPServerless20190615.Models
{
    public class DescribeSpacesRequest : TeaModel {
        [NameInMap("EmasWorkspaceId")]
        [Validation(Required=false)]
        public long? EmasWorkspaceId { get; set; }

        [NameInMap("PageNum")]
        [Validation(Required=false)]
        public int? PageNum { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("SpaceIds")]
        [Validation(Required=false)]
        public List<string> SpaceIds { get; set; }

        [NameInMap("SpecCode")]
        [Validation(Required=false)]
        public string SpecCode { get; set; }

        [NameInMap("TenantId")]
        [Validation(Required=false)]
        public string TenantId { get; set; }

    }

}
