// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SOFA20190815.Models
{
    public class QueryLDCContainerServiceRevisionRequest : TeaModel {
        [NameInMap("DeploymentStatusRepeatList")]
        [Validation(Required=false)]
        public List<string> DeploymentStatusRepeatList { get; set; }

        [NameInMap("MetadataStatusRepeatList")]
        [Validation(Required=false)]
        public List<string> MetadataStatusRepeatList { get; set; }

        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("Namespace")]
        [Validation(Required=false)]
        public string Namespace { get; set; }

        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public long? PageNumber { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

        [NameInMap("WorkspaceGroup")]
        [Validation(Required=false)]
        public string WorkspaceGroup { get; set; }

    }

}
