// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SOFA20190815.Models
{
    public class DescribeSidecarInstancesRequest : TeaModel {
        [NameInMap("AppServiceName")]
        [Validation(Required=false)]
        public string AppServiceName { get; set; }

        [NameInMap("ClusterName")]
        [Validation(Required=false)]
        public string ClusterName { get; set; }

        [NameInMap("Namespace")]
        [Validation(Required=false)]
        public string Namespace { get; set; }

        [NameInMap("PageIndex")]
        [Validation(Required=false)]
        public long? PageIndex { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

        [NameInMap("PodIp")]
        [Validation(Required=false)]
        public string PodIp { get; set; }

        [NameInMap("PodStatus")]
        [Validation(Required=false)]
        public string PodStatus { get; set; }

        [NameInMap("SidecarStatus")]
        [Validation(Required=false)]
        public string SidecarStatus { get; set; }

        [NameInMap("SidecarType")]
        [Validation(Required=false)]
        public string SidecarType { get; set; }

        [NameInMap("SidecarVersion")]
        [Validation(Required=false)]
        public string SidecarVersion { get; set; }

        [NameInMap("SortField")]
        [Validation(Required=false)]
        public string SortField { get; set; }

        [NameInMap("SortOrder")]
        [Validation(Required=false)]
        public string SortOrder { get; set; }

        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

        [NameInMap("WorkspaceName")]
        [Validation(Required=false)]
        public string WorkspaceName { get; set; }

    }

}
