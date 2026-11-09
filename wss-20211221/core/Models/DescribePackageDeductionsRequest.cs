// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Wss20211221.Models
{
    public class DescribePackageDeductionsRequest : TeaModel {
        /// <summary>
        /// <para>The agent type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>OpenClaw</para>
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
        /// <para>The business type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ENTERPRISE、BUSINESS</para>
        /// </summary>
        [NameInMap("BizType")]
        [Validation(Required=false)]
        public string BizType { get; set; }

        /// <summary>
        /// <para>The WUYING user ID. You can obtain it by calling the GetLoginToken operation. The response parameter is WyId.</para>
        /// 
        /// <b>Example:</b>
        /// <para>fb4dc579c48ffbea</para>
        /// </summary>
        [NameInMap("ConsumeWyId")]
        [Validation(Required=false)]
        public string ConsumeWyId { get; set; }

        /// <summary>
        /// <para>The WUYING user ID. You can obtain it by calling the GetLoginToken operation. The response parameter is WyId.</para>
        /// </summary>
        [NameInMap("ConsumeWyIds")]
        [Validation(Required=false)]
        public List<string> ConsumeWyIds { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>UUID</para>
        /// </summary>
        [NameInMap("DeductionRequestId")]
        [Validation(Required=false)]
        public string DeductionRequestId { get; set; }

        /// <summary>
        /// <para>The deduction types.</para>
        /// </summary>
        [NameInMap("DeductionTypes")]
        [Validation(Required=false)]
        public List<string> DeductionTypes { get; set; }

        /// <summary>
        /// <para>The end time of the query. The time is a UNIX timestamp in milliseconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1709117383000</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public long? EndTime { get; set; }

        /// <summary>
        /// <para>The list of resource group types.</para>
        /// </summary>
        [NameInMap("GroupResourceTypes")]
        [Validation(Required=false)]
        public List<string> GroupResourceTypes { get; set; }

        /// <summary>
        /// <para>The instance ID, such as ecd-xxx.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ecd-xxx</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The instance ID type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ecd-xxx</para>
        /// </summary>
        [NameInMap("InstanceIdType")]
        [Validation(Required=false)]
        public string InstanceIdType { get; set; }

        /// <summary>
        /// <para>The list of Cloud Desktop IDs. If this field is specified, the PackageIds field is required.</para>
        /// </summary>
        [NameInMap("InstanceIds")]
        [Validation(Required=false)]
        public List<string> InstanceIds { get; set; }

        /// <summary>
        /// <para>The model name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>happyhorse-1.1</para>
        /// </summary>
        [NameInMap("Model")]
        [Validation(Required=false)]
        public string Model { get; set; }

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
        /// <para>The paging Settings for the number of entries to return on each page in a paged query. Maximum value: 100.</para>
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
        /// <para>Desktop</para>
        /// </summary>
        [NameInMap("ResourceType")]
        [Validation(Required=false)]
        public string ResourceType { get; set; }

        /// <summary>
        /// <para>The array of resource types.</para>
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
        /// <para>The start time of the query. The time is a UNIX timestamp in milliseconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1709117383000</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public long? StartTime { get; set; }

        /// <summary>
        /// <para>The WUYING user ID. You can obtain it by calling the GetLoginToken operation. The response parameter is WyId.</para>
        /// 
        /// <b>Example:</b>
        /// <para>fb4dc579c48ffbea</para>
        /// </summary>
        [NameInMap("WyId")]
        [Validation(Required=false)]
        public string WyId { get; set; }

    }

}
