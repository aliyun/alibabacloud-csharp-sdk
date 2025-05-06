// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Emr_serverless_spark20230808.Models
{
    public class CreateSqlStatementResponseBody : TeaModel {
        /// <summary>
        /// <para>The data returned.</para>
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public CreateSqlStatementResponseBodyData Data { get; set; }
        public class CreateSqlStatementResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The interactive query ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>st-1231dfafadfa***</para>
            /// </summary>
            [NameInMap("statementId")]
            [Validation(Required=false)]
            public string StatementId { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>DD6B1B2A-5837-5237-ABE4-FF0C8944****</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
