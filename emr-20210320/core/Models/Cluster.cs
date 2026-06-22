// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Emr20210320.Models
{
    public class Cluster : TeaModel {
        /// <summary>
        /// <para>The cluster ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>c-b933c5aac8fe****</para>
        /// </summary>
        [NameInMap("ClusterId")]
        [Validation(Required=false)]
        public string ClusterId { get; set; }

        /// <summary>
        /// <para>The cluster name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>emrtest</para>
        /// </summary>
        [NameInMap("ClusterName")]
        [Validation(Required=false)]
        public string ClusterName { get; set; }

        /// <summary>
        /// <para>The cluster state. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><c>STARTING</c>: The cluster is starting.</para>
        /// </description></item>
        /// <item><description><para><c>START_FAILED</c>: The cluster failed to start.</para>
        /// </description></item>
        /// <item><description><para><c>BOOTSTRAPPING</c>: The cluster is running bootstrap actions.</para>
        /// </description></item>
        /// <item><description><para><c>RUNNING</c>: The cluster is running.</para>
        /// </description></item>
        /// <item><description><para><c>TERMINATING</c>: The cluster is terminating.</para>
        /// </description></item>
        /// <item><description><para><c>TERMINATED</c>: The cluster is terminated.</para>
        /// </description></item>
        /// <item><description><para><c>TERMINATED_WITH_ERRORS</c>: The cluster terminated due to errors.</para>
        /// </description></item>
        /// <item><description><para><c>TERMINATE_FAILED</c>: The cluster failed to terminate.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>RUNNING</para>
        /// </summary>
        [NameInMap("ClusterState")]
        [Validation(Required=false)]
        public string ClusterState { get; set; }

        /// <summary>
        /// <para>The cluster type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><c>DATALAKE</c>: New data lake.</para>
        /// </description></item>
        /// <item><description><para><c>OLAP</c>: Data analysis.</para>
        /// </description></item>
        /// <item><description><para><c>DATAFLOW</c>: Real-time data flow.</para>
        /// </description></item>
        /// <item><description><para><c>DATASERVING</c>: Data serving.</para>
        /// </description></item>
        /// <item><description><para><c>CUSTOM</c>: Custom cluster.</para>
        /// </description></item>
        /// <item><description><para><c>HADOOP</c>: Legacy data lake.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>DATALAKE</para>
        /// </summary>
        [NameInMap("ClusterType")]
        [Validation(Required=false)]
        public string ClusterType { get; set; }

        /// <summary>
        /// <para>The time when the cluster was created. The time is a Unix timestamp in milliseconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1592837465784</para>
        /// </summary>
        [NameInMap("CreateTime")]
        [Validation(Required=false)]
        public long? CreateTime { get; set; }

        /// <summary>
        /// <para>Indicates whether deletion protection is enabled for the cluster.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("DeletionProtection")]
        [Validation(Required=false)]
        public bool? DeletionProtection { get; set; }

        /// <summary>
        /// <para>The application deployment mode. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><c>NORMAL</c>: Standard deployment.</para>
        /// </description></item>
        /// <item><description><para><c>HA</c>: High-availability deployment.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>HA</para>
        /// </summary>
        [NameInMap("DeployMode")]
        [Validation(Required=false)]
        public string DeployMode { get; set; }

        /// <summary>
        /// <para>The cluster description.</para>
        /// 
        /// <b>Example:</b>
        /// <para>EMR cluster</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The default role for E-MapReduce.</para>
        /// 
        /// <b>Example:</b>
        /// <para>AliyunEMRDefaultRole</para>
        /// </summary>
        [NameInMap("EmrDefaultRole")]
        [Validation(Required=false)]
        public string EmrDefaultRole { get; set; }

        /// <summary>
        /// <para>The time when the cluster was deleted. The time is a Unix timestamp in milliseconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1592837465784</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public long? EndTime { get; set; }

        /// <summary>
        /// <para>The time when the cluster is scheduled to expire. The time is a Unix timestamp in milliseconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1592837465784</para>
        /// </summary>
        [NameInMap("ExpireTime")]
        [Validation(Required=false)]
        public long? ExpireTime { get; set; }

        /// <summary>
        /// <para>The node attributes.</para>
        /// </summary>
        [NameInMap("NodeAttributes")]
        [Validation(Required=false)]
        public NodeAttributes NodeAttributes { get; set; }

        /// <summary>
        /// <para>The billing method. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><c>PayAsYouGo</c>: Pay-as-you-go.</para>
        /// </description></item>
        /// <item><description><para><c>Subscription</c>: Subscription.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>PayAsYouGo</para>
        /// </summary>
        [NameInMap("PaymentType")]
        [Validation(Required=false)]
        public string PaymentType { get; set; }

        /// <summary>
        /// <para>The time when the cluster became ready. The time is a Unix timestamp in milliseconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1592837465784</para>
        /// </summary>
        [NameInMap("ReadyTime")]
        [Validation(Required=false)]
        public long? ReadyTime { get; set; }

        /// <summary>
        /// <para>The ID of the region.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The release version of E-MapReduce.</para>
        /// 
        /// <b>Example:</b>
        /// <para>EMR-5.8.0</para>
        /// </summary>
        [NameInMap("ReleaseVersion")]
        [Validation(Required=false)]
        public string ReleaseVersion { get; set; }

        /// <summary>
        /// <para>The ID of the resource group.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg-acfmzabjyop****</para>
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// <para>The security mode of the cluster. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><c>NORMAL</c>: Kerberos is disabled.</para>
        /// </description></item>
        /// <item><description><para><c>KERBEROS</c>: Kerberos is enabled.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>NORMAL</para>
        /// </summary>
        [NameInMap("SecurityMode")]
        [Validation(Required=false)]
        public string SecurityMode { get; set; }

        /// <summary>
        /// <para>The reason for the cluster state change.</para>
        /// </summary>
        [NameInMap("StateChangeReason")]
        [Validation(Required=false)]
        public ClusterStateChangeReason StateChangeReason { get; set; }

        /// <summary>
        /// <para>The subscription configuration.</para>
        /// </summary>
        [NameInMap("SubscriptionConfig")]
        [Validation(Required=false)]
        public SubscriptionConfig SubscriptionConfig { get; set; }

        /// <summary>
        /// <para>The cluster tags.</para>
        /// </summary>
        [NameInMap("Tags")]
        [Validation(Required=false)]
        public List<Tag> Tags { get; set; }

    }

}
