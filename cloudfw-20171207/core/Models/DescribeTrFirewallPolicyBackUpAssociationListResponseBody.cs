// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudfw20171207.Models
{
    public class DescribeTrFirewallPolicyBackUpAssociationListResponseBody : TeaModel {
        /// <summary>
        /// <para>The route tables.</para>
        /// </summary>
        [NameInMap("PolicyAssociationBackupConfigs")]
        [Validation(Required=false)]
        public List<DescribeTrFirewallPolicyBackUpAssociationListResponseBodyPolicyAssociationBackupConfigs> PolicyAssociationBackupConfigs { get; set; }
        public class DescribeTrFirewallPolicyBackUpAssociationListResponseBodyPolicyAssociationBackupConfigs : TeaModel {
            /// <summary>
            /// <para>The ID of the traffic redirection instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>vpc-wz9grb8ng3y7h7lf2****</para>
            /// </summary>
            [NameInMap("CandidateId")]
            [Validation(Required=false)]
            public string CandidateId { get; set; }

            /// <summary>
            /// <para>The name of the traffic redirection instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("CandidateName")]
            [Validation(Required=false)]
            public string CandidateName { get; set; }

            /// <summary>
            /// <para>The type of the traffic redirection instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>VPC</para>
            /// </summary>
            [NameInMap("CandidateType")]
            [Validation(Required=false)]
            public string CandidateType { get; set; }

            /// <summary>
            /// <para>The route table that is used after traffic redirection.</para>
            /// 
            /// <b>Example:</b>
            /// <para>vtb-wz9898grickmh5j09****</para>
            /// </summary>
            [NameInMap("CurrentRouteTableId")]
            [Validation(Required=false)]
            public string CurrentRouteTableId { get; set; }

            /// <summary>
            /// <para>The ID of the route table.</para>
            /// 
            /// <b>Example:</b>
            /// <para>vtb-wz9slp3s7m4qrzvnq****</para>
            /// </summary>
            [NameInMap("OriginalRouteTableId")]
            [Validation(Required=false)]
            public string OriginalRouteTableId { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>C264A756-9B48-57E3-B312-716941E146C6</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
