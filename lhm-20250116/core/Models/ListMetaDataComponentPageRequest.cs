// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.LHM20250116.Models
{
    public class ListMetaDataComponentPageRequest : TeaModel {
        /// <summary>
        /// <para>The category type of the data source. Valid values: DATASET, WORKFLOW, and ENGINE. For scheduling scenarios, this parameter is set to WORKFLOW.</para>
        /// 
        /// <b>Example:</b>
        /// <para>WORKFLOW</para>
        /// </summary>
        [NameInMap("categoryType")]
        [Validation(Required=false)]
        public string CategoryType { get; set; }

        /// <summary>
        /// <para>The entry component type. In some operations, this parameter is used as a backward compatible field for version 1.1.0. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>0: source</description></item>
        /// <item><description>1: destination</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("componentType")]
        [Validation(Required=false)]
        public int? ComponentType { get; set; }

        /// <summary>
        /// <para>The data source name. Exact match and fuzzy match are supported.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test_ds318_hangzhou_0428</para>
        /// </summary>
        [NameInMap("dsName")]
        [Validation(Required=false)]
        public string DsName { get; set; }

        /// <summary>
        /// <para>The connectivity status of the data source. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>0: Not tested.</description></item>
        /// <item><description>1: Connected.</description></item>
        /// <item><description>2: Connection failed.</description></item>
        /// <item><description>-1: Connectivity test not supported.</description></item>
        /// </list>
        /// </summary>
        [NameInMap("dsStatus")]
        [Validation(Required=false)]
        public List<int?> DsStatus { get; set; }

        /// <summary>
        /// <para>The data source type, such as Hive or MaxCompute.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Hive</para>
        /// </summary>
        [NameInMap("dsType")]
        [Validation(Required=false)]
        public string DsType { get; set; }

        /// <summary>
        /// <para>The list of data source types.</para>
        /// </summary>
        [NameInMap("dsTypeList")]
        [Validation(Required=false)]
        public List<string> DsTypeList { get; set; }

        /// <summary>
        /// <para>The grouping field (GROUP BY condition). Set this parameter as needed.</para>
        /// 
        /// <b>Example:</b>
        /// <para>order_date</para>
        /// </summary>
        [NameInMap("groupBy")]
        [Validation(Required=false)]
        public string GroupBy { get; set; }

        /// <summary>
        /// <para>Specifies whether to return the total number of records in the paginated result.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("needTotalCount")]
        [Validation(Required=false)]
        public string NeedTotalCount { get; set; }

        /// <summary>
        /// <para>The sort field. Set this parameter as needed.</para>
        /// 
        /// <b>Example:</b>
        /// <para>gmtCreate</para>
        /// </summary>
        [NameInMap("orderBy")]
        [Validation(Required=false)]
        public string OrderBy { get; set; }

        /// <summary>
        /// <para>The sort direction. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>ASC: ascending order</description></item>
        /// <item><description>DESC: descending order</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>DESC</para>
        /// </summary>
        [NameInMap("orderDirection")]
        [Validation(Required=false)]
        public string OrderDirection { get; set; }

        /// <summary>
        /// <para>The page number, starting from 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("pageIndex")]
        [Validation(Required=false)]
        public int? PageIndex { get; set; }

        /// <summary>
        /// <para>The page size, which is the number of records returned per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("pageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The source component ID, which is the primary key of the source data source component.</para>
        /// 
        /// <b>Example:</b>
        /// <para>12345</para>
        /// </summary>
        [NameInMap("srcComponentId")]
        [Validation(Required=false)]
        public long? SrcComponentId { get; set; }

    }

}
