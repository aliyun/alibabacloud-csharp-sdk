// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudfw20171207.Models
{
    public class DescribeTrFirewallPolicyBackUpAssociationListResponseBody : TeaModel {
        /// <summary>
        /// The route tables.
        /// </summary>
        [NameInMap("PolicyAssociationBackupConfigs")]
        [Validation(Required=false)]
        public List<DescribeTrFirewallPolicyBackUpAssociationListResponseBodyPolicyAssociationBackupConfigs> PolicyAssociationBackupConfigs { get; set; }
        public class DescribeTrFirewallPolicyBackUpAssociationListResponseBodyPolicyAssociationBackupConfigs : TeaModel {
            /// <summary>
            /// The ID of the traffic redirection instance.
            /// </summary>
            [NameInMap("CandidateId")]
            [Validation(Required=false)]
            public string CandidateId { get; set; }

            /// <summary>
            /// The name of the traffic redirection instance.
            /// </summary>
            [NameInMap("CandidateName")]
            [Validation(Required=false)]
            public string CandidateName { get; set; }

            /// <summary>
            /// The type of the traffic redirection instance.
            /// </summary>
            [NameInMap("CandidateType")]
            [Validation(Required=false)]
            public string CandidateType { get; set; }

            /// <summary>
            /// The route table that is used after traffic redirection.
            /// </summary>
            [NameInMap("CurrentRouteTableId")]
            [Validation(Required=false)]
            public string CurrentRouteTableId { get; set; }

            /// <summary>
            /// The ID of the route table.
            /// </summary>
            [NameInMap("OriginalRouteTableId")]
            [Validation(Required=false)]
            public string OriginalRouteTableId { get; set; }

        }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
