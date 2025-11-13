// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class ListCheckPoliciesResponseBody : TeaModel {
        /// <summary>
        /// <para>Paging information for the query results.</para>
        /// </summary>
        [NameInMap("PageInfo")]
        [Validation(Required=false)]
        public ListCheckPoliciesResponseBodyPageInfo PageInfo { get; set; }
        public class ListCheckPoliciesResponseBodyPageInfo : TeaModel {
            /// <summary>
            /// <para>分页查询时，当前页显示的数据条数。</para>
            /// 
            /// <b>Example:</b>
            /// <para>20</para>
            /// </summary>
            [NameInMap("Count")]
            [Validation(Required=false)]
            public string Count { get; set; }

            /// <summary>
            /// <para>The current page number displayed in the result.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("CurrentPage")]
            [Validation(Required=false)]
            public int? CurrentPage { get; set; }

            /// <summary>
            /// <para>The maximum number of data entries per page when performing a paginated query.</para>
            /// 
            /// <b>Example:</b>
            /// <para>20</para>
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            /// <summary>
            /// <para>The total number of policies queried.</para>
            /// 
            /// <b>Example:</b>
            /// <para>69</para>
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

        }

        /// <summary>
        /// <para>List of policies.</para>
        /// </summary>
        [NameInMap("Policies")]
        [Validation(Required=false)]
        public List<ListCheckPoliciesResponseBodyPolicies> Policies { get; set; }
        public class ListCheckPoliciesResponseBodyPolicies : TeaModel {
            /// <summary>
            /// <para>Source type of the security check item:</para>
            /// <list type="bullet">
            /// <item><description><b>CUSTOM</b>: User-defined</description></item>
            /// <item><description><b>SYSTEM</b>: Predefined by the security platform</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>CUSTOM</para>
            /// </summary>
            [NameInMap("CheckType")]
            [Validation(Required=false)]
            public string CheckType { get; set; }

            /// <summary>
            /// <para>The ID of the associated higher-level policy.</para>
            /// <para>(The specific dependency relationship, from low to high, is Section -&gt; Requirement -&gt; Standard)</para>
            /// 
            /// <b>Example:</b>
            /// <para>100000000002</para>
            /// </summary>
            [NameInMap("DependentPolicyId")]
            [Validation(Required=false)]
            public long? DependentPolicyId { get; set; }

            /// <summary>
            /// <para>Policy ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100000000001</para>
            /// </summary>
            [NameInMap("PolicyId")]
            [Validation(Required=false)]
            public long? PolicyId { get; set; }

            /// <summary>
            /// <para>Name of the custom policy.</para>
            /// 
            /// <b>Example:</b>
            /// <para>testPolicyName</para>
            /// </summary>
            [NameInMap("PolicyShowName")]
            [Validation(Required=false)]
            public string PolicyShowName { get; set; }

            /// <summary>
            /// <para>Policy type of the custom check item rule:</para>
            /// <list type="bullet">
            /// <item><description><b>STANDARD</b>: Standard policy type</description></item>
            /// <item><description><b>REQUIREMENT</b>: Requirement policy type</description></item>
            /// <item><description><b>SECTION</b>: Section policy type</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>STANDARD</para>
            /// </summary>
            [NameInMap("PolicyType")]
            [Validation(Required=false)]
            public string PolicyType { get; set; }

            /// <summary>
            /// <para>关联的策略大类的名称（PolicyType取值为STANDARD时为必填）：</para>
            /// <list type="bullet">
            /// <item><description><b>AISPM</b>：AI配置管理（AI-SPM）</description></item>
            /// <item><description><b>KISPM</b>：Kubernetes配置管理(KSPM)</description></item>
            /// <item><description><b>IDENTITY_PERMISSION</b>：身份权限管理(CIEM)</description></item>
            /// <item><description><b>RISK</b>：安全风险</description></item>
            /// <item><description><b>COMPLIANCE</b>：合规风险</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>AISPM</para>
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        /// <summary>
        /// <para>ID of the current call request, generated by Alibaba Cloud as a unique identifier for the request, which can be used for troubleshooting and problem localization.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ADE57832-9666-511C-9A80-B87DE2E8****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
