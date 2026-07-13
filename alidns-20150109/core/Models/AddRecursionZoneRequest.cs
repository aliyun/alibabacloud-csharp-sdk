// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alidns20150109.Models
{
    public class AddRecursionZoneRequest : TeaModel {
        /// <summary>
        /// <para>A client token that ensures the idempotence of the request. You can specify a custom value. Make sure that the value is unique among different requests. The value can contain up to 64 ASCII characters.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1ae05db4-10e7-11ef-b126-00163e24**22</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable recursive proxy for subdomains. Valid values:</para>
        /// <para>zone: Disables recursive proxy. An NXDOMAIN response is returned for non-existent subdomains. record: Enables recursive proxy. For non-existent subdomains, the system queries the forwarding and recursion modules in sequence and returns the final result.</para>
        /// 
        /// <b>Example:</b>
        /// <para>record</para>
        /// </summary>
        [NameInMap("ProxyPattern")]
        [Validation(Required=false)]
        public string ProxyPattern { get; set; }

        /// <summary>
        /// <para>The name of the zone.</para>
        /// 
        /// <b>Example:</b>
        /// <para>example.com</para>
        /// </summary>
        [NameInMap("ZoneName")]
        [Validation(Required=false)]
        public string ZoneName { get; set; }

    }

}
