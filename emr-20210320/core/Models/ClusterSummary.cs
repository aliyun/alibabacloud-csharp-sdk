// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Emr20210320.Models
{
    public class ClusterSummary : TeaModel {
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
        /// <para>The state of the cluster. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><c>STARTING</c>: The cluster is starting.</para>
        /// </description></item>
        /// <item><description><para><c>START_FAILED</c>: The cluster fails to be started.</para>
        /// </description></item>
        /// <item><description><para><c>BOOTSTRAPPING</c>: The cluster is being initialized.</para>
        /// </description></item>
        /// <item><description><para><c>RUNNING</c>: The cluster is running.</para>
        /// </description></item>
        /// <item><description><para><c>TERMINATING</c>: The cluster is being terminated.</para>
        /// </description></item>
        /// <item><description><para><c>TERMINATED</c>: The cluster is terminated.</para>
        /// </description></item>
        /// <item><description><para><c>TERMINATED_WITH_ERRORS</c>: The cluster is terminated with errors.</para>
        /// </description></item>
        /// <item><description><para><c>TERMINATE_FAILED</c>: The cluster fails to be terminated.</para>
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
        /// <item><description><para><c>DATALAKE</c>: data lake.</para>
        /// </description></item>
        /// <item><description><para><c>OLAP</c>: data analytics.</para>
        /// </description></item>
        /// <item><description><para><c>DATAFLOW</c>: real-time dataflow.</para>
        /// </description></item>
        /// <item><description><para><c>DATASERVING</c>: data serving.</para>
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
        /// <para>The time when the cluster was created.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1592837465788</para>
        /// </summary>
        [NameInMap("CreateTime")]
        [Validation(Required=false)]
        public long? CreateTime { get; set; }

        /// <summary>
        /// <para>The release protection feature.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("DeletionProtection")]
        [Validation(Required=false)]
        public bool? DeletionProtection { get; set; }

        /// <summary>
        /// <para>The description of the cluster.</para>
        /// 
        /// <b>Example:</b>
        /// <para>EMR cluster</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The EMR service role.</para>
        /// 
        /// <b>Example:</b>
        /// <para>AliyunEMRDefaultRole</para>
        /// </summary>
        [NameInMap("EmrDefaultRole")]
        [Validation(Required=false)]
        public string EmrDefaultRole { get; set; }

        /// <summary>
        /// <para>The time when the cluster was deleted.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1592837485788</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public long? EndTime { get; set; }

        /// <summary>
        /// <para>The expiration time.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1592837475788</para>
        /// </summary>
        [NameInMap("ExpireTime")]
        [Validation(Required=false)]
        public long? ExpireTime { get; set; }

        /// <summary>
        /// <para>The billing method. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><c>PayAsYouGo</c>: pay-as-you-go.</para>
        /// </description></item>
        /// <item><description><para><c>Subscription</c>: subscription.</para>
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
        /// <para>The time when the cluster is available.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1592837465788</para>
        /// </summary>
        [NameInMap("ReadyTime")]
        [Validation(Required=false)]
        public long? ReadyTime { get; set; }

        /// <summary>
        /// <para>The E-MapReduce (EMR) release version.</para>
        /// 
        /// <b>Example:</b>
        /// <para>EMR-5.8.0</para>
        /// </summary>
        [NameInMap("ReleaseVersion")]
        [Validation(Required=false)]
        public string ReleaseVersion { get; set; }

        /// <summary>
        /// <para>The resource group ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg-acfmzabjyop****</para>
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// <para>The reason for the failure.</para>
        /// </summary>
        [NameInMap("StateChangeReason")]
        [Validation(Required=false)]
        public ClusterStateChangeReason StateChangeReason { get; set; }

        /// <summary>
        /// <para>The list of tags.</para>
        /// </summary>
        [NameInMap("Tags")]
        [Validation(Required=false)]
        public List<Tag> Tags { get; set; }

    }

}
