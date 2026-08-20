// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pvtz20180101.Models
{
    public class ChangeZoneDnsGroupRequest : TeaModel {
        /// <summary>
        /// <para>A client token that is used to ensure the idempotence of the request. Generate a unique value for this parameter on your client. The token can contain only ASCII characters and cannot exceed 64 characters in length. For more information, see How to ensure idempotence.</para>
        /// 
        /// <b>Example:</b>
        /// <para>85456erer657cfgfg3437</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>The built-in authoritative DNS group.</para>
        /// <list type="bullet">
        /// <item><description><para>Standard zone group: NORMAL_ZONE</para>
        /// </description></item>
        /// <item><description><para>Acceleration zone group: FAST_ZONE</para>
        /// </description></item>
        /// </list>
        /// <para>&lt;props=&quot;china&quot;&gt;</para>
        /// <remarks>
        /// <para>Starting from April 30, 2025 (UTC+8), when new users of Alibaba Cloud DNS PrivateZone create a zone, the zone is set to an acceleration zone by default.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>NORMAL_ZONE</para>
        /// </summary>
        [NameInMap("DnsGroup")]
        [Validation(Required=false)]
        public string DnsGroup { get; set; }

        /// <summary>
        /// <para>The global ID of the zone.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>e0cff188756b1d4579b25e54b66cb830</para>
        /// </summary>
        [NameInMap("ZoneId")]
        [Validation(Required=false)]
        public string ZoneId { get; set; }

    }

}
