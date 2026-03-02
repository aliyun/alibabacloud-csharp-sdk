// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ververica20220718.Models
{
    public class SqlStatementExecuteResult : TeaModel {
        /// <summary>
        /// <para>The error details returned.</para>
        /// </summary>
        [NameInMap("errorDetails")]
        [Validation(Required=false)]
        public ErrorDetails ErrorDetails { get; set; }

        /// <summary>
        /// <para>Indicates whether the request was successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("executeSuccess")]
        [Validation(Required=false)]
        public bool? ExecuteSuccess { get; set; }

        /// <summary>
        /// <para>The statement that was executed.</para>
        /// 
        /// <b>Example:</b>
        /// <para>“show create table order”</para>
        /// </summary>
        [NameInMap("statement")]
        [Validation(Required=false)]
        public string Statement { get; set; }

    }

}
