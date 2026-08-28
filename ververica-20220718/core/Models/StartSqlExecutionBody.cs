// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ververica20220718.Models
{
    public class StartSqlExecutionBody : TeaModel {
        /// <summary>
        /// <para>The execution description.</para>
        /// </summary>
        [NameInMap("description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The ID of the associated query script. This is a required parameter. It provides the execution environment configuration (Session Cluster, Flink configuration, etc.) and also serves as the parentResourceId for deduplication.</para>
        /// </summary>
        [NameInMap("sqlFileId")]
        [Validation(Required=false)]
        public string SqlFileId { get; set; }

        /// <summary>
        /// <para>The SQL script content to execute.</para>
        /// </summary>
        [NameInMap("sqlScript")]
        [Validation(Required=false)]
        public string SqlScript { get; set; }

    }

}
