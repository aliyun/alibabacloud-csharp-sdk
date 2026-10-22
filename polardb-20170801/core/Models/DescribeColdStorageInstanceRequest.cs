// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardb20170801.Models
{
    public class DescribeColdStorageInstanceRequest : TeaModel {
        /// <summary>
        /// <para>The PolarDB cluster ID.</para>
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
        /// <para>The supported engine types. The return value is the sum of the following engine type values:</para>
        /// <list type="bullet">
        /// <item><description>1: search engine</description></item>
        /// <item><description>2: time series engine</description></item>
        /// <item><description>4: wide table engine</description></item>
        /// <item><description>8: file engine</description></item>
        /// </list>
        /// <remarks>
        /// <para>For example, if the EngineType value is 15, 15 = 8 + 4 + 2 + 1, which indicates that the instance supports the search engine, time series engine, wide table engine, and file engine. If the EngineType value is 6, 6 = 4 + 2, which indicates that the instance supports the time series engine and wide table engine.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("EngineType")]
        [Validation(Required=false)]
        public string EngineType { get; set; }

        /// <summary>
        /// <para>The expiration time of the cluster. Note: A specific value is returned only for clusters whose billing method is Prepaid (subscription). For Postpaid (pay-as-you-go) clusters, a null value is returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2020-11-14T16:00:00Z</para>
        /// </summary>
        [NameInMap("ExpireTime")]
        [Validation(Required=false)]
        public int? ExpireTime { get; set; }

        /// <summary>
        /// <list type="bullet">
        /// <item><description>If you do not specify the <b>MaxResults</b> parameter, batch query is not required. The value of the <b>MaxResults</b> parameter returned after the API call indicates the total number of list entries.</description></item>
        /// <item><description>If you specify the <b>MaxResults</b> parameter, batch query is required. The value of <b>MaxResults</b> indicates the number of entries displayed per batch. Valid values: <b>1</b> to <b>100</b>. The value of the <b>MaxResults</b> parameter returned after the API call indicates the number of list entries in the current query batch. Set the <b>MaxResults</b> parameter to <b>20</b>.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>50</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>The query token. Set the value to the NextToken value returned from the previous API call. If there are no more queries, do not specify this parameter.</para>
        /// 
        /// <b>Example:</b>
        /// <para>c2FpXzIwMjIwNjI5X2Jhay9zYWlfc3VtbWVyX3RyZWFzdXJlX3Bvb2xfbG9nLkNTVg==</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The object type. Valid values: TABLE, PARTITION_TABLE, and LOB.</para>
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
        /// <item><description>You can call the <a href="https://help.aliyun.com/document_detail/98041.html">DescribeRegions</a> operation to query the region information of all clusters under the target account.</description></item>
        /// </list>
        /// </remarks>
        /// <list type="bullet">
        /// <item><description>If this parameter is left empty, scheduled tasks in all regions under the current account are queried by default.</description></item>
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
