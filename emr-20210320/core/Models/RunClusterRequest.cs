// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Emr20210320.Models
{
    public class RunClusterRequest : TeaModel {
        /// <summary>
        /// <para>应用配置。数组元素个数N的取值范围：1~1000。</para>
        /// </summary>
        [NameInMap("ApplicationConfigs")]
        [Validation(Required=false)]
        public List<ApplicationConfig> ApplicationConfigs { get; set; }

        /// <summary>
        /// <para>应用列表。数组元素个数N的取值范围：1~100。</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("Applications")]
        [Validation(Required=false)]
        public List<Application> Applications { get; set; }

        /// <summary>
        /// <para>引导脚本。数组元素个数N的取值范围：1~10。</para>
        /// </summary>
        [NameInMap("BootstrapScripts")]
        [Validation(Required=false)]
        public List<Script> BootstrapScripts { get; set; }

        /// <summary>
        /// <para>幂等客户端TOKEN。同一个ClientToken多次调用的返回结果一致，同一个ClientToken最多只创建一个集群。</para>
        /// 
        /// <b>Example:</b>
        /// <para>A7D960FA-6DBA-5E07-8746-A63E3E4D****</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>集群名称。长度为1~128个字符，必须以大小字母或中文开头，不能以http://和https://开头。可以包含中文、英文、数字、半角冒号（:）、下划线（_）、半角句号（.）或者短划线（-）</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>emrtest</para>
        /// </summary>
        [NameInMap("ClusterName")]
        [Validation(Required=false)]
        public string ClusterName { get; set; }

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
        /// <b>Example:</b>
        /// <para>Emr cluster for ETL</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        [NameInMap("NodeAttributes")]
        [Validation(Required=false)]
        public NodeAttributes NodeAttributes { get; set; }

        /// <summary>
        /// <para>节点组。数组元素个数N的取值范围：1~100。</para>
        /// <para>
        /// 
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("NodeGroups")]
        [Validation(Required=false)]
        public List<NodeGroupConfig> NodeGroups { get; set; }

        /// <summary>
        /// <para>集群的付费类型。取值范围：</para>
        /// <list type="bullet">
        /// <item><description>PayAsYouGo：后付费。</description></item>
        /// <item><description>Subscription：预付费。</description></item>
        /// </list>
        /// <para>默认值：PayAsYouGo。</para>
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
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>EMR-5.16.0</para>
        /// </summary>
        [NameInMap("ReleaseVersion")]
        [Validation(Required=false)]
        public string ReleaseVersion { get; set; }

        /// <summary>
        /// <para>集群所在的企业资源组ID。</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg-acfmzabjyop****</para>
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// <para>Kerberos安全模式。取值范围：</para>
        /// <list type="bullet">
        /// <item><description>NORMAL：普通模式，不开启Kerberos模式。</description></item>
        /// <item><description>KERBEROS：开启Kerberos模式。</description></item>
        /// </list>
        /// <para>默认值：NORMAL</para>
        /// 
        /// <b>Example:</b>
        /// <para>NORMAL</para>
        /// </summary>
        [NameInMap("SecurityMode")]
        [Validation(Required=false)]
        public string SecurityMode { get; set; }

        [NameInMap("SubscriptionConfig")]
        [Validation(Required=false)]
        public SubscriptionConfig SubscriptionConfig { get; set; }

        /// <summary>
        /// <para>标签。数组元数个数N的取值范围：0~20。</para>
        /// </summary>
        [NameInMap("Tags")]
        [Validation(Required=false)]
        public List<Tag> Tags { get; set; }

    }

}
