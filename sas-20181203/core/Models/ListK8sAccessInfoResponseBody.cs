// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class ListK8sAccessInfoResponseBody : TeaModel {
        [NameInMap("K8sAccessInfos")]
        [Validation(Required=false)]
        public List<ListK8sAccessInfoResponseBodyK8sAccessInfos> K8sAccessInfos { get; set; }
        public class ListK8sAccessInfoResponseBodyK8sAccessInfos : TeaModel {
            [NameInMap("AliUid")]
            [Validation(Required=false)]
            public long? AliUid { get; set; }

            [NameInMap("AuditLogStore")]
            [Validation(Required=false)]
            public string AuditLogStore { get; set; }

            [NameInMap("AuditProject")]
            [Validation(Required=false)]
            public string AuditProject { get; set; }

            [NameInMap("AuditRegionId")]
            [Validation(Required=false)]
            public string AuditRegionId { get; set; }

            [NameInMap("ClusterId")]
            [Validation(Required=false)]
            public string ClusterId { get; set; }

            [NameInMap("ClusterName")]
            [Validation(Required=false)]
            public string ClusterName { get; set; }

            [NameInMap("ExpireDate")]
            [Validation(Required=false)]
            public long? ExpireDate { get; set; }

            [NameInMap("GroupId")]
            [Validation(Required=false)]
            public string GroupId { get; set; }

            [NameInMap("GroupName")]
            [Validation(Required=false)]
            public string GroupName { get; set; }

            [NameInMap("Id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            [NameInMap("InstallKey")]
            [Validation(Required=false)]
            public string InstallKey { get; set; }

            [NameInMap("Vendor")]
            [Validation(Required=false)]
            public string Vendor { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
