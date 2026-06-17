// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardb20170801.Models
{
    public class DescribeColdStorageInstanceRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the PolarDB cluster.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pc-wz9062015ly7526jc</para>
        /// </summary>
        [NameInMap("DBClusterId")]
        [Validation(Required=false)]
        public string DBClusterId { get; set; }

        /// <summary>
        /// <para>The name of the database.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test_db</para>
        /// </summary>
        [NameInMap("DBName")]
        [Validation(Required=false)]
        public string DBName { get; set; }

        /// <summary>
        /// <para>The type of the supported engine. The return value is the sum of the values of the supported engine types.</para>
        /// <list type="bullet">
        /// <item><description><para>1: Search engine</para>
        /// </description></item>
        /// <item><description><para>2: LindormTSDB</para>
        /// </description></item>
        /// <item><description><para>4: LindormTable</para>
        /// </description></item>
        /// <item><description><para>8: File engine</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para>For example, if \<c>EngineType\\</c> is 15 (8 + 4 + 2 + 1), the instance supports the search engine, LindormTSDB, LindormTable, and file engine. If \<c>EngineType\\</c> is 6 (4 + 2), the instance supports LindormTSDB and LindormTable.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("EngineType")]
        [Validation(Required=false)]
        public string EngineType { get; set; }

        /// <summary>
        /// <para>The expiration time of the cluster. Note: This parameter is returned only for subscription clusters. An empty value is returned for pay-as-you-go clusters.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2020-11-14T16:00:00Z</para>
        /// </summary>
        [NameInMap("ExpireTime")]
        [Validation(Required=false)]
        public int? ExpireTime { get; set; }

        /// <summary>
        /// <list type="bullet">
        /// <item><description><para>If you do not specify the <b>MaxResults</b> parameter, the query is not paged. The value of the <b>MaxResults</b> parameter in the response indicates the total number of entries.</para>
        /// </description></item>
        /// <item><description><para>If you specify the <b>MaxResults</b> parameter, the query is paged. <b>MaxResults</b> specifies the number of entries to return on each page. Valid values: <b>1</b> to <b>100</b>. The value of the <b>MaxResults</b> parameter in the response indicates the number of entries on the current page. The recommended value is <b>20</b>.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>50</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>A token to retrieve the next page of results. Set this parameter to the \<c>NextToken\\</c> value from a previous call. You do not need to specify this parameter for the first call.</para>
        /// 
        /// <b>Example:</b>
        /// <para>c2FpXzIwMjIwNjI5X2Jhay9zYWlfc3VtbWVyX3RyZWFzdXJlX3Bvb2xfbG9nLkNTVg==</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The object type. Valid values: \<c>TABLE\\</c>, \<c>PARTITION_TABLE\\</c>, and \<c>LOB\\</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>TABLE</para>
        /// </summary>
        [NameInMap("ObjectType")]
        [Validation(Required=false)]
        public string ObjectType { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The page number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public string PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public string PageSize { get; set; }

        /// <summary>
        /// <para>The region ID.</para>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>For more information, see <a href="https://help.aliyun.com/document_detail/98041.html">DescribeRegions</a>.</description></item>
        /// </list>
        /// </remarks>
        /// <list type="bullet">
        /// <item><description>If you do not specify this parameter, the operation queries scheduled tasks in all regions within your account.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        /// <summary>
        /// <para>The name of the data table.</para>
        /// 
        /// <b>Example:</b>
        /// <para>account_log</para>
        /// </summary>
        [NameInMap("TableName")]
        [Validation(Required=false)]
        public string TableName { get; set; }

    }

}
