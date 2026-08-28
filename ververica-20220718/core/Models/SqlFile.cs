// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ververica20220718.Models
{
    public class SqlFile : TeaModel {
        /// <term><b>Obsolete</b></term>
        [NameInMap("batchMode")]
        [Validation(Required=false)]
        [Obsolete]
        public string BatchMode { get; set; }

        [NameInMap("description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The query script name. This field is required when creating a SqlFile.</para>
        /// </summary>
        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("namespace")]
        [Validation(Required=false)]
        public string Namespace { get; set; }

        /// <summary>
        /// <para>The parent folder ID. This field is required when creating a SqlFile.</para>
        /// </summary>
        [NameInMap("parentId")]
        [Validation(Required=false)]
        public string ParentId { get; set; }

        /// <summary>
        /// <para>The session cluster for running the query script. This field is required when creating a SqlFile.</para>
        /// </summary>
        [NameInMap("sessionClusterName")]
        [Validation(Required=false)]
        public string SessionClusterName { get; set; }

        [NameInMap("sqlFileId")]
        [Validation(Required=false)]
        public string SqlFileId { get; set; }

        /// <summary>
        /// <para>The SQL script. This field is required when creating a SqlFile.</para>
        /// </summary>
        [NameInMap("sqlScript")]
        [Validation(Required=false)]
        public string SqlScript { get; set; }

        [NameInMap("workspace")]
        [Validation(Required=false)]
        public string Workspace { get; set; }

    }

}
