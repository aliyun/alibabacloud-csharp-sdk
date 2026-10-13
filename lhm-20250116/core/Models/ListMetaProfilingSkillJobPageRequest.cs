// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.LHM20250116.Models
{
    public class ListMetaProfilingSkillJobPageRequest : TeaModel {
        /// <summary>
        /// <para>The list of component IDs used to filter profiling tasks by multiple data source components.</para>
        /// </summary>
        [NameInMap("componentIds")]
        [Validation(Required=false)]
        public List<long?> ComponentIds { get; set; }

        /// <summary>
        /// <para>The data source ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3001</para>
        /// </summary>
        [NameInMap("dsId")]
        [Validation(Required=false)]
        public long? DsId { get; set; }

        /// <summary>
        /// <para>The data source name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>mysql_source_01</para>
        /// </summary>
        [NameInMap("dsName")]
        [Validation(Required=false)]
        public string DsName { get; set; }

        /// <summary>
        /// <para>The data source type identifier.</para>
        /// 
        /// <b>Example:</b>
        /// <para>MYSQL</para>
        /// </summary>
        [NameInMap("dsType")]
        [Validation(Required=false)]
        public string DsType { get; set; }

        /// <summary>
        /// <para>The name of the grouping field used for aggregation.</para>
        /// 
        /// <b>Example:</b>
        /// <para>dbName</para>
        /// </summary>
        [NameInMap("groupBy")]
        [Validation(Required=false)]
        public string GroupBy { get; set; }

        /// <summary>
        /// <para>Specifies whether to display system built-in tasks.</para>
        /// </summary>
        [NameInMap("isDisplaySystemTask")]
        [Validation(Required=false)]
        public bool? IsDisplaySystemTask { get; set; }

        /// <summary>
        /// <para>The profiling task ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100256</para>
        /// </summary>
        [NameInMap("jobId")]
        [Validation(Required=false)]
        public long? JobId { get; set; }

        /// <summary>
        /// <para>The profiling task name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>profiling_daily</para>
        /// </summary>
        [NameInMap("jobName")]
        [Validation(Required=false)]
        public string JobName { get; set; }

        /// <summary>
        /// <para>Specifies whether to return the total number of records.</para>
        /// </summary>
        [NameInMap("needTotalCount")]
        [Validation(Required=false)]
        public bool? NeedTotalCount { get; set; }

        /// <summary>
        /// <para>The name of the sort field.</para>
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
        /// <para>The number of records to return per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("pageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

    }

}
