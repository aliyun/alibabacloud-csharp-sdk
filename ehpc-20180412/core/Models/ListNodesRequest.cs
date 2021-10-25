// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EHPC20180412.Models
{
    public class ListNodesRequest : TeaModel {
        [NameInMap("ClusterId")]
        [Validation(Required=false)]
        public string ClusterId { get; set; }

        [NameInMap("Role")]
        [Validation(Required=false)]
        public string Role { get; set; }

        [NameInMap("HostName")]
        [Validation(Required=false)]
        public string HostName { get; set; }

        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("Sequence")]
        [Validation(Required=false)]
        public string Sequence { get; set; }

        [NameInMap("SortBy")]
        [Validation(Required=false)]
        public string SortBy { get; set; }

        [NameInMap("Filter")]
        [Validation(Required=false)]
        public string Filter { get; set; }

        [NameInMap("PrivateIpAddress")]
        [Validation(Required=false)]
        public string PrivateIpAddress { get; set; }

        [NameInMap("HostNamePrefix")]
        [Validation(Required=false)]
        public string HostNamePrefix { get; set; }

        [NameInMap("HostNameSuffix")]
        [Validation(Required=false)]
        public string HostNameSuffix { get; set; }

    }

}
