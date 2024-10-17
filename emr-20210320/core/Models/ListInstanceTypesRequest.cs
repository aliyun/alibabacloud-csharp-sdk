// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Emr20210320.Models
{
    public class ListInstanceTypesRequest : TeaModel {
        /// <summary>
        /// <para>集群ID，仅升配场景使用。</para>
        /// 
        /// <b>Example:</b>
        /// <para>c-b933c5aac8fe****</para>
        /// </summary>
        [NameInMap("ClusterId")]
        [Validation(Required=false)]
        public string ClusterId { get; set; }

        /// <summary>
        /// <para>创建的EMR集群类型。取值范围：</para>
        /// <list type="bullet">
        /// <item><description>DATALAKE：新版数据湖。</description></item>
        /// <item><description>OLAP：数据分析。</description></item>
        /// <item><description>DATAFLOW：实时数据流。</description></item>
        /// <item><description>DATASERVING：数据服务。</description></item>
        /// <item><description>CUSTOM：自定义集群。</description></item>
        /// <item><description>HADOOP：旧版数据湖（不推荐使用，建议使用新版数据湖）。</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>DATALAKE</para>
        /// </summary>
        [NameInMap("ClusterType")]
        [Validation(Required=false)]
        public string ClusterType { get; set; }

        /// <summary>
        /// <para>集群中的应用部署模式。取值范围：</para>
        /// <list type="bullet">
        /// <item><description>NORMAL：非高可用部署。集群1个MASTER节点。</description></item>
        /// <item><description>HA：高可用部署。高可用部署要求至少3个MASTER节点。</description></item>
        /// </list>
        /// <para>默认值：NORMAL。</para>
        /// 
        /// <b>Example:</b>
        /// <para>HA</para>
        /// </summary>
        [NameInMap("DeployMode")]
        [Validation(Required=false)]
        public string DeployMode { get; set; }

        /// <summary>
        /// <para>机型</para>
        /// 
        /// <b>Example:</b>
        /// <para>ecs.g6.xlarge</para>
        /// </summary>
        [NameInMap("InstanceType")]
        [Validation(Required=false)]
        public string InstanceType { get; set; }

        /// <summary>
        /// <para>是否变配。</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("IsModification")]
        [Validation(Required=false)]
        public bool? IsModification { get; set; }

        /// <summary>
        /// <para>节点组ID。</para>
        /// 
        /// <b>Example:</b>
        /// <para>G-F06C4B47966A****</para>
        /// </summary>
        [NameInMap("NodeGroupId")]
        [Validation(Required=false)]
        public string NodeGroupId { get; set; }

        /// <summary>
        /// <para>节点组类型。取值范围：</para>
        /// <list type="bullet">
        /// <item><description>MASTER：管理类型节点组。</description></item>
        /// <item><description>CORE：存储类型节点组。</description></item>
        /// <item><description>TASK：计算类型节点组。</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>CORE</para>
        /// </summary>
        [NameInMap("NodeGroupType")]
        [Validation(Required=false)]
        public string NodeGroupType { get; set; }

        /// <summary>
        /// <para>集群的付费类型。取值范围：</para>
        /// <list type="bullet">
        /// <item><description>PayAsYouGo：后付费。</description></item>
        /// <item><description>Subscription：预付费。</description></item>
        /// </list>
        /// <para>默认值：PayAsYouGo。</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>PayAsYouGo</para>
        /// </summary>
        [NameInMap("PaymentType")]
        [Validation(Required=false)]
        public string PaymentType { get; set; }

        /// <summary>
        /// <para>区域ID。</para>
        /// <para>This parameter is required.</para>
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
        /// <para>可用区ID。</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-beijing-h</para>
        /// </summary>
        [NameInMap("ZoneId")]
        [Validation(Required=false)]
        public string ZoneId { get; set; }

    }

}
