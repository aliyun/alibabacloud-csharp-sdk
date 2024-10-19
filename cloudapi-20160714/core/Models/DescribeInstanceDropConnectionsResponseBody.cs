// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CloudAPI20160714.Models
{
    public class DescribeInstanceDropConnectionsResponseBody : TeaModel {
        /// <summary>
        /// <para>The list of dropped connections in the instance.</para>
        /// </summary>
        [NameInMap("InstanceDropConnections")]
        [Validation(Required=false)]
        public DescribeInstanceDropConnectionsResponseBodyInstanceDropConnections InstanceDropConnections { get; set; }
        public class DescribeInstanceDropConnectionsResponseBodyInstanceDropConnections : TeaModel {
            [NameInMap("MonitorItem")]
            [Validation(Required=false)]
            public List<DescribeInstanceDropConnectionsResponseBodyInstanceDropConnectionsMonitorItem> MonitorItem { get; set; }
            public class DescribeInstanceDropConnectionsResponseBodyInstanceDropConnectionsMonitorItem : TeaModel {
                /// <summary>
                /// <para>The monitoring time. The time follows the ISO 8601 standard. Format: YYYY-MM-DDThh:mm:ssZ</para>
                /// 
                /// <b>Example:</b>
                /// <para>2023-01-31T01:11:00Z</para>
                /// </summary>
                [NameInMap("ItemTime")]
                [Validation(Required=false)]
                public string ItemTime { get; set; }

                /// <summary>
                /// <para>The number of dropped packets in the instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0.0</para>
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
        /// <para>CEF72CEB-54B6-4AE8-B225-F876FF7BA984</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
