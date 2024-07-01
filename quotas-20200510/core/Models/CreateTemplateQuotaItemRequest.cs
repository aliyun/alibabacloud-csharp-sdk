// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Quotas20200510.Models
{
    public class CreateTemplateQuotaItemRequest : TeaModel {
        /// <summary>
        /// The requested value of the quota.
        /// 
        /// > 
        /// 
        /// *   You can specify DesireValue based on the values of `TotalUsage` and `ApplicableRange` in the response to the [ListProductQuotas](https://help.aliyun.com/document_detail/440554.html) operation.
        /// 
        /// *   Applications are reviewed by the technical support team for each cloud service. To increase the success rate of your application, specify a reasonable quota value and a detailed reason.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("DesireValue")]
        [Validation(Required=false)]
        public float? DesireValue { get; set; }

        /// <summary>
        /// The quota dimensions.
        /// </summary>
        [NameInMap("Dimensions")]
        [Validation(Required=false)]
        public List<CreateTemplateQuotaItemRequestDimensions> Dimensions { get; set; }
        public class CreateTemplateQuotaItemRequestDimensions : TeaModel {
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
        /// > If you leave this parameter empty, the quota takes effect immediately.
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
        /// The end time of the validity period of the quota. Specify the value in UTC. This parameter is valid only if you set the QuotaCategory parameter to WhiteListLabel.
        /// 
        /// > If you leave this parameter empty, no end time is specified.
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
        public long? NoticeType { get; set; }

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
        /// >  To obtain the quota ID of an Alibaba Cloud service, call the [ListProductQuotas](https://help.aliyun.com/document_detail/440554.html) operation and check the value of `QuotaActionCode` in the response.
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
        /// *   WhiteListLabel: privilege
        /// *   FlowControl: API rate limit
        /// </summary>
        [NameInMap("QuotaCategory")]
        [Validation(Required=false)]
        public string QuotaCategory { get; set; }

    }

}
