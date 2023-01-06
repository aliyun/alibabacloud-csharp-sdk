// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Quotas20200510.Models
{
    public class ListProductQuotasResponseBody : TeaModel {
        /// <summary>
        /// The maximum number of records that are returned for the query.
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// The token that marks the position at which the query ends. An empty value indicates that all data is returned.
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// The details of the quotas.
        /// </summary>
        [NameInMap("Quotas")]
        [Validation(Required=false)]
        public List<ListProductQuotasResponseBodyQuotas> Quotas { get; set; }
        public class ListProductQuotasResponseBodyQuotas : TeaModel {
            /// <summary>
            /// Indicates whether the quota is adjustable. Valid values:
            /// 
            /// *   true: The quota is adjustable.
            /// *   false: The quota is not adjustable.
            /// </summary>
            [NameInMap("Adjustable")]
            [Validation(Required=false)]
            public bool? Adjustable { get; set; }

            /// <summary>
            /// None.
            /// </summary>
            [NameInMap("ApplicableRange")]
            [Validation(Required=false)]
            public List<float?> ApplicableRange { get; set; }

            /// <summary>
            /// The type of the adjustable value. Valid values:
            /// 
            /// *   continuous
            /// *   discontinuous
            /// </summary>
            [NameInMap("ApplicableType")]
            [Validation(Required=false)]
            public string ApplicableType { get; set; }

            /// <summary>
            /// Indicates whether the system shows the used value of the quota. Valid values:
            /// 
            /// *   true: The system shows the used value of the quota.
            /// *   false: The system does not show the used value of the quota.
            /// </summary>
            [NameInMap("Consumable")]
            [Validation(Required=false)]
            public bool? Consumable { get; set; }

            /// <summary>
            /// The quota dimensions. Format: `{"regionId":"Region"}`.
            /// </summary>
            [NameInMap("Dimensions")]
            [Validation(Required=false)]
            public Dictionary<string, object> Dimensions { get; set; }

            /// <summary>
            /// The start time of the validity period of the quota. The value is displayed in UTC.
            /// </summary>
            [NameInMap("EffectiveTime")]
            [Validation(Required=false)]
            public string EffectiveTime { get; set; }

            /// <summary>
            /// The end time of the validity period of the quota. The value is displayed in UTC.
            /// </summary>
            [NameInMap("ExpireTime")]
            [Validation(Required=false)]
            public string ExpireTime { get; set; }

            /// <summary>
            /// The calculation cycle of the quota.
            /// </summary>
            [NameInMap("Period")]
            [Validation(Required=false)]
            public ListProductQuotasResponseBodyQuotasPeriod Period { get; set; }
            public class ListProductQuotasResponseBodyQuotasPeriod : TeaModel {
                /// <summary>
                /// The unit of the calculation cycle. Valid values:
                /// 
                /// *   second
                /// *   minute
                /// *   hour
                /// *   day
                /// *   week
                /// </summary>
                [NameInMap("PeriodUnit")]
                [Validation(Required=false)]
                public string PeriodUnit { get; set; }

                /// <summary>
                /// The value of the calculation cycle.
                /// </summary>
                [NameInMap("PeriodValue")]
                [Validation(Required=false)]
                public int? PeriodValue { get; set; }

            }

            /// <summary>
            /// The abbreviation of the Alibaba Cloud service name.
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
            /// The Alibaba Cloud Resource Name (ARN) of the quota.
            /// </summary>
            [NameInMap("QuotaArn")]
            [Validation(Required=false)]
            public string QuotaArn { get; set; }

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
            /// The description of the quota.
            /// </summary>
            [NameInMap("QuotaDescription")]
            [Validation(Required=false)]
            public string QuotaDescription { get; set; }

            /// <summary>
            /// The details of the quotas.
            /// </summary>
            [NameInMap("QuotaItems")]
            [Validation(Required=false)]
            public List<ListProductQuotasResponseBodyQuotasQuotaItems> QuotaItems { get; set; }
            public class ListProductQuotasResponseBodyQuotasQuotaItems : TeaModel {
                /// <summary>
                /// The value of the quota.
                /// </summary>
                [NameInMap("Quota")]
                [Validation(Required=false)]
                public string Quota { get; set; }

                /// <summary>
                /// The unit of the new quota value.
                /// 
                /// **
                /// 
                /// **The unit of each quota is unique.** For example, the quota whose ID is `q_cbdch3` represents the maximum number of Container Service for Kubernetes (ACK) clusters. The unit of this quota is clusters. The quota whose ID is `q_security-groups` represents the maximum number of security groups. The unit of this quota is security groups.
                /// </summary>
                [NameInMap("QuotaUnit")]
                [Validation(Required=false)]
                public string QuotaUnit { get; set; }

                /// <summary>
                /// The category of the quota. Valid values:
                /// 
                /// *   BaseQuota: base quota
                /// *   ReservedQuota: reserved quota
                /// </summary>
                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

                /// <summary>
                /// The used quota.
                /// </summary>
                [NameInMap("Usage")]
                [Validation(Required=false)]
                public string Usage { get; set; }

            }

            /// <summary>
            /// The name of the quota.
            /// </summary>
            [NameInMap("QuotaName")]
            [Validation(Required=false)]
            public string QuotaName { get; set; }

            /// <summary>
            /// The type of the quota. Valid values:
            /// 
            /// *   privilege
            /// *   normal
            /// </summary>
            [NameInMap("QuotaType")]
            [Validation(Required=false)]
            public string QuotaType { get; set; }

            /// <summary>
            /// The unit of the new quota value.
            /// 
            /// **
            /// 
            /// **The unit of each quota is unique.** For example, the quota whose ID is `q_cbdch3` represents the maximum number of Container Service for Kubernetes (ACK) clusters. The unit of this quota is clusters. The quota whose ID is `q_security-groups` represents the maximum number of security groups. The unit of this quota is security groups.
            /// </summary>
            [NameInMap("QuotaUnit")]
            [Validation(Required=false)]
            public string QuotaUnit { get; set; }

            /// <summary>
            /// None.
            /// </summary>
            [NameInMap("SupportedRange")]
            [Validation(Required=false)]
            public List<float?> SupportedRange { get; set; }

            /// <summary>
            /// The value of the quota.
            /// </summary>
            [NameInMap("TotalQuota")]
            [Validation(Required=false)]
            public float? TotalQuota { get; set; }

            /// <summary>
            /// The used quota.
            /// </summary>
            [NameInMap("TotalUsage")]
            [Validation(Required=false)]
            public float? TotalUsage { get; set; }

            /// <summary>
            /// The reason why the quota is not adjustable. Valid values:
            /// 
            /// *   nonactivated: The service is not activated.
            /// *   applicationProcess: The application is being processed.
            /// *   limitReached: The quota limit is reached.
            /// </summary>
            [NameInMap("UnadjustableDetail")]
            [Validation(Required=false)]
            public string UnadjustableDetail { get; set; }

        }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The total number of records that are returned for the query.
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
