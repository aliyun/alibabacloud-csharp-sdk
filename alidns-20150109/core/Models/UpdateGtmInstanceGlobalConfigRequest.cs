// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alidns20150109.Models
{
    public class UpdateGtmInstanceGlobalConfigRequest : TeaModel {
        /// <summary>
        /// <para>The alert group. Only one alert group is supported.</para>
        /// <remarks>
        /// <para> This parameter is required only for the first modification.</para>
        /// </remarks>
        /// </summary>
        [NameInMap("AlertGroup")]
        [Validation(Required=false)]
        public string AlertGroup { get; set; }

        /// <summary>
        /// <para>If you set <b>CnameMode</b> to <b>CUSTOM</b>, you must specify the CnameCustomDomainName parameter, which must be set to a primary domain name.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="http://www.example.com">www.example.com</a></para>
        /// </summary>
        [NameInMap("CnameCustomDomainName")]
        [Validation(Required=false)]
        public string CnameCustomDomainName { get; set; }

        /// <summary>
        /// <para>Specifies whether to use a system-assigned canonical name (CNAME) or a custom CNAME to access GTM. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>SYSTEM_ASSIGN</b>: system-assigned CNAME</description></item>
        /// <item><description><b>CUSTOM</b>: custom CNAME</description></item>
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
        /// <para>instance1</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The name of the GTM instance.</para>
        /// <remarks>
        /// <para> This parameter is required only for the first modification.</para>
        /// </remarks>
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
        /// <para>The balancing policy. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>ALL_RR</b>: load balancing</description></item>
        /// <item><description><b>RATIO</b>: weighted round-robin</description></item>
        /// </list>
        /// <remarks>
        /// <para> This parameter is required only for the first modification.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>RATIO</para>
        /// </summary>
        [NameInMap("LbaStrategy")]
        [Validation(Required=false)]
        public string LbaStrategy { get; set; }

        /// <summary>
        /// <para>The global time-to-live (TTL).</para>
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
        /// <para> This parameter is required only for the first modification.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para><a href="http://www.example.com">www.example.com</a></para>
        /// </summary>
        [NameInMap("UserDomainName")]
        [Validation(Required=false)]
        public string UserDomainName { get; set; }

    }

}
