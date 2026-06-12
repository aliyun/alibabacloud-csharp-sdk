// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ComputeNest20210601.Models
{
    public class ListServiceInstanceResourcesRequest : TeaModel {
        /// <summary>
        /// <para>The filter conditions. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>ExpireTimeStart: The start of the time range to query the expiration time of subscription resources.</para>
        /// <remarks>
        /// <para>Notice: This parameter applies only to service instances in private deployments.</para>
        /// </remarks>
        /// </description></item>
        /// <item><description><para>ExpireTimeEnd: The end of the time range to query the expiration time of subscription resources.</para>
        /// <remarks>
        /// <para>Notice: This parameter applies only to service instances in private deployments.</para>
        /// </remarks>
        /// </description></item>
        /// <item><description><para>PayType: The billing method.&gt;Notice:  This parameter applies only to service instances in private deployments.
        /// Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>Subscription: subscription.</para>
        /// </description></item>
        /// <item><description><para>PayAsYouGo: pay-as-you-go.</para>
        /// </description></item>
        /// </list>
        /// </description></item>
        /// <item><description><para>ResourceARN: The Alibaba Cloud Resource Name (ARN) of the resource.</para>
        /// </description></item>
        /// </list>
        /// <para>resource name (ARN).</para>
        /// </summary>
        [NameInMap("Filters")]
        [Validation(Required=false)]
        public List<ListServiceInstanceResourcesRequestFilters> Filters { get; set; }
        public class ListServiceInstanceResourcesRequestFilters : TeaModel {
            /// <summary>
            /// <para>The name of the filter. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>ExpireTimeStart</para>
            /// </description></item>
            /// <item><description><para>ExpireTimeEnd</para>
            /// </description></item>
            /// <item><description><para>PayType</para>
            /// </description></item>
            /// <item><description><para>ResourceARN</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>ExpireTimeStart</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The filter condition values.</para>
            /// </summary>
            [NameInMap("Values")]
            [Validation(Required=false)]
            public List<string> Values { get; set; }

        }

        /// <summary>
        /// <para>The number of entries to return on each page. Maximum value: 100. Default value: 20.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>The token that is used to retrieve the next page of results. Set this to the NextToken value from a previous API call.</para>
        /// 
        /// <b>Example:</b>
        /// <para>AAAAAc3HCuYhJi/wvpk4xOr0VLbAx7BkQzyYC+ONO+WudHGKEdB0uWSY7AGnM3qCgm/Ynge7zU6NWdbj0Tegyajyqyc=</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The region ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The ID of the service instance.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>si-d8a0cc2a1ee04dce****</para>
        /// </summary>
        [NameInMap("ServiceInstanceId")]
        [Validation(Required=false)]
        public string ServiceInstanceId { get; set; }

        /// <summary>
        /// <para>The resource type of the service instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>AliyunResource: an Alibaba Cloud resource.</para>
        /// </description></item>
        /// <item><description><para>ContainerResource: a container group (pod) resource.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>AliyunResource</para>
        /// </summary>
        [NameInMap("ServiceInstanceResourceType")]
        [Validation(Required=false)]
        public string ServiceInstanceResourceType { get; set; }

        /// <summary>
        /// <para>The resource tags.</para>
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<ListServiceInstanceResourcesRequestTag> Tag { get; set; }
        public class ListServiceInstanceResourcesRequestTag : TeaModel {
            /// <summary>
            /// <para>The key of the resource tag.</para>
            /// 
            /// <b>Example:</b>
            /// <para>key1</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The value of the resource tag.</para>
            /// 
            /// <b>Example:</b>
            /// <para>value1</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

    }

}
