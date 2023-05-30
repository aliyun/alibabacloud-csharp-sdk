// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudfw20171207.Models
{
    public class DescribeTrFirewallPolicyBackUpAssociationListResponseBody : TeaModel {
        [NameInMap("PolicyAssociationBackupConfigs")]
        [Validation(Required=false)]
        public List<DescribeTrFirewallPolicyBackUpAssociationListResponseBodyPolicyAssociationBackupConfigs> PolicyAssociationBackupConfigs { get; set; }
        public class DescribeTrFirewallPolicyBackUpAssociationListResponseBodyPolicyAssociationBackupConfigs : TeaModel {
            [NameInMap("CandidateId")]
            [Validation(Required=false)]
            public string CandidateId { get; set; }

            [NameInMap("CandidateName")]
            [Validation(Required=false)]
            public string CandidateName { get; set; }

            [NameInMap("CandidateType")]
            [Validation(Required=false)]
            public string CandidateType { get; set; }

            [NameInMap("CurrentRouteTableId")]
            [Validation(Required=false)]
            public string CurrentRouteTableId { get; set; }

            [NameInMap("OriginalRouteTableId")]
            [Validation(Required=false)]
            public string OriginalRouteTableId { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
