// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alidns20150109.Models
{
    public class DescribePdnsUserInfoResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>FD552816-FCC8-4832-B4A2-2DA0C2BA1688</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("UserInfo")]
        [Validation(Required=false)]
        public DescribePdnsUserInfoResponseBodyUserInfo UserInfo { get; set; }
        public class DescribePdnsUserInfoResponseBodyUserInfo : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>SECURE</para>
            /// </summary>
            [NameInMap("AvailableAccessSecurityType")]
            [Validation(Required=false)]
            public string AvailableAccessSecurityType { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>HTTP,HTTPS</para>
            /// </summary>
            [NameInMap("AvailableService")]
            [Validation(Required=false)]
            public string AvailableService { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>10001</para>
            /// </summary>
            [NameInMap("PdnsId")]
            [Validation(Required=false)]
            public long? PdnsId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1c092d715b7a48de</para>
            /// </summary>
            [NameInMap("SecretKey")]
            [Validation(Required=false)]
            public string SecretKey { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>normal</para>
            /// </summary>
            [NameInMap("ServiceType")]
            [Validation(Required=false)]
            public string ServiceType { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>AVAILABLE</para>
            /// </summary>
            [NameInMap("State")]
            [Validation(Required=false)]
            public string State { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>CLOSED</para>
            /// </summary>
            [NameInMap("StatisticSwitchStatus")]
            [Validation(Required=false)]
            public string StatisticSwitchStatus { get; set; }

            [NameInMap("StoppedService")]
            [Validation(Required=false)]
            public string StoppedService { get; set; }

        }

    }

}
