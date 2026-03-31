// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Config20200907.Models
{
    public class ListDiscoveredResourcesRequest : TeaModel {
        /// <summary>
        /// <para>The end time of the time range for querying resources. The value is a timestamp in the UTC format. When you specify this parameter, take note of the following limits:</para>
        /// <list type="bullet">
        /// <item><description>The value must be a timestamp in milliseconds.</description></item>
        /// <item><description>The value cannot be less than the value of the StartUpdateTimestamp parameter. The interval between the value and the value of the StartUpdateTimestamp parameter must be less than or equal to 30 days.</description></item>
        /// <item><description>The StartUpdateTimestamp and EndUpdateTimestamp parameters must be specified at the same time or left empty at the same time.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>1724947200000</para>
        /// </summary>
        [NameInMap("EndUpdateTimestamp")]
        [Validation(Required=false)]
        public long? EndUpdateTimestamp { get; set; }

        /// <summary>
        /// <para>The types of resources that are excluded. Separate multiple values with commas (,). If this parameter conflicts with the ResourceTypes parameter, this parameter prevails.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ACS::ECS::Instance,ACS::ECS::NetworkInterface</para>
        /// </summary>
        [NameInMap("ExcludeResourceTypes")]
        [Validation(Required=false)]
        public string ExcludeResourceTypes { get; set; }

        /// <summary>
        /// <para>The maximum number of entries returned for a single request. Valid values: 1 to 100.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// 
        /// <b>if can be null:</b>
        /// <c>true</c>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>The <c>token</c> that you want to use to initiate the current request. If the response of the previous request is truncated, you can use this token to initiate another request and obtain the remaining entries.</para>
        /// 
        /// <b>Example:</b>
        /// <para>IWBjqMYSy0is7zSMGu16****</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The ID of the region where the resource resides. Separate multiple region IDs with commas (,).</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("Regions")]
        [Validation(Required=false)]
        public string Regions { get; set; }

        /// <summary>
        /// <para>The status of the resource. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>0: The resource is deleted. If a resource is deleted from the desired cloud service, <b>Deleted</b> is displayed in the resource list in the Cloud Config console.</description></item>
        /// <item><description>1 (default): The resource is retained. If a resource is managed as expected, <b>Active</b> is displayed in the resource list in the Cloud Config console.</description></item>
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

        [NameInMap("ResourceName")]
        [Validation(Required=false)]
        public string ResourceName { get; set; }

        /// <summary>
        /// <para>The type of the resource. Separate multiple resource types with commas (,).</para>
        /// 
        /// <b>Example:</b>
        /// <para>ACS::ECS::NetworkInterface</para>
        /// </summary>
        [NameInMap("ResourceTypes")]
        [Validation(Required=false)]
        public string ResourceTypes { get; set; }

        /// <summary>
        /// <para>The start time of the time range for querying resources. The value is a timestamp in the UTC format. When you specify this parameter, take note of the following limits:</para>
        /// <list type="bullet">
        /// <item><description>The value must be a timestamp in milliseconds.</description></item>
        /// <item><description>The value cannot be greater than the value of the EndUpdateTimestamp parameter. The interval between the value and the value of the EndUpdateTimestamp parameter must be less than or equal to 30 days.</description></item>
        /// <item><description>The StartUpdateTimestamp and EndUpdateTimestamp parameters must be specified at the same time or left blank at the same time.</description></item>
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
