// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CloudAPI20160714.Models
{
    public class DescribeInstanceSlbConnectResponseBody : TeaModel {
        [NameInMap("InstanceSlbConnect")]
        [Validation(Required=false)]
        public DescribeInstanceSlbConnectResponseBodyInstanceSlbConnect InstanceSlbConnect { get; set; }
        public class DescribeInstanceSlbConnectResponseBodyInstanceSlbConnect : TeaModel {
            [NameInMap("MonitorItem")]
            [Validation(Required=false)]
            public List<DescribeInstanceSlbConnectResponseBodyInstanceSlbConnectMonitorItem> MonitorItem { get; set; }
            public class DescribeInstanceSlbConnectResponseBodyInstanceSlbConnectMonitorItem : TeaModel {
                [NameInMap("Item")]
                [Validation(Required=false)]
                public string Item { get; set; }

                [NameInMap("ItemTime")]
                [Validation(Required=false)]
                public string ItemTime { get; set; }

                [NameInMap("ItemValue")]
                [Validation(Required=false)]
                public string ItemValue { get; set; }

            }

        }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>E7FE7172-AA75-5880-B6F7-C00893E9BC06</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
