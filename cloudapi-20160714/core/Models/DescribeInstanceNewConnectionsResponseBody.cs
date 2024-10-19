// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CloudAPI20160714.Models
{
    public class DescribeInstanceNewConnectionsResponseBody : TeaModel {
        /// <summary>
        /// <para>The list of new connections in the instance.</para>
        /// </summary>
        [NameInMap("InstanceNewConnections")]
        [Validation(Required=false)]
        public DescribeInstanceNewConnectionsResponseBodyInstanceNewConnections InstanceNewConnections { get; set; }
        public class DescribeInstanceNewConnectionsResponseBodyInstanceNewConnections : TeaModel {
            [NameInMap("MonitorItem")]
            [Validation(Required=false)]
            public List<DescribeInstanceNewConnectionsResponseBodyInstanceNewConnectionsMonitorItem> MonitorItem { get; set; }
            public class DescribeInstanceNewConnectionsResponseBodyInstanceNewConnectionsMonitorItem : TeaModel {
                /// <summary>
                /// <para>The monitoring time. The time follows the ISO 8601 standard and UTC time is used. Format: YYYY-MM-DDThh:mm:ssZ</para>
                /// 
                /// <b>Example:</b>
                /// <para>2022-10-08T02:08:00Z</para>
                /// </summary>
                [NameInMap("ItemTime")]
                [Validation(Required=false)]
                public string ItemTime { get; set; }

                /// <summary>
                /// <para>The number of new connections in the instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>16</para>
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
