// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OceanBasePro20190901.Models
{
    public class DescribeOasAnomalySQLListRequest : TeaModel {
        /// <summary>
        /// <para>The language of the response. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>zh: Chinese</description></item>
        /// <item><description>en: English</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>zh-CN</para>
        /// </summary>
        [NameInMap("AcceptLanguage")]
        [Validation(Required=false)]
        public string AcceptLanguage { get; set; }

        /// <summary>
        /// <para>The current page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Current")]
        [Validation(Required=false)]
        public long? Current { get; set; }

        /// <summary>
        /// <para>The name of the database.</para>
        /// 
        /// <b>Example:</b>
        /// <para>db_****</para>
        /// </summary>
        [NameInMap("DbName")]
        [Validation(Required=false)]
        public string DbName { get; set; }

        /// <summary>
        /// <para>Specifies whether the specified SQL statements are dynamic SQL statements.</para>
        /// <remarks>
        /// <para>This parameter specifies whether the values of the <c>SqlId</c> parameter are the IDs of dynamic SQL statements.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("DynamicSql")]
        [Validation(Required=false)]
        public bool? DynamicSql { get; set; }

        /// <summary>
        /// <para>The end time of the monitoring data.<br>The value must be UTC time in the format of YYYY-MM-DDThh:mm:ssZ.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2023-04-12T05:38:38Z</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// <para>All parameters are referenced by the symbol @. For a list of available parameters, refer to the returned parameters in <a href="https://en.oceanbase.com/docs/community-ocp-en-10000000000840290">Query performance indicators of an SQL statement</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>@avgCpuTime &gt; 20 and @executions &gt; 100</para>
        /// </summary>
        [NameInMap("FilterCondition")]
        [Validation(Required=false)]
        public string FilterCondition { get; set; }

        /// <summary>
        /// <para>The ID of the OceanBase cluster.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ob317v4uif****</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>Specifies whether to merge dynamic SQL statements in the return result. </para>
        /// <remarks>
        /// <para>This parameter specifies whether to aggregate the results of IN queries.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("MergeDynamicSql")]
        [Validation(Required=false)]
        public bool? MergeDynamicSql { get; set; }

        /// <summary>
        /// <para>The node IP.</para>
        /// 
        /// <b>Example:</b>
        /// <para>i-bp19y05uq6x*********</para>
        /// </summary>
        [NameInMap("NodeIp")]
        [Validation(Required=false)]
        public string NodeIp { get; set; }

        /// <summary>
        /// <para>Page size.</para>
        /// <list type="bullet">
        /// <item><description>Start value: 1</description></item>
        /// <item><description>Default value: 1</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

        /// <summary>
        /// <para>The search keyword.</para>
        /// 
        /// <b>Example:</b>
        /// <para>update</para>
        /// </summary>
        [NameInMap("SearchKeyWord")]
        [Validation(Required=false)]
        public string SearchKeyWord { get; set; }

        /// <summary>
        /// <para>The search parameter.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cputime</para>
        /// </summary>
        [NameInMap("SearchParam")]
        [Validation(Required=false)]
        public string SearchParam { get; set; }

        /// <summary>
        /// <para>The search rule.<br>Valid values: &quot;=&quot;, &quot;&gt;&quot;, &quot;&gt;=&quot;, &quot;&lt;&quot;, and &quot;&lt;=&quot;</para>
        /// 
        /// <b>Example:</b>
        /// <remarks>
        /// </remarks>
        /// </summary>
        [NameInMap("SearchRule")]
        [Validation(Required=false)]
        public string SearchRule { get; set; }

        /// <summary>
        /// <para>The search value.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0.01</para>
        /// </summary>
        [NameInMap("SearchValue")]
        [Validation(Required=false)]
        public string SearchValue { get; set; }

        /// <summary>
        /// <para>SQL ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>8D6E84<b><b>0B8FB1823D199E2CA1</b></b></para>
        /// </summary>
        [NameInMap("SqlId")]
        [Validation(Required=false)]
        public string SqlId { get; set; }

        /// <summary>
        /// <para>Max length of the returned SQL text.</para>
        /// 
        /// <b>Example:</b>
        /// <para>65535</para>
        /// </summary>
        [NameInMap("SqlTextLength")]
        [Validation(Required=false)]
        public long? SqlTextLength { get; set; }

        /// <summary>
        /// <para>The start time of the monitoring data.<br>The value must be UTC time in the format of YYYY-MM-DDThh:mm:ssZ.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2023-04-12T04:38:38Z</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

        /// <summary>
        /// <para>The ID of the tenant.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>t4louaeei****</para>
        /// </summary>
        [NameInMap("TenantId")]
        [Validation(Required=false)]
        public string TenantId { get; set; }

    }

}
