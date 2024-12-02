// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Emr20210320.Models
{
    public class ClusterSummary : TeaModel {
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
        /// <para>集群状态。取值范围：</para>
        /// <list type="bullet">
        /// <item><description>STARTING：启动中。</description></item>
        /// <item><description>START_FAILED：启动失败。</description></item>
        /// <item><description>BOOTSTRAPPING：引导操作初始化。</description></item>
        /// <item><description>RUNNING：运行中。</description></item>
        /// <item><description>TERMINATING：终止中。</description></item>
        /// <item><description>TERMINATED：已终止。</description></item>
        /// <item><description>TERMINATED_WITH_ERRORS：发生异常导致终止。</description></item>
        /// <item><description>TERMINATE_FAILED：终止失败。</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>RUNNING</para>
        /// </summary>
        [NameInMap("ClusterState")]
        [Validation(Required=false)]
        public string ClusterState { get; set; }

        /// <summary>
        /// <para>集群类型。取值范围：</para>
        /// <list type="bullet">
        /// <item><description>DATALAKE：新版数据湖。</description></item>
        /// <item><description>OLAP：数据分析。</description></item>
        /// <item><description>DATAFLOW：实时数据流。</description></item>
        /// <item><description>DATASERVING：数据服务。</description></item>
        /// </list>
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

        [NameInMap("DeletionProtection")]
        [Validation(Required=false)]
        public bool? DeletionProtection { get; set; }

        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>EMR服务角色。</para>
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
        /// <para>付费类型。取值范围：</para>
        /// <list type="bullet">
        /// <item><description>PayAsYouGo：后付费。</description></item>
        /// <item><description>Subscription：预付费。</description></item>
        /// </list>
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
        /// <para>EMR发行版。</para>
        /// 
        /// <b>Example:</b>
        /// <para>EMR-5.8.0</para>
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
        /// <para>失败原因。</para>
        /// </summary>
        [NameInMap("StateChangeReason")]
        [Validation(Required=false)]
        public ClusterStateChangeReason StateChangeReason { get; set; }

        /// <summary>
        /// <para>标签列表。</para>
        /// </summary>
        [NameInMap("Tags")]
        [Validation(Required=false)]
        public List<Tag> Tags { get; set; }

    }

}
