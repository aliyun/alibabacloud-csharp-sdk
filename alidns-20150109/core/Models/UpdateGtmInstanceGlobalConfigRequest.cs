// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alidns20150109.Models
{
    public class UpdateGtmInstanceGlobalConfigRequest : TeaModel {
        /// <summary>
        /// <para>The alert contact group. Only one alert contact group is supported.</para>
        /// <remarks>
        /// <para>This parameter is required when you update the instance for the first time. It is optional for subsequent updates.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>[\&quot;研发组\&quot;]</para>
        /// </summary>
        [NameInMap("AlertGroup")]
        [Validation(Required=false)]
        public string AlertGroup { get; set; }

        /// <summary>
        /// <para>This parameter is required when you set <b>CnameMode</b> to <b>CUSTOM</b>. The value must be the primary domain name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>dns-example.top</para>
        /// </summary>
        [NameInMap("CnameCustomDomainName")]
        [Validation(Required=false)]
        public string CnameCustomDomainName { get; set; }

        /// <summary>
        /// <para>The connection type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>SYSTEM_ASSIGN</b>: system-assigned</para>
        /// </description></item>
        /// <item><description><para><b>CUSTOM</b>: custom</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>SYSTEM_ASSIGN</para>
        /// </summary>
        [NameInMap("CnameMode")]
        [Validation(Required=false)]
        public string CnameMode { get; set; }

        /// <summary>
        /// <para>The ID of the GTM instance.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>gtm-cn-cs02xyk4a**</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The name of the instance.</para>
        /// <remarks>
        /// <para>This parameter is required when you update the instance for the first time. It is optional for subsequent updates.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>测试实例</para>
        /// </summary>
        [NameInMap("InstanceName")]
        [Validation(Required=false)]
        public string InstanceName { get; set; }

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
        /// <para>The load balancing policy. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>ALL_RR</b>: round-robin</para>
        /// </description></item>
        /// <item><description><para><b>RATIO</b>: weighted round-robin</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para>This parameter is required when you update the instance for the first time. It is optional for subsequent updates.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>RATIO</para>
        /// </summary>
        [NameInMap("LbaStrategy")]
        [Validation(Required=false)]
        public string LbaStrategy { get; set; }

        /// <summary>
        /// <para>The global Time to Live (TTL).</para>
        /// 
        /// <b>Example:</b>
        /// <para>60</para>
        /// </summary>
        [NameInMap("Ttl")]
        [Validation(Required=false)]
        public int? Ttl { get; set; }

        /// <summary>
        /// <para>The primary domain name.</para>
        /// <remarks>
        /// <para>This parameter is required when you update the instance for the first time. It is optional for subsequent updates.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>dns-example.top</para>
        /// </summary>
        [NameInMap("UserDomainName")]
        [Validation(Required=false)]
        public string UserDomainName { get; set; }

    }

}
