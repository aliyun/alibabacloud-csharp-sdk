// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardb20170801.Models
{
    public class DescribeDBClustersZonalRequest : TeaModel {
        /// <summary>
        /// <para>The cloud service provider.</para>
        /// 
        /// <b>Example:</b>
        /// <para>AlibabaCloud</para>
        /// </summary>
        [NameInMap("CloudProvider")]
        [Validation(Required=false)]
        public string CloudProvider { get; set; }

        /// <summary>
        /// <para>The database endpoint.</para>
        /// 
        /// <b>Example:</b>
        /// <para>********.rwlb.polardb-pg-public.rds.aliyuncs.com</para>
        /// </summary>
        [NameInMap("ConnectionString")]
        [Validation(Required=false)]
        public string ConnectionString { get; set; }

        /// <summary>
        /// <para>The description of the cluster. Fuzzy search is supported.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pc-****************</para>
        /// </summary>
        [NameInMap("DBClusterDescription")]
        [Validation(Required=false)]
        public string DBClusterDescription { get; set; }

        /// <summary>
        /// <para>The cluster ID. To specify multiple cluster IDs, separate them with commas (,).</para>
        /// 
        /// <b>Example:</b>
        /// <para>pc-****************</para>
        /// </summary>
        [NameInMap("DBClusterIds")]
        [Validation(Required=false)]
        public string DBClusterIds { get; set; }

        /// <summary>
        /// <para>The status of the cluster.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Running</para>
        /// </summary>
        [NameInMap("DBClusterStatus")]
        [Validation(Required=false)]
        public string DBClusterStatus { get; set; }

        /// <summary>
        /// <para>The node ID. You can specify multiple node IDs. Separate them with commas (,).</para>
        /// 
        /// <b>Example:</b>
        /// <para>pi-***************</para>
        /// </summary>
        [NameInMap("DBNodeIds")]
        [Validation(Required=false)]
        public string DBNodeIds { get; set; }

        /// <summary>
        /// <para>The database type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>MySQL</para>
        /// </description></item>
        /// <item><description><para>PostgreSQL</para>
        /// </description></item>
        /// <item><description><para>Oracle</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>MySQL</para>
        /// </summary>
        [NameInMap("DBType")]
        [Validation(Required=false)]
        public string DBType { get; set; }

        /// <summary>
        /// <para>The database version.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5.6</para>
        /// </summary>
        [NameInMap("DBVersion")]
        [Validation(Required=false)]
        public string DBVersion { get; set; }

        /// <summary>
        /// <para>The query mode. Set the value to \<c>Simple\\</c>. In this mode, only the basic metadata of the clusters is returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Simple</para>
        /// </summary>
        [NameInMap("DescribeType")]
        [Validation(Required=false)]
        public string DescribeType { get; set; }

        /// <summary>
        /// <para>Specifies whether the cluster has expired. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>true</para>
        /// </description></item>
        /// <item><description><para>false</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Expired")]
        [Validation(Required=false)]
        public string Expired { get; set; }

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
        /// <para>A token used to retrieve the next page of results. Set this parameter to the \<c>NextToken\\</c> value returned from the previous API call. You do not need to specify this parameter for the first call.</para>
        /// 
        /// <b>Example:</b>
        /// <para>212db86sca4384811e0b5e8707e******</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The page number. The value must be an integer that is greater than 0 and does not exceed the maximum value of the Integer data type. Default value: 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries to return on each page. Valid values: 30, 50, and 100.</para>
        /// <para>Default value: 30.</para>
        /// 
        /// <b>Example:</b>
        /// <para>30</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The billing method. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>Postpaid: pay-as-you-go</para>
        /// </description></item>
        /// <item><description><para>Prepaid: subscription</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Postpaid</para>
        /// </summary>
        [NameInMap("PayType")]
        [Validation(Required=false)]
        public string PayType { get; set; }

        /// <summary>
        /// <para>Filters for clusters created in the last N days. Valid values: 0 to 15.</para>
        /// 
        /// <b>Example:</b>
        /// <para>7</para>
        /// </summary>
        [NameInMap("RecentCreationInterval")]
        [Validation(Required=false)]
        public int? RecentCreationInterval { get; set; }

        /// <summary>
        /// <para>Filters for clusters that expire in N days. Valid values: 0 to 15.</para>
        /// 
        /// <b>Example:</b>
        /// <para>6</para>
        /// </summary>
        [NameInMap("RecentExpirationInterval")]
        [Validation(Required=false)]
        public int? RecentExpirationInterval { get; set; }

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
        /// <para>The resource group ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg-**********</para>
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        /// <summary>
        /// <para>The list of tags.</para>
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<DescribeDBClustersZonalRequestTag> Tag { get; set; }
        public class DescribeDBClustersZonalRequestTag : TeaModel {
            /// <summary>
            /// <para>The key of tag \<c>n\\</c>. You can filter clusters by specifying up to 20 tags. The \<c>n\\</c> must be a unique and consecutive integer that starts from 1. \<c>Tag.n.Key\\</c> corresponds to \<c>Tag.n.Value\\</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>MySQL</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The value of the tag key.</para>
            /// 
            /// <b>Example:</b>
            /// <para>5.6</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

    }

}
