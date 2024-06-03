// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Emr20210320.Models
{
    public class ListInstanceTypesRequest : TeaModel {
        /// <summary>
        /// 集群ID，仅升配场景使用。
        /// </summary>
        [NameInMap("ClusterId")]
        [Validation(Required=false)]
        public string ClusterId { get; set; }

        /// <summary>
        /// 创建的EMR集群类型。取值范围：
        /// - DATALAKE：新版数据湖。
        /// - OLAP：数据分析。
        /// - DATAFLOW：实时数据流。
        /// - DATASERVING：数据服务。
        /// - CUSTOM：自定义集群。
        /// - HADOOP：旧版数据湖（不推荐使用，建议使用新版数据湖）。
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("ClusterType")]
        [Validation(Required=false)]
        public string ClusterType { get; set; }

        /// <summary>
        /// 集群中的应用部署模式。取值范围：
        /// - NORMAL：非高可用部署。集群1个MASTER节点。
        /// - HA：高可用部署。高可用部署要求至少3个MASTER节点。
        /// 
        /// 默认值：NORMAL。
        /// </summary>
        [NameInMap("DeployMode")]
        [Validation(Required=false)]
        public string DeployMode { get; set; }

        /// <summary>
        /// 机型
        /// </summary>
        [NameInMap("InstanceType")]
        [Validation(Required=false)]
        public string InstanceType { get; set; }

        /// <summary>
        /// 是否变配。
        /// </summary>
        [NameInMap("IsModification")]
        [Validation(Required=false)]
        public bool? IsModification { get; set; }

        /// <summary>
        /// 节点组ID。
        /// </summary>
        [NameInMap("NodeGroupId")]
        [Validation(Required=false)]
        public string NodeGroupId { get; set; }

        /// <summary>
        /// 节点组类型。取值范围：
        /// - MASTER：管理类型节点组。
        /// - CORE：存储类型节点组。
        /// - TASK：计算类型节点组。
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("NodeGroupType")]
        [Validation(Required=false)]
        public string NodeGroupType { get; set; }

        /// <summary>
        /// 集群的付费类型。取值范围：
        /// - PayAsYouGo：后付费。
        /// - Subscription：预付费。
        /// 
        /// 默认值：PayAsYouGo。
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("PaymentType")]
        [Validation(Required=false)]
        public string PaymentType { get; set; }

        /// <summary>
        /// 区域ID。
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// EMR发行版。
        /// </summary>
        [NameInMap("ReleaseVersion")]
        [Validation(Required=false)]
        public string ReleaseVersion { get; set; }

        /// <summary>
        /// 可用区ID。
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("ZoneId")]
        [Validation(Required=false)]
        public string ZoneId { get; set; }

    }

}
