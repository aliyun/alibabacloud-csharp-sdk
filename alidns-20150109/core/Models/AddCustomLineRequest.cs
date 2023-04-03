/**
 *
 */
// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alidns20150109.Models
{
    public class AddCustomLineRequest : TeaModel {
        /// <summary>
        /// The domain name for which you configure the custom line.
        /// </summary>
        [NameInMap("DomainName")]
        [Validation(Required=false)]
        public string DomainName { get; set; }

        [NameInMap("IpSegment")]
        [Validation(Required=false)]
        public List<AddCustomLineRequestIpSegment> IpSegment { get; set; }
        public class AddCustomLineRequestIpSegment : TeaModel {
            /// <summary>
            /// The end IP address of the CIDR block.
            /// </summary>
            [NameInMap("EndIp")]
            [Validation(Required=false)]
            public string EndIp { get; set; }

            /// <summary>
            /// The start IP address of the CIDR block.
            /// </summary>
            [NameInMap("StartIp")]
            [Validation(Required=false)]
            public string StartIp { get; set; }

        }

        /// <summary>
        /// The language type.
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        /// <summary>
        /// The name of the custom line.
        /// </summary>
        [NameInMap("LineName")]
        [Validation(Required=false)]
        public string LineName { get; set; }

    }

}
