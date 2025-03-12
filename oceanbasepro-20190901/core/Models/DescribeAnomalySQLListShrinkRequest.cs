// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OceanBasePro20190901.Models
{
    public class DescribeAnomalySQLListShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The language of the returned data.<br>Default value: CN for a China site and EN for an International site.</para>
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
        /// <para>testdb</para>
        /// </summary>
        [NameInMap("DbName")]
        [Validation(Required=false)]
        public string DbName { get; set; }

        /// <summary>
        /// <para>The end time of the time range for querying suspicious SQL statements.<br>The value must be UTC time in the format of YYYY-MM-DDThh:mm:ssZ.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2021-09-13T15:40:43Z</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// <para>The filter condition.   </para>
        /// <remarks>
        /// <para><br> - All fields in OceanBase Database support filtering. <br> - You can write the key-value pair of a parameter in a JSON string in the JSON format to filter the parameter.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>{
        ///   &quot;UserName&quot;:testUser
        /// }</para>
        /// </summary>
        [NameInMap("FilterCondition")]
        [Validation(Required=false)]
        public string FilterConditionShrink { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>obsd23j4f****</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The IP address of the node.</para>
        /// 
        /// <b>Example:</b>
        /// <para>i-bp19y05uq6xpacyqnlrc</para>
        /// </summary>
        [NameInMap("NodeIp")]
        [Validation(Required=false)]
        public string NodeIp { get; set; }

        /// <summary>
        /// <para>The number of the page to return.    </para>
        /// <list type="bullet">
        /// <item><description>Start value: 1   </description></item>
        /// <item><description>Default value: 1</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of rows to return on each page.    </para>
        /// <list type="bullet">
        /// <item><description>Maximum value: 100   </description></item>
        /// <item><description>Default value: 10</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>SQLID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>8D6E84<b><b>0B8FB1823D199E2CA1</b></b></para>
        /// </summary>
        [NameInMap("SQLId")]
        [Validation(Required=false)]
        public string SQLId { get; set; }

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
        [NameInMap("SearchParameter")]
        [Validation(Required=false)]
        public string SearchParameter { get; set; }

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
        /// <para>The sorted column.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cputime</para>
        /// </summary>
        [NameInMap("SortColumn")]
        [Validation(Required=false)]
        public string SortColumn { get; set; }

        /// <summary>
        /// <para>The sorting rule.</para>
        /// 
        /// <b>Example:</b>
        /// <para>desc</para>
        /// </summary>
        [NameInMap("SortOrder")]
        [Validation(Required=false)]
        public string SortOrder { get; set; }

        /// <summary>
        /// <para>The start time of the time range for querying suspicious SQL statements.<br>The value must be UTC time in the format of YYYY-MM-DDThh:mm:ssZ.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2021-06-13T15:40:43Z</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

        /// <summary>
        /// <para>The ID of the tenant.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>t2mr3oae0****</para>
        /// </summary>
        [NameInMap("TenantId")]
        [Validation(Required=false)]
        public string TenantId { get; set; }

    }

}
