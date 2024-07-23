// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.DAS20200116.Models
{
    public class GetQueryOptimizeExecErrorStatsRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether to sort the returned entries in ascending order. Default value: <b>true</b>. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: sorts the returned entries in ascending order.</description></item>
        /// <item><description><b>false</b>: does not sort the returned entries in ascending order.</description></item>
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
        /// <item><description><b>MySQL</b></description></item>
        /// <item><description><b>PolarDBMySQL</b></description></item>
        /// <item><description><b>PostgreSQL</b></description></item>
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
        /// <item><description><b>or</b></description></item>
        /// <item><description><b>and</b></description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>or</para>
        /// </summary>
        [NameInMap("LogicalOperator")]
        [Validation(Required=false)]
        public string LogicalOperator { get; set; }

        /// <summary>
        /// <para>The field by which to sort the returned entries. Only error_count is supported, which specifies that the entries are sorted based on the number of failed executions.</para>
        /// 
        /// <b>Example:</b>
        /// <para>error_count</para>
        /// </summary>
        [NameInMap("OrderBy")]
        [Validation(Required=false)]
        public string OrderBy { get; set; }

        /// <summary>
        /// <para>The page number. Pages start from page 1. Default value: 1.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNo")]
        [Validation(Required=false)]
        public string PageNo { get; set; }

        /// <summary>
        /// <para>The number of entries per page. Default value: 10.</para>
        /// <para>This parameter is required.</para>
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
        /// <item><description><b>cn-china</b>: Chinese mainland</description></item>
        /// <item><description><b>cn-hongkong</b>: China (Hong Kong)</description></item>
        /// <item><description><b>ap-southeast-1</b>: Singapore</description></item>
        /// </list>
        /// <para>This parameter takes effect only if <b>InstanceIds</b> is left empty. If you leave <b>InstanceIds</b> empty, the system obtains data from the region set by <b>Region</b>. By default, Region is set to <b>cn-china</b>. If you specify <b>InstanceIds</b>, <b>Region</b> does not take effect and the system obtains data from the region in which the first specified instance resides.****</para>
        /// <remarks>
        /// <para> Set this parameter to <b>cn-china</b> for the instances that are created in the regions in the Chinese mainland.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>cn-china</para>
        /// </summary>
        [NameInMap("Region")]
        [Validation(Required=false)]
        public string Region { get; set; }

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

    }

}
