// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardbx20200202.Models
{
    public class SubmitSqlFlashbackTaskRequest : TeaModel {
        /// <summary>
        /// <para>The name of the database.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("DbName")]
        [Validation(Required=false)]
        public string DbName { get; set; }

        /// <summary>
        /// <para>The end time for executing the flashback SQL.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2019-09-10 23:23:23</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// <para>The instance ID of the PolarDB-X instance.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pxc-*********</para>
        /// </summary>
        [NameInMap("PolardbxInstanceId")]
        [Validation(Required=false)]
        public string PolardbxInstanceId { get; set; }

        /// <summary>
        /// <para>The restoration type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>1</b>: Image-based restoration.</description></item>
        /// <item><description><b>0</b>: Reverse restoration.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("RecallRestoreType")]
        [Validation(Required=false)]
        public string RecallRestoreType { get; set; }

        /// <summary>
        /// <para>The matching mode. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>0</b>: exact match.</description></item>
        /// <item><description><b>1</b>: fuzzy match.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// 
        /// <b>if can be null:</b>
        /// <c>true</c>
        /// </summary>
        [NameInMap("RecallType")]
        [Validation(Required=false)]
        public string RecallType { get; set; }

        /// <summary>
        /// <para>The region where the instance resides.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The primary key of the flashback SQL.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1111</para>
        /// 
        /// <b>if can be null:</b>
        /// <c>true</c>
        /// </summary>
        [NameInMap("SqlPk")]
        [Validation(Required=false)]
        public string SqlPk { get; set; }

        /// <summary>
        /// <para>The type of SQL. Valid values: INSERT, UPDATE, and DELETE. Separate multiple types with commas (,).</para>
        /// 
        /// <b>Example:</b>
        /// <para>INSERT,UPDATE</para>
        /// 
        /// <b>if can be null:</b>
        /// <c>true</c>
        /// </summary>
        [NameInMap("SqlType")]
        [Validation(Required=false)]
        public string SqlType { get; set; }

        /// <summary>
        /// <para>The start time for executing the flashback SQL.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2019-09-10 20:23:23</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

        /// <summary>
        /// <para>The name of the table on which the flashback SQL operation is performed.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// 
        /// <b>if can be null:</b>
        /// <c>true</c>
        /// </summary>
        [NameInMap("TableName")]
        [Validation(Required=false)]
        public string TableName { get; set; }

        /// <summary>
        /// <para>The trace ID of the flashback SQL.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ase*****</para>
        /// 
        /// <b>if can be null:</b>
        /// <c>true</c>
        /// </summary>
        [NameInMap("TraceId")]
        [Validation(Required=false)]
        public string TraceId { get; set; }

    }

}
