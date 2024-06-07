// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ARMS20190808.Models
{
    public class CreateEnvironmentRequest : TeaModel {
        /// <summary>
        /// The language. Default value: zh.
        /// 
        /// Valid values:
        /// 
        /// *   en
        /// 
        ///     <!-- -->
        /// 
        ///     :
        /// 
        ///     <!-- -->
        /// 
        ///     English
        /// 
        ///     <!-- -->
        /// 
        ///     .
        /// 
        /// *   zh
        /// 
        ///     <!-- -->
        /// 
        ///     :
        /// 
        ///     <!-- -->
        /// 
        ///     Chinese
        /// 
        ///     <!-- -->
        /// 
        ///     .
        /// </summary>
        [NameInMap("AliyunLang")]
        [Validation(Required=false)]
        public string AliyunLang { get; set; }

        /// <summary>
        /// The ID of the resource bound to the environment, such as the container ID or VPC ID. For a Cloud environment, specify the region ID.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("BindResourceId")]
        [Validation(Required=false)]
        public string BindResourceId { get; set; }

        /// <summary>
        /// The name of the environment.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("EnvironmentName")]
        [Validation(Required=false)]
        public string EnvironmentName { get; set; }

        /// <summary>
        /// The subtype of the environment. Valid values:
        /// 
        /// *   CS: ACK
        /// *   ECS: ECS
        /// *   Cloud: cloud service
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("EnvironmentSubType")]
        [Validation(Required=false)]
        public string EnvironmentSubType { get; set; }

        /// <summary>
        /// The type of the environment. Valid values:
        /// 
        /// *   CS: ACK
        /// *   ECS: ECS
        /// *   Cloud: cloud service
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("EnvironmentType")]
        [Validation(Required=false)]
        public string EnvironmentType { get; set; }

        /// <summary>
        /// The payable resource plan. Valid values:
        /// 
        /// *   If the EnvironmentType parameter is set to CS, set the value to CS_Basic or CS_Pro. Default value: CS_Basic.
        /// *   Otherwise, leave the parameter empty.
        /// </summary>
        [NameInMap("FeePackage")]
        [Validation(Required=false)]
        public string FeePackage { get; set; }

        /// <summary>
        /// 环境绑定的grafana工作区id。传空时，表示使用默认的共享grafana。
        /// </summary>
        [NameInMap("GrafanaWorkspaceId")]
        [Validation(Required=false)]
        public string GrafanaWorkspaceId { get; set; }

        /// <summary>
        /// Specifies whether agents or exporters are managed. Valid values:
        /// 
        /// *   none: No. By default, no managed agents or exporters are provided for ACK clusters.
        /// *   agent: Agents are managed. By default, managed agents are provided for ASK clusters, ACS clusters, and ACK One clusters.
        /// *   agent-exporter: Agents and exporters are managed. By default, managed agents and exporters are provided for cloud services.
        /// </summary>
        [NameInMap("ManagedType")]
        [Validation(Required=false)]
        public string ManagedType { get; set; }

        /// <summary>
        /// The ID of the Prometheus instance. If no Prometheus instance is created, call the InitEnvironment operation.
        /// </summary>
        [NameInMap("PrometheusInstanceId")]
        [Validation(Required=false)]
        public string PrometheusInstanceId { get; set; }

        /// <summary>
        /// The region ID.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// The ID of the resource group.
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// The tags of the instance. You can specify this parameter to manage tags for the instance.
        /// </summary>
        [NameInMap("Tags")]
        [Validation(Required=false)]
        public List<CreateEnvironmentRequestTags> Tags { get; set; }
        public class CreateEnvironmentRequestTags : TeaModel {
            /// <summary>
            /// The tag key.
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// The tag value.
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

    }

}
