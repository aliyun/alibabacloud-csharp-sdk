// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.LHM20250116.Models
{
    public class SaveSkillAuditRecordRequest : TeaModel {
        /// <summary>
        /// <para>The batch ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20001</para>
        /// </summary>
        [NameInMap("batchId")]
        [Validation(Required=false)]
        public string BatchId { get; set; }

        /// <summary>
        /// <para>The tenant ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>12313</para>
        /// </summary>
        [NameInMap("cid")]
        [Validation(Required=false)]
        public string Cid { get; set; }

        /// <summary>
        /// <para>The dry run status.</para>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("dryRunStatus")]
        [Validation(Required=false)]
        public string DryRunStatus { get; set; }

        /// <summary>
        /// <para>The extended information.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{}</para>
        /// </summary>
        [NameInMap("extInfo")]
        [Validation(Required=false)]
        public string ExtInfo { get; set; }

        /// <summary>
        /// <para>The record type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>logCorrelation</para>
        /// </summary>
        [NameInMap("recordType")]
        [Validation(Required=false)]
        public string RecordType { get; set; }

        /// <summary>
        /// <para>The conversion result.</para>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("scriptTransformResult")]
        [Validation(Required=false)]
        public string ScriptTransformResult { get; set; }

        /// <summary>
        /// <para>The conversion status.</para>
        /// 
        /// <b>Example:</b>
        /// <para>end</para>
        /// </summary>
        [NameInMap("scriptTransformStatus")]
        [Validation(Required=false)]
        public string ScriptTransformStatus { get; set; }

        /// <summary>
        /// <para>The source dialect.</para>
        /// 
        /// <b>Example:</b>
        /// <para>hive</para>
        /// </summary>
        [NameInMap("sourceDialect")]
        [Validation(Required=false)]
        public string SourceDialect { get; set; }

        /// <summary>
        /// <para>The source dialect content.</para>
        /// 
        /// <b>Example:</b>
        /// <para>SELECT * FROM t;</para>
        /// </summary>
        [NameInMap("sourceSqlScript")]
        [Validation(Required=false)]
        public string SourceSqlScript { get; set; }

        /// <summary>
        /// <para>The target dialect.</para>
        /// 
        /// <b>Example:</b>
        /// <para>bigquery</para>
        /// </summary>
        [NameInMap("targetDialect")]
        [Validation(Required=false)]
        public string TargetDialect { get; set; }

    }

}
