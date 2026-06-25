// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sae20190506.Models
{
    public class ListLogConfigsResponseBody : TeaModel {
        /// <summary>
        /// <para>The HTTP status code. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>2xx</b>: The request is successful.</para>
        /// </description></item>
        /// <item><description><para><b>3xx</b>: The request is redirected.</para>
        /// </description></item>
        /// <item><description><para><b>4xx</b>: A request error occurred.</para>
        /// </description></item>
        /// <item><description><para><b>5xx</b>: A server error occurred.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The information about the file logs.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public ListLogConfigsResponseBodyData Data { get; set; }
        public class ListLogConfigsResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The page number.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("CurrentPage")]
            [Validation(Required=false)]
            public int? CurrentPage { get; set; }

            /// <summary>
            /// <para>The log configurations.</para>
            /// </summary>
            [NameInMap("LogConfigs")]
            [Validation(Required=false)]
            public List<ListLogConfigsResponseBodyDataLogConfigs> LogConfigs { get; set; }
            public class ListLogConfigsResponseBodyDataLogConfigs : TeaModel {
                /// <summary>
                /// <para>The name of the Simple Log Service configuration.</para>
                /// 
                /// <b>Example:</b>
                /// <para>sae-1f240907a6faf58c653f09e81b7e****</para>
                /// </summary>
                [NameInMap("ConfigName")]
                [Validation(Required=false)]
                public string ConfigName { get; set; }

                /// <summary>
                /// <para>The time when the log configuration was created.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2019-08-29 17:18:00</para>
                /// </summary>
                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public string CreateTime { get; set; }

                /// <summary>
                /// <para>The path of the log file. This is the log source.</para>
                /// 
                /// <b>Example:</b>
                /// <para>/root/logs/hsf/hsf.log</para>
                /// </summary>
                [NameInMap("LogDir")]
                [Validation(Required=false)]
                public string LogDir { get; set; }

                /// <summary>
                /// <para>The log type. Only <b>file_log</b> is supported.</para>
                /// 
                /// <b>Example:</b>
                /// <para>file_log</para>
                /// </summary>
                [NameInMap("LogType")]
                [Validation(Required=false)]
                public string LogType { get; set; }

                /// <summary>
                /// <para>The region ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cn-beijing</para>
                /// </summary>
                [NameInMap("RegionId")]
                [Validation(Required=false)]
                public string RegionId { get; set; }

                /// <summary>
                /// <para>The name of the Logstore in Simple Log Service.</para>
                /// 
                /// <b>Example:</b>
                /// <para>sae-1f240907a6faf58c653f09e81b7e****</para>
                /// </summary>
                [NameInMap("SlsLogStore")]
                [Validation(Required=false)]
                public string SlsLogStore { get; set; }

                /// <summary>
                /// <para>The ID of the Simple Log Service project.</para>
                /// 
                /// <b>Example:</b>
                /// <para>sae-56f77b65-788d-442a-9885-7f20d91f****</para>
                /// </summary>
                [NameInMap("SlsProject")]
                [Validation(Required=false)]
                public string SlsProject { get; set; }

                /// <summary>
                /// <para>The storage class for Simple Log Service.</para>
                /// 
                /// <b>Example:</b>
                /// <para>sls</para>
                /// </summary>
                [NameInMap("StoreType")]
                [Validation(Required=false)]
                public string StoreType { get; set; }

            }

            /// <summary>
            /// <para>The number of entries returned per page.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            /// <summary>
            /// <para>The total number of entries.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("TotalSize")]
            [Validation(Required=false)]
            public int? TotalSize { get; set; }

        }

        /// <summary>
        /// <para>The error code.</para>
        /// <list type="bullet">
        /// <item><description><para>This parameter is not returned if the request is successful.</para>
        /// </description></item>
        /// <item><description><para>This parameter is returned if the request fails. For more information, see the <b>Error codes</b> list in this topic.</para>
        /// </description></item>
        /// </list>
        /// </summary>
        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// <para>The returned message.</para>
        /// <list type="bullet">
        /// <item><description><para>If the request is successful, <b>success</b> is returned.</para>
        /// </description></item>
        /// <item><description><para>If the request fails, an error code is returned.</para>
        /// </description></item>
        /// </list>
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
        /// <para>91F93257-7A4A-4BD3-9A7E-2F6EAE6D****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the list of application logs was obtained. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>true</b>: The list was obtained.</para>
        /// </description></item>
        /// <item><description><para><b>false</b>: The list failed to be obtained.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// <para>The trace ID of the request. You can use the trace ID to query the details of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ac1d5e2c15671581252413581d****</para>
        /// </summary>
        [NameInMap("TraceId")]
        [Validation(Required=false)]
        public string TraceId { get; set; }

    }

}
