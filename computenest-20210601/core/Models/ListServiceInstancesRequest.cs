// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ComputeNest20210601.Models
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
            /// <para>The name of the filter. You can specify one or more filter names to query resources. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>Name: The name of the service. To perform a fuzzy search, enter the value in the \<em>xxx\</em> format. For example, if the service name is My Service, you can enter \<em>My\</em> or \<em>Service\</em> for a fuzzy search.</para>
            /// </description></item>
            /// <item><description><para>ServiceInstanceName: The name of the service instance. A fuzzy query is performed if you enter one service instance name. A term query is performed if you enter multiple service instance names.</para>
            /// </description></item>
            /// <item><description><para>ServiceInstanceId: The service instance ID.</para>
            /// </description></item>
            /// <item><description><para>ServiceId: The service ID.</para>
            /// </description></item>
            /// <item><description><para>Version: The service version.</para>
            /// </description></item>
            /// <item><description><para>Status: The instance status.</para>
            /// </description></item>
            /// <item><description><para>DeployType: The deployment type.</para>
            /// </description></item>
            /// <item><description><para>ServiceType: The service type.</para>
            /// </description></item>
            /// <item><description><para>OperationStartTimeBefore: The time before the start of the Alibaba Cloud Managed Services.</para>
            /// </description></item>
            /// <item><description><para>OperationStartTimeAfter: The time after the start of the Alibaba Cloud Managed Services.</para>
            /// </description></item>
            /// <item><description><para>OperationEndTimeBefore: The time before the end of the Alibaba Cloud Managed Services.</para>
            /// </description></item>
            /// <item><description><para>OperationEndTimeAfter: The time after the end of the Alibaba Cloud Managed Services.</para>
            /// </description></item>
            /// <item><description><para>OperatedServiceInstanceId: The ID of the managed service instance under a private service.</para>
            /// </description></item>
            /// <item><description><para>OperationServiceInstanceId: The ID of the service instance under a pure managed service.</para>
            /// </description></item>
            /// <item><description><para>EnableInstanceOps: Indicates whether the Alibaba Cloud Managed Services feature is enabled for the service instance.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>ServiceInstanceId</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The list of filter values.</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public List<string> Value { get; set; }

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
        /// <para>The query token. Set it to the <b>NextToken</b> value returned from the previous API call.</para>
        /// 
        /// <b>Example:</b>
        /// <para>BBBAAfu+XtuBE55iRLHEYYuojI4=</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The region ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The resource group ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg-bp67acfmxazb4p****</para>
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

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
