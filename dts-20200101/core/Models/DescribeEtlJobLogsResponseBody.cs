// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dts20200101.Models
{
    public class DescribeEtlJobLogsResponseBody : TeaModel {
        /// <summary>
        /// <para>The dynamic error code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>403</para>
        /// </summary>
        [NameInMap("DynamicCode")]
        [Validation(Required=false)]
        public string DynamicCode { get; set; }

        /// <summary>
        /// <para>The dynamic part in the error message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>present environment is not support,so skip.</para>
        /// </summary>
        [NameInMap("DynamicMessage")]
        [Validation(Required=false)]
        public string DynamicMessage { get; set; }

        /// <summary>
        /// <para>The error code. This example indicates that the specified ETL task ID is invalid.</para>
        /// 
        /// <b>Example:</b>
        /// <para>InvalidJobId</para>
        /// </summary>
        [NameInMap("ErrCode")]
        [Validation(Required=false)]
        public string ErrCode { get; set; }

        /// <summary>
        /// <para>The error message. This example indicates that the specified ETL task ID does not exist. In this case, the ETL task may be deleted.</para>
        /// 
        /// <b>Example:</b>
        /// <para>The specified dts job id %s is not exists.</para>
        /// </summary>
        [NameInMap("ErrMessage")]
        [Validation(Required=false)]
        public string ErrMessage { get; set; }

        /// <summary>
        /// <para>The logs of ETL tasks.</para>
        /// </summary>
        [NameInMap("EtlRunningLogs")]
        [Validation(Required=false)]
        public List<DescribeEtlJobLogsResponseBodyEtlRunningLogs> EtlRunningLogs { get; set; }
        public class DescribeEtlJobLogsResponseBodyEtlRunningLogs : TeaModel {
            /// <summary>
            /// <para>The state of the ETL task.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Starting DTS-ETL...</para>
            /// </summary>
            [NameInMap("Content")]
            [Validation(Required=false)]
            public string Content { get; set; }

            /// <summary>
            /// <para>The module for which the logs are generated, such as the conversion module of ETL tasks.</para>
            /// 
            /// <b>Example:</b>
            /// <para>DTS-ETL</para>
            /// </summary>
            [NameInMap("ContentKey")]
            [Validation(Required=false)]
            public string ContentKey { get; set; }

            /// <summary>
            /// <para>The ID of the ETL task.</para>
            /// 
            /// <b>Example:</b>
            /// <para>u**********5</para>
            /// </summary>
            [NameInMap("EtlId")]
            [Validation(Required=false)]
            public string EtlId { get; set; }

            /// <summary>
            /// <para>The time when the log was generated. This value is a UNIX timestamp representing the number of milliseconds that have elapsed since January 1, 1970, 00:00:00 UTC.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1637306503000</para>
            /// </summary>
            [NameInMap("LogDatetime")]
            [Validation(Required=false)]
            public string LogDatetime { get; set; }

            /// <summary>
            /// <para>The log level. Valid values: ERROR, WARN, INFO, and DEBUG.</para>
            /// 
            /// <b>Example:</b>
            /// <para>INFO</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The ID of the user.</para>
            /// 
            /// <b>Example:</b>
            /// <para>121323*******454512</para>
            /// </summary>
            [NameInMap("UserId")]
            [Validation(Required=false)]
            public string UserId { get; set; }

        }

        /// <summary>
        /// <para>The HTTP status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>224DB9F7-3100-4899-AB9C-C938BCCB43E7</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the call was successful. If the call failed, false is returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
