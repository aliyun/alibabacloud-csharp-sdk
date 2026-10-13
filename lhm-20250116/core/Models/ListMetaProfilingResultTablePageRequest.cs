// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.LHM20250116.Models
{
    public class ListMetaProfilingResultTablePageRequest : TeaModel {
        /// <summary>
        /// <para>The identifier of the component (data source) type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("componentType")]
        [Validation(Required=false)]
        public int? ComponentType { get; set; }

        /// <summary>
        /// <para>The filter condition for the data range.</para>
        /// 
        /// <b>Example:</b>
        /// <para>LAST_7_DAYS</para>
        /// </summary>
        [NameInMap("dataRange")]
        [Validation(Required=false)]
        public string DataRange { get; set; }

        /// <summary>
        /// <para>The threshold for filtering by data size. This parameter must be used together with dataUnit.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1024.0</para>
        /// </summary>
        [NameInMap("dataSize")]
        [Validation(Required=false)]
        public double? DataSize { get; set; }

        /// <summary>
        /// <para>The unit of data size, such as GB or TB. This parameter must be used together with dataSize.</para>
        /// 
        /// <b>Example:</b>
        /// <para>GB</para>
        /// </summary>
        [NameInMap("dataUnit")]
        [Validation(Required=false)]
        public string DataUnit { get; set; }

        /// <summary>
        /// <para>The name of the database, which is used to filter results by database.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ods</para>
        /// </summary>
        [NameInMap("dbName")]
        [Validation(Required=false)]
        public string DbName { get; set; }

        /// <summary>
        /// <para>The name of the group-by field, which is used for aggregate statistics.</para>
        /// 
        /// <b>Example:</b>
        /// <para>dbName</para>
        /// </summary>
        [NameInMap("groupBy")]
        [Validation(Required=false)]
        public string GroupBy { get; set; }

        /// <summary>
        /// <para>Specifies whether to filter only partitioned tables.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("isPartitioned")]
        [Validation(Required=false)]
        public int? IsPartitioned { get; set; }

        /// <summary>
        /// <para>Specifies whether to return only summary statistics.</para>
        /// </summary>
        [NameInMap("isSummary")]
        [Validation(Required=false)]
        public bool? IsSummary { get; set; }

        /// <summary>
        /// <para>The migration status, which is used to filter by migration progress or indicate the migration status of an object.</para>
        /// 
        /// <b>Example:</b>
        /// <para>DONE</para>
        /// </summary>
        [NameInMap("migrationStatus")]
        [Validation(Required=false)]
        public string MigrationStatus { get; set; }

        /// <summary>
        /// <para>Specifies whether to return the total number of records.</para>
        /// </summary>
        [NameInMap("needTotalCount")]
        [Validation(Required=false)]
        public bool? NeedTotalCount { get; set; }

        /// <summary>
        /// <para>The name of the order-by field.</para>
        /// 
        /// <b>Example:</b>
        /// <para>gmtCreate</para>
        /// </summary>
        [NameInMap("orderBy")]
        [Validation(Required=false)]
        public string OrderBy { get; set; }

        /// <summary>
        /// <para>The sort direction, such as ascending (ASC) or descending (DESC).</para>
        /// 
        /// <b>Example:</b>
        /// <para>DESC</para>
        /// </summary>
        [NameInMap("orderDirection")]
        [Validation(Required=false)]
        public string OrderDirection { get; set; }

        /// <summary>
        /// <para>The current page number, starting from 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("pageIndex")]
        [Validation(Required=false)]
        public int? PageIndex { get; set; }

        /// <summary>
        /// <para>The number of records to return on each page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("pageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The name of the table, which is used to filter results by table name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ods_order_detail</para>
        /// </summary>
        [NameInMap("tableName")]
        [Validation(Required=false)]
        public string TableName { get; set; }

        /// <summary>
        /// <para>The ID of the metadata profiling task, which is used to locate the profiling task to which this query belongs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100256</para>
        /// </summary>
        [NameInMap("taskId")]
        [Validation(Required=false)]
        public long? TaskId { get; set; }

        /// <summary>
        /// <para>The identifier of the object type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>TABLE</para>
        /// </summary>
        [NameInMap("type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
