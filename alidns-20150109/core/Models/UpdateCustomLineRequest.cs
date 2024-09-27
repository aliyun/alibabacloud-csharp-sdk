// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alidns20150109.Models
{
    public class UpdateCustomLineRequest : TeaModel {
        /// <summary>
        /// <para>The CIDR blocks. Separate IP addresses with a hyphen (-). Enter a CIDR block in each row. You can enter 1 to 50 CIDR blocks at a time. If a CIDR block contains only one IP address, enter the IP address in the format of IP1-IP1. Different CIDR blocks cannot be overlapped.</para>
        /// </summary>
        [NameInMap("IpSegment")]
        [Validation(Required=false)]
        public List<UpdateCustomLineRequestIpSegment> IpSegment { get; set; }
        public class UpdateCustomLineRequestIpSegment : TeaModel {
            /// <summary>
            /// <para>The end IP address of the CIDR block.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2.2.2.2</para>
            /// </summary>
            [NameInMap("EndIp")]
            [Validation(Required=false)]
            public string EndIp { get; set; }

            /// <summary>
            /// <para>The start IP address of the CIDR block.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1.1.1.1</para>
            /// </summary>
            [NameInMap("StartIp")]
            [Validation(Required=false)]
            public string StartIp { get; set; }

        }

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
        /// <para>The unique ID of the custom line.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1234</para>
        /// </summary>
        [NameInMap("LineId")]
        [Validation(Required=false)]
        public long? LineId { get; set; }

        /// <summary>
        /// <para>The name of the custom line. The name must be 1 to 20 characters in length and can contain letters, digits, hyphens (-), and underscores (_).</para>
        /// </summary>
        [NameInMap("LineName")]
        [Validation(Required=false)]
        public string LineName { get; set; }

    }

}
