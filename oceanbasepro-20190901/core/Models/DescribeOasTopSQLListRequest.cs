// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OceanBasePro20190901.Models
{
    public class DescribeOasTopSQLListRequest : TeaModel {
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
        /// <para>The name of the database.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test_db</para>
        /// </summary>
        [NameInMap("DbName")]
        [Validation(Required=false)]
        public string DbName { get; set; }

        [NameInMap("DynamicSql")]
        [Validation(Required=false)]
        public bool? DynamicSql { get; set; }

        /// <summary>
        /// <para>The end time of querying the TOPSQL parameter.
        /// The value must be UTC time in the format of YYYY-MM-DDThh:mm:ssZ.</para>
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

        [NameInMap("MergeDynamicSql")]
        [Validation(Required=false)]
        public bool? MergeDynamicSql { get; set; }

        /// <summary>
        /// <para>The node IP.</para>
        /// 
        /// <b>Example:</b>
        /// <para>i-bp18l4****str4uk03</para>
        /// </summary>
        [NameInMap("NodeIp")]
        [Validation(Required=false)]
        public string NodeIp { get; set; }

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
        /// <para>The search rule.</para>
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
        /// <remarks>
        /// <para>When the SQL ID is provided, the system collects all the request data for the target SQL ID. When the SQL ID is empty, the system collects all the request data for the entire database instance.</para>
        /// </remarks>
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
        /// <para>The start time of querying the TOPSQL parameter.<br>The value must be UTC time in the format of YYYY-MM-DDThh:mm:ssZ.</para>
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
