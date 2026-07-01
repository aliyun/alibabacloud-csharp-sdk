// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ververica20220718.Models
{
    public class SqlFile : TeaModel {
        /// <summary>
        /// <para>The batch mode.</para>
        /// </summary>
        [NameInMap("batchMode")]
        [Validation(Required=false)]
        public string BatchMode { get; set; }

        /// <summary>
        /// <para>The description of the SQL file.</para>
        /// </summary>
        [NameInMap("description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The name of the SQL file.</para>
        /// </summary>
        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The namespace.</para>
        /// </summary>
        [NameInMap("namespace")]
        [Validation(Required=false)]
        public string Namespace { get; set; }

        /// <summary>
        /// <para>The ID of the parent SQL file.</para>
        /// </summary>
        [NameInMap("parentId")]
        [Validation(Required=false)]
        public string ParentId { get; set; }

        /// <summary>
        /// <para>The name of the session cluster.</para>
        /// </summary>
        [NameInMap("sessionClusterName")]
        [Validation(Required=false)]
        public string SessionClusterName { get; set; }

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
        /// <para>The workspace ID.</para>
        /// </summary>
        [NameInMap("workspace")]
        [Validation(Required=false)]
        public string Workspace { get; set; }

    }

}
