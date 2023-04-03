// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alidns20150109.Models
{
    public class UpdateCustomLineRequest : TeaModel {
        [NameInMap("IpSegment")]
        [Validation(Required=false)]
        public List<UpdateCustomLineRequestIpSegment> IpSegment { get; set; }
        public class UpdateCustomLineRequestIpSegment : TeaModel {
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
        /// The unique ID of the custom line.
        /// </summary>
        [NameInMap("LineId")]
        [Validation(Required=false)]
        public long? LineId { get; set; }

        /// <summary>
        /// The new name of the custom line.
        /// </summary>
        [NameInMap("LineName")]
        [Validation(Required=false)]
        public string LineName { get; set; }

    }

}
