// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SOFA20190815.Models
{
    public class CreateLDCUnifiedAccessInstanceRequest : TeaModel {
        [NameInMap("SpannerCluster")]
        [Validation(Required=false)]
        public string SpannerCluster { get; set; }

        [NameInMap("UnifiedAccessInstanceHttpsEntryJsonStr")]
        [Validation(Required=false)]
        public string UnifiedAccessInstanceHttpsEntryJsonStr { get; set; }

        [NameInMap("UnifiedAccessInstanceHttpEntryJsonStr")]
        [Validation(Required=false)]
        public string UnifiedAccessInstanceHttpEntryJsonStr { get; set; }

        [NameInMap("UnifiedAccessInstanceName")]
        [Validation(Required=false)]
        public string UnifiedAccessInstanceName { get; set; }

        [NameInMap("UnifiedAccessInstanceType")]
        [Validation(Required=false)]
        public string UnifiedAccessInstanceType { get; set; }

        [NameInMap("WorkspaceGroup")]
        [Validation(Required=false)]
        public string WorkspaceGroup { get; set; }

    }

}
