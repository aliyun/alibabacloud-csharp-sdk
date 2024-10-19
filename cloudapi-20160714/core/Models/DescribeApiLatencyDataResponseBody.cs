// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CloudAPI20160714.Models
{
    public class DescribeApiLatencyDataResponseBody : TeaModel {
        /// <summary>
        /// <para>The returned information about API call latency. It is an array consisting of MonitorItem data.</para>
        /// </summary>
        [NameInMap("CallLatencys")]
        [Validation(Required=false)]
        public DescribeApiLatencyDataResponseBodyCallLatencys CallLatencys { get; set; }
        public class DescribeApiLatencyDataResponseBodyCallLatencys : TeaModel {
            [NameInMap("MonitorItem")]
            [Validation(Required=false)]
            public List<DescribeApiLatencyDataResponseBodyCallLatencysMonitorItem> MonitorItem { get; set; }
            public class DescribeApiLatencyDataResponseBodyCallLatencysMonitorItem : TeaModel {
                /// <summary>
                /// <para>The time of the monitoring metric. The time format follows the ISO 8601 standard and UTC time is used. Format: YYYY-MM-DDThh:mm:ssZ</para>
                /// 
                /// <b>Example:</b>
                /// <para>2016-07-28T08:20:00Z</para>
                /// </summary>
                [NameInMap("ItemTime")]
                [Validation(Required=false)]
                public string ItemTime { get; set; }

                /// <summary>
                /// <para>The value corresponding to the monitoring metric.</para>
                /// 
                /// <b>Example:</b>
                /// <para>15</para>
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
        /// <para>CEF72CEB-54B6-4AE8-B225-F876FF7BZ001</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
