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
            /// The value range of N varies based on the number of dimensions that are supported by the related Alibaba Cloud service.
            /// 
            /// > This parameter is required if you set the ProductCode parameter to ecs, ecs-spec, actiontrail, or ess.
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// The value of the dimension.
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
