// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CloudAPI20160714.Models
{
    public class DescribeInstanceTrafficResponseBody : TeaModel {
        /// <summary>
        /// <para>The traffic consumed by the requests and responses in the instance.</para>
        /// </summary>
        [NameInMap("InstanceTraffic")]
        [Validation(Required=false)]
        public DescribeInstanceTrafficResponseBodyInstanceTraffic InstanceTraffic { get; set; }
        public class DescribeInstanceTrafficResponseBodyInstanceTraffic : TeaModel {
            [NameInMap("MonitorItem")]
            [Validation(Required=false)]
            public List<DescribeInstanceTrafficResponseBodyInstanceTrafficMonitorItem> MonitorItem { get; set; }
            public class DescribeInstanceTrafficResponseBodyInstanceTrafficMonitorItem : TeaModel {
                /// <summary>
                /// <para>The metric. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>inbound: traffic consumed by requests</description></item>
                /// <item><description>outbound: traffic consumed by responses</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>inbound</para>
                /// </summary>
                [NameInMap("Item")]
                [Validation(Required=false)]
                public string Item { get; set; }

                /// <summary>
                /// <para>The monitoring time. The time follows the ISO 8601 standard and UTC time is used. Format: YYYY-MM-DDThh:mm:ssZ</para>
                /// 
                /// <b>Example:</b>
                /// <para>2022-04-01T06:34:03Z</para>
                /// </summary>
                [NameInMap("ItemTime")]
                [Validation(Required=false)]
                public string ItemTime { get; set; }

                /// <summary>
                /// <para>The amount of traffic consumed by the requests and responses in the instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>10</para>
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
        /// <para>CEF72CEB-54B6-4AE8-B225-F876FF7BZ004</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
