// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ComputeNest20210601.Models
{
    public class ListServiceInstanceResourcesRequest : TeaModel {
        /// <summary>
        /// <para>The filter conditions. Vaild values:</para>
        /// <list type="bullet">
        /// <item><description><para>ExpireTimeStart：
        /// Query start time for Subscription resource expiration.
        /// <notice>Notice Note: Only supports querying service instances on private deployments.&gt;Notice: </para>
        /// </description></item>
        /// <item><description><para>ExpireTimeEnd：Query end time for Subscription resource expiration.
        /// <notice>Notice Note: Only supports querying service instances on private deployments.&gt;Notice: </para>
        /// </description></item>
        /// <item><description><para>PayType：The billing method of the read-only instance. 
        /// <notice>Notice Note: Only supports querying service instances on private deployments.<notice> </para>
        /// <para> Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>PayAsYouGo</para>
        /// </description></item>
        /// <item><description><para>Subscription</para>
        /// </description></item>
        /// </list>
        /// </description></item>
        /// <item><description><para>ResourceARN：The Alibaba Cloud Resource Name (ARN) of a resource.</para>
        /// </description></item>
        /// </list>
        /// </summary>
        [NameInMap("Filters")]
        [Validation(Required=false)]
        public List<ListServiceInstanceResourcesRequestFilters> Filters { get; set; }
        public class ListServiceInstanceResourcesRequestFilters : TeaModel {
            /// <summary>
            /// <para>Vaild values:</para>
            /// <list type="bullet">
            /// <item><description>ExpireTimeStart</description></item>
            /// <item><description>ExpireTimeEnd</description></item>
            /// <item><description>PayType</description></item>
            /// <item><description>ResourceARN</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>ExpireTimeStart</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The value of the filter condition.</para>
            /// </summary>
            [NameInMap("Values")]
            [Validation(Required=false)]
            public List<string> Values { get; set; }

        }

        /// <summary>
        /// <para>The number of entries per page. Valid values: 1 to 100. Default value: 20.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>The token that determines the start point of the next query. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>If <b>NextToken</b> is not returned, it indicates that no additional results exist.</description></item>
        /// <item><description>If <b>NextToken</b> was returned in the previous query, specify the value to obtain the next set of results.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>AAAAAc3HCuYhJi/wvpk4xOr0VLbAx7BkQzyYC+ONO+WudHGKEdB0uWSY7AGnM3qCgm/Ynge7zU6NWdbj0Tegyajyqyc=</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The region ID. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>cn-hangzhou: China (Hangzhou).</description></item>
        /// <item><description>ap-southeast-1: Singapore.</description></item>
        /// </list>
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
        /// <para>Service Instance resource type，include AliyunResource and ContainerResource.</para>
        /// 
        /// <b>Example:</b>
        /// <para>AliyunResource</para>
        /// </summary>
        [NameInMap("ServiceInstanceResourceType")]
        [Validation(Required=false)]
        public string ServiceInstanceResourceType { get; set; }

        /// <summary>
        /// <para>The tag key and value.</para>
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<ListServiceInstanceResourcesRequestTag> Tag { get; set; }
        public class ListServiceInstanceResourcesRequestTag : TeaModel {
            /// <summary>
            /// <para>The tag key.</para>
            /// 
            /// <b>Example:</b>
            /// <para>key1</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The tag value.</para>
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
