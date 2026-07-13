// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alidns20150109.Models
{
    public class DescribePdnsUserInfoResponseBody : TeaModel {
        /// <summary>
        /// <para>The unique ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>FD552816-FCC8-4832-B4A2-2DA0C2BA1688</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The user information.</para>
        /// </summary>
        [NameInMap("UserInfo")]
        [Validation(Required=false)]
        public DescribePdnsUserInfoResponseBodyUserInfo UserInfo { get; set; }
        public class DescribePdnsUserInfoResponseBodyUserInfo : TeaModel {
            /// <summary>
            /// <para>The enabled secure access type. INSECURE indicates non-encrypted access. SECURE indicates encrypted access.</para>
            /// 
            /// <b>Example:</b>
            /// <para>SECURE</para>
            /// </summary>
            [NameInMap("AvailableAccessSecurityType")]
            [Validation(Required=false)]
            public string AvailableAccessSecurityType { get; set; }

            /// <summary>
            /// <para>The public recursive DNS services that are enabled.</para>
            /// 
            /// <b>Example:</b>
            /// <para>HTTP,HTTPS</para>
            /// </summary>
            [NameInMap("AvailableService")]
            [Validation(Required=false)]
            public string AvailableService { get; set; }

            /// <summary>
            /// <para>The ID of the dedicated configuration for public recursive DNS.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1***1</para>
            /// </summary>
            [NameInMap("PdnsId")]
            [Validation(Required=false)]
            public long? PdnsId { get; set; }

            /// <summary>
            /// <para>The SecretKey for configuring the UDP access IP address segment.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1c09*******</para>
            /// </summary>
            [NameInMap("SecretKey")]
            [Validation(Required=false)]
            public string SecretKey { get; set; }

            /// <summary>
            /// <para>The type of the public recursive DNS service.</para>
            /// 
            /// <b>Example:</b>
            /// <para>normal</para>
            /// </summary>
            [NameInMap("ServiceType")]
            [Validation(Required=false)]
            public string ServiceType { get; set; }

            /// <summary>
            /// <para>The status of the public recursive DNS service.</para>
            /// 
            /// <b>Example:</b>
            /// <para>AVAILABLE</para>
            /// </summary>
            [NameInMap("State")]
            [Validation(Required=false)]
            public string State { get; set; }

            /// <summary>
            /// <para>The status of the switch for public recursive DNS traffic analysis.</para>
            /// 
            /// <b>Example:</b>
            /// <para>CLOSED</para>
            /// </summary>
            [NameInMap("StatisticSwitchStatus")]
            [Validation(Required=false)]
            public string StatisticSwitchStatus { get; set; }

            /// <summary>
            /// <para>The public recursive DNS services that are shut down.</para>
            /// </summary>
            [NameInMap("StoppedService")]
            [Validation(Required=false)]
            public string StoppedService { get; set; }

        }

    }

}
