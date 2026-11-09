// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Wss20211221.Models
{
    public class DescribeRunIdDeductionsRequest : TeaModel {
        /// <summary>
        /// <para>The agent type. Valid values: CREDIT_PACKAGE, JVS_CLAW, OPEN_CLAW, and JVS_COPILOT.</para>
        /// 
        /// <b>Example:</b>
        /// <para>JVSCopilot、JVSClaw、OpenClaw</para>
        /// </summary>
        [NameInMap("AgentType")]
        [Validation(Required=false)]
        public string AgentType { get; set; }

        /// <summary>
        /// <para>The list of agent types.</para>
        /// </summary>
        [NameInMap("AgentTypes")]
        [Validation(Required=false)]
        public List<string> AgentTypes { get; set; }

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
        /// <para>The consumption WyId.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2892766fb8521756</para>
        /// </summary>
        [NameInMap("ConsumeWyId")]
        [Validation(Required=false)]
        public string ConsumeWyId { get; set; }

        /// <summary>
        /// <para>The Wuying user IDs. You can obtain the IDs by calling the GetLoginToken logon operation. The returned parameter is WyId.</para>
        /// </summary>
        [NameInMap("ConsumeWyIds")]
        [Validation(Required=false)]
        public List<string> ConsumeWyIds { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>uuid</para>
        /// </summary>
        [NameInMap("DeductionRequestId")]
        [Validation(Required=false)]
        public string DeductionRequestId { get; set; }

        /// <summary>
        /// <para>The deduction types. Do not specify this parameter for non-knowledge base scenarios.</para>
        /// </summary>
        [NameInMap("DeductionTypes")]
        [Validation(Required=false)]
        public List<string> DeductionTypes { get; set; }

        /// <summary>
        /// <para>The end time of the query. The value is a UNIX timestamp in milliseconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1785205179000</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public long? EndTime { get; set; }

        /// <summary>
        /// <para>The list of additional grouping fields when aggregating by runId, such as model to distinguish between different models.</para>
        /// </summary>
        [NameInMap("GroupByFields")]
        [Validation(Required=false)]
        public List<string> GroupByFields { get; set; }

        /// <summary>
        /// <para>The list of grouped resource types.</para>
        /// </summary>
        [NameInMap("GroupResourceTypes")]
        [Validation(Required=false)]
        public List<string> GroupResourceTypes { get; set; }

        /// <summary>
        /// <para>Specifies whether to group the results by deduction type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("GroupSeparator")]
        [Validation(Required=false)]
        public bool? GroupSeparator { get; set; }

        /// <summary>
        /// <para>The instance ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>mdp-0c62ayep0nk4v****</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

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
        /// <para>The list of cloud computer IDs. If this field is specified, the PackageIds field is required.</para>
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
        /// <para>The model name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>qwen-3.8</para>
        /// </summary>
        [NameInMap("Model")]
        [Validation(Required=false)]
        public string Model { get; set; }

        /// <summary>
        /// <para>The pagination token. Leave this parameter empty for the first request. For subsequent requests, use the nextToken value returned in the previous response.</para>
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
        /// <para>The current page number. Default value: 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNum")]
        [Validation(Required=false)]
        public int? PageNum { get; set; }

        /// <summary>
        /// <para>The Settings for the number of entries per page during paging in a paged query.</para>
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
        /// <para>Enterprise Edition: CreditPackage, Business Edition: BusinessCreditPackage</para>
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
        /// <para>The run ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>t-xxx</para>
        /// </summary>
        [NameInMap("RunId")]
        [Validation(Required=false)]
        public string RunId { get; set; }

        /// <summary>
        /// <para>The list of run IDs.</para>
        /// </summary>
        [NameInMap("RunIdList")]
        [Validation(Required=false)]
        public List<string> RunIdList { get; set; }

        /// <summary>
        /// <para>The start time of the query. The value is a UNIX timestamp in milliseconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1785205179000</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public long? StartTime { get; set; }

        /// <summary>
        /// <para>The globally unique ID of the Wuying user.</para>
        /// 
        /// <b>Example:</b>
        /// <para>wy-123456****</para>
        /// </summary>
        [NameInMap("WyId")]
        [Validation(Required=false)]
        public string WyId { get; set; }

    }

}
