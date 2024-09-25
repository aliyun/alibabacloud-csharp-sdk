// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardb20170801.Models
{
    public class DescribeDBClustersWithBackupsResponseBody : TeaModel {
        /// <summary>
        /// <para>The details about the cluster.</para>
        /// </summary>
        [NameInMap("Items")]
        [Validation(Required=false)]
        public DescribeDBClustersWithBackupsResponseBodyItems Items { get; set; }
        public class DescribeDBClustersWithBackupsResponseBodyItems : TeaModel {
            [NameInMap("DBCluster")]
            [Validation(Required=false)]
            public List<DescribeDBClustersWithBackupsResponseBodyItemsDBCluster> DBCluster { get; set; }
            public class DescribeDBClustersWithBackupsResponseBodyItemsDBCluster : TeaModel {
                /// <summary>
                /// <para>The time when the cluster was created.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2022-05-09T09:33:51Z</para>
                /// </summary>
                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public string CreateTime { get; set; }

                /// <summary>
                /// <para>The name of the cluster.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test</para>
                /// </summary>
                [NameInMap("DBClusterDescription")]
                [Validation(Required=false)]
                public string DBClusterDescription { get; set; }

                /// <summary>
                /// <para>The ID of cluster.</para>
                /// 
                /// <b>Example:</b>
                /// <para>pc-****************</para>
                /// </summary>
                [NameInMap("DBClusterId")]
                [Validation(Required=false)]
                public string DBClusterId { get; set; }

                /// <summary>
                /// <para>The network type of the cluster.</para>
                /// 
                /// <b>Example:</b>
                /// <para>VPC</para>
                /// </summary>
                [NameInMap("DBClusterNetworkType")]
                [Validation(Required=false)]
                public string DBClusterNetworkType { get; set; }

                /// <summary>
                /// <para>The status of the cluster. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>Creating: The cluster is being created.</description></item>
                /// <item><description>Running: The cluster is running.</description></item>
                /// <item><description>Deleting: The cluster is being released.</description></item>
                /// <item><description>Rebooting: The cluster is restarting.</description></item>
                /// <item><description>DBNodeCreating: The node is being added.</description></item>
                /// <item><description>DBNodeDeleting: The node is being deleted.</description></item>
                /// <item><description>ClassChanging: The specifications of the node are being changed.</description></item>
                /// <item><description>NetAddressCreating: The network connection is being created.</description></item>
                /// <item><description>NetAddressDeleting: The network connection is being deleted.</description></item>
                /// <item><description>NetAddressModifying: The network connection is being modified.</description></item>
                /// <item><description>Deleted: The cluster has been released.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>Running</para>
                /// </summary>
                [NameInMap("DBClusterStatus")]
                [Validation(Required=false)]
                public string DBClusterStatus { get; set; }

                /// <summary>
                /// <para>The specifications of the node.</para>
                /// 
                /// <b>Example:</b>
                /// <para>polar.mysql.x4.medium</para>
                /// </summary>
                [NameInMap("DBNodeClass")]
                [Validation(Required=false)]
                public string DBNodeClass { get; set; }

                /// <summary>
                /// <para>The type of the database engine.</para>
                /// 
                /// <b>Example:</b>
                /// <para>MySQL</para>
                /// </summary>
                [NameInMap("DBType")]
                [Validation(Required=false)]
                public string DBType { get; set; }

                /// <summary>
                /// <para>The version of the database engine.</para>
                /// 
                /// <b>Example:</b>
                /// <para>8.0</para>
                /// </summary>
                [NameInMap("DBVersion")]
                [Validation(Required=false)]
                public string DBVersion { get; set; }

                /// <summary>
                /// <para>The time when the cluster was deleted.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2022-05-12T03:25:37Z</para>
                /// </summary>
                [NameInMap("DeletedTime")]
                [Validation(Required=false)]
                public string DeletedTime { get; set; }

                /// <summary>
                /// <para>Indicates whether the cluster is locked and can be deleted. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>0</b>: The cluster is not locked and can be deleted.</description></item>
                /// <item><description><b>1</b>: The cluster is locked and cannot be deleted.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("DeletionLock")]
                [Validation(Required=false)]
                public int? DeletionLock { get; set; }

                /// <summary>
                /// <para>The type of the database engine.</para>
                /// 
                /// <b>Example:</b>
                /// <para>POLARDB</para>
                /// </summary>
                [NameInMap("Engine")]
                [Validation(Required=false)]
                public string Engine { get; set; }

                /// <summary>
                /// <para>The time when the cluster expires.</para>
                /// <remarks>
                /// <para>A specific value will be returned only for subscription clusters. For pay-as-you-go clusters, an empty string will be returned.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>2022-09-14T16:00:00Z</para>
                /// </summary>
                [NameInMap("ExpireTime")]
                [Validation(Required=false)]
                public string ExpireTime { get; set; }

                /// <summary>
                /// <para>Indicates whether the cluster has expired.</para>
                /// <remarks>
                /// <para>A specific value will be returned only for subscription clusters.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("Expired")]
                [Validation(Required=false)]
                public string Expired { get; set; }

                /// <summary>
                /// <para>Indicates whether the cluster was released. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>1: released</description></item>
                /// <item><description>0: not released</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("IsDeleted")]
                [Validation(Required=false)]
                public int? IsDeleted { get; set; }

                /// <summary>
                /// <para>The state of the cluster lock. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>Unlock</b>: The cluster is not locked.</description></item>
                /// <item><description><b>ManualLock</b>: The cluster is manually locked.</description></item>
                /// <item><description><b>LockByExpiration</b>: The cluster is automatically locked after the cluster expires.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>Unlock</para>
                /// </summary>
                [NameInMap("LockMode")]
                [Validation(Required=false)]
                public string LockMode { get; set; }

                /// <summary>
                /// <para>The billing method. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>Postpaid</b>: pay-as-you-go.</description></item>
                /// <item><description><b>Prepaid</b>: subscription</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>Postpaid</para>
                /// </summary>
                [NameInMap("PayType")]
                [Validation(Required=false)]
                public string PayType { get; set; }

                /// <summary>
                /// <para>The region ID of the cluster.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cn-hangzhou</para>
                /// </summary>
                [NameInMap("RegionId")]
                [Validation(Required=false)]
                public string RegionId { get; set; }

                /// <summary>
                /// <para>The VPC ID of the cluster.</para>
                /// 
                /// <b>Example:</b>
                /// <para>vpc-******************</para>
                /// </summary>
                [NameInMap("VpcId")]
                [Validation(Required=false)]
                public string VpcId { get; set; }

                /// <summary>
                /// <para>The ID of the zone in which the instance is located.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cn-hangzhou-h</para>
                /// </summary>
                [NameInMap("ZoneId")]
                [Validation(Required=false)]
                public string ZoneId { get; set; }

            }

        }

        /// <summary>
        /// <para>The total number of returned pages.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of clusters returned per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageRecordCount")]
        [Validation(Required=false)]
        public int? PageRecordCount { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>F8529AA2-522F-4B30-B80B-8F7D39******</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of returned entries.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TotalRecordCount")]
        [Validation(Required=false)]
        public int? TotalRecordCount { get; set; }

    }

}
