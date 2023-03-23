// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CloudAPI20160714.Models
{
    public class DescribeInstanceQpsResponseBody : TeaModel {
        /// <summary>
        /// The list of requests sent to the APIs in the instance.
        /// </summary>
        [NameInMap("InstanceQps")]
        [Validation(Required=false)]
        public DescribeInstanceQpsResponseBodyInstanceQps InstanceQps { get; set; }
        public class DescribeInstanceQpsResponseBodyInstanceQps : TeaModel {
            [NameInMap("MonitorItem")]
            [Validation(Required=false)]
            public List<DescribeInstanceQpsResponseBodyInstanceQpsMonitorItem> MonitorItem { get; set; }
            public class DescribeInstanceQpsResponseBodyInstanceQpsMonitorItem : TeaModel {
                /// <summary>
                /// The monitoring time. The time follows the ISO 8601 standard. Format: YYYY-MM-DDThh:mm:ssZ
                /// </summary>
                [NameInMap("ItemTime")]
                [Validation(Required=false)]
                public string ItemTime { get; set; }

                /// <summary>
                /// The number of requests sent to the APIs in the instance.
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
