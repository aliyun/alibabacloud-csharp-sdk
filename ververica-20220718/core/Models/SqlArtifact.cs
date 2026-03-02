// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ververica20220718.Models
{
    public class SqlArtifact : TeaModel {
        /// <summary>
        /// <para>The additional dependency files. If you want to use dependencies such as UDFs, connectors, and formats that are not registered on Ververica Platform (VVP), you need to configure this parameter. You do not need to configure this parameter for dependencies that are registered on VVP.</para>
        /// </summary>
        [NameInMap("additionalDependencies")]
        [Validation(Required=false)]
        public List<string> AdditionalDependencies { get; set; }

        /// <summary>
        /// <para>The script of the SQL deployment.</para>
        /// 
        /// <b>Example:</b>
        /// <para>CREATE TEMPORARY TABLE datagen_source(   name VARCHAR ) WITH (   \&quot;connector\&quot; = \&quot;datagen\&quot; ); CREATE TEMPORARY TABLE blackhole_sink(   name  VARCHAR ) with (   \&quot;connector\&quot; = \&quot;blackhole\&quot; ); INSERT INTO blackhole_sink SELECT name from datagen_source;</para>
        /// </summary>
        [NameInMap("sqlScript")]
        [Validation(Required=false)]
        public string SqlScript { get; set; }

    }

}
