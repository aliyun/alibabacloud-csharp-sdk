// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.DAS20200116.Models
{
    public class GetInstanceGroupInspectReportDetailResponseBody : TeaModel {
        /// <summary>
        /// <para>The status code returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>ReportDetail</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetInstanceGroupInspectReportDetailResponseBodyData Data { get; set; }
        public class GetInstanceGroupInspectReportDetailResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The content of the automated operations report, including the report date and diagnostic details of managed instances.</para>
            /// 
            /// <b>Example:</b>
            /// <para>&quot;### 概要\n\n报告日期：2025-12-10  \n对比周期：[昨日日期] → 2025-12-10 以下省略&quot;</para>
            /// </summary>
            [NameInMap("ReportDetail")]
            [Validation(Required=false)]
            public string ReportDetail { get; set; }

            /// <summary>
            /// <para>The report ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>13f52040-5a6e-42c3-bb84-051f5d6d****</para>
            /// </summary>
            [NameInMap("ReportId")]
            [Validation(Required=false)]
            public string ReportId { get; set; }

        }

        /// <summary>
        /// <para>The message returned for the request.</para>
        /// <remarks>
        /// <para>If the request is successful, <b>Successful</b> is returned. If the request fails, exception information such as an error code is returned.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>Successful</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>B6D17591-B48B-4D31-9CD6-9B9796B2****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request is successful. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: The request is successful.</description></item>
        /// <item><description>false: The request fails.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public string Success { get; set; }

    }

}
