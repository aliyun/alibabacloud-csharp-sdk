// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20190101.Models
{
    public class DescribeSystemEventMetaListResponseBody : TeaModel {
        /// <summary>
        /// <para>The status code.</para>
        /// <remarks>
        /// <para> The status code 200 indicates that the request was successful.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        /// <summary>
        /// <para>The queried meta information.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public DescribeSystemEventMetaListResponseBodyData Data { get; set; }
        public class DescribeSystemEventMetaListResponseBodyData : TeaModel {
            [NameInMap("Resource")]
            [Validation(Required=false)]
            public List<DescribeSystemEventMetaListResponseBodyDataResource> Resource { get; set; }
            public class DescribeSystemEventMetaListResponseBodyDataResource : TeaModel {
                /// <summary>
                /// <para>The type of the system event. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>StatusNotification: fault notifications</description></item>
                /// <item><description>Exception: exceptions</description></item>
                /// <item><description>Maintenance: O\&amp;M</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>Exception</para>
                /// </summary>
                [NameInMap("EventType")]
                [Validation(Required=false)]
                public string EventType { get; set; }

                /// <summary>
                /// <para>The alert level. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>CRITICAL</description></item>
                /// <item><description>WARN</description></item>
                /// <item><description>INFO</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>INFO</para>
                /// </summary>
                [NameInMap("Level")]
                [Validation(Required=false)]
                public string Level { get; set; }

                /// <summary>
                /// <para>The name of the system event.</para>
                /// 
                /// <b>Example:</b>
                /// <para>SelectFailureRate</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>The description of the event name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>High query failure rate</para>
                /// </summary>
                [NameInMap("NameDesc")]
                [Validation(Required=false)]
                public string NameDesc { get; set; }

                [NameInMap("NameDesc.En")]
                [Validation(Required=false)]
                public string NameDesc_en { get; set; }

                /// <summary>
                /// <para>The abbreviation of the service name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ADS</para>
                /// </summary>
                [NameInMap("Product")]
                [Validation(Required=false)]
                public string Product { get; set; }

                /// <summary>
                /// <para>The status of the system event.</para>
                /// 
                /// <b>Example:</b>
                /// <para>failed</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                /// <summary>
                /// <para>The description of the event status.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Operation Failed</para>
                /// </summary>
                [NameInMap("StatusDesc")]
                [Validation(Required=false)]
                public string StatusDesc { get; set; }

            }

        }

        /// <summary>
        /// <para>The returned message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>A6582C8B-E67C-4A19-BC15-EAEFEBDC7995</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request was successful. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true</description></item>
        /// <item><description>false</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
