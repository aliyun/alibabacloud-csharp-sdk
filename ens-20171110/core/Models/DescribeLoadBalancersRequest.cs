// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class DescribeLoadBalancersRequest : TeaModel {
        /// <summary>
        /// <para>The IP address that the ELB instance uses to provide services.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10.0.XX.XX</para>
        /// </summary>
        [NameInMap("Address")]
        [Validation(Required=false)]
        public string Address { get; set; }

        /// <summary>
        /// <para>The ID of the Edge Node Service (ENS) node.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-guangzhou-10</para>
        /// </summary>
        [NameInMap("EnsRegionId")]
        [Validation(Required=false)]
        public string EnsRegionId { get; set; }

        /// <summary>
        /// <para>The IDs of the Edge Node Service (ENS) nodes.</para>
        /// </summary>
        [NameInMap("EnsRegionIds")]
        [Validation(Required=false)]
        public List<string> EnsRegionIds { get; set; }

        /// <summary>
        /// <para>The ID of the ELB instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>lb-5q73cv04zeyh43lh74lp4****</para>
        /// </summary>
        [NameInMap("LoadBalancerId")]
        [Validation(Required=false)]
        public string LoadBalancerId { get; set; }

        /// <summary>
        /// <para>The name of the ELB instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>example</para>
        /// </summary>
        [NameInMap("LoadBalancerName")]
        [Validation(Required=false)]
        public string LoadBalancerName { get; set; }

        /// <summary>
        /// <para>The status of the listener for the ELB instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Active</b>: The listener for the instance can forward the received traffic based on forwarding rules.</description></item>
        /// <item><description><b>InActive</b>: The listener for the instance does not forward the received traffic.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>InActive</para>
        /// </summary>
        [NameInMap("LoadBalancerStatus")]
        [Validation(Required=false)]
        public string LoadBalancerStatus { get; set; }

        [NameInMap("LoadBalancerType")]
        [Validation(Required=false)]
        public string LoadBalancerType { get; set; }

        /// <summary>
        /// <para>The ID of the network.</para>
        /// 
        /// <b>Example:</b>
        /// <para>n-5s9ayrxsd9hszrlt5fgv2****</para>
        /// </summary>
        [NameInMap("NetworkId")]
        [Validation(Required=false)]
        public string NetworkId { get; set; }

        /// <summary>
        /// <para>The page number. Default value: 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries to return on each page. Default value: 10. Valid values: <b>10</b> to <b>100</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The ID of the backend server.</para>
        /// 
        /// <b>Example:</b>
        /// <para>i-5f67ffjc004wwz0t****</para>
        /// </summary>
        [NameInMap("ServerId")]
        [Validation(Required=false)]
        public string ServerId { get; set; }

        /// <summary>
        /// <para>The ID of the vSwitch.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vsw-5sy773iy25rulsmgskmba****</para>
        /// </summary>
        [NameInMap("VSwitchId")]
        [Validation(Required=false)]
        public string VSwitchId { get; set; }

    }

}
