// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataphin_public20230630.Models
{
    public class GetQualityArchiveTableProgressResponseBody : TeaModel {
        /// <summary>
        /// <para>The backend response code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The asynchronous task progress details.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetQualityArchiveTableProgressResponseBodyData Data { get; set; }
        public class GetQualityArchiveTableProgressResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The archived table ID. This parameter is returned after the task succeeds and can be used to switch the active table.</para>
            /// 
            /// <b>Example:</b>
            /// <para>88012</para>
            /// </summary>
            [NameInMap("ArchiveTableId")]
            [Validation(Required=false)]
            public long? ArchiveTableId { get; set; }

            /// <summary>
            /// <para>The full name of the archived table. This parameter is returned after the task succeeds. When creating a table, the name includes the automatically appended _exception_data suffix.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Train.a01_reanme3_exception_data</para>
            /// </summary>
            [NameInMap("ArchiveTableName")]
            [Validation(Required=false)]
            public string ArchiveTableName { get; set; }

            /// <summary>
            /// <para>The reason for the task failure. This parameter is returned only when Status is FAILED.</para>
            /// 
            /// <b>Example:</b>
            /// <para>The archived table name already exists!</para>
            /// </summary>
            [NameInMap("ErrorMessage")]
            [Validation(Required=false)]
            public string ErrorMessage { get; set; }

            /// <summary>
            /// <para>The task status. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>PROGRESS: In progress.</description></item>
            /// <item><description>SUCCESS: Succeeded.</description></item>
            /// <item><description>FAILED: Failed.</description></item>
            /// <item><description>CANCEL: Canceled.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>SUCCESS</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

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
        /// <para>The backend exception details.</para>
        /// 
        /// <b>Example:</b>
        /// <para>internal error</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>82E78D6B-AA8F-1FEF-8AA3-5C9DA2A79140</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request was successful.</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
