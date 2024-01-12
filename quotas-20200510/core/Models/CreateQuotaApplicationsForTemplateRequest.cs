// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Quotas20200510.Models
{
    public class CreateQuotaApplicationsForTemplateRequest : TeaModel {
        /// <summary>
        /// The Alibaba Cloud accounts that correspond to the resource directory member accounts for which the quotas are applied.
        /// 
        /// >  You can apply for a quota increase for up to 50 member accounts in each request. For more information about the member accounts in a resource directory, see [ListAccounts](~~604207~~).
        /// </summary>
        [NameInMap("AliyunUids")]
        [Validation(Required=false)]
        public List<string> AliyunUids { get; set; }

        /// <summary>
        /// The requested value of the quota.
        /// 
        /// >  Applications are reviewed by the technical support team of each Alibaba Cloud service. To increase the success rate of your application, you must specify a reasonable quota value and detailed reasons when you submit the application.
        /// </summary>
        [NameInMap("DesireValue")]
        [Validation(Required=false)]
        public double? DesireValue { get; set; }

        /// <summary>
        /// The quota dimensions.
        /// </summary>
        [NameInMap("Dimensions")]
        [Validation(Required=false)]
        public List<CreateQuotaApplicationsForTemplateRequestDimensions> Dimensions { get; set; }
        public class CreateQuotaApplicationsForTemplateRequestDimensions : TeaModel {
            /// <summary>
            /// The key of the quota dimension.
            /// 
            /// The value range of N varies based on the number of dimensions that are supported by the Alibaba Cloud service.
            /// 
            /// >  This parameter is required if you set the ProductCode parameter to ecs, ecs-spec, actiontrail, or ess.
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// The value of the quota dimension.
            /// 
            /// >  The value range of N varies based on the number of dimensions that are supported by the Alibaba Cloud service.
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// The start time of the validity period of the quota. Specify the value in UTC. This parameter is valid only if you set the QuotaCategory parameter to WhiteListLabel.
        /// 
        /// >  If you do not specify a start time, the value is the time when the quota application is submitted.
        /// </summary>
        [NameInMap("EffectiveTime")]
        [Validation(Required=false)]
        public string EffectiveTime { get; set; }

        /// <summary>
        /// The language of the notification about the application result. Valid values:
        /// 
        /// *   zh (default): Chinese
        /// *   en: English
        /// </summary>
        [NameInMap("EnvLanguage")]
        [Validation(Required=false)]
        public string EnvLanguage { get; set; }

        /// <summary>
        /// The end time of the validity period of the quota. Specify the value in UTC. This parameter is valid only if you set the QuotaCategory parameter to WhiteListLabel.
        /// 
        /// >  If you do not specify an end time, the value is 99 years after the start time of the validity period.
        /// </summary>
        [NameInMap("ExpireTime")]
        [Validation(Required=false)]
        public string ExpireTime { get; set; }

        /// <summary>
        /// Specifies whether to send a notification about the application result. Valid values:
        /// 
        /// *   0 (default): no
        /// *   3: yes
        /// </summary>
        [NameInMap("NoticeType")]
        [Validation(Required=false)]
        public int? NoticeType { get; set; }

        /// <summary>
        /// The abbreviation of the Alibaba Cloud service name.
        /// 
        /// >  For more information, see [Alibaba Cloud services that support Quota Center](~~182368~~).
        /// </summary>
        [NameInMap("ProductCode")]
        [Validation(Required=false)]
        public string ProductCode { get; set; }

        /// <summary>
        /// The quota ID.
        /// </summary>
        [NameInMap("QuotaActionCode")]
        [Validation(Required=false)]
        public string QuotaActionCode { get; set; }

        /// <summary>
        /// The quota type. Valid values:
        /// 
        /// *   CommonQuota (default): general quota
        /// *   FlowControl: API rate limit
        /// *   WhiteListLabel: privilege
        /// </summary>
        [NameInMap("QuotaCategory")]
        [Validation(Required=false)]
        public string QuotaCategory { get; set; }

        /// <summary>
        /// The reason for the quota application.
        /// 
        /// >  Applications are reviewed by the technical support team of each Alibaba Cloud service. To increase the success rate of your application, you must specify a reasonable quota value and detailed reasons when you submit the application.
        /// </summary>
        [NameInMap("Reason")]
        [Validation(Required=false)]
        public string Reason { get; set; }

    }

}
