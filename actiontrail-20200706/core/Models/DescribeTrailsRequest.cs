// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Actiontrail20200706.Models
{
    public class DescribeTrailsRequest : TeaModel {
        /// <summary>
        /// Specifies whether to query the information about multi-account trails. Valid values:
        /// 
        /// *   true
        /// *   false (default)
        /// </summary>
        [NameInMap("IncludeOrganizationTrail")]
        [Validation(Required=false)]
        public bool? IncludeOrganizationTrail { get; set; }

        /// <summary>
        /// Specifies whether to return the information about shadow trails. Valid values:
        /// 
        /// *   false: Do not return the information about shadow trails. It is the default value.
        /// *   true: Return the information about shadow trails.
        /// </summary>
        [NameInMap("IncludeShadowTrails")]
        [Validation(Required=false)]
        public bool? IncludeShadowTrails { get; set; }

        /// <summary>
        /// The names of the trails whose information you want to query. Separate multiple trail names with commas (,).
        /// </summary>
        [NameInMap("NameList")]
        [Validation(Required=false)]
        public string NameList { get; set; }

    }

}
