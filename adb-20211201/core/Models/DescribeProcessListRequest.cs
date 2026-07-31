// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adb20211201.Models
{
    public class DescribeProcessListRequest : TeaModel {
        /// <summary>
        /// <para>The cluster ID of the AnalyticDB for MySQL Data Lakehouse Edition.</para>
        /// <remarks>
        /// <para>Call the <a href="https://help.aliyun.com/document_detail/129857.html">DescribeDBClusters</a> operation to view details of all AnalyticDB for MySQL Data Lakehouse Edition clusters in the destination region, including cluster IDs.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>amv-xxxxxxxxx</para>
        /// </summary>
        [NameInMap("DBClusterId")]
        [Validation(Required=false)]
        public string DBClusterId { get; set; }

        /// <summary>
        /// <para>Filter keyword. Currently, only <b>SELECT</b> is supported.</para>
        /// 
        /// <b>Example:</b>
        /// <para>SELECT</para>
        /// </summary>
        [NameInMap("Keyword")]
        [Validation(Required=false)]
        public string Keyword { get; set; }

        /// <summary>
        /// <para>Sort by the specified field in JSON format, <c>[{&quot;Field&quot;:&quot;Time&quot;,&quot;Type&quot;:&quot;Desc&quot; },{ &quot;Field&quot;:&quot;User&quot;, &quot;Type&quot;:&quot;Asc&quot; }]</c>. Values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>Field</b>: The name of the field to sort by. Supports Time, User, Host, and DB fields.</para>
        /// </description></item>
        /// <item><description><para><b>Type</b>: Sort type. <b>Desc</b> for descending order, <b>Asc</b> for ascending order.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>[ { &quot;Field&quot;:&quot;Time&quot;,&quot;Type&quot;:&quot;Desc&quot; },  { &quot;Field&quot;:&quot;User&quot;, &quot;Type&quot;:&quot;Asc&quot; }]</para>
        /// </summary>
        [NameInMap("Order")]
        [Validation(Required=false)]
        public string Order { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>Page number. Must be a positive integer. Default value: <b>1</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>Number of records per page. Values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>30</b> (Default value)</para>
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
        public int? PageSize { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        /// <summary>
        /// <para>Filter by running time. Displays queries that have run longer than the specified time. Unit: seconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("RunningTime")]
        [Validation(Required=false)]
        public int? RunningTime { get; set; }

        /// <summary>
        /// <para>Specifies whether to display the full SQL statement. Values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>True</b>: Displays the full SQL statement.</para>
        /// </description></item>
        /// <item><description><para><b>False</b>: Displays only the first 100 characters of the SQL statement.</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para>Default value: False.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>True</para>
        /// </summary>
        [NameInMap("ShowFull")]
        [Validation(Required=false)]
        public bool? ShowFull { get; set; }

        /// <summary>
        /// <para>The database account.</para>
        /// 
        /// <b>Example:</b>
        /// <para>admin</para>
        /// </summary>
        [NameInMap("User")]
        [Validation(Required=false)]
        public string User { get; set; }

    }

}
