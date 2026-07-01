// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ververica20220718.Models
{
    public class SqlExecution : TeaModel {
        /// <summary>
        /// <para>Specifies whether to enable batch mode.</para>
        /// </summary>
        [NameInMap("batchMode")]
        [Validation(Required=false)]
        public bool? BatchMode { get; set; }

        /// <summary>
        /// <para>The description of the SQL execution.</para>
        /// </summary>
        [NameInMap("description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The message returned for the SQL execution.</para>
        /// </summary>
        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The name of the SQL execution.</para>
        /// </summary>
        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The namespace.</para>
        /// 
        /// <b>Example:</b>
        /// <para>default-namespace</para>
        /// </summary>
        [NameInMap("namespace")]
        [Validation(Required=false)]
        public string Namespace { get; set; }

        /// <summary>
        /// <para>The name of the session cluster.</para>
        /// </summary>
        [NameInMap("sessionClusterName")]
        [Validation(Required=false)]
        public string SessionClusterName { get; set; }

        /// <summary>
        /// <para>The SQL execution ID.</para>
        /// </summary>
        [NameInMap("sqlExecutionId")]
        [Validation(Required=false)]
        public string SqlExecutionId { get; set; }

        /// <summary>
        /// <para>The SQL file ID.</para>
        /// </summary>
        [NameInMap("sqlFileId")]
        [Validation(Required=false)]
        public string SqlFileId { get; set; }

        /// <summary>
        /// <para>The SQL script content.</para>
        /// </summary>
        [NameInMap("sqlScript")]
        [Validation(Required=false)]
        public string SqlScript { get; set; }

        /// <summary>
        /// <para>The state of the SQL execution.</para>
        /// </summary>
        [NameInMap("state")]
        [Validation(Required=false)]
        public string State { get; set; }

        [NameInMap("statements")]
        [Validation(Required=false)]
        public List<SqlStatement> Statements { get; set; }

        /// <summary>
        /// <para>The workspace ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>edcef******b4f</para>
        /// </summary>
        [NameInMap("workspace")]
        [Validation(Required=false)]
        public string Workspace { get; set; }

    }

}
