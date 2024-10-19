// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CloudAPI20160714.Models
{
    public class DescribeGroupTrafficResponseBody : TeaModel {
        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>EF924FE4-2EDD-4CD3-89EC-34E4708574E7</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The traffic information per second.</para>
        /// </summary>
        [NameInMap("TrafficPerSecond")]
        [Validation(Required=false)]
        public DescribeGroupTrafficResponseBodyTrafficPerSecond TrafficPerSecond { get; set; }
        public class DescribeGroupTrafficResponseBodyTrafficPerSecond : TeaModel {
            [NameInMap("MonitorItem")]
            [Validation(Required=false)]
            public List<DescribeGroupTrafficResponseBodyTrafficPerSecondMonitorItem> MonitorItem { get; set; }
            public class DescribeGroupTrafficResponseBodyTrafficPerSecondMonitorItem : TeaModel {
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
                /// <para>The corresponding time. The time follows the ISO 8601 standard and UTC time is used. Format: YYYY-MM-DDThh:mm:ssZ.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2023-01-29T01:30:00Z</para>
                /// </summary>
                [NameInMap("ItemTime")]
                [Validation(Required=false)]
                public string ItemTime { get; set; }

                /// <summary>
                /// <para>The traffic volume per second.</para>
                /// 
                /// <b>Example:</b>
                /// <para>100.0</para>
                /// </summary>
                [NameInMap("ItemValue")]
                [Validation(Required=false)]
                public string ItemValue { get; set; }

            }

        }

    }

}
