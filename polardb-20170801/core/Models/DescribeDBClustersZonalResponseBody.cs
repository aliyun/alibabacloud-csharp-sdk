// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardb20170801.Models
{
    public class DescribeDBClustersZonalResponseBody : TeaModel {
        /// <summary>
        /// <para>The list of clusters.</para>
        /// </summary>
        [NameInMap("Items")]
        [Validation(Required=false)]
        public List<DescribeDBClustersZonalResponseBodyItems> Items { get; set; }
        public class DescribeDBClustersZonalResponseBodyItems : TeaModel {
            /// <summary>
            /// <para>The AI node type. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>SearchNode: search node</para>
            /// </description></item>
            /// <item><description><para>DLNode: AI node</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>SearchNode</para>
            /// </summary>
            [NameInMap("AiType")]
            [Validation(Required=false)]
            public string AiType { get; set; }

            /// <summary>
            /// <para>The Cluster Edition. The following editions are supported:</para>
            /// <list type="bullet">
            /// <item><description><para>Normal: Cluster Edition</para>
            /// </description></item>
            /// <item><description><para>Basic: single node</para>
            /// </description></item>
            /// <item><description><para>Archive: X-Engine</para>
            /// </description></item>
            /// <item><description><para>NormalMultimaster: Multi-master Cluster (Database/Table)</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Normal</para>
            /// </summary>
            [NameInMap("Category")]
            [Validation(Required=false)]
            public string Category { get; set; }

            /// <summary>
            /// <para>The ID of the central control region.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-beijing</para>
            /// </summary>
            [NameInMap("CentralControlRegionId")]
            [Validation(Required=false)]
            public string CentralControlRegionId { get; set; }

            /// <summary>
            /// <para>The cloud service provider.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ENS</para>
            /// </summary>
            [NameInMap("CloudProvider")]
            [Validation(Required=false)]
            public string CloudProvider { get; set; }

            /// <summary>
            /// <para>The number of CPU cores.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("CpuCores")]
            [Validation(Required=false)]
            public string CpuCores { get; set; }

            /// <summary>
            /// <para>The creation time.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2020-08-14T05:58:42Z</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <para>The description of the cluster.</para>
            /// 
            /// <b>Example:</b>
            /// <para>GDN-1</para>
            /// </summary>
            [NameInMap("DBClusterDescription")]
            [Validation(Required=false)]
            public string DBClusterDescription { get; set; }

            /// <summary>
            /// <para>The cluster ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>pc-****************</para>
            /// </summary>
            [NameInMap("DBClusterId")]
            [Validation(Required=false)]
            public string DBClusterId { get; set; }

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
            /// <para>The node specifications.</para>
            /// 
            /// <b>Example:</b>
            /// <para>polar.mysql.g1.tiny.c</para>
            /// </summary>
            [NameInMap("DBNodeClass")]
            [Validation(Required=false)]
            public string DBNodeClass { get; set; }

            /// <summary>
            /// <para>The number of nodes.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("DBNodeNumber")]
            [Validation(Required=false)]
            public int? DBNodeNumber { get; set; }

            /// <summary>
            /// <para>The database type.</para>
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
            /// <para>The ENS region ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>sg-singapore-9</para>
            /// </summary>
            [NameInMap("ENSRegionId")]
            [Validation(Required=false)]
            public string ENSRegionId { get; set; }

            /// <summary>
            /// <para>The expiration time of the cluster.</para>
            /// <remarks>
            /// <para>This parameter is returned only for <b>Prepaid</b> (subscription) clusters. For <b>Postpaid</b> (pay-as-you-go) clusters, this parameter is empty.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>2022-09-14T16:00:00Z</para>
            /// </summary>
            [NameInMap("ExpireTime")]
            [Validation(Required=false)]
            public string ExpireTime { get; set; }

            /// <summary>
            /// <para>Indicates whether the cluster has expired. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>true</para>
            /// </description></item>
            /// <item><description><para>false</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("Expired")]
            [Validation(Required=false)]
            public string Expired { get; set; }

            /// <summary>
            /// <para>The lock state of the cluster. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>Unlock: Normal.</para>
            /// </description></item>
            /// <item><description><para>ManualLock: The cluster is manually locked.</para>
            /// </description></item>
            /// <item><description><para>LockByExpiration: The cluster is automatically locked upon expiration.</para>
            /// </description></item>
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
            /// <item><description><para>Postpaid: pay-as-you-go.</para>
            /// </description></item>
            /// <item><description><para>Prepaid: subscription.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Prepaid</para>
            /// </summary>
            [NameInMap("PayType")]
            [Validation(Required=false)]
            public string PayType { get; set; }

            /// <summary>
            /// <para>The Serverless type. \<c>**AgileServerless**\\</c> indicates that the cluster is a Serverless cluster. An empty value indicates that the cluster is a common cluster.</para>
            /// 
            /// <b>Example:</b>
            /// <para>AgileServerless</para>
            /// </summary>
            [NameInMap("ServerlessType")]
            [Validation(Required=false)]
            public string ServerlessType { get; set; }

            /// <summary>
            /// <para>The storage capacity of the instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("StorageSpace")]
            [Validation(Required=false)]
            public long? StorageSpace { get; set; }

            /// <summary>
            /// <para>The storage class of the Standard Edition cluster. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>essdpl0</para>
            /// </description></item>
            /// <item><description><para>essdpl1</para>
            /// </description></item>
            /// <item><description><para>essdpl2</para>
            /// </description></item>
            /// <item><description><para>essdpl3</para>
            /// </description></item>
            /// <item><description><para>essdautopl</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>essdautopl</para>
            /// </summary>
            [NameInMap("StorageType")]
            [Validation(Required=false)]
            public string StorageType { get; set; }

            /// <summary>
            /// <para>The used storage space of the cluster. Unit: bytes.</para>
            /// 
            /// <b>Example:</b>
            /// <para>3009413120</para>
            /// </summary>
            [NameInMap("StorageUsed")]
            [Validation(Required=false)]
            public long? StorageUsed { get; set; }

            /// <summary>
            /// <para>Indicates whether strong consistency is enabled for data across multiple zones. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>ON</b>: Strong consistency is enabled. This applies to Standard Edition clusters that are deployed in three zones.</para>
            /// </description></item>
            /// <item><description><para><b>OFF</b>: Strong consistency is not enabled.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>ON</para>
            /// </summary>
            [NameInMap("StrictConsistency")]
            [Validation(Required=false)]
            public string StrictConsistency { get; set; }

            /// <summary>
            /// <para>The specification type of the compute node. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>Exclusive</b>: Dedicated</para>
            /// </description></item>
            /// <item><description><para><b>General</b>: General-purpose</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Exclusive</para>
            /// </summary>
            [NameInMap("SubCategory")]
            [Validation(Required=false)]
            public string SubCategory { get; set; }

            /// <summary>
            /// <para>The list of tags.</para>
            /// </summary>
            [NameInMap("Tags")]
            [Validation(Required=false)]
            public List<DescribeDBClustersZonalResponseBodyItemsTags> Tags { get; set; }
            public class DescribeDBClustersZonalResponseBodyItemsTags : TeaModel {
                /// <summary>
                /// <para>The tag key.</para>
                /// 
                /// <b>Example:</b>
                /// <para>MySQL</para>
                /// </summary>
                [NameInMap("Key")]
                [Validation(Required=false)]
                public string Key { get; set; }

                /// <summary>
                /// <para>The tag value.</para>
                /// 
                /// <b>Example:</b>
                /// <para>5.6</para>
                /// </summary>
                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

            /// <summary>
            /// <para>The ID of the virtual private cloud (VPC).</para>
            /// 
            /// <b>Example:</b>
            /// <para>vpc-****************</para>
            /// </summary>
            [NameInMap("VpcId")]
            [Validation(Required=false)]
            public string VpcId { get; set; }

            /// <summary>
            /// <para>The virtual switch ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>vsw-***************</para>
            /// </summary>
            [NameInMap("VswitchId")]
            [Validation(Required=false)]
            public string VswitchId { get; set; }

            /// <summary>
            /// <para>The zone ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-hangzhou-i</para>
            /// </summary>
            [NameInMap("ZoneId")]
            [Validation(Required=false)]
            public string ZoneId { get; set; }

        }

        /// <summary>
        /// <para>The maximum number of entries returned for the current request. Default value: 10.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>The token to retrieve the next page of results. If more results are available, this parameter is returned. To retrieve the next page, include this token in your next request. If all results have been returned, this parameter is not returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>212db86sca4384811e0b5e8707e******</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The page number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>12</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of clusters on the current page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5</para>
        /// </summary>
        [NameInMap("PageRecordCount")]
        [Validation(Required=false)]
        public int? PageRecordCount { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>9B7BFB11-C077-4FE3-B051-F69CEB******</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of records.</para>
        /// 
        /// <b>Example:</b>
        /// <para>16</para>
        /// </summary>
        [NameInMap("TotalRecordCount")]
        [Validation(Required=false)]
        public int? TotalRecordCount { get; set; }

    }

}
