// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Emr20210320.Models
{
    public class Cluster : TeaModel {
        /// <summary>
        /// <para>集群ID。</para>
        /// 
        /// <b>Example:</b>
        /// <para>c-b933c5aac8fe****</para>
        /// </summary>
        [NameInMap("ClusterId")]
        [Validation(Required=false)]
        public string ClusterId { get; set; }

        /// <summary>
        /// <para>集群名称。</para>
        /// 
        /// <b>Example:</b>
        /// <para>emrtest</para>
        /// </summary>
        [NameInMap("ClusterName")]
        [Validation(Required=false)]
        public string ClusterName { get; set; }

        /// <summary>
        /// <para>集群状态。</para>
        /// 
        /// <b>Example:</b>
        /// <para>RUNNING</para>
        /// </summary>
        [NameInMap("ClusterState")]
        [Validation(Required=false)]
        public string ClusterState { get; set; }

        /// <summary>
        /// <para>集群类型。</para>
        /// 
        /// <b>Example:</b>
        /// <para>DATALAKE</para>
        /// </summary>
        [NameInMap("ClusterType")]
        [Validation(Required=false)]
        public string ClusterType { get; set; }

        /// <summary>
        /// <para>创建时间。</para>
        /// 
        /// <b>Example:</b>
        /// <para>1592837465784</para>
        /// </summary>
        [NameInMap("CreateTime")]
        [Validation(Required=false)]
        public long? CreateTime { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("DeletionProtection")]
        [Validation(Required=false)]
        public bool? DeletionProtection { get; set; }

        /// <summary>
        /// <para>部署模式。</para>
        /// 
        /// <b>Example:</b>
        /// <para>HA</para>
        /// </summary>
        [NameInMap("DeployMode")]
        [Validation(Required=false)]
        public string DeployMode { get; set; }

        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>EMR默认角色。</para>
        /// 
        /// <b>Example:</b>
        /// <para>AliyunEMRDefaultRole</para>
        /// </summary>
        [NameInMap("EmrDefaultRole")]
        [Validation(Required=false)]
        public string EmrDefaultRole { get; set; }

        /// <summary>
        /// <para>删除时间。</para>
        /// 
        /// <b>Example:</b>
        /// <para>1592837465784</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public long? EndTime { get; set; }

        /// <summary>
        /// <para>过期时间。</para>
        /// 
        /// <b>Example:</b>
        /// <para>1592837465784</para>
        /// </summary>
        [NameInMap("ExpireTime")]
        [Validation(Required=false)]
        public long? ExpireTime { get; set; }

        /// <summary>
        /// <para>节点属性。</para>
        /// </summary>
        [NameInMap("NodeAttributes")]
        [Validation(Required=false)]
        public NodeAttributes NodeAttributes { get; set; }

        /// <summary>
        /// <para>付费类型。</para>
        /// 
        /// <b>Example:</b>
        /// <para>PayAsYouGo</para>
        /// </summary>
        [NameInMap("PaymentType")]
        [Validation(Required=false)]
        public string PaymentType { get; set; }

        /// <summary>
        /// <para>可用时间。</para>
        /// 
        /// <b>Example:</b>
        /// <para>1592837465784</para>
        /// </summary>
        [NameInMap("ReadyTime")]
        [Validation(Required=false)]
        public long? ReadyTime { get; set; }

        /// <summary>
        /// <para>地域ID。</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>EMR发行版。</para>
        /// 
        /// <b>Example:</b>
        /// <para>EMR-5.3.0</para>
        /// </summary>
        [NameInMap("ReleaseVersion")]
        [Validation(Required=false)]
        public string ReleaseVersion { get; set; }

        /// <summary>
        /// <para>资源组ID。</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg-acfmzabjyop****</para>
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// <para>Kerberos安全模式。</para>
        /// 
        /// <b>Example:</b>
        /// <para>NORMAL</para>
        /// </summary>
        [NameInMap("SecurityMode")]
        [Validation(Required=false)]
        public string SecurityMode { get; set; }

        [NameInMap("StateChangeReason")]
        [Validation(Required=false)]
        public ClusterStateChangeReason StateChangeReason { get; set; }

        /// <summary>
        /// <para>预付费配置。</para>
        /// </summary>
        [NameInMap("SubscriptionConfig")]
        [Validation(Required=false)]
        public SubscriptionConfig SubscriptionConfig { get; set; }

        /// <summary>
        /// <para>集群标签。</para>
        /// </summary>
        [NameInMap("Tags")]
        [Validation(Required=false)]
        public List<Tag> Tags { get; set; }

    }

}
