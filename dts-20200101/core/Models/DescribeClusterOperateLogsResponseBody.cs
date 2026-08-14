// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dts20200101.Models
{
    public class DescribeClusterOperateLogsResponseBody : TeaModel {
        /// <summary>
        /// <para>The backend error code, which is incrementally numeric.</para>
        /// 
        /// <b>Example:</b>
        /// <para>500</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The monitoring statistics information.</para>
        /// </summary>
        [NameInMap("DataPoints")]
        [Validation(Required=false)]
        public List<DescribeClusterOperateLogsResponseBodyDataPoints> DataPoints { get; set; }
        public class DescribeClusterOperateLogsResponseBodyDataPoints : TeaModel {
            /// <summary>
            /// <para>The additional remarks.</para>
            /// 
            /// <b>Example:</b>
            /// <para>null</para>
            /// </summary>
            [NameInMap("Content")]
            [Validation(Required=false)]
            public string Content { get; set; }

            /// <summary>
            /// <para>The primary key of the log record table.</para>
            /// 
            /// <b>Example:</b>
            /// <para>237827</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            /// <summary>
            /// <para>The timestamp. Unit: milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1642077211574</para>
            /// </summary>
            [NameInMap("LogDatetime")]
            [Validation(Required=false)]
            public long? LogDatetime { get; set; }

            /// <summary>
            /// <para>The new parameter value when the operation type is update.</para>
            /// 
            /// <b>Example:</b>
            /// <para>105</para>
            /// </summary>
            [NameInMap("NewValue")]
            [Validation(Required=false)]
            public string NewValue { get; set; }

            /// <summary>
            /// <para>The old parameter value when the operation type is update.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("OldValue")]
            [Validation(Required=false)]
            public string OldValue { get; set; }

            /// <summary>
            /// <para>The operation type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>modify-oversold-ratio</para>
            /// </summary>
            [NameInMap("OperationName")]
            [Validation(Required=false)]
            public string OperationName { get; set; }

            /// <summary>
            /// <para>The operator.</para>
            /// 
            /// <b>Example:</b>
            /// <para>null</para>
            /// </summary>
            [NameInMap("OperationUser")]
            [Validation(Required=false)]
            public string OperationUser { get; set; }

            /// <summary>
            /// <para>The call result. Indicates whether the call was successful. A value of <b>1</b> indicates success.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Success")]
            [Validation(Required=false)]
            public int? Success { get; set; }

        }

        /// <summary>
        /// <para>The dynamic error message, which is used to replace the %s placeholder in the ErrMessage response parameter.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Type</para>
        /// </summary>
        [NameInMap("DynamicMessage")]
        [Validation(Required=false)]
        public string DynamicMessage { get; set; }

        /// <summary>
        /// <para>The error code returned when the call fails.</para>
        /// 
        /// <b>Example:</b>
        /// <para>InternalError</para>
        /// </summary>
        [NameInMap("ErrCode")]
        [Validation(Required=false)]
        public string ErrCode { get; set; }

        /// <summary>
        /// <para>The error message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>The Value of Input Parameter %s is not valid.</para>
        /// </summary>
        [NameInMap("ErrMessage")]
        [Validation(Required=false)]
        public string ErrMessage { get; set; }

        /// <summary>
        /// <para>The HTTP status code corresponding to the exception.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// <para>The current page number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries displayed on the current page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("PageRecordCount")]
        [Validation(Required=false)]
        public int? PageRecordCount { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>621BB4F8-3016-4FAA-8D5A-5D3163CC****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The call result.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// <para>The total number of records.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("TotalRecordCount")]
        [Validation(Required=false)]
        public long? TotalRecordCount { get; set; }

    }

}
