// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ESA20240910.Models
{
    public class GetLoadBalancerRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the load balancer. This ID is returned when the load balancer is created. You can also call <a href="https://help.aliyun.com/document_detail/2868897.html">ListLoadBalancers</a> to get the IDs of all load balancers in a site.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>99867648760****</para>
        /// </summary>
        [NameInMap("Id")]
        [Validation(Required=false)]
        public long? Id { get; set; }

        /// <summary>
        /// <para>The ID of the site. Call <a href="~~ListSites~~">ListSites</a> to get this ID.</para>
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
