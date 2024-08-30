// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ARMS20190808.Models
{
    public class ListPrometheusAlertRulesRequest : TeaModel {
        /// <summary>
        /// The ID of the cluster.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("ClusterId")]
        [Validation(Required=false)]
        public string ClusterId { get; set; }

        /// <summary>
        /// The tag match conditions that are described in a JSON string. For more information about this parameter, see the **Additional description of the MatchExpressions parameter** section.
        /// </summary>
        [NameInMap("MatchExpressions")]
        [Validation(Required=false)]
        public string MatchExpressions { get; set; }

        /// <summary>
        /// The name of the alert rule.
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// The region ID of the instance.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// Specifies whether the alert rule is enabled. Valid values:
        /// 
        /// - 1: enables the alert rule.
        /// - 0: disables the alert rule.
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public int? Status { get; set; }

        /// <summary>
        /// The tags.
        /// </summary>
        [NameInMap("Tags")]
        [Validation(Required=false)]
        public List<ListPrometheusAlertRulesRequestTags> Tags { get; set; }
        public class ListPrometheusAlertRulesRequestTags : TeaModel {
            /// <summary>
            /// The tag key.
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// The tag value.
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// The type of the alert rule.
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
