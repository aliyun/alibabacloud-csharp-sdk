// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ververica20220718.Models
{
    public class GetLineageInfoParams : TeaModel {
        /// <summary>
        /// <para>The depth of the data lineage.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("depth")]
        [Validation(Required=false)]
        public long? Depth { get; set; }

        /// <summary>
        /// <para>The direction of the lineage. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>UPSTREAM: searches for upstream operators.</description></item>
        /// <item><description>DOWNSTREAM: searches for downstream operators.</description></item>
        /// <item><description>BOTH: searches for both upstream and downstream operators.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Both</para>
        /// </summary>
        [NameInMap("direction")]
        [Validation(Required=false)]
        public string Direction { get; set; }

        /// <summary>
        /// <para>The job ID or the table ID. You can call the ListJobs operation to obtain the job ID or call the ListTables operation to obtain the table ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>664cc64d-5dea-4ad3-9ee4-8432a874****</para>
        /// </summary>
        [NameInMap("id")]
        [Validation(Required=false)]
        public string Id { get; set; }

        /// <summary>
        /// <para>The data type of the job or table. If the id parameter is set to the job ID, the value of this parameter is the data type of the job. If the id parameter is set to the table ID, the value of this parameter is the data type of the table.</para>
        /// 
        /// <b>Example:</b>
        /// <para>JOB</para>
        /// </summary>
        [NameInMap("idType")]
        [Validation(Required=false)]
        public string IdType { get; set; }

        /// <summary>
        /// <para>The lineage type. The value true indicates a field-level lineage. The value false indicates a table-level lineage.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("isColumnLevel")]
        [Validation(Required=false)]
        public bool? IsColumnLevel { get; set; }

        /// <summary>
        /// <para>Indicates whether the table was a temporary table.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("isTemporary")]
        [Validation(Required=false)]
        public bool? IsTemporary { get; set; }

        /// <summary>
        /// <para>The name of the namespace.</para>
        /// 
        /// <b>Example:</b>
        /// <para>default-namespace</para>
        /// </summary>
        [NameInMap("namespace")]
        [Validation(Required=false)]
        public string Namespace { get; set; }

        /// <summary>
        /// <para>The workspace ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>a14bd5d90a****</para>
        /// </summary>
        [NameInMap("workspace")]
        [Validation(Required=false)]
        public string Workspace { get; set; }

    }

}
