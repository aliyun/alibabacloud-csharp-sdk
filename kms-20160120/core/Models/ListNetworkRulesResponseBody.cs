// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Kms20160120.Models
{
    public class ListNetworkRulesResponseBody : TeaModel {
        /// <summary>
        /// <para>A list of access control rules.</para>
        /// </summary>
        [NameInMap("NetworkRules")]
        [Validation(Required=false)]
        public ListNetworkRulesResponseBodyNetworkRules NetworkRules { get; set; }
        public class ListNetworkRulesResponseBodyNetworkRules : TeaModel {
            [NameInMap("NetworkRule")]
            [Validation(Required=false)]
            public List<ListNetworkRulesResponseBodyNetworkRulesNetworkRule> NetworkRule { get; set; }
            public class ListNetworkRulesResponseBodyNetworkRulesNetworkRule : TeaModel {
                /// <summary>
                /// <para>The name of the access control rule.</para>
                /// 
                /// <b>Example:</b>
                /// <para>networkrule_test</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>The network type. The value is fixed as Private. Self-managed applications can access KMS instances only over a private virtual private cloud (VPC).</para>
                /// 
                /// <b>Example:</b>
                /// <para>Private</para>
                /// </summary>
                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

        }

        /// <summary>
        /// <para>The page number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The ID of the request, which is used to locate and troubleshoot issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3bf02f7a-015b-4f34-be0f-cc043fda2d33</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of entries returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
