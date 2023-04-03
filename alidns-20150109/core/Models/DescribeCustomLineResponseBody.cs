// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alidns20150109.Models
{
    public class DescribeCustomLineResponseBody : TeaModel {
        /// <summary>
        /// The code of the custom line. The code is used when you configure a resolution record.
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// The domain name for which the custom line is configured.
        /// </summary>
        [NameInMap("DomainName")]
        [Validation(Required=false)]
        public string DomainName { get; set; }

        /// <summary>
        /// The unique ID of the custom line.
        /// </summary>
        [NameInMap("Id")]
        [Validation(Required=false)]
        public long? Id { get; set; }

        /// <summary>
        /// The list of CIDR blocks.
        /// </summary>
        [NameInMap("IpSegmentList")]
        [Validation(Required=false)]
        public List<DescribeCustomLineResponseBodyIpSegmentList> IpSegmentList { get; set; }
        public class DescribeCustomLineResponseBodyIpSegmentList : TeaModel {
            /// <summary>
            /// The end IP address.
            /// </summary>
            [NameInMap("EndIp")]
            [Validation(Required=false)]
            public string EndIp { get; set; }

            /// <summary>
            /// The start IP address.
            /// </summary>
            [NameInMap("StartIp")]
            [Validation(Required=false)]
            public string StartIp { get; set; }

        }

        /// <summary>
        /// The name of the custom line.
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
