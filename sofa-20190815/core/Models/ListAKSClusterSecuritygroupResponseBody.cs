// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SOFA20190815.Models
{
    public class ListAKSClusterSecuritygroupResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("ResultCode")]
        [Validation(Required=false)]
        public string ResultCode { get; set; }

        [NameInMap("ResultMessage")]
        [Validation(Required=false)]
        public string ResultMessage { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<ListAKSClusterSecuritygroupResponseBodyData> Data { get; set; }
        public class ListAKSClusterSecuritygroupResponseBodyData : TeaModel {
            [NameInMap("IaasProviderId")]
            [Validation(Required=false)]
            public string IaasProviderId { get; set; }

            [NameInMap("Id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("SecuredGroupIdentity")]
            [Validation(Required=false)]
            public string SecuredGroupIdentity { get; set; }

            [NameInMap("SecuredZoneId")]
            [Validation(Required=false)]
            public string SecuredZoneId { get; set; }

            [NameInMap("UtcCreate")]
            [Validation(Required=false)]
            public string UtcCreate { get; set; }

            [NameInMap("UtcModified")]
            [Validation(Required=false)]
            public string UtcModified { get; set; }

        }

    }

}
