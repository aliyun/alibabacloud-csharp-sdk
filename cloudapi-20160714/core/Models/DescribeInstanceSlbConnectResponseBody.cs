// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CloudAPI20160714.Models
{
    public class DescribeInstanceSlbConnectResponseBody : TeaModel {
        /// <summary>
        /// <para>The list of concurrent connections in the instance.</para>
        /// </summary>
        [NameInMap("InstanceSlbConnect")]
        [Validation(Required=false)]
        public DescribeInstanceSlbConnectResponseBodyInstanceSlbConnect InstanceSlbConnect { get; set; }
        public class DescribeInstanceSlbConnectResponseBodyInstanceSlbConnect : TeaModel {
            [NameInMap("MonitorItem")]
            [Validation(Required=false)]
            public List<DescribeInstanceSlbConnectResponseBodyInstanceSlbConnectMonitorItem> MonitorItem { get; set; }
            public class DescribeInstanceSlbConnectResponseBodyInstanceSlbConnectMonitorItem : TeaModel {
                /// <summary>
                /// <para>The metric. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>InstanceMaxConnection: the maximum number of connections</description></item>
                /// <item><description>InstanceInactiveConnection: the number of inactive connections</description></item>
                /// <item><description>InstanceActiveConnection: the number of active connections</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>InstanceActiveConnection</para>
                /// </summary>
                [NameInMap("Item")]
                [Validation(Required=false)]
                public string Item { get; set; }

                /// <summary>
                /// <para>The monitoring time. The time follows the ISO 8601 standard and UTC time is used. Format: YYYY-MM-DDThh:mm:ssZ</para>
                /// 
                /// <b>Example:</b>
                /// <para>2022-09-15T15:07:06Z</para>
                /// </summary>
                [NameInMap("ItemTime")]
                [Validation(Required=false)]
                public string ItemTime { get; set; }

                /// <summary>
                /// <para>The number of concurrent connections in the instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>12</para>
                /// </summary>
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
