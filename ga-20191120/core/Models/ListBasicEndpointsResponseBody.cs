// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ga20191120.Models
{
    public class ListBasicEndpointsResponseBody : TeaModel {
        /// <summary>
        /// <para>The endpoints that are associated with the basic GA instance.</para>
        /// </summary>
        [NameInMap("Endpoints")]
        [Validation(Required=false)]
        public List<ListBasicEndpointsResponseBodyEndpoints> Endpoints { get; set; }
        public class ListBasicEndpointsResponseBodyEndpoints : TeaModel {
            /// <summary>
            /// <para>The ID of the basic GA instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ga-bp17frjjh0udz4qz****</para>
            /// </summary>
            [NameInMap("AcceleratorId")]
            [Validation(Required=false)]
            public string AcceleratorId { get; set; }

            /// <summary>
            /// <para>The address of the endpoint.</para>
            /// 
            /// <b>Example:</b>
            /// <para>eni-bp1a05txelswuj8g****</para>
            /// </summary>
            [NameInMap("EndpointAddress")]
            [Validation(Required=false)]
            public string EndpointAddress { get; set; }

            /// <summary>
            /// <para>The ID of the endpoint group to which the endpoint belongs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>epg-bp1dmlohjjz4kqaun****</para>
            /// </summary>
            [NameInMap("EndpointGroupId")]
            [Validation(Required=false)]
            public string EndpointGroupId { get; set; }

            /// <summary>
            /// <para>The ID of the endpoint that is associated with the basic GA instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ep-bp14sz7ftcwwjgrdm****</para>
            /// </summary>
            [NameInMap("EndpointId")]
            [Validation(Required=false)]
            public string EndpointId { get; set; }

            /// <summary>
            /// <para>The secondary address of the endpoint.</para>
            /// <para>This parameter is returned if the endpoint type is <b>ECS</b>, <b>ENI</b>, or <b>NLB</b>.</para>
            /// <list type="bullet">
            /// <item><description>If the endpoint type is <b>ECS</b>, <b>EndpointSubAddress</b> returns the primary or secondary private IP address of the primary ENI.</description></item>
            /// <item><description>If the endpoint type is <b>ENI</b>, <b>EndpointSubAddress</b> returns the primary or secondary private IP address of the secondary ENI.</description></item>
            /// <item><description>If the endpoint type is <b>NLB</b>, <b>EndpointSubAddress</b> returns the primary private IP address of the NLB backend server.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>172.16.XX.XX</para>
            /// </summary>
            [NameInMap("EndpointSubAddress")]
            [Validation(Required=false)]
            public string EndpointSubAddress { get; set; }

            /// <summary>
            /// <para>The secondary address type of the endpoint.</para>
            /// <list type="bullet">
            /// <item><description><b>primary</b>: a primary private IP address.</description></item>
            /// <item><description><b>secondary</b>: a secondary private IP address.</description></item>
            /// </list>
            /// <para>This parameter is returned if the type of the endpoint is set to <b>ECS</b>, <b>ENI</b>, or <b>NLB</b>. If the endpoint type is set to <b>NLB</b>, <b>primary</b> is returned.</para>
            /// 
            /// <b>Example:</b>
            /// <para>primary</para>
            /// </summary>
            [NameInMap("EndpointSubAddressType")]
            [Validation(Required=false)]
            public string EndpointSubAddressType { get; set; }

            /// <summary>
            /// <para>The type of endpoint. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>ENI</b>: ENI.</description></item>
            /// <item><description><b>SLB</b>: CLB instance.</description></item>
            /// <item><description><b>ECS</b>: ECS instance.</description></item>
            /// <item><description><b>NLB</b>: NLB instance.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>ENI</para>
            /// </summary>
            [NameInMap("EndpointType")]
            [Validation(Required=false)]
            public string EndpointType { get; set; }

            /// <summary>
            /// <para>The zone ID of the endpoint.</para>
            /// <para>This parameter is returned only when the endpoint type is set to <b>NLB</b>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-hangzhou-g</para>
            /// </summary>
            [NameInMap("EndpointZoneId")]
            [Validation(Required=false)]
            public string EndpointZoneId { get; set; }

            /// <summary>
            /// <para>The name of the endpoint.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ep01</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The status of the endpoint. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>init</b>: The endpoint is being initialized.</description></item>
            /// <item><description><b>active</b>: The endpoint is available.</description></item>
            /// <item><description><b>updating</b>: The endpoint is being configured.</description></item>
            /// <item><description><b>binding</b>: The endpoint is being associated.</description></item>
            /// <item><description><b>unbinding</b>: The endpoint is being disassociated.</description></item>
            /// <item><description><b>deleting</b>: The endpoint is being deleted.</description></item>
            /// <item><description><b>bound</b>: The endpoint is associated.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>active</para>
            /// </summary>
            [NameInMap("State")]
            [Validation(Required=false)]
            public string State { get; set; }

        }

        /// <summary>
        /// <para>The number of entries returned per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public string MaxResults { get; set; }

        /// <summary>
        /// <para>The token that determines the start point of the query. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>If <b>NextToken</b> is not returned, it indicates that no additional results exist.</description></item>
        /// <item><description>If a value is returned for <b>NextToken</b>, the value is the token that determines the start point of the next query.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>FFmyTO70tTpLG6I3FmYAXGKPd****</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>04F0F334-1335-436C-A1D7-6C044FE73368</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of entries returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public string TotalCount { get; set; }

    }

}
