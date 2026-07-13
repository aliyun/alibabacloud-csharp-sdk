// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BDRC20230808.Models
{
    public class ListProtectionPoliciesRequest : TeaModel {
        /// <summary>
        /// <para>The maximum number of results to return.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>The paging token.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cae**********699</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The protection policy ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>p-123***7890</para>
        /// </summary>
        [NameInMap("ProtectionPolicyId")]
        [Validation(Required=false)]
        public string ProtectionPolicyId { get; set; }

        /// <summary>
        /// <para>The region ID of the protection policy.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("ProtectionPolicyRegionId")]
        [Validation(Required=false)]
        public string ProtectionPolicyRegionId { get; set; }

    }

}
