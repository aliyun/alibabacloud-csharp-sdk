// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardb20170801.Models
{
    public class ListOrdersRequest : TeaModel {
        /// <summary>
        /// <para>The <a href="https://help.aliyun.com/document_detail/183258.html">edition</a> of the cluster. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>Normal</b>: Cluster Edition</para>
        /// </description></item>
        /// <item><description><para><b>Basic</b>: single node</para>
        /// </description></item>
        /// <item><description><para><b>Archive</b>: X-Engine</para>
        /// </description></item>
        /// <item><description><para><b>NormalMultimaster</b>: Multi-master Cluster Edition</para>
        /// </description></item>
        /// <item><description><para><b>SENormal</b>: Standard Edition</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description><para>The single node edition is not supported on PolarDB for PostgreSQL clusters that run PostgreSQL 11.</para>
        /// </description></item>
        /// <item><description><para>The Standard Edition is supported on PolarDB for MySQL clusters that run MySQL 8.0 or 5.7, and on PolarDB for PostgreSQL clusters that run PostgreSQL 14.</para>
        /// </description></item>
        /// <item><description><para>PolarDB for MySQL clusters that run MySQL 8.0 support X-Engine and the Multi-master Cluster Edition.</para>
        /// </description></item>
        /// </list>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>Normal</para>
        /// </summary>
        [NameInMap("Category")]
        [Validation(Required=false)]
        public string Category { get; set; }

        /// <summary>
        /// <para>The ID of the current instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pc-2zed3m89cw***</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The maximum number of entries to return for the current request. Default value: 10.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>A pagination token. If the query results are not returned in a single call, this token is returned. Use this token in a subsequent call to retrieve the remaining results.</para>
        /// 
        /// <b>Example:</b>
        /// <para>212db86sca4384811e0b5e8707e******</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The status of the order.</para>
        /// <list type="bullet">
        /// <item><description><para><b>pending</b>: The task is waiting to start.</para>
        /// </description></item>
        /// <item><description><para><b>create</b>: The order is placed and is being processed.</para>
        /// </description></item>
        /// <item><description><para><b>fail</b>: The instance failed to be created.</para>
        /// </description></item>
        /// <item><description><para><b>cancel</b>: The order is canceled.</para>
        /// </description></item>
        /// <item><description><para><b>success</b>: The instance is created.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("OrderStatus")]
        [Validation(Required=false)]
        public string OrderStatus { get; set; }

        /// <summary>
        /// <para>The page number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries to return on each page. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>30</b></para>
        /// </description></item>
        /// <item><description><para><b>50</b></para>
        /// </description></item>
        /// <item><description><para><b>100</b></para>
        /// </description></item>
        /// </list>
        /// <para>Default value: 30.</para>
        /// 
        /// <b>Example:</b>
        /// <para>30</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The product code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>polardb</para>
        /// </summary>
        [NameInMap("ProductCode")]
        [Validation(Required=false)]
        public string ProductCode { get; set; }

        /// <summary>
        /// <para>The region ID.</para>
        /// <remarks>
        /// <para>Call the <a href="https://help.aliyun.com/document_detail/98041.html">DescribeRegions</a> operation to view the details of regions.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The resource group ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg-************</para>
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

    }

}
