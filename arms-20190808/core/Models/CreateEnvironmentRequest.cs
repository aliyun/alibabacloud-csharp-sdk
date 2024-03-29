// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ARMS20190808.Models
{
    public class CreateEnvironmentRequest : TeaModel {
        /// <summary>
        /// The language. Valid values: zh and en. Default value: zh.
        /// </summary>
        [NameInMap("AliyunLang")]
        [Validation(Required=false)]
        public string AliyunLang { get; set; }

        /// <summary>
        /// The ID of the resource bound to the environment, such as the container ID or VPC ID. For a Cloud environment, specify the region ID.
        /// </summary>
        [NameInMap("BindResourceId")]
        [Validation(Required=false)]
        public string BindResourceId { get; set; }

        /// <summary>
        /// The name of the environment.
        /// </summary>
        [NameInMap("EnvironmentName")]
        [Validation(Required=false)]
        public string EnvironmentName { get; set; }

        /// <summary>
        /// The subtype of the environment. Valid values:
        /// 
        /// *   CS: Container Service for Kubernetes (ACK)
        /// *   ECS: Elastic Compute Service (ECS)
        /// *   Cloud: cloud service
        /// </summary>
        [NameInMap("EnvironmentSubType")]
        [Validation(Required=false)]
        public string EnvironmentSubType { get; set; }

        /// <summary>
        /// The type of the environment. Valid values:
        /// 
        /// *   CS: Container Service
        /// *   ECS: Elastic Compute Service
        /// *   Cloud: cloud service
        /// </summary>
        [NameInMap("EnvironmentType")]
        [Validation(Required=false)]
        public string EnvironmentType { get; set; }

        [NameInMap("FeePackage")]
        [Validation(Required=false)]
        public string FeePackage { get; set; }

        /// <summary>
        /// type of managed: 
        /// - none: not managed. default value of prometheus for ACK.
        /// - agent: managed agent. default value of  promehtues for ASK/ACS/AckOne.
        /// - agent-exproter: maanged agent and exporter. default of prometheus for Cloud.
        /// </summary>
        [NameInMap("ManagedType")]
        [Validation(Required=false)]
        public string ManagedType { get; set; }

        /// <summary>
        /// the ID of prometheus instance bound to the environment. If not provided, please call the InitEnvironment interface to complete the initialization of the storage instance.
        /// </summary>
        [NameInMap("PrometheusInstanceId")]
        [Validation(Required=false)]
        public string PrometheusInstanceId { get; set; }

        /// <summary>
        /// The region ID.
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
