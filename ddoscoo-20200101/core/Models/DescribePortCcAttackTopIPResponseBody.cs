// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ddoscoo20200101.Models
{
    public class DescribePortCcAttackTopIPResponseBody : TeaModel {
        /// <summary>
        /// The request ID, which is used to locate and troubleshoot issues.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The information about the source IP address of the attack.
        /// </summary>
        [NameInMap("TopIp")]
        [Validation(Required=false)]
        public List<DescribePortCcAttackTopIPResponseBodyTopIp> TopIp { get; set; }
        public class DescribePortCcAttackTopIPResponseBodyTopIp : TeaModel {
            /// <summary>
            /// The code of the location from which the attack is initiated. For more information, see [Codes of administrative regions in China and codes of countries and areas](https://help.aliyun.com/document_detail/167926.html). For example, **110000** indicates Beijing, China, and **us** indicates the United States.
            /// </summary>
            [NameInMap("AreaId")]
            [Validation(Required=false)]
            public string AreaId { get; set; }

            /// <summary>
            /// The number of attacks from the IP address.
            /// </summary>
            [NameInMap("Pv")]
            [Validation(Required=false)]
            public long? Pv { get; set; }

            /// <summary>
            /// The source IP address of the attack.
            /// </summary>
            [NameInMap("SrcIp")]
            [Validation(Required=false)]
            public string SrcIp { get; set; }

        }

    }

}
