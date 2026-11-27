// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adb20211201.Models
{
    public class DescribeAppliedAdvicesRequest : TeaModel {
        /// <summary>
        /// <para>The type of the suggestion. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>INDEX</b>: Index optimization.</description></item>
        /// <item><description><b>TIERING</b>: Hot and cold data optimization.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>INDEX</para>
        /// </summary>
        [NameInMap("AdviceType")]
        [Validation(Required=false)]
        public string AdviceType { get; set; }

        /// <summary>
        /// <para>The cluster ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>am-uf6g8w25jacm7****</para>
        /// </summary>
        [NameInMap("DBClusterId")]
        [Validation(Required=false)]
        public string DBClusterId { get; set; }

        /// <summary>
        /// <para>The end date for querying suggestions, in the yyyyMMdd format.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20220824</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public long? EndTime { get; set; }

        /// <summary>
        /// <para>The query keyword. Fuzzy search by table name is supported.</para>
        /// 
        /// <b>Example:</b>
        /// <para>you_table_name</para>
        /// </summary>
        [NameInMap("Keyword")]
        [Validation(Required=false)]
        public string Keyword { get; set; }

        /// <summary>
        /// <para>The display language for the suggestions. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>zh</b>: Simplified Chinese (default).</description></item>
        /// <item><description><b>en</b>: English.</description></item>
        /// <item><description><b>ja</b>: Japanese.</description></item>
        /// <item><description><b>zh-tw</b>: Traditional Chinese.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>zh</para>
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        /// <summary>
        /// <para>The field by which to sort the query results. The value is a JSON string, such as [{&quot;Field&quot;:&quot;SchemaName&quot;,&quot;Type&quot;:&quot;Asc&quot;}].</para>
        /// <list type="bullet">
        /// <item><description><c>Field</c>: the sort field. Valid values:<list type="bullet">
        /// <item><description><c>SchemaName</c>: the database name.</description></item>
        /// <item><description><c>TableName</c>: the table name.</description></item>
        /// <item><description><c>JobStatus</c>: the status of the table build task.</description></item>
        /// <item><description><c>SubmitTime</c>: the time when the suggestion was issued.</description></item>
        /// <item><description><c>Benefit</c>: the expected optimization benefit.</description></item>
        /// </list>
        /// </description></item>
        /// <item><description><c>Type</c>: the sort order. Valid values:<list type="bullet">
        /// <item><description><c>Asc</c>: ascending order.</description></item>
        /// <item><description><c>Desc</c>: descending order.</description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para>If this parameter is not specified, the results are sorted in descending order by the time when the optimization suggestions were issued.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>[{&quot;Field&quot;:&quot;AdviceType&quot;,&quot;Type&quot;:&quot;Desc&quot;}]</para>
        /// </summary>
        [NameInMap("Order")]
        [Validation(Required=false)]
        public string Order { get; set; }

        /// <summary>
        /// <para>The page number. The value must be greater than 0 and no more than the maximum value of the Integer data type. Default value: 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public long? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries per page. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>30</b> (default)</description></item>
        /// <item><description><b>50</b></description></item>
        /// <item><description><b>100</b></description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>30</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

        /// <summary>
        /// <para>The region ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The database name and table name. Format: <b>database.table</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>tpch.lineitem</para>
        /// </summary>
        [NameInMap("SchemaTableName")]
        [Validation(Required=false)]
        public string SchemaTableName { get; set; }

        /// <summary>
        /// <para>The start date for querying suggestions, in the yyyyMMdd format.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20220811</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public long? StartTime { get; set; }

    }

}
