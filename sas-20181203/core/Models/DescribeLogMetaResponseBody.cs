// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeLogMetaResponseBody : TeaModel {
        /// <summary>
        /// <para>An array that consists of the configurations of the log analysis feature.</para>
        /// </summary>
        [NameInMap("LogMetaList")]
        [Validation(Required=false)]
        public List<DescribeLogMetaResponseBodyLogMetaList> LogMetaList { get; set; }
        public class DescribeLogMetaResponseBodyLogMetaList : TeaModel {
            /// <summary>
            /// <para>The category of logs. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>host</b></description></item>
            /// <item><description><b>security</b></description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>host</para>
            /// </summary>
            [NameInMap("Category")]
            [Validation(Required=false)]
            public string Category { get; set; }

            /// <summary>
            /// <para>The time period after which logs in hot storage are moved to cold storage. Unit: days.</para>
            /// <remarks>
            /// <para> If the value is -1, logs that are stored in hot storage are not moved to cold storage.</para>
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
            /// <para>The name of the dedicated Logstore in which logs are stored.</para>
            /// 
            /// <b>Example:</b>
            /// <para>aegis-log-login</para>
            /// </summary>
            [NameInMap("LogStore")]
            [Validation(Required=false)]
            public string LogStore { get; set; }

            /// <summary>
            /// <para>The name of the project.</para>
            /// 
            /// <b>Example:</b>
            /// <para>aegis-log</para>
            /// </summary>
            [NameInMap("Project")]
            [Validation(Required=false)]
            public string Project { get; set; }

            /// <summary>
            /// <para>The status of the log analysis feature. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>disabled</b></description></item>
            /// <item><description><b>enabled</b></description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>enabled</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The topic of logs that are delivered.</para>
            /// 
            /// <b>Example:</b>
            /// <para>aegis-log-login</para>
            /// </summary>
            [NameInMap("Topic")]
            [Validation(Required=false)]
            public string Topic { get; set; }

            /// <summary>
            /// <para>The number of days during which logs can be retained.</para>
            /// 
            /// <b>Example:</b>
            /// <para>180</para>
            /// </summary>
            [NameInMap("Ttl")]
            [Validation(Required=false)]
            public int? Ttl { get; set; }

            /// <summary>
            /// <para>The name of the dedicated Logstore in which user logs are stored.</para>
            /// 
            /// <b>Example:</b>
            /// <para>aegis-log-network</para>
            /// </summary>
            [NameInMap("UserLogStore")]
            [Validation(Required=false)]
            public string UserLogStore { get; set; }

            /// <summary>
            /// <para>The name of the dedicated project in which logs are stored.</para>
            /// 
            /// <b>Example:</b>
            /// <para>sasnew-log-XXXX-cn-hangzhou</para>
            /// </summary>
            [NameInMap("UserProject")]
            [Validation(Required=false)]
            public string UserProject { get; set; }

            /// <summary>
            /// <para>The ID of the region.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-hangzhou</para>
            /// </summary>
            [NameInMap("UserRegion")]
            [Validation(Required=false)]
            public string UserRegion { get; set; }

        }

        /// <summary>
        /// <para>The ID of the request, which is used to locate and troubleshoot issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>D0D6E6E4-CB8C-4897-B852-46AEFDA04B21</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of entries returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
