// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Config20200907.Models
{
    public class ListDiscoveredResourcesRequest : TeaModel {
        /// <summary>
        /// <para>The end of the time range to query resources, specified as a UNIX timestamp in milliseconds. Note:</para>
        /// <list type="bullet">
        /// <item><description><para>The value cannot be earlier than StartUpdateTimestamp.</para>
        /// </description></item>
        /// <item><description><para>The time interval between StartUpdateTimestamp and EndUpdateTimestamp cannot exceed 30 days.</para>
        /// </description></item>
        /// <item><description><para>Specify both StartUpdateTimestamp and EndUpdateTimestamp, or leave both blank.</para>
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
        /// <para>The resource types to exclude. Separate multiple resource types with commas (,). This parameter takes precedence over the ResourceTypes parameter.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ACS::ECS::Instance,ACS::ECS::NetworkInterface</para>
        /// </summary>
        [NameInMap("ExcludeResourceTypes")]
        [Validation(Required=false)]
        public string ExcludeResourceTypes { get; set; }

        /// <summary>
        /// <para>The maximum number of entries to return on each page. Valid values: 1 to 100.</para>
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
        /// <para>A pagination token. If the response is truncated, use this token in a subsequent request to retrieve the next page of results.</para>
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
        /// <item><description><para>0: The resource is deleted. If you delete a resource in the corresponding Alibaba Cloud service, Cloud Config displays the resource as <b>Deleted</b>.</para>
        /// </description></item>
        /// <item><description><para>1 (Default): The resource is active. If a resource is managed, Cloud Config displays the resource as <b>Active</b>.</para>
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
        /// <para>test-resource-name</para>
        /// </summary>
        [NameInMap("ResourceName")]
        [Validation(Required=false)]
        public string ResourceName { get; set; }

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
        /// <para>The start of the time range to query resources, specified as a UNIX timestamp in milliseconds. Note:</para>
        /// <list type="bullet">
        /// <item><description><para>The value cannot be later than EndUpdateTimestamp.</para>
        /// </description></item>
        /// <item><description><para>The time interval between StartUpdateTimestamp and EndUpdateTimestamp cannot exceed 30 days.</para>
        /// </description></item>
        /// <item><description><para>Specify both StartUpdateTimestamp and EndUpdateTimestamp, or leave both blank.</para>
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
