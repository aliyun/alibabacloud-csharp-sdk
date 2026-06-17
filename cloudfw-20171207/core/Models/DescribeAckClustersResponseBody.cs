// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudfw20171207.Models
{
    public class DescribeAckClustersResponseBody : TeaModel {
        /// <summary>
        /// <para>A list of ACK clusters.</para>
        /// </summary>
        [NameInMap("Clusters")]
        [Validation(Required=false)]
        public List<DescribeAckClustersResponseBodyClusters> Clusters { get; set; }
        public class DescribeAckClustersResponseBodyClusters : TeaModel {
            /// <summary>
            /// <para>The ID of the ACK cluster.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cb0f5640b1b2d404cad6ba21509d7847b</para>
            /// </summary>
            [NameInMap("ClusterId")]
            [Validation(Required=false)]
            public string ClusterId { get; set; }

            /// <summary>
            /// <para>The name of the ACK cluster.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ack-cluster-name</para>
            /// </summary>
            [NameInMap("ClusterName")]
            [Validation(Required=false)]
            public string ClusterName { get; set; }

            /// <summary>
            /// <para>The specification of the ACK cluster.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ack.pro.small</para>
            /// </summary>
            [NameInMap("ClusterSpec")]
            [Validation(Required=false)]
            public string ClusterSpec { get; set; }

            /// <summary>
            /// <para>The type of the ACK cluster. For more information about the valid values, see <a href="~~DescribeClustersV1~~">DescribeClustersV1</a>.</para>
            /// <list type="bullet">
            /// <item><description><a href="~~DescribeClustersV1~~">DescribeClustersV1</a>: Returns a list of ACK clusters in your account that meet specific criteria, such as the cluster type and specifications.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>ManagedKubernetes</para>
            /// </summary>
            [NameInMap("ClusterType")]
            [Validation(Required=false)]
            public string ClusterType { get; set; }

            /// <summary>
            /// <para>The Alibaba Cloud UID of the account to which the ACK cluster resources belong.</para>
            /// 
            /// <b>Example:</b>
            /// <para>135809047715****</para>
            /// </summary>
            [NameInMap("MemberUid")]
            [Validation(Required=false)]
            public string MemberUid { get; set; }

            /// <summary>
            /// <para>The network plugin of the ACK cluster. For more information about the valid values, see <a href="~~DescribeClustersV1~~">DescribeClustersV1</a>.</para>
            /// <list type="bullet">
            /// <item><description><a href="~~DescribeClustersV1~~">DescribeClustersV1</a>: Lists the ACK clusters in your account that meet specified conditions, such as cluster type and specifications.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>terway-eniip</para>
            /// </summary>
            [NameInMap("Network")]
            [Validation(Required=false)]
            public string Network { get; set; }

            /// <summary>
            /// <para>The subtype of the cluster. This parameter is available only when <c>ClusterType</c> is set to <c>ManagedKubernetes</c>. For more information about the valid values, see <a href="~~DescribeClustersV1~~">DescribeClustersV1</a>.</para>
            /// <list type="bullet">
            /// <item><description><a href="~~DescribeClustersV1~~">DescribeClustersV1</a>: Lists ACK clusters in your account that meet specified conditions, such as cluster type and specifications.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Default</para>
            /// </summary>
            [NameInMap("Profile")]
            [Validation(Required=false)]
            public string Profile { get; set; }

            /// <summary>
            /// <para>The region ID of the ACK cluster.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-hangzhou</para>
            /// </summary>
            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            /// <summary>
            /// <para>The running status of the ACK cluster. For more information about the valid values, see <a href="~~DescribeClustersV1~~">DescribeClustersV1</a>.</para>
            /// <list type="bullet">
            /// <item><description><a href="~~DescribeClustersV1~~">DescribeClustersV1</a>: Retrieves a list of ACK clusters in your account that meet specified conditions, such as cluster type and specifications.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>running</para>
            /// </summary>
            [NameInMap("State")]
            [Validation(Required=false)]
            public string State { get; set; }

            /// <summary>
            /// <para>The ID of the VPC where the ACK cluster is deployed.</para>
            /// 
            /// <b>Example:</b>
            /// <para>vpc-2vcg932hsxsxuqbgl****</para>
            /// </summary>
            [NameInMap("VpcId")]
            [Validation(Required=false)]
            public string VpcId { get; set; }

        }

        /// <summary>
        /// <para>The page number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNo")]
        [Validation(Required=false)]
        public int? PageNo { get; set; }

        /// <summary>
        /// <para>The number of entries per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>C5DDD596-1191-5F36-A504-8733045A****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of entries.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
