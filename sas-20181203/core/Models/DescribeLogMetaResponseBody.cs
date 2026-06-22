// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeLogMetaResponseBody : TeaModel {
        /// <summary>
        /// <para>The list of log analysis configurations in Security Center.</para>
        /// </summary>
        [NameInMap("LogMetaList")]
        [Validation(Required=false)]
        public List<DescribeLogMetaResponseBodyLogMetaList> LogMetaList { get; set; }
        public class DescribeLogMetaResponseBodyLogMetaList : TeaModel {
            /// <summary>
            /// <para>The log category. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>host</b>: Host logs.</description></item>
            /// <item><description><b>security</b>: Security logs.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>host</para>
            /// </summary>
            [NameInMap("Category")]
            [Validation(Required=false)]
            public string Category { get; set; }

            /// <summary>
            /// <para>The number of days before hot storage data is converted to cold storage. Unit: days.</para>
            /// <remarks>
            /// <para>A value of <b>-1</b> indicates that no conversion is performed.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>-1</para>
            /// </summary>
            [NameInMap("HotTtl")]
            [Validation(Required=false)]
            public int? HotTtl { get; set; }

            /// <summary>
            /// <para>The name of the log type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Login</para>
            /// </summary>
            [NameInMap("LogDesc")]
            [Validation(Required=false)]
            public string LogDesc { get; set; }

            /// <summary>
            /// <para>The name of the dedicated Logstore where logs are stored.</para>
            /// 
            /// <b>Example:</b>
            /// <para>aegis-log-login</para>
            /// </summary>
            [NameInMap("LogStore")]
            [Validation(Required=false)]
            public string LogStore { get; set; }

            /// <summary>
            /// <para>The Project name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>aegis-log</para>
            /// </summary>
            [NameInMap("Project")]
            [Validation(Required=false)]
            public string Project { get; set; }

            /// <summary>
            /// <para>The current status. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>disabled</b>: Disabled.</description></item>
            /// <item><description><b>enabled</b>: Enabled.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>enabled</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The topic of the delivered logs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>aegis-log-login</para>
            /// </summary>
            [NameInMap("Topic")]
            [Validation(Required=false)]
            public string Topic { get; set; }

            /// <summary>
            /// <para>The log retention period, in days.</para>
            /// 
            /// <b>Example:</b>
            /// <para>180</para>
            /// </summary>
            [NameInMap("Ttl")]
            [Validation(Required=false)]
            public int? Ttl { get; set; }

            /// <summary>
            /// <para>The name of the dedicated Logstore where user logs are stored.</para>
            /// 
            /// <b>Example:</b>
            /// <para>aegis-log-network</para>
            /// </summary>
            [NameInMap("UserLogStore")]
            [Validation(Required=false)]
            public string UserLogStore { get; set; }

            /// <summary>
            /// <para>The name of the dedicated Project where logs are stored.</para>
            /// 
            /// <b>Example:</b>
            /// <para>sasnew-log-XXXX-cn-hangzhou</para>
            /// </summary>
            [NameInMap("UserProject")]
            [Validation(Required=false)]
            public string UserProject { get; set; }

            /// <summary>
            /// <para>The region to which the logs belong.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-hangzhou</para>
            /// </summary>
            [NameInMap("UserRegion")]
            [Validation(Required=false)]
            public string UserRegion { get; set; }

        }

        /// <summary>
        /// <para>The request ID. It is a unique identifier generated by Alibaba Cloud for the request and can be used for troubleshooting.</para>
        /// 
        /// <b>Example:</b>
        /// <para>D0D6E6E4-CB8C-4897-B852-46AEFDA04B21</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of configuration entries returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
