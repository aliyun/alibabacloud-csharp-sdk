// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class GenerateK8sAccessInfoResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GenerateK8sAccessInfoResponseBodyData Data { get; set; }
        public class GenerateK8sAccessInfoResponseBodyData : TeaModel {
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

            [NameInMap("InstallKey")]
            [Validation(Required=false)]
            public string InstallKey { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
