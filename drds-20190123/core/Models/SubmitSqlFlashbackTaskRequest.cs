// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Drds20190123.Models
{
    public class SubmitSqlFlashbackTaskRequest : TeaModel {
        /// <summary>
        /// <para>The name of the DRDS database.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("DbName")]
        [Validation(Required=false)]
        public string DbName { get; set; }

        /// <summary>
        /// <para>The ID of a DRDS instance.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>drds*********</para>
        /// </summary>
        [NameInMap("DrdsInstanceId")]
        [Validation(Required=false)]
        public string DrdsInstanceId { get; set; }

        /// <summary>
        /// <para>The time when the SQL flashback task ends.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2019-09-10 23:23:23</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// <para>The restoration type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>1: Image restoration</description></item>
        /// <item><description>0: reverse recovery</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("RecallRestoreType")]
        [Validation(Required=false)]
        public int? RecallRestoreType { get; set; }

        /// <summary>
        /// <para>Exact match or fuzzy match. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>0: the exact match.</description></item>
        /// <item><description>1: the fuzzy match.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("RecallType")]
        [Validation(Required=false)]
        public int? RecallType { get; set; }

        /// <summary>
        /// <para>The primary key of flashback SQL.</para>
        /// 
        /// <b>Example:</b>
        /// <para>11111</para>
        /// </summary>
        [NameInMap("SqlPk")]
        [Validation(Required=false)]
        public string SqlPk { get; set; }

        /// <summary>
        /// <para>The type of the SQL statement. Valid values: INSERT, UPDATE, and DELETE. Separate multiple types with commas (,).</para>
        /// 
        /// <b>Example:</b>
        /// <para>INSERT,UPDATE</para>
        /// </summary>
        [NameInMap("SqlType")]
        [Validation(Required=false)]
        public string SqlType { get; set; }

        /// <summary>
        /// <para>The start time of the flashback SQL statement.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2019-09-10 20:23:23</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

        /// <summary>
        /// <para>The name of the table where the flashback SQL operation was performed.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("TableName")]
        [Validation(Required=false)]
        public string TableName { get; set; }

        /// <summary>
        /// <para>The Trace ID of the flashback SQL.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ase*****</para>
        /// </summary>
        [NameInMap("TraceId")]
        [Validation(Required=false)]
        public string TraceId { get; set; }

    }

}
