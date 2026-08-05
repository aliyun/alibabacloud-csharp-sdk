// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Wss20211221.Models
{
    public class DescribeRunIdDeductionsRequest : TeaModel {
        /// <summary>
        /// <para>The agent type. Valid values: <c>CREDIT_PACKAGE</c>, <c>JVS_CLAW</c>, <c>OPEN_CLAW</c>, and <c>JVS_COPILOT</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>JVSCopilot、JVSClaw、OpenClaw</para>
        /// </summary>
        [NameInMap("AgentType")]
        [Validation(Required=false)]
        public string AgentType { get; set; }

        /// <summary>
        /// <para>The Alibaba Cloud UID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1457450820614624</para>
        /// </summary>
        [NameInMap("AliUid")]
        [Validation(Required=false)]
        public long? AliUid { get; set; }

        /// <summary>
        /// <para>The business type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ENTERPRISE、BUSINESS</para>
        /// </summary>
        [NameInMap("BizType")]
        [Validation(Required=false)]
        public string BizType { get; set; }

        /// <summary>
        /// <para>The deduction type. Do not specify this parameter for non-knowledge base scenarios.</para>
        /// </summary>
        [NameInMap("DeductionTypes")]
        [Validation(Required=false)]
        public List<string> DeductionTypes { get; set; }

        /// <summary>
        /// <para>The end time of the period.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Millisecond timestamp: 1785205179000</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public long? EndTime { get; set; }

        /// <summary>
        /// <para>Specifies whether to group results by deduction type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("GroupSeparator")]
        [Validation(Required=false)]
        public bool? GroupSeparator { get; set; }

        /// <summary>
        /// <para>The instance ID type. Do not specify this parameter for non-knowledge base scenarios.</para>
        /// 
        /// <b>Example:</b>
        /// <para>KnowledgeSpaceId、AgentId</para>
        /// </summary>
        [NameInMap("InstanceIdType")]
        [Validation(Required=false)]
        public string InstanceIdType { get; set; }

        /// <summary>
        /// <para>The list of cloud computer IDs. If this field has a value, the <c>PackageIds</c> field is required.</para>
        /// </summary>
        [NameInMap("InstanceIds")]
        [Validation(Required=false)]
        public List<string> InstanceIds { get; set; }

        /// <summary>
        /// <para>The number of entries per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>The pagination token. Leave this parameter empty for the first request. For subsequent requests, use the <c>nextToken</c> value from the previous response.</para>
        /// 
        /// <b>Example:</b>
        /// <para>eyJvZmZzZXQiOjIwfQ==</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The list of core-hour package IDs in JSON format.</para>
        /// </summary>
        [NameInMap("PackageIds")]
        [Validation(Required=false)]
        public List<string> PackageIds { get; set; }

        /// <summary>
        /// <para>The page number. Default value: 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNum")]
        [Validation(Required=false)]
        public int? PageNum { get; set; }

        /// <summary>
        /// <para>The number of entries per page for a paged query.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The resource type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Enterprise Edition: CreditPackage, Commercial Edition: BusinessCreditPackage</para>
        /// </summary>
        [NameInMap("ResourceType")]
        [Validation(Required=false)]
        public string ResourceType { get; set; }

        /// <summary>
        /// <para>The list of resource types in JSON array format.</para>
        /// </summary>
        [NameInMap("ResourceTypes")]
        [Validation(Required=false)]
        public List<string> ResourceTypes { get; set; }

        /// <summary>
        /// <para>The start time.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Millisecond timestamp: 1785205179000</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public long? StartTime { get; set; }

    }

}
