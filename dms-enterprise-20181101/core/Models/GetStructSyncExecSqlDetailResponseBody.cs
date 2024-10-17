// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms_enterprise20181101.Models
{
    public class GetStructSyncExecSqlDetailResponseBody : TeaModel {
        /// <summary>
        /// <para>The error code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>UnknownError</para>
        /// </summary>
        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// <para>The error message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>UnknownError</para>
        /// </summary>
        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1810E635-A2D7-428B-BAA9-85DAEB9B1A77</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The details of the SQL statements.</para>
        /// </summary>
        [NameInMap("StructSyncExecSqlDetail")]
        [Validation(Required=false)]
        public GetStructSyncExecSqlDetailResponseBodyStructSyncExecSqlDetail StructSyncExecSqlDetail { get; set; }
        public class GetStructSyncExecSqlDetailResponseBodyStructSyncExecSqlDetail : TeaModel {
            /// <summary>
            /// <para>The SQL statements that are executed.</para>
            /// </summary>
            [NameInMap("ExecSql")]
            [Validation(Required=false)]
            public string ExecSql { get; set; }

            /// <summary>
            /// <para>The total number of SQL statements.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("TotalSqlCount")]
            [Validation(Required=false)]
            public long? TotalSqlCount { get; set; }

        }

        /// <summary>
        /// <para>Indicates whether the request is successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
