// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adb20190315.Models
{
    public class DescribeAvailableAdvicesRequest : TeaModel {
        /// <summary>
        /// <para>The date on which the advice was generated, in the yyyyMMdd format and in UTC.</para>
        /// <remarks>
        /// <para>Advice is generated daily after an early-morning analysis. To query for advice, you must specify a date that is at least one day prior to the current date (T-1). For example, if the current date is 20240627, you must specify 20240626 or an earlier date.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20221124</para>
        /// </summary>
        [NameInMap("AdviceDate")]
        [Validation(Required=false)]
        public long? AdviceDate { get; set; }

        /// <summary>
        /// <para>The type of advice. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>INDEX</b>: index optimization.</para>
        /// </description></item>
        /// <item><description><para><b>TIERING</b>: data tiering optimization.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Index</para>
        /// </summary>
        [NameInMap("AdviceType")]
        [Validation(Required=false)]
        public string AdviceType { get; set; }

        /// <summary>
        /// <para>The ID of the cluster.</para>
        /// <remarks>
        /// <para>You can call the <a href="https://help.aliyun.com/document_detail/129857.html">DescribeDBClusters</a> API to query for the IDs of Data Warehouse Edition clusters.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>am-bp198m028ih55****</para>
        /// </summary>
        [NameInMap("DBClusterId")]
        [Validation(Required=false)]
        public string DBClusterId { get; set; }

        /// <summary>
        /// <para>The keyword for a fuzzy search by table name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>you_table_name</para>
        /// </summary>
        [NameInMap("Keyword")]
        [Validation(Required=false)]
        public string Keyword { get; set; }

        /// <summary>
        /// <para>The language for the advice. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>zh</b>: simplified Chinese (default)</para>
        /// </description></item>
        /// <item><description><para><b>en</b>: English</para>
        /// </description></item>
        /// <item><description><para><b>ja</b>: Japanese</para>
        /// </description></item>
        /// <item><description><para><b>zh-tw</b>: traditional Chinese</para>
        /// </description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>zh</para>
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        /// <summary>
        /// <para>The sort order of the query results. The value is a JSON string, for example, <c>[{&quot;Field&quot;:&quot;SchemaName&quot;,&quot;Type&quot;:&quot;Asc&quot;}]</c>. The JSON string contains the following parameters:</para>
        /// <list type="bullet">
        /// <item><description><para><c>Field</c>: the field to sort by. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><c>SchemaName</c>: The database name.</para>
        /// </description></item>
        /// <item><description><para><c>TableName</c>: The table name.</para>
        /// </description></item>
        /// <item><description><para><c>Benefit</c>: The expected benefit.</para>
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
        /// <para>By default, results are sorted by expected benefit in descending order.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>[{&quot;Field&quot;:&quot;Benefit&quot;,&quot;Type&quot;:&quot;Desc&quot;}]</para>
        /// </summary>
        [NameInMap("Order")]
        [Validation(Required=false)]
        public string Order { get; set; }

        /// <summary>
        /// <para>The page number. The value must be a positive integer. Default value: 1.</para>
        /// <para>This parameter is required.</para>
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
        /// <item><description><para><b>30</b> (default)</para>
        /// </description></item>
        /// <item><description><para><b>50</b></para>
        /// </description></item>
        /// <item><description><para><b>100</b></para>
        /// </description></item>
        /// </list>
        /// <para>This parameter is required.</para>
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
        /// <para>You can call the <a href="https://help.aliyun.com/document_detail/143074.html">DescribeRegions</a> API to query for the IDs of available regions.</para>
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
        /// <para>The concatenation of the database name and the table name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>tpch.lineitem</para>
        /// </summary>
        [NameInMap("SchemaTableName")]
        [Validation(Required=false)]
        public string SchemaTableName { get; set; }

    }

}
