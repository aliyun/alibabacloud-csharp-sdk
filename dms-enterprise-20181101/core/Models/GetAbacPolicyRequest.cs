// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms_enterprise20181101.Models
{
    public class GetAbacPolicyRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the policy.</para>
        /// 
        /// <b>Example:</b>
        /// <para>12****</para>
        /// </summary>
        [NameInMap("AbacPolicyId")]
        [Validation(Required=false)]
        public long? AbacPolicyId { get; set; }

        /// <summary>
        /// <para>The name of the policy.</para>
        /// 
        /// <b>Example:</b>
        /// <para>policy_test</para>
        /// </summary>
        [NameInMap("AbacPolicyName")]
        [Validation(Required=false)]
        public string AbacPolicyName { get; set; }

        /// <summary>
        /// <para>The ID of the tenant.</para>
        /// <remarks>
        /// <para>To view the ID of the tenant, go to the Data Management (DMS) console and move the pointer over the profile picture in the upper-right corner. For more information, see the <a href="https://help.aliyun.com/document_detail/181330.html">View information about the current tenant</a> section of the &quot;Manage DMS tenants&quot; topic.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>3***</para>
        /// </summary>
        [NameInMap("Tid")]
        [Validation(Required=false)]
        public long? Tid { get; set; }

    }

}
