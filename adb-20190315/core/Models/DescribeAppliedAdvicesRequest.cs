// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adb20190315.Models
{
    public class DescribeAppliedAdvicesRequest : TeaModel {
        /// <summary>
        /// <para>The type of suggestions to return. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>INDEX</b>: index optimization.</para>
        /// </description></item>
        /// <item><description><para><b>TIERING</b>: data tiering.</para>
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
        /// <para>The ID of the AnalyticDB for MySQL Data Warehouse Edition cluster.</para>
        /// <remarks>
        /// <para>To query the IDs of AnalyticDB for MySQL Data Warehouse Edition clusters, call the <a href="https://help.aliyun.com/document_detail/129857.html">DescribeDBClusters</a> API.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>am-uf6g8w25jacm7****</para>
        /// </summary>
        [NameInMap("DBClusterId")]
        [Validation(Required=false)]
        public string DBClusterId { get; set; }

        /// <summary>
        /// <para>The end date of the query time range, in yyyyMMdd format and in UTC.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20220824</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public long? EndTime { get; set; }

        /// <summary>
        /// <para>A keyword for performing a fuzzy search by table name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>you_table_name</para>
        /// </summary>
        [NameInMap("Keyword")]
        [Validation(Required=false)]
        public string Keyword { get; set; }

        /// <summary>
        /// <para>The language of the suggestions. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>zh</b>: Simplified Chinese (default)</para>
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
        /// <para>The sort order for the results. The value must be a JSON string, such as <c>[{&quot;Field&quot;:&quot;SchemaName&quot;,&quot;Type&quot;:&quot;Asc&quot;}]</c>. The JSON string contains the following fields:</para>
        /// <list type="bullet">
        /// <item><description><para><c>Field</c>: The field by which to sort the results. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><c>SchemaName</c>: schema name.</para>
        /// </description></item>
        /// <item><description><para><c>TableName</c>: table name.</para>
        /// </description></item>
        /// <item><description><para><c>JobStatus</c>: Status of the table build job.</para>
        /// </description></item>
        /// <item><description><para><c>SubmitTime</c>: Time when the suggestion was created.</para>
        /// </description></item>
        /// <item><description><para><c>Benefit</c>: Expected optimization benefit.</para>
        /// </description></item>
        /// </list>
        /// </description></item>
        /// <item><description><para><c>Type</c>: the sort order. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><c>Asc</c>: ascending order.</para>
        /// </description></item>
        /// <item><description><para><c>Desc</c>: descending order.</para>
        /// </description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para>If this parameter is not specified, the results are sorted by creation time (<c>SubmitTime</c>) in descending order by default.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>[{&quot;Field&quot;:&quot;Benefit&quot;,&quot;Type&quot;:&quot;Desc&quot;}]</para>
        /// </summary>
        [NameInMap("Order")]
        [Validation(Required=false)]
        public string Order { get; set; }

        /// <summary>
        /// <para>The page number. The value must be an integer that is greater than 0 and does not exceed the maximum value of the integer data type. Default: 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public long? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries to return per page. Valid values:</para>
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
        /// <remarks>
        /// <para>To query available region IDs, call the <a href="https://help.aliyun.com/document_detail/143074.html">DescribeRegions</a> API.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The schema name and table name. The value must be in the <b><c>&lt;schema&gt;.&lt;table&gt;</c></b> format.</para>
        /// 
        /// <b>Example:</b>
        /// <para>tpch.lineitem</para>
        /// </summary>
        [NameInMap("SchemaTableName")]
        [Validation(Required=false)]
        public string SchemaTableName { get; set; }

        /// <summary>
        /// <para>The start date of the query time range, in yyyyMMdd format and in UTC.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20220811</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public long? StartTime { get; set; }

    }

}
