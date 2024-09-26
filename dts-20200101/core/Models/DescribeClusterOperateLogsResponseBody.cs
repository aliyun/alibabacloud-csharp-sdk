// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dts20200101.Models
{
    public class DescribeClusterOperateLogsResponseBody : TeaModel {
        /// <summary>
        /// <para>The error code returned by the backend service. The number is incremented.</para>
        /// 
        /// <b>Example:</b>
        /// <para>500</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The information about the operation logs.</para>
        /// </summary>
        [NameInMap("DataPoints")]
        [Validation(Required=false)]
        public List<DescribeClusterOperateLogsResponseBodyDataPoints> DataPoints { get; set; }
        public class DescribeClusterOperateLogsResponseBodyDataPoints : TeaModel {
            /// <summary>
            /// <para>Other description of the operation.</para>
            /// 
            /// <b>Example:</b>
            /// <para>null</para>
            /// </summary>
            [NameInMap("Content")]
            [Validation(Required=false)]
            public string Content { get; set; }

            /// <summary>
            /// <para>The primary key of the log table.</para>
            /// 
            /// <b>Example:</b>
            /// <para>237827</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            /// <summary>
            /// <para>The time when the operation is recorded. The value is in the UNIX timestamp format. Unit: milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1642077211574</para>
            /// </summary>
            [NameInMap("LogDatetime")]
            [Validation(Required=false)]
            public long? LogDatetime { get; set; }

            /// <summary>
            /// <para>The value of the parameter after the operation if the operation is an UPDATE operation.</para>
            /// 
            /// <b>Example:</b>
            /// <para>105</para>
            /// </summary>
            [NameInMap("NewValue")]
            [Validation(Required=false)]
            public string NewValue { get; set; }

            /// <summary>
            /// <para>The value of the parameter before the operation if the operation is an UPDATE operation.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("OldValue")]
            [Validation(Required=false)]
            public string OldValue { get; set; }

            /// <summary>
            /// <para>The type of the operation.</para>
            /// 
            /// <b>Example:</b>
            /// <para>modify-oversold-ratio</para>
            /// </summary>
            [NameInMap("OperationName")]
            [Validation(Required=false)]
            public string OperationName { get; set; }

            /// <summary>
            /// <para>The user who performed the operation.</para>
            /// 
            /// <b>Example:</b>
            /// <para>null</para>
            /// </summary>
            [NameInMap("OperationUser")]
            [Validation(Required=false)]
            public string OperationUser { get; set; }

            /// <summary>
            /// <para>Indicates whether the request was successful. A value of <b>1</b> indicates that the request was successful.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Success")]
            [Validation(Required=false)]
            public int? Success { get; set; }

        }

        /// <summary>
        /// <para>The dynamic part in the error message. This parameter is used to replace %s in the ErrMessage parameter.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Type</para>
        /// </summary>
        [NameInMap("DynamicMessage")]
        [Validation(Required=false)]
        public string DynamicMessage { get; set; }

        /// <summary>
        /// <para>The error code returned if the request failed.</para>
        /// 
        /// <b>Example:</b>
        /// <para>InternalError</para>
        /// </summary>
        [NameInMap("ErrCode")]
        [Validation(Required=false)]
        public string ErrCode { get; set; }

        /// <summary>
        /// <para>The error message returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>The Value of Input Parameter %s is not valid.</para>
        /// </summary>
        [NameInMap("ErrMessage")]
        [Validation(Required=false)]
        public string ErrMessage { get; set; }

        /// <summary>
        /// <para>The HTTP status code returned for an exception.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// <para>The page number of the returned page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries returned per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("PageRecordCount")]
        [Validation(Required=false)]
        public int? PageRecordCount { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>621BB4F8-3016-4FAA-8D5A-5D3163CC****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request was successful.</para>
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
