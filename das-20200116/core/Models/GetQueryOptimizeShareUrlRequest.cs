// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.DAS20200116.Models
{
    public class GetQueryOptimizeShareUrlRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether to sort the results in ascending order. Default value: <b>true</b>. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: Yes.</description></item>
        /// <item><description><b>false</b>: No.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Asc")]
        [Validation(Required=false)]
        public bool? Asc { get; set; }

        /// <summary>
        /// <para>The names of the databases to be queried.</para>
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
        /// <item><description><b>MySQL</b>: RDS MySQL</description></item>
        /// <item><description><b>PolarDBMySQL</b>: PolarDB for MySQL</description></item>
        /// <item><description><b>PostgreSQL</b>: RDS PostgreSQL</description></item>
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
        /// <para>The instance IDs. Separate multiple instance IDs with commas.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rm-2ze1jdv45i7l6****</para>
        /// </summary>
        [NameInMap("InstanceIds")]
        [Validation(Required=false)]
        public string InstanceIds { get; set; }

        /// <summary>
        /// <para>The keywords in the SQL text. Separate multiple keywords with spaces.</para>
        /// 
        /// <b>Example:</b>
        /// <para>select update</para>
        /// </summary>
        [NameInMap("Keywords")]
        [Validation(Required=false)]
        public string Keywords { get; set; }

        /// <summary>
        /// <para>The logical relationship between multiple keywords in the SQL text. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>or</b>: The OR logical relationship.</description></item>
        /// <item><description><b>and</b>: The AND logical relationship.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>or</para>
        /// </summary>
        [NameInMap("LogicalOperator")]
        [Validation(Required=false)]
        public string LogicalOperator { get; set; }

        /// <summary>
        /// <para>Specifies whether to query only the SQL statements that need to be optimized. Default value: <b>false</b>. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: Yes.</description></item>
        /// <item><description><b>false</b>: No.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("OnlyOptimizedSql")]
        [Validation(Required=false)]
        public bool? OnlyOptimizedSql { get; set; }

        /// <summary>
        /// <para>The field by which to sort the results. Default value: <b>count</b>. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>count</b>: The number of executions.</description></item>
        /// <item><description><b>maxQueryTime</b>: The maximum execution time.</description></item>
        /// <item><description><b>avgQueryTime</b>: The average execution time.</description></item>
        /// <item><description><b>maxLockTime</b>: The maximum lock wait time.</description></item>
        /// <item><description><b>avgLockTime</b>: The average lock wait time.</description></item>
        /// <item><description><b>maxRowsExamined</b>: The maximum number of scanned rows.</description></item>
        /// <item><description><b>avgRowsExamined</b>: The average number of scanned rows.</description></item>
        /// <item><description><b>maxRowsSent</b>: The maximum number of returned rows.</description></item>
        /// <item><description><b>avgRowsSent</b>: The average number of returned rows.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>count</para>
        /// </summary>
        [NameInMap("OrderBy")]
        [Validation(Required=false)]
        public string OrderBy { get; set; }

        /// <summary>
        /// <para>The page number of the paging query. Pages start from 1. Default value: 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNo")]
        [Validation(Required=false)]
        public int? PageNo { get; set; }

        /// <summary>
        /// <para>The maximum number of records per page in a paging query. Default value: 10.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The region where the instance resides. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>cn-china</b>: The Chinese mainland.</description></item>
        /// <item><description><b>cn-hongkong</b>: Hong Kong (China).</description></item>
        /// <item><description><b>ap-southeast-1</b>: Singapore.</description></item>
        /// </list>
        /// <para>This parameter is valid only when the <b>InstanceIds</b> request parameter is empty. If the <b>InstanceIds</b> request parameter is empty, data is retrieved based on the region specified by the <b>Region</b> parameter, and the default region is <b>cn-china</b>. If the <b>InstanceIds</b> request parameter is not empty, data is retrieved based on the region of the first instance specified in <b>InstanceIds</b>, regardless of the value of the <b>Region</b> parameter.</para>
        /// <remarks>
        /// <para>For instances created in regions in the Chinese mainland, set this parameter to <b>cn-china</b>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>cn-china</para>
        /// </summary>
        [NameInMap("Region")]
        [Validation(Required=false)]
        public string Region { get; set; }

        /// <summary>
        /// <para>The rules to be filtered. Separate multiple rules with commas. For more information, see <a href="https://help.aliyun.com/document_detail/290038.html">Query Governance</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>DAS_NOT_IMPORTANT</para>
        /// </summary>
        [NameInMap("Rules")]
        [Validation(Required=false)]
        public string Rules { get; set; }

        /// <summary>
        /// <para>The SQL template IDs. You can call the <a href="https://help.aliyun.com/document_detail/405261.html">GetQueryOptimizeDataStats</a> operation to query the SQL template IDs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>6068ce044e3dc9b903979672fb0b69df,d12515c015fc9f41a0778a9e1de0****</para>
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
        /// <para>The date when the data is queried. The value is a UNIX timestamp in milliseconds.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1642953600000</para>
        /// </summary>
        [NameInMap("Time")]
        [Validation(Required=false)]
        public long? Time { get; set; }

        /// <summary>
        /// <para>The database account to be queried.</para>
        /// 
        /// <b>Example:</b>
        /// <para>testUser</para>
        /// </summary>
        [NameInMap("User")]
        [Validation(Required=false)]
        public string User { get; set; }

    }

}
