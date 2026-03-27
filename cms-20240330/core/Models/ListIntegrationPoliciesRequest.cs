// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20240330.Models
{
    public class ListIntegrationPoliciesRequest : TeaModel {
        /// <summary>
        /// <para>Addon name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cs-default</para>
        /// </summary>
        [NameInMap("addonName")]
        [Validation(Required=false)]
        public string AddonName { get; set; }

        /// <summary>
        /// <para>Bound resource ID</para>
        /// 
        /// <b>Example:</b>
        /// <para>622d27c2e87d49debceeebc7c642610e</para>
        /// </summary>
        [NameInMap("bindResourceId")]
        [Validation(Required=false)]
        public string BindResourceId { get; set; }

        /// <summary>
        /// <para>Filter for entity IDs, separated by commas</para>
        /// 
        /// <b>Example:</b>
        /// <para>eg-1,eg-2,eg-3</para>
        /// </summary>
        [NameInMap("entityGroupIds")]
        [Validation(Required=false)]
        public string EntityGroupIds { get; set; }

        /// <summary>
        /// <para>Used for Region query, separated by commas</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-beijing,cn-hangzhou</para>
        /// </summary>
        [NameInMap("filterRegionIds")]
        [Validation(Required=false)]
        public string FilterRegionIds { get; set; }

        /// <summary>
        /// <para>Maximum number of results to return. Default is 30, with a maximum of 100.</para>
        /// 
        /// <b>Example:</b>
        /// <para>30</para>
        /// </summary>
        [NameInMap("maxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>Used to return more results. This parameter is not required for the first query. For subsequent queries, use the Token obtained from the response.</para>
        /// 
        /// <b>Example:</b>
        /// <para>mvnX6zqg3P</para>
        /// </summary>
        [NameInMap("nextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>Policy ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>policy-93817a401f78435596d745a97d2e85a1</para>
        /// </summary>
        [NameInMap("policyId")]
        [Validation(Required=false)]
        public string PolicyId { get; set; }

        /// <summary>
        /// <para>Rule name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>prod-database</para>
        /// </summary>
        [NameInMap("policyName")]
        [Validation(Required=false)]
        public string PolicyName { get; set; }

        /// <summary>
        /// <para>Policy type</para>
        /// 
        /// <b>Example:</b>
        /// <para>CS</para>
        /// </summary>
        [NameInMap("policyType")]
        [Validation(Required=false)]
        public string PolicyType { get; set; }

        /// <summary>
        /// <para>Instance ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cmee-622d27c2e87d49debceeebc7c642610e</para>
        /// </summary>
        [NameInMap("prometheusInstanceId")]
        [Validation(Required=false)]
        public string PrometheusInstanceId { get; set; }

        /// <summary>
        /// <para>Used for general queries</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("query")]
        [Validation(Required=false)]
        public string Query { get; set; }

        /// <summary>
        /// <para>Resource group ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg-xxxxx</para>
        /// </summary>
        [NameInMap("resourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// <para>Tag list.</para>
        /// </summary>
        [NameInMap("tag")]
        [Validation(Required=false)]
        public List<ListIntegrationPoliciesRequestTag> Tag { get; set; }
        public class ListIntegrationPoliciesRequestTag : TeaModel {
            /// <summary>
            /// <para>Tag key</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>Tag value</para>
            /// 
            /// <b>Example:</b>
            /// <para>value</para>
            /// </summary>
            [NameInMap("value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// <para>Workspace.</para>
        /// 
        /// <b>Example:</b>
        /// <para>demo</para>
        /// </summary>
        [NameInMap("workspace")]
        [Validation(Required=false)]
        public string Workspace { get; set; }

    }

}
