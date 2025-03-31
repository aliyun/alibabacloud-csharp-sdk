// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cr20181201.Models
{
    public class ListRepoBuildRecordLogResponseBody : TeaModel {
        /// <summary>
        /// <para>The log content of the image building record.</para>
        /// </summary>
        [NameInMap("BuildRecordLogs")]
        [Validation(Required=false)]
        public List<ListRepoBuildRecordLogResponseBodyBuildRecordLogs> BuildRecordLogs { get; set; }
        public class ListRepoBuildRecordLogResponseBodyBuildRecordLogs : TeaModel {
            /// <summary>
            /// <para>The stage of the building that is recorded in the log entry.</para>
            /// 
            /// <b>Example:</b>
            /// <para>GIT_CLONE</para>
            /// </summary>
            [NameInMap("BuildStage")]
            [Validation(Required=false)]
            public string BuildStage { get; set; }

            /// <summary>
            /// <para>The line number of the log entry.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("LineNumber")]
            [Validation(Required=false)]
            public int? LineNumber { get; set; }

            /// <summary>
            /// <para>The content of the log.</para>
            /// 
            /// <b>Example:</b>
            /// <para>fetch stage begin</para>
            /// </summary>
            [NameInMap("Message")]
            [Validation(Required=false)]
            public string Message { get; set; }

        }

        /// <summary>
        /// <para>The return value.</para>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>Indicates whether the request is successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("IsSuccess")]
        [Validation(Required=false)]
        public bool? IsSuccess { get; set; }

        /// <summary>
        /// <para>The page number of the returned page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNo")]
        [Validation(Required=false)]
        public int? PageNo { get; set; }

        /// <summary>
        /// <para>The number of entries returned per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>4CE1F661-75DD-4EBD-A4AD-057B26834ABB</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of returned entries.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1000</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public string TotalCount { get; set; }

    }

}
