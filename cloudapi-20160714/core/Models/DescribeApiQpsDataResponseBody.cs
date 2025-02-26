// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CloudAPI20160714.Models
{
    public class DescribeApiQpsDataResponseBody : TeaModel {
        /// <summary>
        /// <para>The returned information about failed API calls. It is an array consisting of MonitorItem data.</para>
        /// </summary>
        [NameInMap("CallFails")]
        [Validation(Required=false)]
        public DescribeApiQpsDataResponseBodyCallFails CallFails { get; set; }
        public class DescribeApiQpsDataResponseBodyCallFails : TeaModel {
            [NameInMap("MonitorItem")]
            [Validation(Required=false)]
            public List<DescribeApiQpsDataResponseBodyCallFailsMonitorItem> MonitorItem { get; set; }
            public class DescribeApiQpsDataResponseBodyCallFailsMonitorItem : TeaModel {
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
                /// <para>0</para>
                /// </summary>
                [NameInMap("ItemValue")]
                [Validation(Required=false)]
                public string ItemValue { get; set; }

            }

        }

        /// <summary>
        /// <para>The returned information about successful API calls. It is an array consisting of MonitorItem data.</para>
        /// </summary>
        [NameInMap("CallSuccesses")]
        [Validation(Required=false)]
        public DescribeApiQpsDataResponseBodyCallSuccesses CallSuccesses { get; set; }
        public class DescribeApiQpsDataResponseBodyCallSuccesses : TeaModel {
            [NameInMap("MonitorItem")]
            [Validation(Required=false)]
            public List<DescribeApiQpsDataResponseBodyCallSuccessesMonitorItem> MonitorItem { get; set; }
            public class DescribeApiQpsDataResponseBodyCallSuccessesMonitorItem : TeaModel {
                /// <summary>
                /// <para>The time of the monitoring metric. The time format follows the ISO 8601 standard and UTC time is used. Format: YYYY-MM-DDThh:mm:ssZ</para>
                /// 
                /// <b>Example:</b>
                /// <para>2016-07-28T08:24:00Z</para>
                /// </summary>
                [NameInMap("ItemTime")]
                [Validation(Required=false)]
                public string ItemTime { get; set; }

                /// <summary>
                /// <para>The value corresponding to the monitoring metric.</para>
                /// 
                /// <b>Example:</b>
                /// <para>650</para>
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
