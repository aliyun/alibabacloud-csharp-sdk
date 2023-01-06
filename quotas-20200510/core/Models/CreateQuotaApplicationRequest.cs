// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Quotas20200510.Models
{
    public class CreateQuotaApplicationRequest : TeaModel {
        /// <summary>
        /// The mode in which you want the application to be reviewed. Valid values:
        /// 
        /// *   Sync: The application is reviewed in a synchronous manner. Quota Center automatically reviews the application. The result is returned immediately after you submit the application. However, the chance of an approval for an application that is reviewed in Sync mode is lower than the chance of an approval for an application that is reviewed in Async mode. The validity period of the new quota value is 1 hour.
        /// *   Async: The application is reviewed in an asynchronous manner. An Alibaba Cloud support engineer reviews the application. The chance of an approval for an application that is reviewed in Async mode is higher than the chance of an approval for an application that is reviewed in Sync mode. The validity period of the new quota value is one month.
        /// 
        /// > This parameter is available only for ECS Quotas by Instance Type.
        /// </summary>
        [NameInMap("AuditMode")]
        [Validation(Required=false)]
        public string AuditMode { get; set; }

        /// <summary>
        /// The requested value of the quota.
        /// 
        /// > Applications are reviewed by the technical support team of each Alibaba Cloud service. To increase the success rate of your application, you must specify a reasonable quota value and detailed reasons when you submit an application to increase the value of the quota.
        /// </summary>
        [NameInMap("DesireValue")]
        [Validation(Required=false)]
        public float? DesireValue { get; set; }

        /// <summary>
        /// The quota dimensions.
        /// </summary>
        [NameInMap("Dimensions")]
        [Validation(Required=false)]
        public List<CreateQuotaApplicationRequestDimensions> Dimensions { get; set; }
        public class CreateQuotaApplicationRequestDimensions : TeaModel {
            /// <summary>
            /// The dimension keys.
            /// 
            /// The value range of N varies based on the number of dimensions that are supported by the related Alibaba Cloud service.
            /// 
            /// > This parameter is required if you set the ProductCode parameter to ecs, ecs-spec, actiontrail, or ess.
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// The dimension values.
            /// 
            /// The value range of N varies based on the number of dimensions that are supported by the related Alibaba Cloud service.
            /// 
            /// > This parameter is required if you set the ProductCode parameter to ecs, ecs-spec, actiontrail, or ess.
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// The end time of the validity period of the quota. Specify the value in UTC. This parameter is valid only if you set the QuotaCategory parameter to WhiteListLabel.
        /// 
        /// > If you do not specify an end time, the default end time is 99 years after the quota application is submitted.
        /// </summary>
        [NameInMap("EffectiveTime")]
        [Validation(Required=false)]
        public string EffectiveTime { get; set; }

        /// <summary>
        /// The language of the quota alert notification. Valid values:
        /// 
        /// *   zh (default value): Chinese
        /// *   en: English
        /// </summary>
        [NameInMap("EnvLanguage")]
        [Validation(Required=false)]
        public string EnvLanguage { get; set; }

        /// <summary>
        /// The start time of the validity period of the quota. Specify the value in UTC. This parameter is valid only if you set the QuotaCategory parameter to WhiteListLabel.
        /// 
        /// > If you do not specify a start time, the default start time is the time when the quota application is submitted.
        /// </summary>
        [NameInMap("ExpireTime")]
        [Validation(Required=false)]
        public string ExpireTime { get; set; }

        /// <summary>
        /// Specifies whether to send a notification about the application result. Valid values:
        /// 
        /// *   0 (default value): no
        /// *   3: yes
        /// </summary>
        [NameInMap("NoticeType")]
        [Validation(Required=false)]
        public int? NoticeType { get; set; }

        /// <summary>
        /// The abbreviation of the Alibaba Cloud service name.
        /// 
        /// > For more information, see [Alibaba Cloud services that support Quota Center](~~182368~~).
        /// </summary>
        [NameInMap("ProductCode")]
        [Validation(Required=false)]
        public string ProductCode { get; set; }

        /// <summary>
        /// The ID of the quota.
        /// </summary>
        [NameInMap("QuotaActionCode")]
        [Validation(Required=false)]
        public string QuotaActionCode { get; set; }

        /// <summary>
        /// The type of the quota.
        /// 
        /// *   CommonQuota: general quota
        /// *   FlowControl: API rate limit
        /// *   WhiteListLabel: whitelist quota
        /// </summary>
        [NameInMap("QuotaCategory")]
        [Validation(Required=false)]
        public string QuotaCategory { get; set; }

        /// <summary>
        /// The reason for the application.
        /// 
        /// > Applications are reviewed by the technical support team of each Alibaba Cloud service. To increase the success rate of your application, you must specify a reasonable quota value and detailed reasons when you submit an application to increase the value of the quota.
        /// </summary>
        [NameInMap("Reason")]
        [Validation(Required=false)]
        public string Reason { get; set; }

    }

}
