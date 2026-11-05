// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Appstream_center20210901.Models
{
    public class QueryUserAppUsageAggregateByHourResponseBody : TeaModel {
        /// <summary>
        /// <para>The business status code. A value of 200 indicates that the request is successful. Other values indicate that the request failed.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The list of hourly aggregated user application usage data. A maximum of five records are returned for each hour.</para>
        /// </summary>
        [NameInMap("IndexData")]
        [Validation(Required=false)]
        public List<QueryUserAppUsageAggregateByHourResponseBodyIndexData> IndexData { get; set; }
        public class QueryUserAppUsageAggregateByHourResponseBodyIndexData : TeaModel {
            /// <summary>
            /// <para>The application ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>app-9ciijz60n4xsv****</para>
            /// </summary>
            [NameInMap("AppId")]
            [Validation(Required=false)]
            public string AppId { get; set; }

            /// <summary>
            /// <para>The application name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Visual Studio Code</para>
            /// </summary>
            [NameInMap("AppName")]
            [Validation(Required=false)]
            public string AppName { get; set; }

            /// <summary>
            /// <para>The cumulative usage duration of the application within the statistical range. Unit: seconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>200</para>
            /// </summary>
            [NameInMap("AppTimeCnt")]
            [Validation(Required=false)]
            public string AppTimeCnt { get; set; }

            /// <summary>
            /// <para>The statistical hour in a two-digit 24-hour format string. Valid values: 00 to 23. Hour boundaries are divided based on the Asia/Shanghai (UTC+8) time zone.</para>
            /// 
            /// <b>Example:</b>
            /// <para>02</para>
            /// </summary>
            [NameInMap("Hh")]
            [Validation(Required=false)]
            public string Hh { get; set; }

        }

        /// <summary>
        /// <para>The description of the request processing result. A value of success is usually returned when the request is successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The unique identifier of the request, which can be used to troubleshoot request issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1CBAFFAB-B697-4049-A9B1-67E1FC5F****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
