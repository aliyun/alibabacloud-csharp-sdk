// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloud_siem20241212.Models
{
    public class ListNormalizationRuleCapacitiesResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>50。</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>AAAAAUqcj6VO4E3ECWIrFczs****。</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        [NameInMap("NormalizationRuleCapacities")]
        [Validation(Required=false)]
        public List<ListNormalizationRuleCapacitiesResponseBodyNormalizationRuleCapacities> NormalizationRuleCapacities { get; set; }
        public class ListNormalizationRuleCapacitiesResponseBodyNormalizationRuleCapacities : TeaModel {
            [NameInMap("Capacities")]
            [Validation(Required=false)]
            public List<string> Capacities { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>detection_preset_rule。</para>
            /// </summary>
            [NameInMap("CapacityType")]
            [Validation(Required=false)]
            public string CapacityType { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>nr-z0b2ssjteut85uoh9nzp。</para>
            /// </summary>
            [NameInMap("NormalizationRuleId")]
            [Validation(Required=false)]
            public string NormalizationRuleId { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1。</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>10。</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>6276D891-*****-55B2-87B9-74D413F7****。</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>57。</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>3。</para>
        /// </summary>
        [NameInMap("TotalPage")]
        [Validation(Required=false)]
        public int? TotalPage { get; set; }

    }

}
