// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class ModifyLoadBalancerAttributeRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the load balancing instance.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>lb-5q73cv04zeyh43lh74lp4gtm8</para>
        /// </summary>
        [NameInMap("LoadBalancerId")]
        [Validation(Required=false)]
        public string LoadBalancerId { get; set; }

        /// <summary>
        /// <para>The name of the load balancing instance. The name must be <b>2</b> to <b>128</b> characters in length, and can contain English or Chinese characters.</para>
        /// <remarks>
        /// <para>It cannot start with <c>http://</c> or <c>https://</c>.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("LoadBalancerName")]
        [Validation(Required=false)]
        public string LoadBalancerName { get; set; }

    }

}
