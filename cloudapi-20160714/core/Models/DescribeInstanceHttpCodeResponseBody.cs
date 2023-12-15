// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CloudAPI20160714.Models
{
    public class DescribeInstanceHttpCodeResponseBody : TeaModel {
        /// <summary>
        /// The HTTP status codes.
        /// </summary>
        [NameInMap("InstanceHttpCode")]
        [Validation(Required=false)]
        public DescribeInstanceHttpCodeResponseBodyInstanceHttpCode InstanceHttpCode { get; set; }
        public class DescribeInstanceHttpCodeResponseBodyInstanceHttpCode : TeaModel {
            [NameInMap("MonitorItem")]
            [Validation(Required=false)]
            public List<DescribeInstanceHttpCodeResponseBodyInstanceHttpCodeMonitorItem> MonitorItem { get; set; }
            public class DescribeInstanceHttpCodeResponseBodyInstanceHttpCodeMonitorItem : TeaModel {
                /// <summary>
                /// The HTTP status code returned.
                /// </summary>
                [NameInMap("ItemTime")]
                [Validation(Required=false)]
                public string ItemTime { get; set; }

                /// <summary>
                /// The corresponding value.
                /// </summary>
                [NameInMap("ItemValue")]
                [Validation(Required=false)]
                public string ItemValue { get; set; }

            }

        }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
