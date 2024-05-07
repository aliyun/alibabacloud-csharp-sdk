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
        /// *   CS: ACK
        /// *   ECS: ECS
        /// *   Cloud: cloud service
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
        /// </summary>
        [NameInMap("EnvironmentType")]
        [Validation(Required=false)]
        public string EnvironmentType { get; set; }

        /// <summary>
        /// Paid packages.
        /// *  When EnvironmentType is CS: can be specified as CS_Basic (default) or CS_Pro.
        /// * When EnvironmentType is any other value, enter a null value.
        /// </summary>
        [NameInMap("FeePackage")]
        [Validation(Required=false)]
        public string FeePackage { get; set; }

        /// <summary>
        /// Specifies whether agents or exporters are managed. Valid values:
        /// 
        /// *   none: No. By default, no managed agents or exporters are provided for ACK clusters.
        /// *   agent: Agents are managed. By default, managed agents are provided for ASK clusters, ACS clusters, and ACK One clusters.
        /// *   agent-exproter: Agents and exporters are managed. By default, managed agents and exporters are provided for cloud services.
        /// </summary>
        [NameInMap("ManagedType")]
        [Validation(Required=false)]
        public string ManagedType { get; set; }

        /// <summary>
        /// Nullable, the prom instance id for the environment binding. if not provided, call the InitEnvironment interface to complete the initialization of the storage instance.
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
