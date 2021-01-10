// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SOFA20190815.Models
{
    public class QueryLinkeBahamutVcsmergerequestRequest : TeaModel {
        [NameInMap("MergeRequestId")]
        [Validation(Required=false)]
        public string MergeRequestId { get; set; }

        [NameInMap("PipelineTag")]
        [Validation(Required=false)]
        public string PipelineTag { get; set; }

        [NameInMap("ProjectId")]
        [Validation(Required=false)]
        public string ProjectId { get; set; }

        [NameInMap("TenantId")]
        [Validation(Required=false)]
        public string TenantId { get; set; }

    }

}
