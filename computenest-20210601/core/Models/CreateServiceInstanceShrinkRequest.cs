// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ComputeNest20210601.Models
{
    public class CreateServiceInstanceShrinkRequest : TeaModel {
        [NameInMap("BusinessInfo")]
        [Validation(Required=false)]
        public string BusinessInfoShrink { get; set; }

        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        [NameInMap("Commodity")]
        [Validation(Required=false)]
        public CreateServiceInstanceShrinkRequestCommodity Commodity { get; set; }
        public class CreateServiceInstanceShrinkRequestCommodity : TeaModel {
            [NameInMap("PayPeriod")]
            [Validation(Required=false)]
            public long? PayPeriod { get; set; }

            [NameInMap("PayPeriodUnit")]
            [Validation(Required=false)]
            public string PayPeriodUnit { get; set; }

        }

        /// <summary>
        /// 接收告警的云监控联系人组。
        /// </summary>
        [NameInMap("ContactGroup")]
        [Validation(Required=false)]
        public string ContactGroup { get; set; }

        [NameInMap("DryRun")]
        [Validation(Required=false)]
        public bool? DryRun { get; set; }

        [NameInMap("EnableInstanceOps")]
        [Validation(Required=false)]
        public bool? EnableInstanceOps { get; set; }

        [NameInMap("EnableUserPrometheus")]
        [Validation(Required=false)]
        public bool? EnableUserPrometheus { get; set; }

        /// <summary>
        /// 服务实例名称。格式要求如下：
        /// 
        /// - 长度不超过64个字符。
        /// 
        /// - 必须以数字或英文字母开头，可包含数字、英文字母、短划线（-）和下划线（_）。
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("OperationMetadata")]
        [Validation(Required=false)]
        public CreateServiceInstanceShrinkRequestOperationMetadata OperationMetadata { get; set; }
        public class CreateServiceInstanceShrinkRequestOperationMetadata : TeaModel {
            [NameInMap("EndTime")]
            [Validation(Required=false)]
            public string EndTime { get; set; }

            [NameInMap("ExtraInfo")]
            [Validation(Required=false)]
            public string ExtraInfo { get; set; }

            [NameInMap("Resources")]
            [Validation(Required=false)]
            public string Resources { get; set; }

            [NameInMap("ServiceInstanceId")]
            [Validation(Required=false)]
            public string ServiceInstanceId { get; set; }

            [NameInMap("StartTime")]
            [Validation(Required=false)]
            public string StartTime { get; set; }

        }

        [NameInMap("Parameters")]
        [Validation(Required=false)]
        public string ParametersShrink { get; set; }

        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        [NameInMap("ServiceId")]
        [Validation(Required=false)]
        public string ServiceId { get; set; }

        [NameInMap("ServiceVersion")]
        [Validation(Required=false)]
        public string ServiceVersion { get; set; }

        [NameInMap("SpecificationCode")]
        [Validation(Required=false)]
        public string SpecificationCode { get; set; }

        /// <summary>
        /// 套餐规格名称。
        /// </summary>
        [NameInMap("SpecificationName")]
        [Validation(Required=false)]
        public string SpecificationName { get; set; }

        /// <summary>
        /// 用户自定义标签。
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<CreateServiceInstanceShrinkRequestTag> Tag { get; set; }
        public class CreateServiceInstanceShrinkRequestTag : TeaModel {
            /// <summary>
            /// 标签键。
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// 标签值。
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        [NameInMap("TemplateName")]
        [Validation(Required=false)]
        public string TemplateName { get; set; }

        /// <summary>
        /// 使用类型。可选值：
        /// 
        /// - Trial：支持试用。
        /// 
        /// - NotTrial：不支持试用。
        /// </summary>
        [NameInMap("TrialType")]
        [Validation(Required=false)]
        public string TrialType { get; set; }

    }

}
