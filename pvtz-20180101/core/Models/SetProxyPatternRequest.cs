// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pvtz20180101.Models
{
    public class SetProxyPatternRequest : TeaModel {
        /// <summary>
        /// <para>A client token to ensure the idempotence of the request. The token must be unique for each request. It can contain only ASCII characters and must be no more than 64 characters in length.</para>
        /// 
        /// <b>Example:</b>
        /// <para>21079fa016944979537637959d09bc</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>The language of the response. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>zh: Chinese.</para>
        /// </description></item>
        /// <item><description><para>en: English.</para>
        /// </description></item>
        /// </list>
        /// <para>Default value: en</para>
        /// 
        /// <b>Example:</b>
        /// <para>en</para>
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        /// <summary>
        /// <para>The proxy mode for recursive resolution of subdomains. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>ZONE</b>: Disables the proxy. If a subdomain does not exist, an NXDOMAIN response is returned.</para>
        /// </description></item>
        /// <item><description><para><b>RECORD</b>: Enables the proxy. If a subdomain does not exist, the system queries the forwarding and recursion modules and returns the final result.</para>
        /// </description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ZONE</para>
        /// </summary>
        [NameInMap("ProxyPattern")]
        [Validation(Required=false)]
        public string ProxyPattern { get; set; }

        /// <summary>
        /// <para>The IP address of the client.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10.61.XX.XX</para>
        /// </summary>
        [NameInMap("UserClientIp")]
        [Validation(Required=false)]
        public string UserClientIp { get; set; }

        /// <summary>
        /// <para>The unique ID of the zone.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>df2d03865266bd9842306db586d3****</para>
        /// </summary>
        [NameInMap("ZoneId")]
        [Validation(Required=false)]
        public string ZoneId { get; set; }

    }

}
