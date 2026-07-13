// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alidns20150109.Models
{
    public class AddGtmAccessStrategyRequest : TeaModel {
        /// <summary>
        /// <para>The source of the DNS requests.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[&quot;default&quot;, &quot;drpeng&quot;]</para>
        /// </summary>
        [NameInMap("AccessLines")]
        [Validation(Required=false)]
        public string AccessLines { get; set; }

        /// <summary>
        /// <para>The ID of the primary address pool collection.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>hrsix</para>
        /// </summary>
        [NameInMap("DefaultAddrPoolId")]
        [Validation(Required=false)]
        public string DefaultAddrPoolId { get; set; }

        /// <summary>
        /// <para>The ID of the failover address pool collection.</para>
        /// <para>If a failover address pool collection is not configured, set this parameter to <b>EMPTY</b>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>hrsyw</para>
        /// </summary>
        [NameInMap("FailoverAddrPoolId")]
        [Validation(Required=false)]
        public string FailoverAddrPoolId { get; set; }

        /// <summary>
        /// <para>The instance ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>instance1</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The language.</para>
        /// 
        /// <b>Example:</b>
        /// <para>en</para>
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        /// <summary>
        /// <para>The policy name.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>访问策略测试</para>
        /// </summary>
        [NameInMap("StrategyName")]
        [Validation(Required=false)]
        public string StrategyName { get; set; }

    }

}
