// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sae20190506.Models
{
    public class ListLogConfigsResponseBody : TeaModel {
        /// <summary>
        /// <para>Indicates whether the logging configurations of an application were obtained. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: indicates that the configurations were obtained.</description></item>
        /// <item><description><b>false</b>: indicates that the configurations could not be obtained.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The details of logging configurations.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public ListLogConfigsResponseBodyData Data { get; set; }
        public class ListLogConfigsResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The total number of returned entries.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("CurrentPage")]
            [Validation(Required=false)]
            public int? CurrentPage { get; set; }

            /// <summary>
            /// <para>The name of the Log Service configuration.</para>
            /// </summary>
            [NameInMap("LogConfigs")]
            [Validation(Required=false)]
            public List<ListLogConfigsResponseBodyDataLogConfigs> LogConfigs { get; set; }
            public class ListLogConfigsResponseBodyDataLogConfigs : TeaModel {
                /// <summary>
                /// <para>The path of logs.</para>
                /// 
                /// <b>Example:</b>
                /// <para>sae-1f240907a6faf58c653f09e81b7e****</para>
                /// </summary>
                [NameInMap("ConfigName")]
                [Validation(Required=false)]
                public string ConfigName { get; set; }

                /// <summary>
                /// <para>The storage type of logs.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2019-08-29 17:18:00</para>
                /// </summary>
                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public string CreateTime { get; set; }

                /// <summary>
                /// <para>The name of the Logstore in Log Service.</para>
                /// 
                /// <b>Example:</b>
                /// <para>/root/logs/hsf/hsf.log</para>
                /// </summary>
                [NameInMap("LogDir")]
                [Validation(Required=false)]
                public string LogDir { get; set; }

                /// <summary>
                /// <para>The ID of the region.</para>
                /// 
                /// <b>Example:</b>
                /// <para>file_log</para>
                /// </summary>
                [NameInMap("LogType")]
                [Validation(Required=false)]
                public string LogType { get; set; }

                /// <summary>
                /// <para>The number of the returned page.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cn-beijing</para>
                /// </summary>
                [NameInMap("RegionId")]
                [Validation(Required=false)]
                public string RegionId { get; set; }

                /// <summary>
                /// <para>The time when the configuration was created.</para>
                /// 
                /// <b>Example:</b>
                /// <para>sae-1f240907a6faf58c653f09e81b7e****</para>
                /// </summary>
                [NameInMap("SlsLogStore")]
                [Validation(Required=false)]
                public string SlsLogStore { get; set; }

                /// <summary>
                /// <para>The type of the log. Set this value to <b>file_log</b>.</para>
                /// 
                /// <b>Example:</b>
                /// <para>sae-56f77b65-788d-442a-9885-7f20d91f****</para>
                /// </summary>
                [NameInMap("SlsProject")]
                [Validation(Required=false)]
                public string SlsProject { get; set; }

                /// <summary>
                /// <para>The ID of the Log Service project.</para>
                /// 
                /// <b>Example:</b>
                /// <para>sls</para>
                /// </summary>
                [NameInMap("StoreType")]
                [Validation(Required=false)]
                public string StoreType { get; set; }

            }

            /// <summary>
            /// <para>The error code.</para>
            /// <list type="bullet">
            /// <item><description>The <b>ErrorCode</b> parameter is not returned when the request succeeds.</description></item>
            /// <item><description>The <b>ErrorCode</b> parameter is returned when the request fails. For more information, see <b>Error codes</b> in this topic.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            /// <summary>
            /// <para>The number of entries returned on each page.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("TotalSize")]
            [Validation(Required=false)]
            public int? TotalSize { get; set; }

        }

        /// <summary>
        /// <para>The HTTP status code. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>2xx</b>: indicates that the request was successful.</description></item>
        /// <item><description><b>3xx</b>: indicates that the request was redirected.</description></item>
        /// <item><description><b>4xx</b>: indicates that the request was invalid.</description></item>
        /// <item><description><b>5xx</b>: indicates that a server error occurred.</description></item>
        /// </list>
        /// </summary>
        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// <para>The ID of the trace. It can be used to query the details of a request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The returned message.</para>
        /// <list type="bullet">
        /// <item><description><b>success</b> is returned when the request succeeds.</description></item>
        /// <item><description>An error code is returned when the request fails.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>91F93257-7A4A-4BD3-9A7E-2F6EAE6D****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// <para>The logging configurations.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ac1d5e2c15671581252413581d****</para>
        /// </summary>
        [NameInMap("TraceId")]
        [Validation(Required=false)]
        public string TraceId { get; set; }

    }

}
