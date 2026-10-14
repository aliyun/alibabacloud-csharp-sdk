// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ddoscoo20200101.Models
{
    public class DescribeUdpReflectResponseBody : TeaModel {
        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>F97A8766-FB4D-411A-9CD5-2CFF701B592F</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>An array consisting of the source ports of the UDP traffic that are filtered out by the filtering policies for UDP reflection attacks.</para>
        /// </summary>
        [NameInMap("UdpSports")]
        [Validation(Required=false)]
        public List<string> UdpSports { get; set; }

    }

}
