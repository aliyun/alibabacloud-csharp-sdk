// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Quotas20200510.Models
{
    public class ListQuotaApplicationTemplatesResponseBody : TeaModel {
        /// <summary>
        /// The maximum number of records that are returned for the query.
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// The token that marks the position at which the query ends.
        /// 
        /// > An empty value indicates that all data is returned.
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// The quota templates that are returned.
        /// </summary>
        [NameInMap("QuotaApplicationTemplates")]
        [Validation(Required=false)]
        public List<ListQuotaApplicationTemplatesResponseBodyQuotaApplicationTemplates> QuotaApplicationTemplates { get; set; }
        public class ListQuotaApplicationTemplatesResponseBodyQuotaApplicationTemplates : TeaModel {
            /// <summary>
            /// None
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
            /// The requested value of the quota.
            /// </summary>
            [NameInMap("DesireValue")]
            [Validation(Required=false)]
            public float? DesireValue { get; set; }

            /// <summary>
            /// The quota dimensions.
            /// 
            /// Format: {"regionId":"Region"}.
            /// </summary>
            [NameInMap("Dimensions")]
            [Validation(Required=false)]
            public Dictionary<string, object> Dimensions { get; set; }

            /// <summary>
            /// 配额生效的UTC时间。
            /// </summary>
            [NameInMap("EffectiveTime")]
            [Validation(Required=false)]
            public string EffectiveTime { get; set; }

            /// <summary>
            /// The language of the quota alert notification. Valid values:
            /// 
            /// *   zh: Chinese
            /// *   en: English
            /// </summary>
            [NameInMap("EnvLanguage")]
            [Validation(Required=false)]
            public string EnvLanguage { get; set; }

            /// <summary>
            /// 配额失效的UTC时间。
            /// </summary>
            [NameInMap("ExpireTime")]
            [Validation(Required=false)]
            public string ExpireTime { get; set; }

            /// <summary>
            /// The ID of the quota template.
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            /// <summary>
            /// Indicates whether Quota Center sends a notification about the application result. Valid values:
            /// 
            /// *   0: no
            /// *   3: yes
            /// </summary>
            [NameInMap("NoticeType")]
            [Validation(Required=false)]
            public int? NoticeType { get; set; }

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
            /// 配额类型。
            /// - CommonQuota：通用配额。
            /// - WhiteListLabel：权益配额。
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
            /// The name of the quota.
            /// </summary>
            [NameInMap("QuotaName")]
            [Validation(Required=false)]
            public string QuotaName { get; set; }

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
