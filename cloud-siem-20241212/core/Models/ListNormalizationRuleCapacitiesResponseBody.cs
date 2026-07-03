// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloud_siem20241212.Models
{
    public class ListNormalizationRuleCapacitiesResponseBody : TeaModel {
        /// <summary>
        /// <para>The maximum number of entries returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>50</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>The token for the next query. If the response is truncated, use this token in your next request to retrieve the next page of results. If this parameter is empty, all results have been returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>AAAAAUqcj6VO4E3ECWIrFczs****</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The list of security capabilities that are associated with the normalization rules.</para>
        /// </summary>
        [NameInMap("NormalizationRuleCapacities")]
        [Validation(Required=false)]
        public List<ListNormalizationRuleCapacitiesResponseBodyNormalizationRuleCapacities> NormalizationRuleCapacities { get; set; }
        public class ListNormalizationRuleCapacitiesResponseBodyNormalizationRuleCapacities : TeaModel {
            /// <summary>
            /// <para>The list of security capabilities.</para>
            /// </summary>
            [NameInMap("Capacities")]
            [Validation(Required=false)]
            public List<string> Capacities { get; set; }

            /// <summary>
            /// <para>The type of the security capability. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>detection_preset_rule: predefined analysis rule.</para>
            /// </description></item>
            /// <item><description><para>detection_custom_rule: custom analysis rule.</para>
            /// </description></item>
            /// <item><description><para>incident_investigation: security event handling.</para>
            /// </description></item>
            /// <item><description><para>soar_playbooks: predefined playbook.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>detection_preset_rule</para>
            /// </summary>
            [NameInMap("CapacityType")]
            [Validation(Required=false)]
            public string CapacityType { get; set; }

            /// <summary>
            /// <para>The ID of the normalization rule.</para>
            /// 
            /// <b>Example:</b>
            /// <para>nr-z0b2ssjteut85uoh9nzp</para>
            /// </summary>
            [NameInMap("NormalizationRuleId")]
            [Validation(Required=false)]
            public string NormalizationRuleId { get; set; }

        }

        /// <summary>
        /// <para>The page number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>6276D891-*****-55B2-87B9-74D413F7****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of entries.</para>
        /// 
        /// <b>Example:</b>
        /// <para>57</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

        /// <summary>
        /// <para>The total number of pages.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3</para>
        /// </summary>
        [NameInMap("TotalPage")]
        [Validation(Required=false)]
        public int? TotalPage { get; set; }

    }

}
