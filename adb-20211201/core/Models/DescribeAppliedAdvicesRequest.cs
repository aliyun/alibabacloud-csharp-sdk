// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adb20211201.Models
{
    public class DescribeAppliedAdvicesRequest : TeaModel {
        /// <summary>
        /// <para>The type of the advice. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>INDEX</b>: index optimization</para>
        /// </description></item>
        /// <item><description><para><b>TIERING</b>: hot/cold data optimization</para>
        /// </description></item>
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
        /// <para>The end date of the query. The date is in the <c>yyyyMMdd</c> format.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20220824</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public long? EndTime { get; set; }

        /// <summary>
        /// <para>The keyword for the query. Fuzzy match by table name is supported.</para>
        /// 
        /// <b>Example:</b>
        /// <para>you_table_name</para>
        /// </summary>
        [NameInMap("Keyword")]
        [Validation(Required=false)]
        public string Keyword { get; set; }

        /// <summary>
        /// <para>The language of the query results. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>zh</b> (default): Chinese</para>
        /// </description></item>
        /// <item><description><para><b>en</b>: English</para>
        /// </description></item>
        /// <item><description><para><b>ja</b>: Japanese</para>
        /// </description></item>
        /// <item><description><para><b>zh-tw</b>: Traditional Chinese</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>zh</para>
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        /// <summary>
        /// <para>The order by which to sort the query results. The value is a JSON string. Example: <c>[{&quot;Field&quot;:&quot;SchemaName&quot;,&quot;Type&quot;:&quot;Asc&quot;}]</c>. Fields:</para>
        /// <list type="bullet">
        /// <item><description><para><c>Field</c>: The field by which to sort the results. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><c>SchemaName</c>: the database name</para>
        /// </description></item>
        /// <item><description><para><c>TableName</c>: the table name</para>
        /// </description></item>
        /// <item><description><para><c>JobStatus</c>: the status of the build job for the table</para>
        /// </description></item>
        /// <item><description><para><c>SubmitTime</c>: the time when the advice was submitted</para>
        /// </description></item>
        /// <item><description><para><c>Benefit</c>: the estimated benefit</para>
        /// </description></item>
        /// </list>
        /// </description></item>
        /// <item><description><para><c>Type</c>: The sort order. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><c>Asc</c>: ascending</para>
        /// </description></item>
        /// <item><description><para><c>Desc</c>: descending</para>
        /// </description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para>If you do not set this parameter, the query results are sorted by advice submission time in descending order.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>[{\&quot;Field\&quot;:\&quot;AdviceType\&quot;,\&quot;Type\&quot;:\&quot;Desc\&quot;}]</para>
        /// </summary>
        [NameInMap("Order")]
        [Validation(Required=false)]
        public string Order { get; set; }

        /// <summary>
        /// <para>The page number. The value must be an integer that is greater than 0. Default value: 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public long? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries to return on each page. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>30</b> (default)</para>
        /// </description></item>
        /// <item><description><para><b>50</b></para>
        /// </description></item>
        /// <item><description><para><b>100</b></para>
        /// </description></item>
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
        /// <para>The name of the database and table. Format: <b>database.table</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>tpch.lineitem</para>
        /// </summary>
        [NameInMap("SchemaTableName")]
        [Validation(Required=false)]
        public string SchemaTableName { get; set; }

        /// <summary>
        /// <para>The start date of the query. The date is in the <c>yyyyMMdd</c> format.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20220811</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public long? StartTime { get; set; }

    }

}
