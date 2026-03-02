// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ververica20220718.Models
{
    public class SqlStatementWithContext : TeaModel {
        /// <summary>
        /// <para>The additional dependencies.</para>
        /// </summary>
        [NameInMap("additionalDependencies")]
        [Validation(Required=false)]
        public List<string> AdditionalDependencies { get; set; }

        /// <summary>
        /// <para>Specifies whether the deployment is a batch deployment.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("batchMode")]
        [Validation(Required=false)]
        public bool? BatchMode { get; set; }

        /// <summary>
        /// <para>The Realtime Compute for Apache Flink configuration.</para>
        /// </summary>
        [NameInMap("flinkConfiguration")]
        [Validation(Required=false)]
        public Dictionary<string, object> FlinkConfiguration { get; set; }

        /// <summary>
        /// <para>The code of the deployment.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>CREATE TEMPORARY TABLE datagen_source (
        ///     name VARCHAR,
        ///     score BIGINT
        /// ) WITH (
        ///    \&quot;connector\&quot; = \&quot;datagen\&quot;
        /// );
        /// CREATE TEMPORARY TABLE print_table (
        ///    name VARCHAR,
        ///    score BIGINT
        /// ) WITH (
        ///   \&quot;connector\&quot;=\&quot;print\&quot;,
        ///   \&quot;logger\&quot;=\&quot;true\&quot;
        /// );</para>
        /// <para>INSERT INTO print_table
        /// select * from datagen_source;</para>
        /// </summary>
        [NameInMap("statement")]
        [Validation(Required=false)]
        public string Statement { get; set; }

        /// <summary>
        /// <para>The engine version.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vvr-8.0.6-flink-1.17</para>
        /// </summary>
        [NameInMap("versionName")]
        [Validation(Required=false)]
        public string VersionName { get; set; }

    }

}
