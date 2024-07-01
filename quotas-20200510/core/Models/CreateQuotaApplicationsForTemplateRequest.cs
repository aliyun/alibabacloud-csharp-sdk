// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Quotas20200510.Models
{
    public class CreateQuotaApplicationsForTemplateRequest : TeaModel {
        /// <summary>
        /// The Alibaba Cloud accounts that correspond to the resource directory members for which the quotas are applied.
        /// 
        /// >  You can submit a quota increase application for a maximum of 50 members at a time. For more information about the members of a resource directory, see [ListAccounts](https://help.aliyun.com/document_detail/604207.html).
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("AliyunUids")]
        [Validation(Required=false)]
        public List<string> AliyunUids { get; set; }

        /// <summary>
        /// The requested value of the quota.
        /// 
        /// > 
        /// 
        /// *   You can specify DesireValue based on the values of `TotalUsage` and `ApplicableRange` in the response to the [ListProductQuotas](https://help.aliyun.com/document_detail/440554.html) operation.
        /// 
        /// *   Applications are reviewed by the technical support team of each Alibaba Cloud service. To increase the success rate of your application, specify a reasonable quota value and a detailed reason.
        /// 
        /// This parameter is required.
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
            /// The key of the dimension.
            /// 
            /// > 
            /// 
            /// *   The value range of N varies based on the number of dimensions that are supported by the related Alibaba Cloud service.
            /// 
            /// *   This parameter is required if you set the `ProductCode` parameter to `ecs`, `ecs-spec`, `actiontrail`, or `ess`.
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// The value of the dimension.
            /// 
            /// > 
            /// 
            /// *   The value range of N varies based on the number of dimensions that are supported by the related Alibaba Cloud service.
            /// 
            /// *   This parameter is required if you set the `ProductCode` parameter to `ecs`, `ecs-spec`, `actiontrail`, or `ess`.
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
        /// >  To query the abbreviation of an Alibaba Cloud service name, call the [ListProducts](https://help.aliyun.com/document_detail/440555.html) operation and check the value of `ProductCode` in the response.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("ProductCode")]
        [Validation(Required=false)]
        public string ProductCode { get; set; }

        /// <summary>
        /// The quota ID.
        /// 
        /// >  To query the quota ID of an Alibaba Cloud service, call the [ListProductQuotas](https://help.aliyun.com/document_detail/440554.html) and check the value of `QuotaActionCode` in the response.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("QuotaActionCode")]
        [Validation(Required=false)]
        public string QuotaActionCode { get; set; }

        /// <summary>
        /// The quota type. Valid values:
        /// 
        /// *   CommonQuota: general quota
        /// *   FlowControl: API rate limit
        /// *   WhiteListLabel: privilege
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("QuotaCategory")]
        [Validation(Required=false)]
        public string QuotaCategory { get; set; }

        /// <summary>
        /// The reason for the quota application.
        /// 
        /// >  Applications are reviewed by the technical support team of each Alibaba Cloud service. To increase the success rate of your application, you must specify a reasonable quota value and detailed reasons when you submit the application.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("Reason")]
        [Validation(Required=false)]
        public string Reason { get; set; }

    }

}
