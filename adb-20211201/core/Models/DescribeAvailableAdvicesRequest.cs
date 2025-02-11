// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adb20211201.Models
{
    public class DescribeAvailableAdvicesRequest : TeaModel {
        /// <summary>
        /// <para>The date when the suggestion is generated. Specify the date in the yyyyMMdd format.</para>
        /// <remarks>
        /// <para> Suggestions are generated after analysis after midnight every day. You must specify a date that is at least one day earlier than the current date. For example, if the current date is 20240627, you must specify 20240626 or an earlier date.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>20221124</para>
        /// </summary>
        [NameInMap("AdviceDate")]
        [Validation(Required=false)]
        public long? AdviceDate { get; set; }

        /// <summary>
        /// <para>The type of the suggestion. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>INDEX</b>: index optimization.</description></item>
        /// <item><description><b>TIERING</b>: hot and cold data optimization.</description></item>
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
        /// <para>am-bp198m028ih55****</para>
        /// </summary>
        [NameInMap("DBClusterId")]
        [Validation(Required=false)]
        public string DBClusterId { get; set; }

        /// <summary>
        /// <para>The keyword that is used to query information by table name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>you_table_name</para>
        /// </summary>
        [NameInMap("Keyword")]
        [Validation(Required=false)]
        public string Keyword { get; set; }

        /// <summary>
        /// <para>The display language of suggestions. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>zh</b> (default): simplified Chinese.</description></item>
        /// <item><description><b>en</b>: English.</description></item>
        /// <item><description><b>ja</b>: Japanese.</description></item>
        /// <item><description><b>zh-tw</b>: traditional Chinese.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>zh</para>
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        /// <summary>
        /// <para>The order by which to sort query results. Specify the parameter value in the JSON format. Example: <c>[{&quot;Field&quot;:&quot;SchemaName&quot;,&quot;Type&quot;:&quot;Asc&quot;}]</c>.</para>
        /// <list type="bullet">
        /// <item><description><para><c>Field</c> specifies the field by which to sort the query results. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><c>SchemaName</c>: the name of the database.</description></item>
        /// <item><description><c>TableName</c>: the name of the table.</description></item>
        /// <item><description><c>Benefit</c>: the expected benefits of the applied optimization suggestion.</description></item>
        /// </list>
        /// </description></item>
        /// <item><description><para><c>Type</c> specifies the sorting order. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><c>Asc</c>: ascending order.</description></item>
        /// <item><description><c>Desc</c>: descending order.</description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para> If you do not specify this parameter, the query results are sorted in descending order based on the Benefit field.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>[{\&quot;Field\&quot;:\&quot;AdviceType\&quot;,\&quot;Type\&quot;:\&quot;Desc\&quot;}]</para>
        /// </summary>
        [NameInMap("Order")]
        [Validation(Required=false)]
        public string Order { get; set; }

        /// <summary>
        /// <para>The page number. Pages start from page 1. Default value: 1.</para>
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
        /// <para>The name of the table in the DatabaseName.TableName format.</para>
        /// 
        /// <b>Example:</b>
        /// <para>tpch.lineitem</para>
        /// </summary>
        [NameInMap("SchemaTableName")]
        [Validation(Required=false)]
        public string SchemaTableName { get; set; }

    }

}
