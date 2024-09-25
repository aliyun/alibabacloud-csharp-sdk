// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ComputeNestSupplier20210521.Models
{
    public class ListServiceInstancesRequest : TeaModel {
        /// <summary>
        /// <para>The filter.</para>
        /// </summary>
        [NameInMap("Filter")]
        [Validation(Required=false)]
        public List<ListServiceInstancesRequestFilter> Filter { get; set; }
        public class ListServiceInstancesRequestFilter : TeaModel {
            /// <summary>
            /// <para>The parameter name of the filter. You can specify one or more filters. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>Name: The service name. If you want to perform a fuzzy match, specify the service name in the <em>xxx</em> format. For example, if the service name is My Service, you can set the filter value to <em>My</em> or <em>Service</em>.</description></item>
            /// <item><description>ServiceInstanceId: The ID of the service instance.</description></item>
            /// <item><description>ServiceId: The service ID.</description></item>
            /// <item><description>UserId: The user ID.</description></item>
            /// <item><description>Version: The service version.</description></item>
            /// <item><description>Status: The status of the service instance.</description></item>
            /// <item><description>DeployType: The deployment type of the service.</description></item>
            /// <item><description>ServiceType: The service type.</description></item>
            /// <item><description>OperationStartTimeBefore: The time before the hosted O\&amp;M starts.</description></item>
            /// <item><description>OperationStartTimeAfter: The time after the hosted O\&amp;M starts.</description></item>
            /// <item><description>OperationEndTimeBefore: The time before the hosted O\&amp;M ends.</description></item>
            /// <item><description>OperationEndTimeAfter: The time after the hosted O\&amp;M ends.</description></item>
            /// <item><description>OperatedServiceInstanceId: The ID of the hosted O\&amp;M instance that belongs to a private service.</description></item>
            /// <item><description>OperationServiceInstanceId: The ID of the hosted O\&amp;M service instance that belongs to a hosted O\&amp;M service.</description></item>
            /// <item><description>EnableInstanceOps: Whether the hosted O\&amp;M feature is enabled for service instances.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>ServiceInstanceId</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The parameter values of the filter.</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public List<string> Value { get; set; }

        }

        /// <summary>
        /// <para>The number of entries per page. Valid values: 1 to 100. Default value: 20.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>The pagination token that is used in the next request to retrieve a new page of results. You do not need to specify this parameter for the first request. You must specify the token that is obtained from the previous query as the value of NextToken.</para>
        /// 
        /// <b>Example:</b>
        /// <para>BBBAAfu+XtuBE55iRLHEYYuojI4=</para>
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
        /// <para>The ID of the resource group.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg-aekzkt5buxxxxxx</para>
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// <para>Specifies whether to display the information that the service instance is deleted. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true</description></item>
        /// <item><description>false</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("ShowDeleted")]
        [Validation(Required=false)]
        public bool? ShowDeleted { get; set; }

        /// <summary>
        /// <para>The custom tags.</para>
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<ListServiceInstancesRequestTag> Tag { get; set; }
        public class ListServiceInstancesRequestTag : TeaModel {
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
