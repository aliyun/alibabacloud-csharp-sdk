// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Smartag20180313.Models
{
    public class ModifyClientUserDNSRequest : TeaModel {
        /// <summary>
        /// <para>The IP addresses of the primary and secondary DNS servers that the client uses when it connects to a private network.</para>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>If the client uses PrivateZone to access Alibaba Cloud, the DNS server IP addresses are 100.100.2.136 and 100.100.2.138.</description></item>
        /// </list>
        /// </remarks>
        /// <list type="bullet">
        /// <item><description>DNS configuration is supported only on Android and macOS clients, version 2.1.1 or later.</description></item>
        /// <item><description>This parameter is optional. If you do not specify this parameter, the system deletes the existing DNS configuration.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>100.XX.XX.100</para>
        /// </summary>
        [NameInMap("AppDNS")]
        [Validation(Required=false)]
        public List<string> AppDNS { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The IP addresses of the primary and secondary DNS servers to use after the client disconnects from the private network.</para>
        /// <remarks>
        /// <para>This feature is not yet available.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>100.XX.XX.110</para>
        /// </summary>
        [NameInMap("RecoveredDNS")]
        [Validation(Required=false)]
        public List<string> RecoveredDNS { get; set; }

        /// <summary>
        /// <para>The region ID of the Smart Access Gateway app instance.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-shanghai</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        /// <summary>
        /// <para>The ID of the Smart Access Gateway app instance.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>sag-9uyg53s6juhpxv****</para>
        /// </summary>
        [NameInMap("SmartAGId")]
        [Validation(Required=false)]
        public string SmartAGId { get; set; }

    }

}
