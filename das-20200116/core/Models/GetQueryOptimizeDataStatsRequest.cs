// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.DAS20200116.Models
{
    public class GetQueryOptimizeDataStatsRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether to sort the returned entries in ascending order. Default value: <b>true</b>. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>true</b>: sorts the returned entries in ascending order.</para>
        /// </description></item>
        /// <item><description><para><b>false</b>: does not sort the returned entries in ascending order.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Asc")]
        [Validation(Required=false)]
        public string Asc { get; set; }

        /// <summary>
        /// <para>The name of the database to be queried.</para>
        /// 
        /// <b>Example:</b>
        /// <para>testdb01</para>
        /// </summary>
        [NameInMap("DbNames")]
        [Validation(Required=false)]
        public string DbNames { get; set; }

        /// <summary>
        /// <para>The database engine. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>MySQL</b></para>
        /// </description></item>
        /// <item><description><para><b>PolarDBMySQL</b></para>
        /// </description></item>
        /// <item><description><para><b>PostgreSQL</b></para>
        /// </description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>MySQL</para>
        /// </summary>
        [NameInMap("Engine")]
        [Validation(Required=false)]
        public string Engine { get; set; }

        /// <summary>
        /// <para>The instance IDs. Separate multiple IDs with commas (,).</para>
        /// 
        /// <b>Example:</b>
        /// <para>rm-2ze8g2am97624****</para>
        /// </summary>
        [NameInMap("InstanceIds")]
        [Validation(Required=false)]
        public string InstanceIds { get; set; }

        /// <summary>
        /// <para>The keywords of the SQL template. Separate multiple keywords with spaces.</para>
        /// 
        /// <b>Example:</b>
        /// <para>select update</para>
        /// </summary>
        [NameInMap("Keywords")]
        [Validation(Required=false)]
        public string Keywords { get; set; }

        /// <summary>
        /// <para>The logical relationship between multiple keywords. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>or</b></para>
        /// </description></item>
        /// <item><description><para><b>and</b></para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>or</para>
        /// </summary>
        [NameInMap("LogicalOperator")]
        [Validation(Required=false)]
        public string LogicalOperator { get; set; }

        /// <summary>
        /// <para>Specifies whether to query only SQL templates that need to be optimized. Default value: <b>false</b>. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>true</b>: queries only SQL templates that need to be optimized.</para>
        /// </description></item>
        /// <item><description><para><b>false</b>: does not query only SQL statements that need to be optimized.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("OnlyOptimizedSql")]
        [Validation(Required=false)]
        public string OnlyOptimizedSql { get; set; }

        /// <summary>
        /// <para>The field by which to sort the returned entries. Default value: <b>count</b>. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>count</b>: the number of executions.</para>
        /// </description></item>
        /// <item><description><para><b>maxQueryTime</b>: the longest execution time.</para>
        /// </description></item>
        /// <item><description><para><b>avgQueryTime</b>: the average execution time.</para>
        /// </description></item>
        /// <item><description><para><b>maxLockTime</b>: the longest lock wait time.</para>
        /// </description></item>
        /// <item><description><para><b>avgLockTime</b>: the longest lock wait time.</para>
        /// </description></item>
        /// <item><description><para><b>maxRowsExamined</b>: the largest number of scanned rows.</para>
        /// </description></item>
        /// <item><description><para><b>avgRowsExamined</b>: the average number of scanned rows.</para>
        /// </description></item>
        /// <item><description><para><b>maxRowsSent</b>: the largest number of returned rows.</para>
        /// </description></item>
        /// <item><description><para><b>avgRowsSent</b>: the average number of returned rows.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>count</para>
        /// </summary>
        [NameInMap("OrderBy")]
        [Validation(Required=false)]
        public string OrderBy { get; set; }

        /// <summary>
        /// <para>The page number. Pages start from page 1. Default value: 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNo")]
        [Validation(Required=false)]
        public string PageNo { get; set; }

        /// <summary>
        /// <para>The number of entries per page. Default value: 10.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public string PageSize { get; set; }

        /// <summary>
        /// <para>The region in which the instance resides. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>cn-china</b>: Chinese mainland</para>
        /// </description></item>
        /// <item><description><para><b>cn-hongkong</b>: China (Hong Kong)</para>
        /// </description></item>
        /// <item><description><para><b>ap-southeast-1</b>: Singapore</para>
        /// </description></item>
        /// </list>
        /// <para>This parameter takes effect only if <b>InstanceIds</b> is left empty. If you leave <b>InstanceIds</b> empty, the system obtains data from the region set by <b>Region</b>. By default, Region is set to <b>cn-china</b>. If you specify <b>InstanceIds</b>, <b>Region</b> does not take effect and the system obtains data from the region in which the first specified instance resides.\<em>\</em>\<em>\</em></para>
        /// <remarks>
        /// <para>Set this parameter to <b>cn-china</b> for the instances that are created in the regions in the Chinese mainland.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>cn-china</para>
        /// </summary>
        [NameInMap("Region")]
        [Validation(Required=false)]
        public string Region { get; set; }

        /// <summary>
        /// <para>The tags that are used to filter SQL templates. Separate multiple tags with commas (,). For more information, see <a href="https://help.aliyun.com/document_detail/290038.html">Query governance</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>DAS_NOT_IMPORTANT</para>
        /// </summary>
        [NameInMap("Rules")]
        [Validation(Required=false)]
        public string Rules { get; set; }

        /// <summary>
        /// <para>The SQL template ID. You can query the ID of a template by calling the <a href="https://help.aliyun.com/document_detail/405235.html">GetQueryOptimizeExecErrorStats</a> operation.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2e8147b5ca2dfc640dfd5e43d96a****</para>
        /// </summary>
        [NameInMap("SqlIds")]
        [Validation(Required=false)]
        public string SqlIds { get; set; }

        /// <summary>
        /// <para>The reserved parameter.</para>
        /// 
        /// <b>Example:</b>
        /// <para>None</para>
        /// </summary>
        [NameInMap("TagNames")]
        [Validation(Required=false)]
        public string TagNames { get; set; }

        /// <summary>
        /// <para>The time range to query. Specify the time in the UNIX timestamp format. Unit: milliseconds.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1642953600000</para>
        /// </summary>
        [NameInMap("Time")]
        [Validation(Required=false)]
        public string Time { get; set; }

        /// <summary>
        /// <para>The account of the database to be queried.</para>
        /// 
        /// <b>Example:</b>
        /// <para>testUser</para>
        /// </summary>
        [NameInMap("User")]
        [Validation(Required=false)]
        public string User { get; set; }

    }

}
