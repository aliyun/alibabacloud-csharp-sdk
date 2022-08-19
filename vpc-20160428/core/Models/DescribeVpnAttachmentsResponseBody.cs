// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class DescribeVpnAttachmentsResponseBody : TeaModel {
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

        [NameInMap("VpnAttachments")]
        [Validation(Required=false)]
        public List<DescribeVpnAttachmentsResponseBodyVpnAttachments> VpnAttachments { get; set; }
        public class DescribeVpnAttachmentsResponseBodyVpnAttachments : TeaModel {
            [NameInMap("AttachType")]
            [Validation(Required=false)]
            public string AttachType { get; set; }

            [NameInMap("CrossAccountAuthorized")]
            [Validation(Required=false)]
            public bool? CrossAccountAuthorized { get; set; }

            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("TransitRouterId")]
            [Validation(Required=false)]
            public string TransitRouterId { get; set; }

            [NameInMap("TransitRouterName")]
            [Validation(Required=false)]
            public string TransitRouterName { get; set; }

        }

    }

}
