// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ESA20240910.Models
{
    public class ListTraceTasksResponseBody : TeaModel {
        /// <summary>
        /// <para>The number of pages.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("Count")]
        [Validation(Required=false)]
        public long? Count { get; set; }

        /// <summary>
        /// <para>The returned list information.</para>
        /// </summary>
        [NameInMap("List")]
        [Validation(Required=false)]
        public List<ListTraceTasksResponseBodyList> List { get; set; }
        public class ListTraceTasksResponseBodyList : TeaModel {
            /// <summary>
            /// <para>The Alibaba Cloud account ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1077********7468</para>
            /// </summary>
            [NameInMap("Aliuid")]
            [Validation(Required=false)]
            public string Aliuid { get; set; }

            /// <summary>
            /// <para>The IP address of the local DNS server.</para>
            /// 
            /// <b>Example:</b>
            /// <para>xx.xx.xx.xx</para>
            /// </summary>
            [NameInMap("ClientAddr")]
            [Validation(Required=false)]
            public string ClientAddr { get; set; }

            /// <summary>
            /// <para>The client IP address.</para>
            /// 
            /// <b>Example:</b>
            /// <para>xx.xx.xx.xx</para>
            /// </summary>
            [NameInMap("ClientIp")]
            [Validation(Required=false)]
            public string ClientIp { get; set; }

            /// <summary>
            /// <para>The time when the report was created. Format: yyyy-MM-dd HH:mm:ss. Time zone: UTC+8.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2022-12-10 15:11:47</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <para>The diagnose ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>f2a18ad5</para>
            /// </summary>
            [NameInMap("DiagnoseId")]
            [Validation(Required=false)]
            public string DiagnoseId { get; set; }

            /// <summary>
            /// <para>The diagnostic URL.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="http://cdn.dns-detect.alicdn.com/diagnose/xxxxxx">http://cdn.dns-detect.alicdn.com/diagnose/xxxxxx</a></para>
            /// </summary>
            [NameInMap("DiagnoseUrl")]
            [Validation(Required=false)]
            public string DiagnoseUrl { get; set; }

            /// <summary>
            /// <para>The domain name to diagnose.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="http://www.example.com">http://www.example.com</a></para>
            /// </summary>
            [NameInMap("Domain")]
            [Validation(Required=false)]
            public string Domain { get; set; }

            /// <summary>
            /// <para>The expiration time. The value is a UNIX timestamp. Unit: seconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1669285111</para>
            /// </summary>
            [NameInMap("ExpireTime")]
            [Validation(Required=false)]
            public long? ExpireTime { get; set; }

            /// <summary>
            /// <para>The remaining number of available diagnostic attempts.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("RemainDiagnoseTimes")]
            [Validation(Required=false)]
            public long? RemainDiagnoseTimes { get; set; }

            /// <summary>
            /// <para>The report generation status. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>0: Succeeded.</description></item>
            /// <item><description>1: Failed.</description></item>
            /// <item><description>2: Timed out.</description></item>
            /// <item><description>3: Running.</description></item>
            /// <item><description>4: Waiting.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("State")]
            [Validation(Required=false)]
            public string State { get; set; }

            /// <summary>
            /// <para>The status of the diagnostic URL. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>1: active</description></item>
            /// <item><description>0: expired.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public long? Status { get; set; }

            /// <summary>
            /// <para>The task ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>000000xxxxxxxxxxxxxxxxxxxxxxxxxxxx475e</para>
            /// </summary>
            [NameInMap("TaskId")]
            [Validation(Required=false)]
            public string TaskId { get; set; }

            /// <summary>
            /// <para>The time consumed to generate the report.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("TimeConsuming")]
            [Validation(Required=false)]
            public long? TimeConsuming { get; set; }

            /// <summary>
            /// <para>The diagnostic trace ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>000000xxxxxxxxxxxxxxxxxxxxxx25941e</para>
            /// </summary>
            [NameInMap("TraceId")]
            [Validation(Required=false)]
            public string TraceId { get; set; }

        }

        /// <summary>
        /// <para>The page number, starting from 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public long? PageNumber { get; set; }

        /// <summary>
        /// <para>The page size. Valid values: any integer from 1 to 1000.</para>
        /// 
        /// <b>Example:</b>
        /// <para>6</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>4E09C5D7-E1CF-4CAA-A45E-8727F4C8FD70</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
