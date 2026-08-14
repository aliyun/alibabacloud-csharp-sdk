// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dts20200101.Models
{
    public class DescribeEtlJobLogsResponseBody : TeaModel {
        /// <summary>
        /// <para>The dynamic error code associated with this request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>403</para>
        /// </summary>
        [NameInMap("DynamicCode")]
        [Validation(Required=false)]
        public string DynamicCode { get; set; }

        /// <summary>
        /// <para>The dynamic error message associated with this request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>present environment is not support,so skip.</para>
        /// </summary>
        [NameInMap("DynamicMessage")]
        [Validation(Required=false)]
        public string DynamicMessage { get; set; }

        /// <summary>
        /// <para>The error code returned when the specified ETL task ID is invalid and the corresponding task cannot be found.</para>
        /// 
        /// <b>Example:</b>
        /// <para>InvalidJobId</para>
        /// </summary>
        [NameInMap("ErrCode")]
        [Validation(Required=false)]
        public string ErrCode { get; set; }

        /// <summary>
        /// <para>The error message returned when the specified ETL task ID is invalid and the corresponding task cannot be found. The task may have been deleted.</para>
        /// 
        /// <b>Example:</b>
        /// <para>The specified dts job id %s is not exists.</para>
        /// </summary>
        [NameInMap("ErrMessage")]
        [Validation(Required=false)]
        public string ErrMessage { get; set; }

        /// <summary>
        /// <para>The array of ETL task running log objects.</para>
        /// </summary>
        [NameInMap("EtlRunningLogs")]
        [Validation(Required=false)]
        public List<DescribeEtlJobLogsResponseBodyEtlRunningLogs> EtlRunningLogs { get; set; }
        public class DescribeEtlJobLogsResponseBodyEtlRunningLogs : TeaModel {
            /// <summary>
            /// <para>The description of the ETL task running status.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Starting DTS-ETL...</para>
            /// </summary>
            [NameInMap("Content")]
            [Validation(Required=false)]
            public string Content { get; set; }

            /// <summary>
            /// <para>The status, which indicates the name of the module that generated the log, such as the transformation module of the ETL task.</para>
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
            /// <para>The timestamp when the log was generated.</para>
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
            /// <para>The user ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>123123******12131</para>
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
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>224DB9F7-3100-4899-AB9C-C938BCCB43E7</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request was successful. A value of false indicates a failure.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
