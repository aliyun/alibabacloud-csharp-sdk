// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eds_user20210308.Models
{
    public class DescribeResourceGroupsRequest : TeaModel {
        [NameInMap("AgentType")]
        [Validation(Required=false)]
        public string AgentType { get; set; }

        /// <summary>
        /// <para>The cloud platform resource group ID.</para>
        /// </summary>
        [NameInMap("AliyunResourceGroupIds")]
        [Validation(Required=false)]
        public List<string> AliyunResourceGroupIds { get; set; }

        /// <summary>
        /// <para>The channel tag.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ENTERPRISE</para>
        /// </summary>
        [NameInMap("BusinessChannel")]
        [Validation(Required=false)]
        public string BusinessChannel { get; set; }

        /// <summary>
        /// <remarks>
        /// <para>This parameter is not publicly available.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("NeedContainResourceGroupWithOfficeSite")]
        [Validation(Required=false)]
        public long? NeedContainResourceGroupWithOfficeSite { get; set; }

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
        /// <para>20</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <remarks>
        /// <para>Fixed value: AliyunConsole.</para>
        /// <list type="bullet">
        /// <item><description>For Elastic Desktop Service Enterprise Edition, set this parameter to AliyunConsole. Other platforms are not publicly available.</description></item>
        /// </list>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>AliyunConsole</para>
        /// </summary>
        [NameInMap("Platform")]
        [Validation(Required=false)]
        public string Platform { get; set; }

        [NameInMap("ResourceClassification")]
        [Validation(Required=false)]
        public string ResourceClassification { get; set; }

        /// <summary>
        /// <para>The list of resource group IDs.</para>
        /// </summary>
        [NameInMap("ResourceGroupIds")]
        [Validation(Required=false)]
        public List<string> ResourceGroupIds { get; set; }

        /// <summary>
        /// <para>The name of the resource group.</para>
        /// 
        /// <b>Example:</b>
        /// <para>部门A资源组</para>
        /// </summary>
        [NameInMap("ResourceGroupName")]
        [Validation(Required=false)]
        public string ResourceGroupName { get; set; }

    }

}
