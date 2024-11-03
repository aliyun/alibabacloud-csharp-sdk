// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cdn20180510.Models
{
    public class ChangeCdnDomainToDcdnResponseBody : TeaModel {
        /// <summary>
        /// <para>The content of the migration instructions.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{
        ///         &quot;The_domain_name_quota_for_the_target_account_has_reached_the_upper_limit&quot;: true,
        ///         &quot;Domain_name_requires_node2_architecture_to_be_enabled&quot;: true,
        ///         &quot;Internal_customer_domain_name_migration_prohibited&quot;: true,
        ///         &quot;Prohibit_the_migration_of_important_customer_domain_names&quot;: true,
        ///         &quot;Protected_domain_names_are_prohibited_from_migration&quot;: true,
        ///         &quot;Domain_names_accessed_through_TopDomain_are_prohibited_from_migration&quot;: true,
        ///         &quot;Prohibit_migration_of_customer_domain_names_for_integrated_access&quot;: true
        ///     }</para>
        /// </summary>
        [NameInMap("Content")]
        [Validation(Required=false)]
        public Dictionary<string, object> Content { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>E6172599-7DA7-5471-9D22-359A4E0C9B94</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
