// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mse20190531.Models
{
    public class AddGatewayShrinkRequest : TeaModel {
        /// <summary>
        /// The language of the response. Valid values:
        /// 
        /// *   zh: Chinese
        /// *   en: English
        /// </summary>
        [NameInMap("AcceptLanguage")]
        [Validation(Required=false)]
        public string AcceptLanguage { get; set; }

        /// <summary>
        /// The billing method.
        /// 
        /// Valid values:
        /// 
        /// *   PREPAY
        /// 
        ///     <!-- -->
        /// 
        ///     :
        /// 
        ///     <!-- -->
        /// 
        ///     the subscription billing method
        /// 
        ///     <!-- -->
        /// 
        /// *   POSTPAY
        /// 
        ///     <!-- -->
        /// 
        ///     :
        /// 
        ///     <!-- -->
        /// 
        ///     the pay-as-you-go billing method
        /// 
        ///     <!-- -->
        /// </summary>
        [NameInMap("ChargeType")]
        [Validation(Required=false)]
        public string ChargeType { get; set; }

        [NameInMap("ClbNetworkType")]
        [Validation(Required=false)]
        public string ClbNetworkType { get; set; }

        /// <summary>
        /// Specifies whether to activate Tracing Analysis.
        /// </summary>
        [NameInMap("EnableHardwareAcceleration")]
        [Validation(Required=false)]
        public bool? EnableHardwareAcceleration { get; set; }

        /// <summary>
        /// The tag of the gateway.
        /// </summary>
        [NameInMap("EnableSls")]
        [Validation(Required=false)]
        public bool? EnableSls { get; set; }

        /// <summary>
        /// The sampling rate of Tracing Analysis. Valid values: [1,100].
        /// </summary>
        [NameInMap("EnableXtrace")]
        [Validation(Required=false)]
        public bool? EnableXtrace { get; set; }

        /// <summary>
        /// Specifies whether to enable hardware acceleration.
        /// </summary>
        [NameInMap("EnterpriseSecurityGroup")]
        [Validation(Required=false)]
        public bool? EnterpriseSecurityGroup { get; set; }

        /// <summary>
        /// The ID of the secondary vSwitch.
        /// </summary>
        [NameInMap("InternetSlbSpec")]
        [Validation(Required=false)]
        public string InternetSlbSpec { get; set; }

        /// <summary>
        /// The MSE instance type. Valid values:
        /// 
        /// *   mse_pro: ordinary instance.
        /// *   mse_serverless: serverless instance.
        /// </summary>
        [NameInMap("MserVersion")]
        [Validation(Required=false)]
        public string MserVersion { get; set; }

        /// <summary>
        /// The ID of the region.
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// The network type of the Network Load Balancer (NLB) instance when the serverless NLB instance is purchased. Valid values:
        /// 
        /// *   pubnet
        /// *   privatenet
        /// *   privatepubnet
        /// </summary>
        [NameInMap("NlbNetworkType")]
        [Validation(Required=false)]
        public string NlbNetworkType { get; set; }

        /// <summary>
        /// The specifications of the internal-facing Server Load Balancer (SLB) instance. Valid values:
        /// 
        /// *   slb.s1.small
        /// *   slb.s2.small
        /// *   slb.s2.medium
        /// *   slb.s3.small
        /// *   slb.s3.medium
        /// *   slb.s3.large
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("Region")]
        [Validation(Required=false)]
        public string Region { get; set; }

        /// <summary>
        /// The number of nodes.
        /// </summary>
        [NameInMap("Replica")]
        [Validation(Required=false)]
        public int? Replica { get; set; }

        /// <summary>
        /// The extended field.
        /// </summary>
        [NameInMap("RequestPars")]
        [Validation(Required=false)]
        public string RequestPars { get; set; }

        /// <summary>
        /// The language of the response. Valid values:
        /// 
        /// *   zh: Chinese
        /// *   en: English
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// The specifications of the internal-facing Server Load Balancer (SLB) instance. Valid values:
        /// 
        /// *   slb.s1.small
        /// *   slb.s2.small
        /// *   slb.s2.medium
        /// *   slb.s3.small
        /// *   slb.s3.medium
        /// *   slb.s3.large
        /// </summary>
        [NameInMap("SlbSpec")]
        [Validation(Required=false)]
        public string SlbSpec { get; set; }

        /// <summary>
        /// The node specifications. Valid values:
        /// 
        /// *   MSE_GTW_16_32_200_c(16C32G)
        /// *   MSE_GTW_2_4_200_c(2C4G)
        /// *   MSE_GTW_4_8_200_c(4C8G)
        /// *   MSE_GTW_8_16_200_c(8C16G)
        /// </summary>
        [NameInMap("Spec")]
        [Validation(Required=false)]
        public string Spec { get; set; }

        /// <summary>
        /// The tag object.
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<AddGatewayShrinkRequestTag> Tag { get; set; }
        public class AddGatewayShrinkRequestTag : TeaModel {
            /// <summary>
            /// The value of the tag.
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// The ID of the resource group.
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// The ID of the primary vSwitch.
        /// </summary>
        [NameInMap("VSwitchId")]
        [Validation(Required=false)]
        public string VSwitchId { get; set; }

        /// <summary>
        /// Specifies whether to use an advanced security group.
        /// </summary>
        [NameInMap("VSwitchId2")]
        [Validation(Required=false)]
        public string VSwitchId2 { get; set; }

        /// <summary>
        /// The ID of the primary vSwitch.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("Vpc")]
        [Validation(Required=false)]
        public string Vpc { get; set; }

        /// <summary>
        /// Specifies whether to activate Log Service.
        /// </summary>
        [NameInMap("XtraceRatio")]
        [Validation(Required=false)]
        public string XtraceRatio { get; set; }

        /// <summary>
        /// The details of the zone.
        /// </summary>
        [NameInMap("ZoneInfo")]
        [Validation(Required=false)]
        public string ZoneInfoShrink { get; set; }

    }

}
