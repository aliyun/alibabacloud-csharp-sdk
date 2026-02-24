// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Config20200907.Models
{
    public class ListAggregateDiscoveredResourcesRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the account group.</para>
        /// <para>For more information about how to obtain the ID of an account group, see <a href="https://help.aliyun.com/document_detail/255797.html">ListAggregators</a>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ca-c560626622af0005****</para>
        /// </summary>
        [NameInMap("AggregatorId")]
        [Validation(Required=false)]
        public string AggregatorId { get; set; }

        /// <summary>
        /// <para>The end of the time range to query. This is a standard UTC timestamp. The following limits apply:</para>
        /// <list type="bullet">
        /// <item><description><para>The value must be a timestamp in milliseconds.</para>
        /// </description></item>
        /// <item><description><para>The value cannot be earlier than StartUpdateTimestamp. The interval between StartUpdateTimestamp and EndUpdateTimestamp cannot exceed 30 days.</para>
        /// </description></item>
        /// <item><description><para>You must specify both StartUpdateTimestamp and EndUpdateTimestamp, or leave both empty.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>1724947200000</para>
        /// </summary>
        [NameInMap("EndUpdateTimestamp")]
        [Validation(Required=false)]
        public long? EndUpdateTimestamp { get; set; }

        /// <summary>
        /// <para>The resource types to exclude. Separate multiple resource types with commas (,). This parameter has a higher priority than the ResourceTypes parameter.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ACS::ECS::Instance,ACS::ECS::NetworkInterface</para>
        /// </summary>
        [NameInMap("ExcludeResourceTypes")]
        [Validation(Required=false)]
        public string ExcludeResourceTypes { get; set; }

        /// <summary>
        /// <para>The maximum number of entries to return for a single request. Valid values: 1 to 100.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>If the response is truncated, use the <c>NextToken</c> to retrieve the next page of results.</para>
        /// 
        /// <b>Example:</b>
        /// <para>IWBjqMYSy0is7zSMGu16****</para>
        /// 
        /// <b>if can be null:</b>
        /// <c>false</c>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The ID of the region where the resource resides. Separate multiple region IDs with commas (,).</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-huhehaote</para>
        /// </summary>
        [NameInMap("Regions")]
        [Validation(Required=false)]
        public string Regions { get; set; }

        /// <summary>
        /// <para>The ID of the Alibaba Cloud account to which the resources to be queried belong. The account is a member of the account group.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100931896542****</para>
        /// </summary>
        [NameInMap("ResourceAccountId")]
        [Validation(Required=false)]
        public long? ResourceAccountId { get; set; }

        /// <summary>
        /// <para>The status of the resource. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>0: The resource is deleted. A resource is displayed as Deleted in Cloud Config after it is deleted from the source Alibaba Cloud service.</para>
        /// </description></item>
        /// <item><description><para>1 (Default): The resource is active. A resource is displayed as Active in Cloud Config if it is properly managed.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("ResourceDeleted")]
        [Validation(Required=false)]
        public int? ResourceDeleted { get; set; }

        /// <summary>
        /// <para>The resource ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>eni-hp31cqoba96jagtz****</para>
        /// </summary>
        [NameInMap("ResourceId")]
        [Validation(Required=false)]
        public string ResourceId { get; set; }

        /// <summary>
        /// <para>The resource name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>launch-advisor-20200330</para>
        /// </summary>
        [NameInMap("ResourceName")]
        [Validation(Required=false)]
        public string ResourceName { get; set; }

        /// <term><b>Obsolete</b></term>
        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        [Obsolete]
        public long? ResourceOwnerId { get; set; }

        /// <summary>
        /// <para>The resource type. Separate multiple resource types with commas (,).</para>
        /// 
        /// <b>Example:</b>
        /// <para>ACS::ECS::NetworkInterface</para>
        /// </summary>
        [NameInMap("ResourceTypes")]
        [Validation(Required=false)]
        public string ResourceTypes { get; set; }

        /// <summary>
        /// <para>The start of the time range to query. This is a standard UTC timestamp. The following limits apply:</para>
        /// <list type="bullet">
        /// <item><description><para>The value must be a timestamp in milliseconds.</para>
        /// </description></item>
        /// <item><description><para>The value cannot be later than EndUpdateTimestamp. The interval between StartUpdateTimestamp and EndUpdateTimestamp cannot exceed 30 days.</para>
        /// </description></item>
        /// <item><description><para>You must specify both StartUpdateTimestamp and EndUpdateTimestamp, or leave both empty.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>1722441600000</para>
        /// </summary>
        [NameInMap("StartUpdateTimestamp")]
        [Validation(Required=false)]
        public long? StartUpdateTimestamp { get; set; }

    }

}
