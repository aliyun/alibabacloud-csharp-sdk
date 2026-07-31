// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adb20211201.Models
{
    public class GenerateSqlBySemanticSqlResponseBody : TeaModel {
        /// <summary>
        /// <para>The returned data.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GenerateSqlBySemanticSqlResponseBodyData Data { get; set; }
        public class GenerateSqlBySemanticSqlResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The error message returned when the task fails to be created.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Failed to rewrite semantic SQL: Ambiguous path from \&quot;lineitem\&quot; to \&quot;nation\&quot;. Multiple paths found</para>
            /// </summary>
            [NameInMap("ErrorMessage")]
            [Validation(Required=false)]
            public string ErrorMessage { get; set; }

            /// <summary>
            /// <para>The generated executable SQL statement.</para>
            /// 
            /// <b>Example:</b>
            /// <para>select sum(amount) from orders</para>
            /// </summary>
            [NameInMap("GeneratedSql")]
            [Validation(Required=false)]
            public string GeneratedSql { get; set; }

            /// <summary>
            /// <para>Indicates whether the generation request was successful. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>true</b>: Successful.</description></item>
            /// <item><description><b>false</b>: Failed.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("Success")]
            [Validation(Required=false)]
            public bool? Success { get; set; }

        }

        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>1AD222E9-E606-4A42-BF6D-8A4442913CEF</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
