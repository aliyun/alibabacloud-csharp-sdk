// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Actiontrail20200706.Models
{
    public class GetTrailStatusRequest : TeaModel {
        /// <summary>
        /// Specifies whether to query the status of a multi-account trail. Valid values:
        /// 
        /// *   true: Query the status of a multi-account trail.
        /// *   false: Query the status of a single-account trail. It is the default value.
        /// </summary>
        [NameInMap("IsOrganizationTrail")]
        [Validation(Required=false)]
        public bool? IsOrganizationTrail { get; set; }

        /// <summary>
        /// The name of the trail.
        /// 
        /// The name must be 6 to 36 characters in length. The name must start with a lowercase letter and can contain lowercase letters, digits, hyphens (-), and underscores (\_).
        /// 
        /// > The name must be unique within your Alibaba Cloud account.
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

    }

}
