// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ESA20240910.Models
{
    public class ListLoadBalancerOriginStatusRequest : TeaModel {
        /// <summary>
        /// <para>Load balancer ID. When querying multiple load balancers, separate the IDs with commas. A maximum of 100 load balancer IDs can be passed at once. Load balancer IDs can be obtained by calling the <a href="https://help.aliyun.com/document_detail/2868897.html">ListLoadBalancers</a> interface.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>99874066052****,100892832360****</para>
        /// </summary>
        [NameInMap("LoadBalancerIds")]
        [Validation(Required=false)]
        public string LoadBalancerIds { get; set; }

        /// <summary>
        /// <para>Source address pool type. Various source address pools are configured under the load balancer, including default pools, fallback pools, and primary region pools. Only the status of origins in the default pool affects the status of the load balancer itself. Passing <c>default_pool</c> means only querying the status of origins in the default source address pool under the load balancer.</para>
        /// 
        /// <b>Example:</b>
        /// <para>default_pool</para>
        /// </summary>
        [NameInMap("PoolType")]
        [Validation(Required=false)]
        public string PoolType { get; set; }

        /// <summary>
        /// <para>Site ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1159101787****</para>
        /// </summary>
        [NameInMap("SiteId")]
        [Validation(Required=false)]
        public long? SiteId { get; set; }

    }

}
